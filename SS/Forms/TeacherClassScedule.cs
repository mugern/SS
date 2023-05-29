using SS.Card;
using SS.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SS.Forms
{
    public partial class TeacherClassScedule : Form
    {
        // Список карт расписания
        public List<Schedule> scheduleCards = new List<Schedule>();

        // Неделя (понедельник, вторник и т.д.)
        public string week;

        // Объект класса
        Class classObj;
        public string[] classData;
        string classLetter;
        string classNumber;
        public TeacherClassScedule(string []ClassData)
        {
            InitializeComponent();
            LPMonday.AutoScroll = true;
            LPFriday.AutoScroll = true;
            LPThursday.AutoScroll = true;
            LPTuesday.AutoScroll = true;
            LPWednesday.AutoScroll = true;
            // Получение данных о классе
            classLetter = ClassData[1];
            classNumber = ClassData[0];
            // Скрытие заголовка и кнопки закрытия формы
            this.Text = string.Empty;
            this.ControlBox = false;

            // Поиск класса в базе данных
            classObj = DB.DB.db.Class.FirstOrDefault(a => a.letter == classLetter && a.Number.ToString() == classNumber);
            this.classData = ClassData;

            if (classObj != null)
            {
                List<ClassLesson> classLessons = DB.DB.db.ClassLesson.Where(SL => SL.ID_class == classObj.ID_class).ToList();
                for (int day = 1; day <= 5; day++)
                {
                    List<ClassLesson> lessonsOfDay = classLessons.Where(cl => cl.Day_Life == day).ToList();

                    foreach (ClassLesson lessonOfDay in lessonsOfDay)
                    {
                        // Создание карты расписания
                        Schedule schedule = new Schedule(
                                                    DB.DB.db.Lessons.FirstOrDefault(a => a.ID_lessons == lessonOfDay.ID_lessons)?.lessons1,
                                                    DB.DB.db.Lessons.FirstOrDefault(a => a.ID_lessons == lessonOfDay.ID_lessons)?.Сabinet_Number,
                                                    lessonOfDay.Lesson_Number.ToString(),
                                                    lessonOfDay.id
                                                );
                        Schedule scheduleCard = schedule;

                        // Добавление карты расписания в соответствующий день недели
                        switch (day)
                        {
                            case 1:
                                LPMonday.Controls.Add(scheduleCard);
                                break;
                            case 2:
                                LPTuesday.Controls.Add(scheduleCard);
                                break;
                            case 3:
                                LPWednesday.Controls.Add(scheduleCard);
                                break;
                            case 4:
                                LPThursday.Controls.Add(scheduleCard);
                                break;
                            case 5:
                                LPFriday.Controls.Add(scheduleCard);
                                break;
                        }
                    }
                }
            }
            LpSort(LPMonday);
            LpSort(LPFriday);
            LpSort(LPThursday);
            LpSort(LPTuesday);
            LpSort(LPWednesday);
        }
        public void LpSort(FlowLayoutPanel FLP)
        {
            // Получение списка всех контролов (карточек) в FlowLayoutPanel
            List<Control> controls = FLP.Controls.Cast<Control>().ToList();

            // Сортировка контролов по значению TBLessonNumber
            controls.Sort((c1, c2) =>
            {
                int lessonNumber1 = ((Schedule)c1).lessonNumber;
                int lessonNumber2 = ((Schedule)c2).lessonNumber;
                return lessonNumber1.CompareTo(lessonNumber2);
            });


            // Очистка и повторное добавление контролов в FlowLayoutPanel с учетом новой сортировки
            FLP.Controls.Clear();
            FLP.Controls.AddRange(controls.ToArray());
        }

        private void BReturn_Click(object sender, EventArgs e)
        {
            TeacherMenu a = new TeacherMenu();
            a.Show();
            this.Close();
        }

        private void BMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        
    }
}
