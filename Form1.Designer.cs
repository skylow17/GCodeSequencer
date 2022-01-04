
namespace GCodeSequencer
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_baudrate = new System.Windows.Forms.ComboBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.cmb_port = new System.Windows.Forms.ComboBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_openFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_sendSimple = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.num_loops = new System.Windows.Forms.NumericUpDown();
            this.check_loop = new System.Windows.Forms.CheckBox();
            this.check_waitAnswer = new System.Windows.Forms.CheckBox();
            this.txt_CharToWait = new System.Windows.Forms.TextBox();
            this.btn_applyWaitAnswer = new System.Windows.Forms.Button();
            this.lbl_file = new System.Windows.Forms.Label();
            this.btn_Pause = new System.Windows.Forms.Button();
            this.num_timer = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_delHeader = new System.Windows.Forms.Button();
            this.btn_resumeTimer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_loops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_timer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_baudrate);
            this.groupBox1.Controls.Add(this.btn_refresh);
            this.groupBox1.Controls.Add(this.cmb_port);
            this.groupBox1.Location = new System.Drawing.Point(21, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Baudrate";
            // 
            // cmb_baudrate
            // 
            this.cmb_baudrate.FormattingEnabled = true;
            this.cmb_baudrate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cmb_baudrate.Location = new System.Drawing.Point(6, 55);
            this.cmb_baudrate.Name = "cmb_baudrate";
            this.cmb_baudrate.Size = new System.Drawing.Size(146, 21);
            this.cmb_baudrate.TabIndex = 3;
            this.cmb_baudrate.Text = "9600";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(158, 28);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // cmb_port
            // 
            this.cmb_port.FormattingEnabled = true;
            this.cmb_port.Location = new System.Drawing.Point(6, 28);
            this.cmb_port.Name = "cmb_port";
            this.cmb_port.Size = new System.Drawing.Size(146, 21);
            this.cmb_port.TabIndex = 0;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(98, 144);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 1;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_openFile
            // 
            this.btn_openFile.Location = new System.Drawing.Point(27, 202);
            this.btn_openFile.Name = "btn_openFile";
            this.btn_openFile.Size = new System.Drawing.Size(75, 23);
            this.btn_openFile.TabIndex = 2;
            this.btn_openFile.Text = "Open File";
            this.btn_openFile.UseVisualStyleBackColor = true;
            this.btn_openFile.Click += new System.EventHandler(this.btn_openFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Fichiers GCode|*.gcode|Tous les fichiers|*.*\"";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(290, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(460, 277);
            this.listBox1.TabIndex = 3;
            // 
            // btn_sendSimple
            // 
            this.btn_sendSimple.Location = new System.Drawing.Point(310, 15);
            this.btn_sendSimple.Name = "btn_sendSimple";
            this.btn_sendSimple.Size = new System.Drawing.Size(160, 23);
            this.btn_sendSimple.TabIndex = 4;
            this.btn_sendSimple.Text = "Send selected position";
            this.btn_sendSimple.UseVisualStyleBackColor = true;
            this.btn_sendSimple.Click += new System.EventHandler(this.btn_sendSimple_Click);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(310, 44);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(88, 23);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "Start with timer";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(232, 44);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(72, 23);
            this.btn_stop.TabIndex = 8;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_resumeTimer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.num_timer);
            this.groupBox2.Controls.Add(this.btn_Pause);
            this.groupBox2.Controls.Add(this.num_loops);
            this.groupBox2.Controls.Add(this.check_loop);
            this.groupBox2.Controls.Add(this.btn_stop);
            this.groupBox2.Controls.Add(this.btn_sendSimple);
            this.groupBox2.Controls.Add(this.btn_start);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(274, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 119);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GCode";
            // 
            // num_loops
            // 
            this.num_loops.Location = new System.Drawing.Point(19, 43);
            this.num_loops.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_loops.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_loops.Name = "num_loops";
            this.num_loops.Size = new System.Drawing.Size(72, 20);
            this.num_loops.TabIndex = 15;
            this.num_loops.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // check_loop
            // 
            this.check_loop.AutoSize = true;
            this.check_loop.Location = new System.Drawing.Point(97, 44);
            this.check_loop.Name = "check_loop";
            this.check_loop.Size = new System.Drawing.Size(50, 17);
            this.check_loop.TabIndex = 14;
            this.check_loop.Text = "Loop";
            this.check_loop.UseVisualStyleBackColor = true;
            // 
            // check_waitAnswer
            // 
            this.check_waitAnswer.AutoSize = true;
            this.check_waitAnswer.Location = new System.Drawing.Point(46, 307);
            this.check_waitAnswer.Name = "check_waitAnswer";
            this.check_waitAnswer.Size = new System.Drawing.Size(205, 17);
            this.check_waitAnswer.TabIndex = 10;
            this.check_waitAnswer.Text = "Wait for answer before next command";
            this.check_waitAnswer.UseVisualStyleBackColor = true;
            // 
            // txt_CharToWait
            // 
            this.txt_CharToWait.Location = new System.Drawing.Point(46, 281);
            this.txt_CharToWait.Name = "txt_CharToWait";
            this.txt_CharToWait.Size = new System.Drawing.Size(100, 20);
            this.txt_CharToWait.TabIndex = 11;
            this.txt_CharToWait.Text = "ok\\r\\n";
            // 
            // btn_applyWaitAnswer
            // 
            this.btn_applyWaitAnswer.Location = new System.Drawing.Point(152, 279);
            this.btn_applyWaitAnswer.Name = "btn_applyWaitAnswer";
            this.btn_applyWaitAnswer.Size = new System.Drawing.Size(75, 23);
            this.btn_applyWaitAnswer.TabIndex = 12;
            this.btn_applyWaitAnswer.Text = "Apply";
            this.btn_applyWaitAnswer.UseVisualStyleBackColor = true;
            // 
            // lbl_file
            // 
            this.lbl_file.AutoSize = true;
            this.lbl_file.Location = new System.Drawing.Point(108, 207);
            this.lbl_file.Name = "lbl_file";
            this.lbl_file.Size = new System.Drawing.Size(72, 13);
            this.lbl_file.TabIndex = 13;
            this.lbl_file.Text = "No file loaded";
            // 
            // btn_Pause
            // 
            this.btn_Pause.Location = new System.Drawing.Point(398, 44);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(72, 23);
            this.btn_Pause.TabIndex = 16;
            this.btn_Pause.Text = "Pause";
            this.btn_Pause.UseVisualStyleBackColor = true;
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // num_timer
            // 
            this.num_timer.Location = new System.Drawing.Point(320, 73);
            this.num_timer.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.num_timer.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_timer.Name = "num_timer";
            this.num_timer.Size = new System.Drawing.Size(72, 20);
            this.num_timer.TabIndex = 17;
            this.num_timer.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "timer [ms]";
            // 
            // btn_delHeader
            // 
            this.btn_delHeader.Location = new System.Drawing.Point(457, 12);
            this.btn_delHeader.Name = "btn_delHeader";
            this.btn_delHeader.Size = new System.Drawing.Size(102, 23);
            this.btn_delHeader.TabIndex = 19;
            this.btn_delHeader.Text = "Delete first line";
            this.btn_delHeader.UseVisualStyleBackColor = true;
            this.btn_delHeader.Click += new System.EventHandler(this.btn_delHeader_Click);
            // 
            // btn_resumeTimer
            // 
            this.btn_resumeTimer.Location = new System.Drawing.Point(398, 73);
            this.btn_resumeTimer.Name = "btn_resumeTimer";
            this.btn_resumeTimer.Size = new System.Drawing.Size(72, 23);
            this.btn_resumeTimer.TabIndex = 19;
            this.btn_resumeTimer.Text = "Resume";
            this.btn_resumeTimer.UseVisualStyleBackColor = true;
            this.btn_resumeTimer.Click += new System.EventHandler(this.btn_resumeTimer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 511);
            this.Controls.Add(this.btn_delHeader);
            this.Controls.Add(this.lbl_file);
            this.Controls.Add(this.btn_applyWaitAnswer);
            this.Controls.Add(this.txt_CharToWait);
            this.Controls.Add(this.check_waitAnswer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_openFile);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_connect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "GCodeSequencer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_loops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_timer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_baudrate;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.ComboBox cmb_port;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_openFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sendSimple;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox check_waitAnswer;
        private System.Windows.Forms.TextBox txt_CharToWait;
        private System.Windows.Forms.Button btn_applyWaitAnswer;
        private System.Windows.Forms.Label lbl_file;
        private System.Windows.Forms.NumericUpDown num_loops;
        private System.Windows.Forms.CheckBox check_loop;
        private System.Windows.Forms.Button btn_Pause;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_timer;
        private System.Windows.Forms.Button btn_delHeader;
        private System.Windows.Forms.Button btn_resumeTimer;
    }
}

