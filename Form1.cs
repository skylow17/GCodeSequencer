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
                }
            }
            else
            {
                ComPort.Close();
                btn_connect.Text = "Connect";
                groupBox1.Enabled = true;
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

        private void btn_start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (i >= listBox1.Items.Count - 1)
            {
                i = 1;
            }
            listBox1.SelectedIndex = i;
            ComPort.Write(listBox1.SelectedItem.ToString() + '\n');
            i++;
            
            
        }
    }
}
