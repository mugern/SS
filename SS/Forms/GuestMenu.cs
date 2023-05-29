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
    public partial class GuestMenu : Form
    {
        public GuestMenu()
        {           
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            List<Class> SLASSES = DB.DB.db.Class.ToList();
            foreach (Class cla in SLASSES)
            {
                Button BClass = new Button();
                BClass.Text = cla.Number + " " + cla.letter;
                BClass.Font = new Font("Segoe Print", 12, FontStyle.Bold);
                BClass.ForeColor = Color.White;
                BClass.Click += test;
                BClass.Height = 50;
                BClass.BackColor = Color.FromArgb(39, 39, 65);
                BClass.FlatStyle = FlatStyle.Flat;
                BClass.FlatAppearance.BorderSize = 0;
                flowLayoutPanel1.Controls.Add(BClass);
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void test(object sender, EventArgs e)
        {
            string[] Fir = (sender as Button).Text.Split(' ');
            GuesClassSchedule ACS = new GuesClassSchedule(Fir);
            ACS.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            FormAuthorization a = new FormAuthorization();
            a.Show();
            this.Close();
        }

        private void BMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
