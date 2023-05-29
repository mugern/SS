namespace SS.Card
{
    partial class ApplicationCard
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TBAppli = new System.Windows.Forms.TextBox();
            this.TB_FIO = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.BApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBAppli
            // 
            this.TBAppli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBAppli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(65)))));
            this.TBAppli.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBAppli.ForeColor = System.Drawing.Color.Transparent;
            this.TBAppli.Location = new System.Drawing.Point(131, 41);
            this.TBAppli.Multiline = true;
            this.TBAppli.Name = "TBAppli";
            this.TBAppli.ReadOnly = true;
            this.TBAppli.Size = new System.Drawing.Size(391, 156);
            this.TBAppli.TabIndex = 5;
            // 
            // TB_FIO
            // 
            this.TB_FIO.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_FIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(65)))));
            this.TB_FIO.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_FIO.ForeColor = System.Drawing.Color.Transparent;
            this.TB_FIO.Location = new System.Drawing.Point(131, 3);
            this.TB_FIO.Name = "TB_FIO";
            this.TB_FIO.Size = new System.Drawing.Size(391, 36);
            this.TB_FIO.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(3, 123);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(46, 32);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "✓";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.checkBox2.Location = new System.Drawing.Point(77, 123);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 32);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "✘";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // BApply
            // 
            this.BApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(65)))));
            this.BApply.Cursor = System.Windows.Forms.Cursors.Default;
            this.BApply.FlatAppearance.BorderSize = 0;
            this.BApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BApply.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.BApply.ForeColor = System.Drawing.Color.White;
            this.BApply.Location = new System.Drawing.Point(3, 161);
            this.BApply.Name = "BApply";
            this.BApply.Size = new System.Drawing.Size(122, 36);
            this.BApply.TabIndex = 9;
            this.BApply.Text = "Применить";
            this.BApply.UseVisualStyleBackColor = false;
            this.BApply.Click += new System.EventHandler(this.BApply_Click);
            // 
            // ApplicationCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Controls.Add(this.BApply);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.TB_FIO);
            this.Controls.Add(this.TBAppli);
            this.Name = "ApplicationCard";
            this.Size = new System.Drawing.Size(525, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBAppli;
        private System.Windows.Forms.TextBox TB_FIO;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button BApply;
    }
}
