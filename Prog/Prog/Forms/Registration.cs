using Prog.DataFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog.Forms
{
    public partial class Registration : Form
    {
        AutoVedEntities db = new AutoVedEntities();
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            checkBox_pass.Checked = true;
            foreach (var item in db.Role)
            {
                comboBoxRole.Items.Add(item.RoleName);
            }
        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            try
            {
                db.Account.Add(new Account()
                {
                    login = textBox_log.Text,
                    password = textBox_pass.Text,
                    role = db.Role.Where(x => x.RoleName == comboBoxRole.Text).First().Id,
                });
                db.SaveChanges();
                MessageBox.Show("Пользователь добавлен!");
            }
            catch
            {
                MessageBox.Show("Перепроверьте поля, либо пользователь уже существует!!");
            }
        }

        private void checkBox_pass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_pass.Checked)
            {
                textBox_pass.UseSystemPasswordChar = true;
            }
            else
            {
                textBox_pass.UseSystemPasswordChar = false;

            }
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Hide();
            Authorization auth = new Authorization();
            auth.ShowDialog();
            this.Close();
            
        }
    }
}
