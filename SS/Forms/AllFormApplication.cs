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
    public partial class AllFormApplication : Form
    {
        public string formStatus;
        public AllFormApplication(string status)
        {
            formStatus = status;
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;            
            if (formStatus != "Teacher")
            {
                BApplication.Visible = false;
            }

            foreach (ApplicationTB application in DB.DB.db.ApplicationTBs.ToList())
            {
                // Создание и добавление карточки в FlowLayoutPanel              
                ApplicationCard cards = new ApplicationCard(formStatus, application.FIO_application, application.application, application.Status_application);
                flowLayoutPanel1.Controls.Add(cards);
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

        private void BClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (formStatus == "Teacher")
            {
                TeacherMenu a = new TeacherMenu();
                a.Show();
                this.Close();
            }
            else
            { 
                AdminMenu a = new AdminMenu();
                a.Show();
                this.Close();
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }        

        private void BApplication_Click(object sender, EventArgs e)
        {
            applicationTeaher a = new applicationTeaher();
            a.Show();
            this.Close();
        }

        private void bAll_applications_Click(object sender, EventArgs e)
        {
            bAll_applications.BackColor = Color.FromArgb(51, 51, 76);
            bApproved.BackColor = bNot_Approved.BackColor = button1.BackColor = Color.FromArgb(39, 39, 65);
            // Очистка старых карточек
            flowLayoutPanel1.Controls.Clear();
            // Добавление новых карточек
            foreach (ApplicationTB application in DB.DB.db.ApplicationTBs.ToList())
            {
                ApplicationCard cards = new ApplicationCard(formStatus, application.FIO_application, application.application, application.Status_application);
                flowLayoutPanel1.Controls.Add(cards);
            }
        }

        private void bApproved_Click(object sender, EventArgs e)
        {
            bApproved.BackColor = Color.FromArgb(51, 51, 76);
            bAll_applications.BackColor = bNot_Approved.BackColor = button1.BackColor = Color.FromArgb(39, 39, 65);
            // Очистка старых карточек
            flowLayoutPanel1.Controls.Clear();            
            // Добавление новых карточек
            foreach (ApplicationTB application in DB.DB.db.ApplicationTBs.ToList().Where(a => a.Status_application == "1").ToList())
            {
                ApplicationCard cards = new ApplicationCard(formStatus, application.FIO_application, application.application, application.Status_application);               
                flowLayoutPanel1.Controls.Add(cards);
            }
        }

        private void bNot_Approved_Click(object sender, EventArgs e)
        {
            bNot_Approved.BackColor = Color.FromArgb(51, 51, 76);
            bAll_applications.BackColor = bApproved.BackColor = button1.BackColor = Color.FromArgb(39, 39, 65);
            flowLayoutPanel1.Controls.Clear();
            // Добавление новых карточек
            foreach (ApplicationTB application in DB.DB.db.ApplicationTBs.ToList().Where(a => a.Status_application == "2").ToList())
            {
                ApplicationCard cards = new ApplicationCard(formStatus, application.FIO_application, application.application, application.Status_application);
                flowLayoutPanel1.Controls.Add(cards);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(51, 51, 76);
            bAll_applications.BackColor = bNot_Approved.BackColor = bApproved.BackColor = Color.FromArgb(39, 39, 65);
            flowLayoutPanel1.Controls.Clear();
            // Добавление новых карточек
            foreach (ApplicationTB application in DB.DB.db.ApplicationTBs.ToList().Where(a => a.Status_application == "0").ToList())
            {
                ApplicationCard cards = new ApplicationCard(formStatus, application.FIO_application, application.application, application.Status_application);
                flowLayoutPanel1.Controls.Add(cards);
            }
        }
    }
}
