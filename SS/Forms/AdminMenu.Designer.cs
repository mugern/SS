namespace SS.Forms
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BMinimize = new System.Windows.Forms.Button();
            this.BClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bclassMIN = new System.Windows.Forms.Button();
            this.bclassPL = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 372);
            this.flowLayoutPanel1.TabIndex = 0;
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
            this.panel2.TabIndex = 7;
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
            this.panel1.Controls.Add(this.bclassMIN);
            this.panel1.Controls.Add(this.bclassPL);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Location = new System.Drawing.Point(0, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 56);
            this.panel1.TabIndex = 8;
            // 
            // bclassMIN
            // 
            this.bclassMIN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bclassMIN.BackgroundImage")));
            this.bclassMIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bclassMIN.FlatAppearance.BorderSize = 0;
            this.bclassMIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bclassMIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bclassMIN.Location = new System.Drawing.Point(12, 17);
            this.bclassMIN.Name = "bclassMIN";
            this.bclassMIN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bclassMIN.Size = new System.Drawing.Size(25, 25);
            this.bclassMIN.TabIndex = 10;
            this.bclassMIN.UseVisualStyleBackColor = true;
            // 
            // bclassPL
            // 
            this.bclassPL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bclassPL.BackgroundImage")));
            this.bclassPL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bclassPL.FlatAppearance.BorderSize = 0;
            this.bclassPL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bclassPL.Location = new System.Drawing.Point(43, 17);
            this.bclassPL.Name = "bclassPL";
            this.bclassPL.Size = new System.Drawing.Size(25, 25);
            this.bclassPL.TabIndex = 9;
            this.bclassPL.UseVisualStyleBackColor = true;
            this.bclassPL.Click += new System.EventHandler(this.bclassPL_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(65)))));
            this.Exit.Cursor = System.Windows.Forms.Cursors.Default;
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(621, 6);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(167, 36);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BMinimize;
        private System.Windows.Forms.Button BClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button bclassMIN;
        private System.Windows.Forms.Button bclassPL;
    }
}