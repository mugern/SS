using SS.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SS.Forms
{
    public partial class Deleting_class_Form : Form
    {
        public Deleting_class_Form()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            var classes = DB.DB.db.Class.Select(c => c.Number + c.letter).ToList();
            CBDelClass.DataSource = classes;
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
            AdminMenu a = new AdminMenu();
            a.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminMenu a = new AdminMenu();
            a.Show();
            this.Close();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BDel_class_Click(object sender, EventArgs e)
        {            
            // Проверяем, выбран ли элемент в ComboBox
            if (CBDelClass.SelectedItem != null)
            {
                // Получаем выбранный класс
                string selectedClass = CBDelClass.SelectedItem.ToString();

                // Создаем экземпляр контекста базы данных


                // Ищем класс в таблице Class по выбранному классу
                var classToDelete = DB.DB.db.Class.FirstOrDefault(c => c.Number + c.letter == selectedClass);
                //string num = 
                //var classLessonToDelet = DB.DB.db.ClassLesson.ToList(a => );
                //foreach

                // Если класс найден, удаляем его
                if (classToDelete != null)
                {
                    int id = classToDelete.ID_class;
                    List<ClassLesson> classLessons = DB.DB.db.ClassLesson.ToList();
                    
                        List<ClassLesson> classLessonToRemove = classLessons
                            .Where(d => d.ID_class == id).ToList();
                        classLessons.RemoveAll(lesson => lesson.ID_class == id);
                    DB.DB.db.Class.Remove(classToDelete);
                    DB.DB.db.SaveChanges(); // Сохраняем изменения в базе данных
                    MessageBox.Show("Класс успешно удален.");
                    RefreshComboBoxData(); // Обновляем ComboBox
                }
                else
                {
                    MessageBox.Show("Выбранный класс не найден.");
                }

            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите класс для удаления.");
            }
        }
        private void RefreshComboBoxData()
        {
            // Очищаем ComboBox перед обновлением данных
            CBDelClass.DataSource = null;

            // Создаем экземпляр контекста базы данных


            // Получаем список всех классов из таблицы Class
            var classes = DB.DB.db.Class.Select(c => c.Number + c.letter).ToList();
            // Устанавливаем источник данных для ComboBox
            CBDelClass.DataSource = classes;
            CBDelClass.DataSource = classes;


        }
    }
}
