namespace SS.Forms
{
    partial class GuesClassSchedule
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
            this.BReturn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BMinimize = new System.Windows.Forms.Button();
            this.BClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LPMonday = new System.Windows.Forms.FlowLayoutPanel();
            this.LMonday = new System.Windows.Forms.Label();
            this.LFriday = new System.Windows.Forms.Label();
            this.LPFriday = new System.Windows.Forms.FlowLayoutPanel();
            this.LThursday = new System.Windows.Forms.Label();
            this.LPThursday = new System.Windows.Forms.FlowLayoutPanel();
            this.LWednesday = new System.Windows.Forms.Label();
            this.LPWednesday = new System.Windows.Forms.FlowLayoutPanel();
            this.LTuesday = new System.Windows.Forms.Label();
            this.LPTuesday = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BReturn
            // 
            this.BReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(65)))));
            this.BReturn.FlatAppearance.BorderSize = 0;
            this.BReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BReturn.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.BReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BReturn.Location = new System.Drawing.Point(1194, 24);
            this.BReturn.Name = "BReturn";
            this.BReturn.Size = new System.Drawing.Size(111, 36);
            this.BReturn.TabIndex = 0;
            this.BReturn.Text = "Вернуться";
            this.BReturn.UseVisualStyleBackColor = false;
            this.BReturn.Click += new System.EventHandler(this.BReturn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel3.Controls.Add(this.BReturn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 594);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1317, 63);
            this.panel3.TabIndex = 9;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // BMinimize
            // 
            this.BMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BMinimize.FlatAppearance.BorderSize = 0;
            this.BMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMinimize.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BMinimize.Location = new System.Drawing.Point(1268, -3);
            this.BMinimize.Name = "BMinimize";
            this.BMinimize.Size = new System.Drawing.Size(20, 27);
            this.BMinimize.TabIndex = 13;
            this.BMinimize.Text = "O";
            this.BMinimize.UseVisualStyleBackColor = true;
            this.BMinimize.Click += new System.EventHandler(this.BMinimize_Click);
            // 
            // BClose
            // 
            this.BClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BClose.FlatAppearance.BorderSize = 0;
            this.BClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BClose.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BClose.Location = new System.Drawing.Point(1294, -3);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(20, 27);
            this.BClose.TabIndex = 11;
            this.BClose.Text = "O";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel2.Controls.Add(this.BMinimize);
            this.panel2.Controls.Add(this.BClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1317, 24);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // LPMonday
            // 
            this.LPMonday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LPMonday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(65)))));
            this.LPMonday.Location = new System.Drawing.Point(273, 156);
            this.LPMonday.Name = "LPMonday";
            this.LPMonday.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LPMonday.Size = new System.Drawing.Size(203, 513);
            this.LPMonday.TabIndex = 0;
            this.LPMonday.Paint += new System.Windows.Forms.PaintEventHandler(this.LPMonday_Paint);
            // 
            // LMonday
            // 
            this.LMonday.AutoSize = true;
            this.LMonday.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.LMonday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LMonday.Location = new System.Drawing.Point(268, 125);
            this.LMonday.Name = "LMonday";
            this.LMonday.Size = new System.Drawing.Size(113, 28);
            this.LMonday.TabIndex = 0;
            this.LMonday.Text = "Понедельник";
            this.LMonday.Click += new System.EventHandler(this.LMonday_Click);
            // 
            // LFriday
            // 
            this.LFriday.AutoSize = true;
            this.LFriday.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.LFriday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LFriday.Location = new System.Drawing.Point(1100, 125);
            this.LFriday.Name = "LFriday";
            this.LFriday.Size = new System.Drawing.Size(85, 28);
            this.LFriday.TabIndex = 0;
            this.LFriday.Text = "Пятница";
            this.LFriday.Click += new System.EventHandler(this.LFriday_Click);
            // 
            // LPFriday
            // 
            this.LPFriday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LPFriday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(65)))));
            this.LPFriday.Location = new System.Drawing.Point(1097, 156);
            this.LPFriday.Name = "LPFriday";
            this.LPFriday.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LPFriday.Size = new System.Drawing.Size(203, 513);
            this.LPFriday.TabIndex = 4;
            this.LPFriday.Paint += new System.Windows.Forms.PaintEventHandler(this.LPFriday_Paint);
            // 
            // LThursday
            // 
            this.LThursday.AutoSize = true;
            this.LThursday.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.LThursday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LThursday.Location = new System.Drawing.Point(894, 125);
            this.LThursday.Name = "LThursday";
            this.LThursday.Size = new System.Drawing.Size(83, 28);
            this.LThursday.TabIndex = 0;
            this.LThursday.Text = "Четверг";
            this.LThursday.Click += new System.EventHandler(this.LThursday_Click);
            // 
            // LPThursday
            // 
            this.LPThursday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LPThursday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(65)))));
            this.LPThursday.Location = new System.Drawing.Point(891, 156);
            this.LPThursday.Name = "LPThursday";
            this.LPThursday.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LPThursday.Size = new System.Drawing.Size(203, 513);
            this.LPThursday.TabIndex = 3;
            this.LPThursday.Paint += new System.Windows.Forms.PaintEventHandler(this.LPThursday_Paint);
            // 
            // LWednesday
            // 
            this.LWednesday.AutoSize = true;
            this.LWednesday.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.LWednesday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LWednesday.Location = new System.Drawing.Point(688, 125);
            this.LWednesday.Name = "LWednesday";
            this.LWednesday.Size = new System.Drawing.Size(58, 28);
            this.LWednesday.TabIndex = 0;
            this.LWednesday.Text = "Среда";
            this.LWednesday.Click += new System.EventHandler(this.LWednesday_Click);
            // 
            // LPWednesday
            // 
            this.LPWednesday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LPWednesday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(65)))));
            this.LPWednesday.Location = new System.Drawing.Point(685, 156);
            this.LPWednesday.Name = "LPWednesday";
            this.LPWednesday.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LPWednesday.Size = new System.Drawing.Size(203, 513);
            this.LPWednesday.TabIndex = 2;
            this.LPWednesday.Paint += new System.Windows.Forms.PaintEventHandler(this.LPWednesday_Paint);
            // 
            // LTuesday
            // 
            this.LTuesday.AutoSize = true;
            this.LTuesday.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.LTuesday.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LTuesday.Location = new System.Drawing.Point(482, 125);
            this.LTuesday.Name = "LTuesday";
            this.LTuesday.Size = new System.Drawing.Size(87, 28);
            this.LTuesday.TabIndex = 0;
            this.LTuesday.Text = "Вторник";
            this.LTuesday.Click += new System.EventHandler(this.LTuesday_Click);
            // 
            // LPTuesday
            // 
            this.LPTuesday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LPTuesday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(65)))));
            this.LPTuesday.Location = new System.Drawing.Point(479, 156);
            this.LPTuesday.Name = "LPTuesday";
            this.LPTuesday.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LPTuesday.Size = new System.Drawing.Size(203, 513);
            this.LPTuesday.TabIndex = 1;
            this.LPTuesday.Paint += new System.Windows.Forms.PaintEventHandler(this.LPTuesday_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(65)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1303, 156);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(203, 513);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1298, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Расписание уроков";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LMonday);
            this.panel1.Controls.Add(this.LTuesday);
            this.panel1.Controls.Add(this.LWednesday);
            this.panel1.Controls.Add(this.LThursday);
            this.panel1.Controls.Add(this.LFriday);
            this.panel1.Controls.Add(this.LPMonday);
            this.panel1.Controls.Add(this.LPTuesday);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.LPWednesday);
            this.panel1.Controls.Add(this.LPFriday);
            this.panel1.Controls.Add(this.LPThursday);
            this.panel1.Location = new System.Drawing.Point(-227, -81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1772, 820);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // GuesClassSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 657);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GuesClassSchedule";
            this.Text = "GuesClassSchedule";
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BReturn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BMinimize;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel LPMonday;
        private System.Windows.Forms.Label LMonday;
        private System.Windows.Forms.Label LFriday;
        private System.Windows.Forms.FlowLayoutPanel LPFriday;
        private System.Windows.Forms.Label LThursday;
        private System.Windows.Forms.FlowLayoutPanel LPThursday;
        private System.Windows.Forms.Label LWednesday;
        private System.Windows.Forms.FlowLayoutPanel LPWednesday;
        private System.Windows.Forms.Label LTuesday;
        private System.Windows.Forms.FlowLayoutPanel LPTuesday;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}