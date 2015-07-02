namespace Organizer
{
    partial class frm_Organizer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Organizer));
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_set = new System.Windows.Forms.Label();
            this.nUD_hrs = new System.Windows.Forms.NumericUpDown();
            this.lbl_hrs = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.nUD_minutes = new System.Windows.Forms.NumericUpDown();
            this.pB_time = new System.Windows.Forms.ProgressBar();
            this.btn_Start = new System.Windows.Forms.Button();
            this.cBx_Alerts = new System.Windows.Forms.CheckBox();
            this.cBx_Sound = new System.Windows.Forms.CheckBox();
            this.ntfyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.lbl_minutes = new System.Windows.Forms.Label();
            this.cBx_Force = new System.Windows.Forms.CheckBox();
            this.timer_start = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nUD_hrs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_minutes)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Times New Roman", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(273, 25);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "THE MANGO PROJECT";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_set
            // 
            this.lbl_set.AutoSize = true;
            this.lbl_set.Location = new System.Drawing.Point(25, 55);
            this.lbl_set.Name = "lbl_set";
            this.lbl_set.Size = new System.Drawing.Size(75, 13);
            this.lbl_set.TabIndex = 1;
            this.lbl_set.Text = "Set a timer for ";
            // 
            // nUD_hrs
            // 
            this.nUD_hrs.Location = new System.Drawing.Point(106, 53);
            this.nUD_hrs.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nUD_hrs.Name = "nUD_hrs";
            this.nUD_hrs.Size = new System.Drawing.Size(35, 20);
            this.nUD_hrs.TabIndex = 2;
            this.nUD_hrs.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUD_hrs.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lbl_hrs
            // 
            this.lbl_hrs.AutoSize = true;
            this.lbl_hrs.Location = new System.Drawing.Point(147, 55);
            this.lbl_hrs.Name = "lbl_hrs";
            this.lbl_hrs.Size = new System.Drawing.Size(45, 13);
            this.lbl_hrs.TabIndex = 3;
            this.lbl_hrs.Text = "hrs and ";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nUD_minutes
            // 
            this.nUD_minutes.Location = new System.Drawing.Point(198, 53);
            this.nUD_minutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nUD_minutes.Name = "nUD_minutes";
            this.nUD_minutes.Size = new System.Drawing.Size(36, 20);
            this.nUD_minutes.TabIndex = 4;
            this.nUD_minutes.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // pB_time
            // 
            this.pB_time.Location = new System.Drawing.Point(12, 109);
            this.pB_time.Name = "pB_time";
            this.pB_time.Size = new System.Drawing.Size(270, 23);
            this.pB_time.Step = 1;
            this.pB_time.TabIndex = 5;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(207, 80);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(75, 23);
            this.btn_Start.TabIndex = 6;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // cBx_Alerts
            // 
            this.cBx_Alerts.AutoSize = true;
            this.cBx_Alerts.Location = new System.Drawing.Point(12, 84);
            this.cBx_Alerts.Name = "cBx_Alerts";
            this.cBx_Alerts.Size = new System.Drawing.Size(52, 17);
            this.cBx_Alerts.TabIndex = 7;
            this.cBx_Alerts.Text = "Alerts";
            this.cBx_Alerts.UseVisualStyleBackColor = false;
            // 
            // cBx_Sound
            // 
            this.cBx_Sound.AutoSize = true;
            this.cBx_Sound.Location = new System.Drawing.Point(70, 84);
            this.cBx_Sound.Name = "cBx_Sound";
            this.cBx_Sound.Size = new System.Drawing.Size(57, 17);
            this.cBx_Sound.TabIndex = 8;
            this.cBx_Sound.Text = "Sound";
            this.cBx_Sound.UseVisualStyleBackColor = false;
            // 
            // ntfyIcon
            // 
            this.ntfyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ntfyIcon.BalloonTipTitle = "MANGO PROJECT IS RUNNING";
            this.ntfyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("ntfyIcon.Icon")));
            this.ntfyIcon.Text = "THE MANGO PROJECT";
            this.ntfyIcon.Visible = true;
            this.ntfyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntfyIcon_MouseDoubleClick);
            // 
            // lbl_minutes
            // 
            this.lbl_minutes.AutoSize = true;
            this.lbl_minutes.Location = new System.Drawing.Point(239, 55);
            this.lbl_minutes.Name = "lbl_minutes";
            this.lbl_minutes.Size = new System.Drawing.Size(43, 13);
            this.lbl_minutes.TabIndex = 9;
            this.lbl_minutes.Text = "minutes";
            // 
            // cBx_Force
            // 
            this.cBx_Force.AutoSize = true;
            this.cBx_Force.Location = new System.Drawing.Point(133, 84);
            this.cBx_Force.Name = "cBx_Force";
            this.cBx_Force.Size = new System.Drawing.Size(59, 17);
            this.cBx_Force.TabIndex = 10;
            this.cBx_Force.Text = "Log off";
            this.cBx_Force.UseVisualStyleBackColor = true;
            this.cBx_Force.CheckedChanged += new System.EventHandler(this.cBx_Force_CheckedChanged);
            // 
            // timer_start
            // 
            this.timer_start.Interval = 1000;
            this.timer_start.Tick += new System.EventHandler(this.timer_start_Tick);
            // 
            // frm_Organizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 145);
            this.Controls.Add(this.cBx_Force);
            this.Controls.Add(this.lbl_minutes);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.cBx_Sound);
            this.Controls.Add(this.cBx_Alerts);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.pB_time);
            this.Controls.Add(this.nUD_minutes);
            this.Controls.Add(this.lbl_hrs);
            this.Controls.Add(this.nUD_hrs);
            this.Controls.Add(this.lbl_set);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Organizer";
            this.Text = "Mango";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.frm_Organizer_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nUD_hrs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_minutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_set;
        private System.Windows.Forms.NumericUpDown nUD_hrs;
        private System.Windows.Forms.Label lbl_hrs;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NumericUpDown nUD_minutes;
        private System.Windows.Forms.ProgressBar pB_time;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.CheckBox cBx_Alerts;
        private System.Windows.Forms.CheckBox cBx_Sound;
        private System.Windows.Forms.NotifyIcon ntfyIcon;
        private System.Windows.Forms.Label lbl_minutes;
        private System.Windows.Forms.CheckBox cBx_Force;
        private System.Windows.Forms.Timer timer_start;
    }
    
}

