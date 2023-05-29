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
    public partial class ApplicationCard : UserControl
    {

        public AllFormApplication allFApp;
        public ApplicationCard(string status, string fIO, string appli, string sAppli)
        {
            InitializeComponent();
            if (status == "Teacher")
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                BApply.Visible = false;
                TB_FIO.Text = fIO;
                TBAppli.Text = appli;
                switch (sAppli)
                {
                    case "0":
                        break;
                    case "1":
                        checkBox1.Checked = true;
                        checkBox2.Enabled = false;
                        BApply.Visible = false;
                        break;
                    case "2":
                        checkBox2.Checked = true;
                        checkBox1.Enabled = false;
                        BApply.Visible = false;
                        break;
                }
            }
            else
            {
                TB_FIO.Text = fIO;
                TBAppli.Text = appli;
                switch (sAppli)
                {
                    case "0":                      
                        break;
                    case "1":
                        checkBox1.Checked = true;
                        checkBox2.Enabled = false;
                        BApply.Visible = false;
                        break;
                    case "2":
                        checkBox2.Checked = true;
                        checkBox1.Enabled = false;
                        BApply.Visible = false;
                        break;
                }
            }
        }

        private void BApply_Click(object sender, EventArgs e)
        {
            
            
                string fio = TB_FIO.Text;
                string application = TBAppli.Text;

                var applicationEntry = DB.DB.db.ApplicationTBs.FirstOrDefault(a => a.FIO_application == fio && a.application == application);
                if (applicationEntry != null)
                {
                if (checkBox1.Checked == true && checkBox2.Checked == false)
                {
                    applicationEntry.Status_application = "1";
                    checkBox1.Enabled = false;
                    checkBox2.Enabled = false;
                    BApply.Visible = false;
                }
                else if (checkBox2.Checked == true && checkBox1.Checked == false)
                {
                    applicationEntry.Status_application = "2";
                    checkBox1.Enabled = false;
                    checkBox2.Enabled = false;
                    BApply.Visible = false;
                }
                else
                {
                    MessageBox.Show("Что-то пошло не так. Проверьте выбран ли у вас 1 вариант " , "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                DB.DB.db.SaveChanges();
                }
            
        }
    }
}

