using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Security;
using System.IO;



namespace GCodeSequencer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updatePorts();
        }
        private SerialPort ComPort = new SerialPort();
        private void updatePorts()
        {

            cmb_port.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cmb_port.Items.Add(port);
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            bool error = false;

            if (!ComPort.IsOpen)
            {
                if ((cmb_port.SelectedIndex != -1) & (cmb_baudrate.SelectedIndex != -1))
                {

                    ComPort.PortName = cmb_port.Text;
                    ComPort.BaudRate = int.Parse(cmb_baudrate.Text);

                    try
                    {
                        ComPort.Open();
                    }
                    catch (UnauthorizedAccessException) { error = true; }
                    catch (System.IO.IOException) { error = true; }
                    catch (ArgumentException) { error = true; }

                    if (error) MessageBox.Show("Impossible d'ouvrir le port");
                }
                else
                {
                    MessageBox.Show("Veuillez selectionner tous les paramètres");
                }

                if (ComPort.IsOpen)
                {
                    btn_connect.Text = "Disconnect";
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = true;
                }
            }
            else
            {
                ComPort.Close();
                btn_connect.Text = "Connect";
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
            }

        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            updatePorts();
        }

        private void btn_openFile_Click(object sender, EventArgs e)
        {
            string MyGCode;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lbl_file.Text = Path.GetFileName(openFileDialog1.FileName);
                listBox1.Items.Clear(); //delete all items if a new file is loaded

                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);
                    while((MyGCode = sr.ReadLine()) != null)
                    {
                        listBox1.Items.Add(MyGCode);
                    }

                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }

            }
        }

        private void btn_sendSimple_Click(object sender, EventArgs e)
        {
            ComPort.Write(listBox1.SelectedItem.ToString() + '\n');
        }

        Queue<string> GCommands = new Queue<string>();
        private void btn_start_Click(object sender, EventArgs e)
        {
            ushort N_loops = 1;

            timer1.Interval = (int)num_timer.Value;

            if(check_loop.Checked)
            {
                N_loops = (ushort)num_loops.Value;
            }
            for(ushort index1 = 0; index1 <= N_loops - 1; index1++)
            { 
                for (int index2 = 0; index2 <= listBox1.Items.Count - 1; index2++)
                {
                    listBox1.SelectedIndex = index2;
                    GCommands.Enqueue(listBox1.SelectedItem.ToString() + '\n');
                }
            }
            listBox1.SelectedIndex = 0;
            timer1.Start();
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        private void btn_resumeTimer_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void btn_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            GCommands.Clear();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(GCommands.Count == 0)
            {
                timer1.Stop();
            }

            ComPort.Write(GCommands.Dequeue());

        }        

        private void btn_delHeader_Click(object sender, EventArgs e)
        {
            if(listBox1.Items.Count != 0)
            {
                listBox1.Items.RemoveAt(0);
            }
        }

        
    }
}
