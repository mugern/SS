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
        public string status = "Редактировать";
        public List<Schedule> CARD = new List<Schedule>();
        public string week;
        Class Cl;
        public AdminClassSchedule(string[] Fir )
        {
            
            InitializeComponent();
            byte i = 0;            
            this.Text = string.Empty;
            this.ControlBox = false;
            Cl = DB.DB.db.Class.ToList().Find(a => a.letter == Fir[1] && a.Number.ToString() == Fir[0]);
            if (Cl != null)
            {
                List<ClassLesson> classLessons = DB.DB.db.ClassLesson.ToList().FindAll(SL => SL.ID_class == Cl.ID_class);
                foreach (ClassLesson cl in classLessons)
                {                    
                    i++;
                    List<ClassLesson> CL_Day = classLessons.FindAll(day => day.Day_Life == i);
                    foreach (ClassLesson DL in CL_Day)
                    {
                        Schedule card = new Schedule
                            (
                                DB.DB.db.Lessons.ToList().Find(a=>a.ID_lessons == DL.ID_lessons).lessons1,
                                DB.DB.db.Lessons.ToList().Find(a => a.ID_lessons == DL.ID_lessons).Сabinet_Number,
                                DL.Lesson_Number.ToString(),
                                DL.id
                            );
                        card.ACS = this;
                        switch (DL.Day_Life)
                        {
                            case 1:
                                LPMonday.Controls.Add(card);                               
                                break;
                            case 2:
                                LPTuesday.Controls.Add(card);
                                break;
                            case 3:
                                LPWednesday.Controls.Add(card);
                                break;
                            case 4:
                                LPThursday.Controls.Add(card);
                                break;
                            case 5:
                                LPFriday.Controls.Add(card);
                                break;
                        }
                    }
                }
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void BMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

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
                    Application.Exit();
                }                  
            }
            else
            {
                Application.Exit();
            }          
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BEdit_Click(object sender, EventArgs e)
        {
            if (BEdit.Text == "Применить")
            {
                foreach (Schedule sch in CARD)
                {
                    ClassLesson CL = new ClassLesson();
                    CL.ID_lessons = DB.DB.db.Lessons.ToList().Find(l => l.lessons1 == sch.get_Lesson()).ID_lessons;
                    CL.Lesson_Number = int.Parse(sch.get_LessonNumber());

                    ClassLesson CLAS = DB.DB.db.ClassLesson.ToList().Find(cl => cl.id == sch.id);
                    if (CLAS != null)
                    {
                        CLAS.SetValues(CL);
                    }
                    else
                    {
                        CL.ID_class = Cl.ID_class;
                        switch (sch.Parent.Name)
                        {
                            case "LPMonday":
                                CL.Day_Life = 1;
                                break;
                            case "LPTuesday":
                                CL.Day_Life = 2;
                                break;
                            case "LPWednesday":
                                CL.Day_Life = 3;
                                break;
                            case "LPThursday":
                                CL.Day_Life = 4;
                                break;
                            case "LPFriday":
                                CL.Day_Life = 5;
                                break;
                        }
                        DB.DB.db.ClassLesson.Add(CL);
                    }

                    DB.DB.db.SaveChanges();
                    sch.disablecart();
                }
                CARD.Clear();
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
        public void PLUS(string week)
        {
            Schedule card = new Schedule("", "", "");
            switch (week)
            {
                case "Monday":                    
                    card.ACS = this;
                    LPMonday.Controls.Add(card);
                    break;
                case "Tuesday":                   
                    card.ACS = this;
                    LPTuesday.Controls.Add(card);
                    break;
                case "Wednesday":                    
                    card.ACS = this;
                    LPWednesday.Controls.Add(card);
                    break;
                case "Thursday":                    
                    card.ACS = this;
                    LPThursday.Controls.Add(card);
                    break;
                case "Friday":                   
                    card.ACS = this;
                    LPFriday.Controls.Add(card);
                    break;

            }
        }
        private void bMondayPL_Click(object sender, EventArgs e)
        {
            week = "Monday";
            PLUS(week);
        }

        private void bTuesdayPL_Click(object sender, EventArgs e)
        {
            week = "Tuesday";
            PLUS(week);
        }

        private void bWednesdayPL_Click(object sender, EventArgs e)
        {
            week = "Wednesday";
            PLUS(week);
        }

        private void bThursdayPL_Click(object sender, EventArgs e)
        {
            week = "Thursday";
            PLUS(week);
        }

        private void bFridayPL_Click(object sender, EventArgs e)
        {
            week = "Friday";
            PLUS(week);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bMondayMIN_Click(object sender, EventArgs e)
        {

        }



        //if (BEdit.Text == "Применить")
        //{
        //    Schedule card = new Schedule("","","",);
        //    LPMonday.Controls.Add(card);
        //}

    }
}
