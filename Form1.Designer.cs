namespace BatteryReader
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.txt_Status = new System.Windows.Forms.Label();
            this.txt_LogBox = new System.Windows.Forms.TextBox();
            this.lbl_LogFile = new System.Windows.Forms.Label();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.gBox_Settings = new System.Windows.Forms.GroupBox();
            this.txt_LogFile = new System.Windows.Forms.TextBox();
            this.lbl_Interval = new System.Windows.Forms.Label();
            this.int_Interval = new System.Windows.Forms.NumericUpDown();
            this.gBox_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.int_Interval)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Start.Location = new System.Drawing.Point(12, 12);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Stop.Location = new System.Drawing.Point(12, 41);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(75, 23);
            this.btn_Stop.TabIndex = 1;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Status.Location = new System.Drawing.Point(93, 16);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(42, 15);
            this.lbl_Status.TabIndex = 2;
            this.lbl_Status.Text = "Status:";
            // 
            // txt_Status
            // 
            this.txt_Status.AutoSize = true;
            this.txt_Status.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_Status.Location = new System.Drawing.Point(141, 16);
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.Size = new System.Drawing.Size(71, 15);
            this.txt_Status.TabIndex = 3;
            this.txt_Status.Text = "<<Status>>";
            // 
            // txt_LogBox
            // 
            this.txt_LogBox.Location = new System.Drawing.Point(12, 70);
            this.txt_LogBox.Multiline = true;
            this.txt_LogBox.Name = "txt_LogBox";
            this.txt_LogBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_LogBox.Size = new System.Drawing.Size(211, 176);
            this.txt_LogBox.TabIndex = 4;
            // 
            // lbl_LogFile
            // 
            this.lbl_LogFile.AutoSize = true;
            this.lbl_LogFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_LogFile.Location = new System.Drawing.Point(6, 19);
            this.lbl_LogFile.Name = "lbl_LogFile";
            this.lbl_LogFile.Size = new System.Drawing.Size(51, 15);
            this.lbl_LogFile.TabIndex = 5;
            this.lbl_LogFile.Text = "Log File:";
            // 
            // btn_Settings
            // 
            this.btn_Settings.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Settings.Location = new System.Drawing.Point(148, 41);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(75, 23);
            this.btn_Settings.TabIndex = 7;
            this.btn_Settings.Text = "Settings";
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // gBox_Settings
            // 
            this.gBox_Settings.Controls.Add(this.txt_LogFile);
            this.gBox_Settings.Controls.Add(this.lbl_Interval);
            this.gBox_Settings.Controls.Add(this.int_Interval);
            this.gBox_Settings.Controls.Add(this.lbl_LogFile);
            this.gBox_Settings.Location = new System.Drawing.Point(239, 12);
            this.gBox_Settings.Name = "gBox_Settings";
            this.gBox_Settings.Size = new System.Drawing.Size(388, 100);
            this.gBox_Settings.TabIndex = 8;
            this.gBox_Settings.TabStop = false;
            this.gBox_Settings.Text = "Settings";
            // 
            // txt_LogFile
            // 
            this.txt_LogFile.Location = new System.Drawing.Point(54, 16);
            this.txt_LogFile.Name = "txt_LogFile";
            this.txt_LogFile.Size = new System.Drawing.Size(328, 23);
            this.txt_LogFile.TabIndex = 9;
            this.txt_LogFile.Text = "<<LogFile>>";
            // 
            // lbl_Interval
            // 
            this.lbl_Interval.AutoSize = true;
            this.lbl_Interval.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Interval.Location = new System.Drawing.Point(6, 47);
            this.lbl_Interval.Name = "lbl_Interval";
            this.lbl_Interval.Size = new System.Drawing.Size(77, 15);
            this.lbl_Interval.TabIndex = 8;
            this.lbl_Interval.Text = "Interval (sec):";
            // 
            // int_Interval
            // 
            this.int_Interval.Location = new System.Drawing.Point(89, 45);
            this.int_Interval.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.int_Interval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.int_Interval.Name = "int_Interval";
            this.int_Interval.Size = new System.Drawing.Size(37, 23);
            this.int_Interval.TabIndex = 7;
            this.int_Interval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.int_Interval.ValueChanged += new System.EventHandler(this.int_Interval_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 453);
            this.Controls.Add(this.gBox_Settings);
            this.Controls.Add(this.btn_Settings);
            this.Controls.Add(this.txt_LogBox);
            this.Controls.Add(this.txt_Status);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_Start);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBox_Settings.ResumeLayout(false);
            this.gBox_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.int_Interval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Start;
        private Button btn_Stop;
        private Label lbl_Status;
        private Label txt_Status;
        private TextBox txt_LogBox;
        private Label lbl_LogFile;
        private Button btn_Settings;
        private GroupBox gBox_Settings;
        private TextBox txt_LogFile;
        private Label lbl_Interval;
        private NumericUpDown int_Interval;
    }
}