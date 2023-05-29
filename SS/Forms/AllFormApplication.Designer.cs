namespace SS.Forms
{
    partial class AllFormApplication
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.BMinimize = new System.Windows.Forms.Button();
            this.BClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BApplication = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bNot_Approved = new System.Windows.Forms.Button();
            this.bApproved = new System.Windows.Forms.Button();
            this.bAll_applications = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel2.Controls.Add(this.BMinimize);
            this.panel2.Controls.Add(this.BClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 24);
            this.panel2.TabIndex = 22;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // BMinimize
            // 
            this.BMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BMinimize.FlatAppearance.BorderSize = 0;
            this.BMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BMinimize.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BMinimize.Location = new System.Drawing.Point(751, -3);
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
            this.BClose.Location = new System.Drawing.Point(777, -3);
            this.BClose.Name = "BClose";
            this.BClose.Size = new System.Drawing.Size(20, 27);
            this.BClose.TabIndex = 11;
            this.BClose.Text = "O";
            this.BClose.UseVisualStyleBackColor = true;
            this.BClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.BApplication);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Location = new System.Drawing.Point(0, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 41);
            this.panel1.TabIndex = 21;
            // 
            // BApplication
            // 
            this.BApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(65)))));
            this.BApplication.Cursor = System.Windows.Forms.Cursors.Default;
            this.BApplication.FlatAppearance.BorderSize = 0;
            this.BApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BApplication.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.BApplication.ForeColor = System.Drawing.Color.White;
            this.BApplication.Location = new System.Drawing.Point(3, 3);
            this.BApplication.Name = "BApplication";
            this.BApplication.Size = new System.Drawing.Size(192, 36);
            this.BApplication.TabIndex = 3;
            this.BApplication.Text = "Оставить заявку";
            this.BApplication.UseVisualStyleBackColor = false;
            this.BApplication.Click += new System.EventHandler(this.BApplication_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(65)))));
            this.Exit.Cursor = System.Windows.Forms.Cursors.Default;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(605, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(192, 36);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.bNot_Approved);
            this.panel3.Controls.Add(this.bApproved);
            this.panel3.Controls.Add(this.bAll_applications);
            this.panel3.Location = new System.Drawing.Point(0, 24);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(203, 387);
            this.panel3.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(65)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Не рассмотренные";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bNot_Approved
            // 
            this.bNot_Approved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(65)))));
            this.bNot_Approved.Cursor = System.Windows.Forms.Cursors.Default;
            this.bNot_Approved.FlatAppearance.BorderSize = 0;
            this.bNot_Approved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bNot_Approved.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.bNot_Approved.ForeColor = System.Drawing.Color.White;
            this.bNot_Approved.Location = new System.Drawing.Point(3, 93);
            this.bNot_Approved.Name = "bNot_Approved";
            this.bNot_Approved.Size = new System.Drawing.Size(192, 36);
            this.bNot_Approved.TabIndex = 4;
            this.bNot_Approved.Text = "Не одобренные";
            this.bNot_Approved.UseVisualStyleBackColor = false;
            this.bNot_Approved.Click += new System.EventHandler(this.bNot_Approved_Click);
            // 
            // bApproved
            // 
            this.bApproved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(65)))));
            this.bApproved.Cursor = System.Windows.Forms.Cursors.Default;
            this.bApproved.FlatAppearance.BorderSize = 0;
            this.bApproved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bApproved.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.bApproved.ForeColor = System.Drawing.Color.White;
            this.bApproved.Location = new System.Drawing.Point(3, 51);
            this.bApproved.Name = "bApproved";
            this.bApproved.Size = new System.Drawing.Size(192, 36);
            this.bApproved.TabIndex = 3;
            this.bApproved.Text = "Одобренные";
            this.bApproved.UseVisualStyleBackColor = false;
            this.bApproved.Click += new System.EventHandler(this.bApproved_Click);
            // 
            // bAll_applications
            // 
            this.bAll_applications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.bAll_applications.Cursor = System.Windows.Forms.Cursors.Default;
            this.bAll_applications.FlatAppearance.BorderSize = 0;
            this.bAll_applications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAll_applications.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.bAll_applications.ForeColor = System.Drawing.Color.White;
            this.bAll_applications.Location = new System.Drawing.Point(3, 9);
            this.bAll_applications.Name = "bAll_applications";
            this.bAll_applications.Size = new System.Drawing.Size(192, 36);
            this.bAll_applications.TabIndex = 2;
            this.bAll_applications.Text = "Все заявки";
            this.bAll_applications.UseVisualStyleBackColor = false;
            this.bAll_applications.Click += new System.EventHandler(this.bAll_applications_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(65)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(201, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(17, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(600, 387);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // AllFormApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AllFormApplication";
            this.Text = "AllFormApplication";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BMinimize;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bNot_Approved;
        private System.Windows.Forms.Button bApproved;
        private System.Windows.Forms.Button bAll_applications;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BApplication;
    }
}