using Microsoft.Office.Interop.Excel;
using Prog.DataFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prog.Forms
{
    public partial class Group : Form
    {
        AutoVedEntities db = new AutoVedEntities();
        public Group()
        {
            InitializeComponent();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Hide();
            Authorization auth = new Authorization();
            auth.ShowDialog();
            this.Close();
        }

        private void Group_Load(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString =
            $"Server=(localdb)\\mssqllocaldb;Database=AutoVed;Trusted_Connection=True;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    //определяем выполняемую команду
                    command.CommandText = $"CREATE TABLE {textBox_namegr.Text} (Id INT PRIMARY KEY IDENTITY, FIO NVARCHAR(300) NOT NULL)";
                    //еделяем использованное подключение
                    command.Connection = connection;
                    //выполняем команду
                    command.ExecuteNonQuery();
                    MessageBox.Show("Таблица создана!!!");
                }
            }
            catch { MessageBox.Show("Возможно такая группа уже существует"); }
        }

        private void buttonAddStud_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_namegr.Text != "")
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        try
                        {
                            if (dataGridView1.Rows.Count > 1)
                            {
                                string connectionString =
                            $"Server=(localdb)\\mssqllocaldb;Database=AutoVed;Trusted_Connection=True;";
                                string sqlExpression = $"INSERT INTO {textBox_namegr.Text} (FIO) VALUES (N'{dataGridView1.Rows[i - 1].Cells[0].Value.ToString()}')";
                                using (SqlConnection connection = new SqlConnection(connectionString))
                                {
                                    connection.Open();
                                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                                    int number = command.ExecuteNonQuery();
                                    
                                }
                            }
                            else { MessageBox.Show("FIO can't been clear"); }
                        }
                        catch { }
                    }
                    MessageBox.Show($"Студенты добавлены");
                }
                else { MessageBox.Show("Введите название таблицы в поле в левом верхнем углу"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button_output_Click(object sender, EventArgs e)
        {
            Hide();
            OutPut outputForm = new OutPut();
            outputForm.ShowDialog();
            this.Close();
        }

    }
}
