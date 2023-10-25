using Prog.DataFile;
using Prog.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog
{
    public partial class Authorization : Form
    {
        AutoVedEntities db = new AutoVedEntities();

        public Authorization()
        {

            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            checkBox_pass.Checked = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_pass.Checked)
            {
            textBox_password.UseSystemPasswordChar = true;
            }
            else
            {
            textBox_password.UseSystemPasswordChar = false;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            foreach (var item in db.Account)
            {
                if (item.role == 2)
                {
                    if (item.login == textBox_log.Text && item.password == textBox_password.Text)
                    {
                        Hide();
                        Group g = new Group();
                        g.ShowDialog();
                        this.Close();
                        break;
                    }
                }
                else if(item.role == 1)
                {
                    if (item.login == textBox_log.Text && item.password == textBox_password.Text)
                    {
                        Hide();
                        OutPut wordF = new OutPut();
                        wordF.ShowDialog();
                        this.Close();
                        break;
                    }
                }

                else
                {
                    MessageBox.Show("Проверьте введённые данные");
                }
            }
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            
            Hide();
            Registration regform = new Registration();
            regform.ShowDialog();
            this.Close();
        }
    }
}

