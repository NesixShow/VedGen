using Prog.DataFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;

namespace Prog.Forms
{
    public partial class Word : Form
    {
        AutoVedEntities db = new AutoVedEntities();
        SqlConnection con = new SqlConnection($"Server=(localdb)\\mssqllocaldb;Database=AutoVed;Trusted_Connection=True;");

        public Word()
        {
            InitializeComponent();

        }

        private void Word_Load(object sender, EventArgs e)
        {
            db.sp_upgraddiagrams();
            comboBoxKurs.SelectedIndex = 0;
            comboBoxSemestr.SelectedIndex = 0;
            try
            {

                con.Open();
                System.Data.DataTable schemaTable = con.GetSchema("Tables");
                foreach (System.Data.DataRow row in schemaTable.Rows)
                {
                    comboBox_Group.Items.Add(row["TABLE_NAME"].ToString());
                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Hide();
            Authorization auth = new Authorization();
            auth.ShowDialog();
            this.Close();
        }

        private void buttonExp_Click(object sender, EventArgs e)
        {
            if (textBoxYear.Text != "" && textBoxLesson.Text != "")
            {
                // ISSUE: variable of a compiler-generated type
                Microsoft.Office.Interop.Word.Application instance = (Microsoft.Office.Interop.Word.Application)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("000209FF-0000-0000-C000-000000000046")));
                // ISSUE: variable of a compiler-generated type
                Documents documents = instance.Documents;
                object missing1 = Type.Missing;
                ref object local1 = ref missing1;
                object missing2 = Type.Missing;
                ref object local2 = ref missing2;
                object missing3 = Type.Missing;
                ref object local3 = ref missing3;
                object missing4 = Type.Missing;
                ref object local4 = ref missing4;
                // ISSUE: reference to a compiler-generated method
                // ISSUE: variable of a compiler-generated type
                Document document = documents.Add(ref local1, ref local2, ref local3, ref local4);
                // ISSUE: variable of a compiler-generated type
                Paragraphs paragraphs1 = document.Content.Paragraphs;
                object missing5 = Type.Missing;
                ref object local5 = ref missing5;
                // ISSUE: reference to a compiler-generated method
                // ISSUE: variable of a compiler-generated type
                Paragraph paragraph1 = paragraphs1.Add(ref local5);
                paragraph1.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                paragraph1.Range.Text = "Министерство образования и науки Алтайского края";
                paragraph1.Range.Font.Name = "Times New Roman";
                paragraph1.Range.Font.Size = 12f;
                paragraph1.Range.Font.Bold = 0;
                paragraph1.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                // ISSUE: reference to a compiler-generated method
                paragraph1.Range.InsertParagraphAfter();
                // ISSUE: variable of a compiler-generated type
                Paragraphs paragraphs2 = document.Content.Paragraphs;
                object missing6 = Type.Missing;
                ref object local6 = ref missing6;
                // ISSUE: reference to a compiler-generated method
                // ISSUE: variable of a compiler-generated type
                Paragraph paragraph2 = paragraphs2.Add(ref local6);
                paragraph2.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                paragraph2.Range.Text = "КГБПОУ «Алтайская академия гостеприимства»";
                paragraph2.Range.Font.Name = "Times New Roman";
                paragraph2.Range.Font.Size = 12f;
                paragraph2.Range.Font.Bold = 0;
                paragraph2.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                // ISSUE: reference to a compiler-generated method
                paragraph2.Range.InsertParagraphAfter();
                // ISSUE: variable of a compiler-generated type
                Paragraphs paragraphs3 = document.Content.Paragraphs;
                object missing7 = Type.Missing;
                ref object local7 = ref missing7;
                // ISSUE: reference to a compiler-generated method
                // ISSUE: variable of a compiler-generated type
                Paragraph paragraph3 = paragraphs3.Add(ref local7);
                paragraph3.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                paragraph3.Range.Text = "";
                paragraph3.Range.Font.Name = "Times New Roman";
                paragraph3.Range.Font.Size = 12f;
                paragraph3.Range.Font.Bold = 0;
                paragraph3.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                // ISSUE: reference to a compiler-generated method
                paragraph3.Range.InsertParagraphAfter();
                // ISSUE: variable of a compiler-generated type
                Paragraphs paragraphs4 = document.Content.Paragraphs;
                object missing8 = Type.Missing;
                ref object local8 = ref missing8;
                // ISSUE: reference to a compiler-generated method
                // ISSUE: variable of a compiler-generated type
                Paragraph paragraph4 = paragraphs4.Add(ref local8);
                paragraph4.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                paragraph4.Range.Text = "ЭКЗАМЕНАЦИОННАЯ ВЕДОМОСТЬ";
                paragraph4.Range.Font.Name = "Times New Roman";
                paragraph4.Range.Font.Size = 14f;
                paragraph4.Range.Font.Bold = 0;
                paragraph4.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                // ISSUE: reference to a compiler-generated method
                paragraph4.Range.InsertParagraphAfter();
                paragraph4.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                paragraph4.Range.Font.Name = "Times New Roman";
                paragraph4.Range.Font.Size = 14f;
                paragraph4.Range.Font.Bold = 0;
                // ISSUE: reference to a compiler-generated method
                paragraph4.Range.InsertParagraphAfter();
                // ISSUE: variable of a compiler-generated type
                Paragraphs paragraphs5 = document.Content.Paragraphs;
                object missing9 = Type.Missing;
                ref object local9 = ref missing9;
                // ISSUE: reference to a compiler-generated method
                // ISSUE: variable of a compiler-generated type
                Paragraph paragraph5 = paragraphs5.Add(ref local9);
                paragraph5.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                paragraph5.Range.Text = "По Дисциплине: " + this.textBoxLesson.Text;
                paragraph5.Range.Font.Name = "Times New Roman";
                paragraph5.Range.Font.Size = 12f;
                paragraph5.Range.Font.Bold = 0;
                paragraph5.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                // ISSUE: reference to a compiler-generated method
                paragraph5.Range.InsertParagraphAfter();
                // ISSUE: variable of a compiler-generated type
                Paragraphs paragraphs6 = document.Content.Paragraphs;
                object missing10 = Type.Missing;
                ref object local10 = ref missing10;
                // ISSUE: reference to a compiler-generated method
                // ISSUE: variable of a compiler-generated type
                Paragraph paragraph6 = paragraphs6.Add(ref local10);
                paragraph6.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                paragraph6.Range.Text = "Специальность/Профессия 09.02.07 Информационные системы и программирование " + 
                    "\nФорма обучения очная \nГруппа " + this.comboBox_Group.Text + " Курс " 
                    + this.comboBoxKurs.Text + " семестр " + this.comboBoxSemestr.Text + " \n ";
                paragraph6.Range.Font.Name = "Times New Roman";
                paragraph6.Range.Font.Size = 12f;
                paragraph6.Range.Font.Bold = 0;
                paragraph6.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                // ISSUE: reference to a compiler-generated method
                paragraph6.Range.InsertParagraphAfter();
                int rowCount = this.dataGridView1.RowCount;
                int columnCount = this.dataGridView1.ColumnCount;
                if (rowCount == 0)
                    return;
                // ISSUE: variable of a compiler-generated type
                Tables tables = document.Tables;
                // ISSUE: variable of a compiler-generated type
                Microsoft.Office.Interop.Word.Range range = paragraph4.Range;
                int NumColumns = columnCount + 4;
                object missing11 = Type.Missing;
                ref object local11 = ref missing11;
                object missing12 = Type.Missing;
                ref object local12 = ref missing12;
                // ISSUE: reference to a compiler-generated method
                // ISSUE: variable of a compiler-generated type
                Table table = tables.Add(range, 1, NumColumns, ref local11, ref local12);
                table.Rows[1].Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                int num1 = 1;
                int num2 = 2;
                while (num2 <= rowCount + 1)
                {
                    // ISSUE: variable of a compiler-generated type
                    Rows rows = table.Rows;
                    object missing13 = Type.Missing;
                    ref object local13 = ref missing13;
                    // ISSUE: reference to a compiler-generated method
                    rows.Add(ref local13);
                    // ISSUE: reference to a compiler-generated method
                    table.Cell(num2, 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                    table.Rows[num2].Cells[1].Range.Text = num1.ToString();
                    for (int Index = 2; Index <= columnCount + 1; ++Index)
                        table.Rows[num2].Cells[Index].Range.Text = this.dataGridView1.Rows[num2 - 2].Cells[Index - 2].Value.ToString();
                    ++num2;
                    ++num1;
                }
                table.Columns[1].Width = 30f;
                table.Columns[2].Width = 210f;
                table.Columns[3].Width = 70f;
                table.Columns[4].Width = 80f;
                table.Borders.Enable = 1;
                table.Rows[1].Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
                table.Rows[1].Cells[1].Range.Text = "№ П/П";
                table.Rows[1].Cells[2].Range.Text = "Фамилия Имя Отчество";
                table.Rows[1].Cells[3].Range.Text = "Номер билета";
                table.Rows[1].Cells[4].Range.Text = "Оценка";
                table.Rows[1].Cells[5].Range.Text = "Подпись преподавателя";
                table.Rows[1].Range.Font.Bold = 1;
                // ISSUE: variable of a compiler-generated type
                Paragraphs paragraphs7 = document.Content.Paragraphs;
                object missing14 = Type.Missing;
                ref object local14 = ref missing14;
                // ISSUE: reference to a compiler-generated method
                // ISSUE: variable of a compiler-generated type
                Paragraph paragraph7 = paragraphs7.Add(ref local14);
                paragraph7.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                paragraph7.Range.Text = "Дата «    »                 " + this.textBoxYear.Text + " г.";
                paragraph7.Range.Font.Name = "Times New Roman";
                paragraph7.Range.Font.Size = 12f;
                paragraph7.Range.Font.Bold = 0;
                paragraph7.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                // ISSUE: reference to a compiler-generated method
                paragraph7.Range.InsertParagraphAfter();
                // ISSUE: variable of a compiler-generated type
                Paragraphs paragraphs8 = document.Content.Paragraphs;
                object obj1 = Type.Missing;
                ref object local15 = ref obj1;
                // ISSUE: reference to a compiler-generated method
                // ISSUE: variable of a compiler-generated type
                Paragraph paragraph8 = paragraphs8.Add(ref local15);
                paragraph8.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                paragraph8.Range.Text = "Количество «5»        «4»        «3»        «2»        «неявок»        ";
                paragraph8.Range.Font.Name = "Times New Roman";
                paragraph8.Range.Font.Size = 12f;
                paragraph8.Range.Font.Bold = 0;
                paragraph8.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                // ISSUE: reference to a compiler-generated method
                paragraph8.Range.InsertParagraphAfter();
                // ISSUE: variable of a compiler-generated type
                Paragraphs paragraphs9 = document.Content.Paragraphs;
                obj1 = Type.Missing;
                ref object local16 = ref obj1;
                // ISSUE: reference to a compiler-generated method
                // ISSUE: variable of a compiler-generated type
                Paragraph paragraph9 = paragraphs9.Add(ref local16);
                paragraph9.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                paragraph9.Range.Text = "Подпись преподавателя                                                  ";
                paragraph9.Range.Font.Name = "Times New Roman";
                paragraph9.Range.Font.Size = 12f;
                paragraph9.Range.Font.Bold = 0;
                paragraph9.Alignment = WdParagraphAlignment.wdAlignParagraphLeft;
                // ISSUE: reference to a compiler-generated method
                paragraph9.Range.InsertParagraphAfter();
                instance.Visible = true;
                this.saveFileDialog1.FileName = "Export";
                this.saveFileDialog1.InitialDirectory = "D:\\";
                this.saveFileDialog1.Filter = "Microsoft Word | *.docx";
                this.saveFileDialog1.DefaultExt = "docx";
                if (this.saveFileDialog1.ShowDialog() != DialogResult.OK)
                    return;
                string fileName = this.saveFileDialog1.FileName;
                this.textBoxYear.Text = fileName;
                // ISSUE: variable of a compiler-generated type
                Document activeDocument = instance.Application.ActiveDocument;
                obj1 = (object)fileName;
                ref object local17 = ref obj1;
                object missing15 = Type.Missing;
                ref object local18 = ref missing15;
                object missing16 = Type.Missing;
                ref object local19 = ref missing16;
                object missing17 = Type.Missing;
                ref object local20 = ref missing17;
                object missing18 = Type.Missing;
                ref object local21 = ref missing18;
                object missing19 = Type.Missing;
                ref object local22 = ref missing19;
                object obj2 = (object)XlSaveAsAccessMode.xlNoChange;
                ref object local23 = ref obj2;
                object missing20 = Type.Missing;
                ref object local24 = ref missing20;
                object missing21 = Type.Missing;
                ref object local25 = ref missing21;
                object missing22 = Type.Missing;
                ref object local26 = ref missing22;
                object missing23 = Type.Missing;
                ref object local27 = ref missing23;
                object missing24 = Type.Missing;
                ref object local28 = ref missing24;
                object missing25 = Type.Missing;
                ref object local29 = ref missing25;
                object missing26 = Type.Missing;
                ref object local30 = ref missing26;
                object missing27 = Type.Missing;
                ref object local31 = ref missing27;
                object missing28 = Type.Missing;
                ref object local32 = ref missing28;
                // ISSUE: reference to a compiler-generated method
                activeDocument.SaveAs(ref local17, ref local18, ref local19, ref local20, ref local21, ref local22, ref local23, ref local24, ref local25, ref local26, ref local27, ref local28, ref local29, ref local30, ref local31, ref local32);
                // ISSUE: variable of a compiler-generated type
                Microsoft.Office.Interop.Word.Application application = instance;
                object missing29 = Type.Missing;
                ref object local33 = ref missing29;
                missing27 = Type.Missing;
                ref object local34 = ref missing27;
                object missing30 = Type.Missing;
                ref object local35 = ref missing30;
                // ISSUE: reference to a compiler-generated method
                application.Quit(ref local33, ref local34, ref local35);
                Marshal.ReleaseComObject((object)instance);
            }
        }
    }
}
