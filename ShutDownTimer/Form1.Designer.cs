namespace ShutDownTimer
{
    partial class ShutDownTimer
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
            this.buttonRun = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.cBTimerHours = new System.Windows.Forms.ComboBox();
            this.lbHours = new System.Windows.Forms.Label();
            this.cbTimerMinutes = new System.Windows.Forms.ComboBox();
            this.lbMinutes = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(49, 136);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Выключить";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(46, 105);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(109, 13);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Осталось времени: ";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // cBTimerHours
            // 
            this.cBTimerHours.FormattingEnabled = true;
            this.cBTimerHours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cBTimerHours.Location = new System.Drawing.Point(49, 12);
            this.cBTimerHours.Name = "cBTimerHours";
            this.cBTimerHours.Size = new System.Drawing.Size(121, 21);
            this.cBTimerHours.TabIndex = 2;
            this.cBTimerHours.SelectedIndex = 0;

            // 
            // lbHours
            // 
            this.lbHours.AutoSize = true;
            this.lbHours.Location = new System.Drawing.Point(177, 13);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(27, 13);
            this.lbHours.TabIndex = 3;
            this.lbHours.Text = "час.";
            // 
            // cbTimerMinutes
            // 
            this.cbTimerMinutes.FormattingEnabled = true;
            for (int i = 1; i <= 60; i++)
            {
                this.cbTimerMinutes.Items.Add(i.ToString());
            }
            this.cbTimerMinutes.Location = new System.Drawing.Point(49, 49);
            this.cbTimerMinutes.Name = "cbTimerMinutes";
            this.cbTimerMinutes.Size = new System.Drawing.Size(121, 21);
            this.cbTimerMinutes.TabIndex = 4;
            this.cbTimerMinutes.SelectedIndex = 0;
            // 
            // lbMinutes
            // 
            this.lbMinutes.AutoSize = true;
            this.lbMinutes.Location = new System.Drawing.Point(177, 56);
            this.lbMinutes.Name = "lbMinutes";
            this.lbMinutes.Size = new System.Drawing.Size(30, 13);
            this.lbMinutes.TabIndex = 5;
            this.lbMinutes.Text = "мин.";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(180, 136);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // ShutDownTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 187);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.lbMinutes);
            this.Controls.Add(this.cbTimerMinutes);
            this.Controls.Add(this.lbHours);
            this.Controls.Add(this.cBTimerHours);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonRun);
            this.Name = "ShutDownTimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShutDownTimer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ComboBox cBTimerHours;
        private System.Windows.Forms.Label lbHours;
        private System.Windows.Forms.ComboBox cbTimerMinutes;
        private System.Windows.Forms.Label lbMinutes;
        private System.Windows.Forms.Button btnStop;
    }
}

