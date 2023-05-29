using SS.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SS.Forms
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            List<Class> SLASSES = DB.DB.db.Class.ToList();
            foreach (Class cla in SLASSES) 
            {
                Button BClass = new Button();
                BClass.Text = cla.Number + " " + cla.letter;
                BClass.Font = new Font("Segoe Print",12,FontStyle.Bold);
                BClass.ForeColor = Color.White;
                BClass.Click += test;
                BClass.Height= 50;
                BClass.BackColor = Color.FromArgb(39,39,65);
                BClass.FlatStyle = FlatStyle.Flat;
                BClass.FlatAppearance.BorderSize = 0;
                flowLayoutPanel1.Controls.Add(BClass);
            }           
        }
        public void plClass(Class Clas)
        {                      
            DB.DB.db.Class.Add(Clas);
            DB.DB.db.SaveChanges();
            AdminMenu a = new AdminMenu();
            a.Show();
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void test(object sender, EventArgs e) 
        {            
            string[] Fir = (sender as Button).Text.Split(' ');            
            AdminClassSchedule ACS = new AdminClassSchedule(Fir);
            ACS.Show();
            this.Hide();
        }

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
            Application.Exit();
        }

        

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bclassPL_Click(object sender, EventArgs e)
        {
            AdminMenu a = new AdminMenu();
            PlusClass pl =  new PlusClass(a);
            pl.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {            
            FormAuthorization a = new FormAuthorization();
            a.Show();
            this.Close();
        }

        private void BApplication_Click(object sender, EventArgs e)
        {
            string status = "";
            AllFormApplication a = new AllFormApplication(status);
            a.Show();
            this.Close();
        }

        private void bclassMIN_Click(object sender, EventArgs e)
        {
            Deleting_class_Form a = new Deleting_class_Form();
            a.Show();
            this.Close();
        }
    }
}
