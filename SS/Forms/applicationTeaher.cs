using SS.DB;
using SS.Forms;
using SS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SS.Forms
{
    public partial class applicationTeaher : Form
    {
        public applicationTeaher()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void BMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            string status = "Teacher";
            AllFormApplication a = new AllFormApplication(status);
            a.Show();
            this.Close();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BAddit_Click_1(object sender, EventArgs e)
        {
            try
            {
                string fio = TB_FIO.Text;
                string applicationText = TBAppli.Text;

                // Проверка наличия данных в полях ФИО и заявки
                if (string.IsNullOrEmpty(fio) || string.IsNullOrEmpty(applicationText))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Создание новой заявки
                ApplicationTB newApplication = new ApplicationTB()
                {
                    FIO_application = fio,
                    application = applicationText,
                    Status_application = "0"// Новая заявка имеет статус "не обработана"
                };

                // Добавление заявки в базу данных
                DB.DB.db.ApplicationTBs.Add(newApplication);
                DB.DB.db.SaveChanges();

                MessageBox.Show("Заявка успешно отправлена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Очистка полей ввода после отправки заявки
                TB_FIO.Text = string.Empty;
                TBAppli.Text = string.Empty;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при отправке заявки: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
    }
}
