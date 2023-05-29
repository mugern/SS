using SS.Card;
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
    public partial class AdminClassSchedule : Form
    {

        // Статус формы
        public string status = "Редактировать";

        // Список карт расписания
        public List<Schedule> scheduleCards = new List<Schedule>();

        // Неделя (понедельник, вторник и т.д.)
        public string week;

        // Объект класса
        Class classObj;

        // Массив с данными о классе
        public string[] classData;
        string classLetter;
        string classNumber;
        public AdminClassSchedule(string[] classData)
        {
            // Получение данных о классе
            classLetter = classData[1];
            classNumber = classData[0];
            InitializeComponent();
            LPMonday.AutoScroll=true;
            LPFriday.AutoScroll=true;
            LPThursday.AutoScroll=true;
            LPTuesday.AutoScroll=true;
            LPWednesday.AutoScroll=true;
            // Скрытие заголовка и кнопки закрытия формы
            this.Text = string.Empty;
            this.ControlBox = false;

            // Поиск класса в базе данных
            classObj = DB.DB.db.Class.FirstOrDefault(a => a.letter == classLetter && a.Number.ToString() == classNumber);
            this.classData = classData;

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

                        scheduleCard.ACS = this;

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
        // Импорт функций для перемещения окна формы
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Свернуть окно
        private void BMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Закрыть окно
        private void BClose_Click(object sender, EventArgs e)
        {
            if (BEdit.Text == "Применить")
            {
                DialogResult result = MessageBox.Show("Внимание! Вы не сохранили изменения.",
                    "Внимание!",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.DefaultDesktopOnly);

                if (result == DialogResult.OK)
                {
                    System.Windows.Forms.Application.Exit();
                }
            }
            else
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        // Перетаскивание окна формы
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Редактирование расписания
        private void BEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (BEdit.Text == "Применить")
                {
                    // Сохранение изменений в базе данных
                    foreach (Schedule scheduleCard in scheduleCards)
                    {
                        var lesson = DB.DB.db.Lessons.AsEnumerable().FirstOrDefault(l => l.lessons1 == scheduleCard.get_Lesson());
                        if (lesson == null)
                            continue;

                        ClassLesson classLesson = new ClassLesson()
                        {
                            ID_lessons = lesson.ID_lessons,
                            Lesson_Number = int.Parse(scheduleCard.get_LessonNumber())
                        };

                        ClassLesson existingClassLesson = DB.DB.db.ClassLesson.FirstOrDefault(cl => cl.id == scheduleCard.id);
                        if (existingClassLesson != null)
                        {
                            existingClassLesson.SetValues(classLesson);
                        }
                        else
                        {
                            classLesson.ID_class = classObj.ID_class;
                            switch (scheduleCard.Parent.Name)
                            {
                                case "LPMonday":
                                    classLesson.Day_Life = 1;
                                    break;
                                case "LPTuesday":
                                    classLesson.Day_Life = 2;
                                    break;
                                case "LPWednesday":
                                    classLesson.Day_Life = 3;
                                    break;
                                case "LPThursday":
                                    classLesson.Day_Life = 4;
                                    break;
                                case "LPFriday":
                                    classLesson.Day_Life = 5;
                                    break;
                            }
                            DB.DB.db.ClassLesson.Add(classLesson);
                        }
                        DB.DB.db.SaveChanges();
                        scheduleCard.disablecart();
                    }
                    scheduleCards.Clear();
                    BEdit.Text = "Редактировать";
                    status = "Редактировать";
                    bFridayMIN.Visible = bFridayPL.Visible = bMondayMIN.Visible = bMondayPL.Visible = bThursdayMIN.Visible
                        = bThursdayPL.Visible = bWednesdayMIN.Visible = bWednesdayPL.Visible = bTuesdayMIN.Visible = bTuesdayPL.Visible = false;
                    panel4.BackColor = panel5.BackColor = panel6.BackColor = panel7.BackColor = panel8.BackColor = Color.FromArgb(51, 51, 76);
                }
                else
                {
                    bFridayMIN.Visible = bFridayPL.Visible = bMondayMIN.Visible = bMondayPL.Visible = bThursdayMIN.Visible
                        = bThursdayPL.Visible = bWednesdayMIN.Visible = bWednesdayPL.Visible = bTuesdayMIN.Visible = bTuesdayPL.Visible = true;
                    panel4.BackColor = panel5.BackColor = panel6.BackColor = panel7.BackColor = panel8.BackColor = Color.FromArgb(39, 39, 65);
                    status = "Применить";
                    BEdit.Text = "Применить";
                }
            }
            catch 
            {
                
                DialogResult result = MessageBox.Show("Внимание! Возникла ошибка при попытке занесения изменений. Проверьте все ли поля заполнены либо заполнены правильно. ПРИ НАЖАТИИ КНОПКИ Cancel ВЫ ВЕРНЁТЕСЬ НА ФОРМУ ВЫБОРА КЛАССОВ!!!",
                "Внимание!",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
                if (result == DialogResult.OK)
                {
                    // Оставьте пустой блок или добавьте обработку в случае нажатия кнопки OK
                }
                else
                {
                    AdminMenu adminMenu = new AdminMenu();
                    adminMenu.Show();
                    this.Close();
                }
            }
        }

        // Добавление нового расписания
        public void PLUS(string week)
        {
            Schedule scheduleCard = new Schedule("", "", "");
            switch (week)
            {
                case "Monday":
                    scheduleCard.ACS = this;
                    LPMonday.Controls.Add(scheduleCard);
                    break;
                case "Tuesday":
                    scheduleCard.ACS = this;
                    LPTuesday.Controls.Add(scheduleCard);
                    break;
                case "Wednesday":
                    scheduleCard.ACS = this;
                    LPWednesday.Controls.Add(scheduleCard);
                    break;
                case "Thursday":
                    scheduleCard.ACS = this;
                    LPThursday.Controls.Add(scheduleCard);
                    break;
                case "Friday":
                    scheduleCard.ACS = this;
                    LPFriday.Controls.Add(scheduleCard);
                    break;

            }
        }

        // Добавление расписания на понедельник
        private void bMondayPL_Click(object sender, EventArgs e)
        {
            week = "Monday";
            PLUS(week);
        }

        // Добавление расписания на вторник
        private void bTuesdayPL_Click(object sender, EventArgs e)
        {
            week = "Tuesday";
            PLUS(week);
        }

        // Добавление расписания на среду
        private void bWednesdayPL_Click(object sender, EventArgs e)
        {
            week = "Wednesday";
            PLUS(week);
        }

        // Добавление расписания на четверг
        private void bThursdayPL_Click(object sender, EventArgs e)
        {
            week = "Thursday";
            PLUS(week);
        }

        // Добавление расписания на пятницу
        private void bFridayPL_Click(object sender, EventArgs e)
        {
            week = "Friday";
            PLUS(week);
        }
        private void RemoveLastSchedule(Control control, int dayLife)
        {

            if (control.Controls.Count > 0)
            {
                try
                {
                    Schedule lastSchedule = control.Controls[control.Controls.Count - 1] as Schedule;
                    int lastScheduleId = lastSchedule.id;

                    // Найти карточку для удаления по ее id
                    ClassLesson classLessonToRemove = DB.DB.db.ClassLesson
                        .SingleOrDefault(d => d.id == lastScheduleId);

                    if (classLessonToRemove != null)
                    {
                        DB.DB.db.ClassLesson.Remove(classLessonToRemove);
                        DB.DB.db.SaveChanges();
                    }

                    control.Controls.Remove(lastSchedule);
                }
                catch
                {                   
                    
                }
            }
        }

        // Минус - удаление последнего элемента расписания на понедельник
        private void bMondayMIN_Click(object sender, EventArgs e)
        {

            RemoveLastSchedule(LPMonday, 1);
        }
        private void BReturn_Click(object sender, EventArgs e)
        {
            AdminMenu a = new AdminMenu();
            a.Show();
            this.Close();

        }

        private void bTuesdayMIN_Click(object sender, EventArgs e)
        {
            RemoveLastSchedule(LPTuesday, 2);
        }

        private void bWednesdayMIN_Click(object sender, EventArgs e)
        {
            RemoveLastSchedule(LPWednesday, 3);
        }

        private void bThursdayMIN_Click(object sender, EventArgs e)
        {
            RemoveLastSchedule(LPThursday, 4);
        }

        private void bFridayMIN_Click(object sender, EventArgs e)
        {
            RemoveLastSchedule(LPFriday, 5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddLessons add = new AddLessons(classLetter, classNumber);
            add.Show();
            this.Close();
        }
    }
}