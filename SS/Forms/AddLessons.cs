using SS.DB;
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
    public partial class AddLessons : Form
    {
        public string Number;
        public string Letter;
        public AddLessons(string classLetter, string classNumber)
        {
            Letter = classLetter;
            Number = classNumber;
            this.Text = string.Empty;
            this.ControlBox = false;
            InitializeComponent();
        }
        
        private void BPLLessons_Click(object sender, EventArgs e)
        {
            try
            {
                // Получение максимального значения ID_lessons из базы данных
                int maxLessonId = DB.DB.db.Lessons.Max(l => l.ID_lessons);

                // Генерация нового значения ID_lessons
                int newLessonId = maxLessonId + 1;

                // Создание нового объекта Lessons с заполненными данными из текстовых полей
                Lessons newLesson = new Lessons()
                {
                    ID_lessons = newLessonId,
                    lessons1 = textBox1.Text,
                    Сabinet_Number = textBox2.Text
                };

                // Добавление нового урока в базу данных
                DB.DB.db.Lessons.Add(newLesson);
                DB.DB.db.SaveChanges();

                // Вывод сообщения об успешном добавлении урока
                MessageBox.Show("Урок успешно добавлен в базу данных.");

                // Очистка текстовых полей
                textBox1.Clear();
                textBox2.Clear();
            }
            catch (Exception ex)
            {
                // Обработка ошибки
                MessageBox.Show("Ошибка при добавлении урока: " + ex.Message);
            }
        }
        // Импорт функций для перемещения окна формы
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
            if (textBox1.Text != null || textBox2.Text != null)
            {
                DialogResult result = MessageBox.Show("Внимание! Вы не сохранили изменения.",
                    "Внимание!",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.OK)
                {
                    string[] classDate = new string[] { Number, Letter };
                    AdminClassSchedule a = new AdminClassSchedule(classDate);
                    a.Show();
                    this.Close();
                }               
            }
            else
            {
                string[] classDate = new string[] { Number, Letter };
                AdminClassSchedule a = new AdminClassSchedule(classDate);
                a.Show();
                this.Close();               
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
