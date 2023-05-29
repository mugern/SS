using SS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SS.Card
{
    public partial class Schedule : UserControl
    {
        public int id;
        public AdminClassSchedule ACS;
        public int lessonNumber;

        public Schedule(string STBlesson, string STBOffice, string STBLessonNumber, int id)
        {

            InitializeComponent();
            TBlesson.Text = STBlesson;
            TBOffice.Text = STBOffice;
            TBLessonNumber.Text = STBLessonNumber;
            this.id = id;
            lessonNumber = int.Parse(STBLessonNumber);
        }
        public Schedule(string STBlesson, string STBOffice, string STBLessonNumber)
        {

            InitializeComponent();
            TBlesson.Text = STBlesson;
            TBOffice.Text = STBOffice;
            TBLessonNumber.Text = STBLessonNumber;
            lessonNumber = 1;

        }
        public Schedule(int id)
        { 
            this.id = id;
        }

        public string get_Lesson() { return TBlesson.Text; }
        public string get_Office() { return TBOffice.Text; }
        public string get_LessonNumber() { return TBLessonNumber.Text; }

        private void Schedule_Click(object sender, EventArgs e)
        {
            
            if (ACS != null && ACS.status == "Применить")
            {
                ACS.scheduleCards.Add(this);
                TBlesson.ReadOnly = TBOffice.ReadOnly = TBLessonNumber.ReadOnly = false;
                TBlesson.BorderStyle = TBOffice.BorderStyle = TBLessonNumber.BorderStyle = BorderStyle.Fixed3D;
            }
        }
        public void disablecart()
        {
            TBlesson.ReadOnly = TBOffice.ReadOnly = TBLessonNumber.ReadOnly = true;
            TBlesson.BorderStyle = TBOffice.BorderStyle = TBLessonNumber.BorderStyle = BorderStyle.None;

        }

        
    }
}
