using SS.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SS.Forms
{
    public partial class PlusClass : Form
    {
        AdminMenu mene;
        public PlusClass(AdminMenu menu)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.mene = menu;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void BPLCLASS_Click(object sender, EventArgs e)
        {
            Class CL = new Class();           
            int result = DB.DB.db.Class.ToList().Count;
            CL.ID_class= result + 1;
            CL.Number = textBox1.Text;
            CL.letter = textBox2.Text;
            mene.plClass(CL);
            this.Close();
        }

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

        
    }
}
