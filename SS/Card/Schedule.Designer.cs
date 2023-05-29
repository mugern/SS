namespace SS.Card
{
    partial class Schedule
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
            this.TBlesson = new System.Windows.Forms.TextBox();
            this.TBOffice = new System.Windows.Forms.TextBox();
            this.TBLessonNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TBlesson
            // 
            this.TBlesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.TBlesson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBlesson.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold);
            this.TBlesson.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TBlesson.Location = new System.Drawing.Point(8, 3);
            this.TBlesson.Name = "TBlesson";
            this.TBlesson.ReadOnly = true;
            this.TBlesson.Size = new System.Drawing.Size(169, 34);
            this.TBlesson.TabIndex = 3;
            this.TBlesson.Text = "Название предмета";
            // 
            // TBOffice
            // 
            this.TBOffice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.TBOffice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBOffice.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBOffice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TBOffice.Location = new System.Drawing.Point(8, 36);
            this.TBOffice.Name = "TBOffice";
            this.TBOffice.ReadOnly = true;
            this.TBOffice.Size = new System.Drawing.Size(79, 30);
            this.TBOffice.TabIndex = 4;
            this.TBOffice.Text = "Кабинет";
            // 
            // TBLessonNumber
            // 
            this.TBLessonNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.TBLessonNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBLessonNumber.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBLessonNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TBLessonNumber.Location = new System.Drawing.Point(124, 36);
            this.TBLessonNumber.Name = "TBLessonNumber";
            this.TBLessonNumber.ReadOnly = true;
            this.TBLessonNumber.Size = new System.Drawing.Size(53, 30);
            this.TBLessonNumber.TabIndex = 5;
            this.TBLessonNumber.Text = "Номер";
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.Controls.Add(this.TBLessonNumber);
            this.Controls.Add(this.TBOffice);
            this.Controls.Add(this.TBlesson);
            this.Name = "Schedule";
            this.Size = new System.Drawing.Size(180, 70);
            
            this.Click += new System.EventHandler(this.Schedule_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TBlesson;
        private System.Windows.Forms.TextBox TBOffice;
        private System.Windows.Forms.TextBox TBLessonNumber;
    }
}
