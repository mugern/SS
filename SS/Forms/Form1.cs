using SS.DB;
using SS.Forms;
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


namespace SS
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false; 
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Enter_Click(object sender, EventArgs e)
        {

            List<User> users = DB.DB.db.User.ToList();
            if (users.Find(a=>a.User_Name == textBoxLog.Text)!=null) //Проверка юзера
            {
                if (DB.DB.db.User.ToList().Find(d => d.User_Password == textBoxPass.Text) != null)//Проверка пароля
                {
                    User usersdsdsds = DB.DB.db.User.ToList().Find(d => d.User_Password == textBoxPass.Text);
                    switch (comboBox1.SelectedIndex + 1)
                    {
                        case 1:
                            if (usersdsdsds.User_Rols == 1)
                            {
                                AdminMenu A = new AdminMenu();
                                A.Show();
                                this.Hide();
                            }
                            break;
                            case 2:
                            if (usersdsdsds.User_Rols == 2)
                            {
                                TeacherMenu T = new TeacherMenu();
                                T.Show();
                                this.Hide();
                            }
                            break;
                        default:
                            GuestMenu G = new GuestMenu();
                            G.Show();
                            this.Hide();
                            break;
                    }                                        
                }
            }
        }
        private void butGuestEntrance_Click(object sender, EventArgs e)
        {
            GuestMenu G = new GuestMenu();
            G.Show();
            this.Hide();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       

        private void BMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
