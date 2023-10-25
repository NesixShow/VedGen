namespace Prog.Forms
{
    partial class WordOutPut
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordOutPut));
            this.label_comboBox = new System.Windows.Forms.Label();
            this.comboBox_Group = new System.Windows.Forms.ComboBox();
            this.button_logout = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.buttonExp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLesson = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxKurs = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSemestr = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_comboBox
            // 
            this.label_comboBox.AutoSize = true;
            this.label_comboBox.Location = new System.Drawing.Point(8, 9);
            this.label_comboBox.Name = "label_comboBox";
            this.label_comboBox.Size = new System.Drawing.Size(137, 20);
            this.label_comboBox.TabIndex = 0;
            this.label_comboBox.Text = "Выберите группу";
            // 
            // comboBox_Group
            // 
            this.comboBox_Group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Group.FormattingEnabled = true;
            this.comboBox_Group.Location = new System.Drawing.Point(12, 32);
            this.comboBox_Group.Name = "comboBox_Group";
            this.comboBox_Group.Size = new System.Drawing.Size(156, 28);
            this.comboBox_Group.TabIndex = 1;
            // 
            // button_logout
            // 
            this.button_logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_logout.BackgroundImage")));
            this.button_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_logout.Location = new System.Drawing.Point(593, 225);
            this.button_logout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(118, 65);
            this.button_logout.TabIndex = 16;
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(235, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 281);
            this.dataGridView1.TabIndex = 17;
            // 
            // textBoxYear
            // 
            this.textBoxYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.textBoxYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxYear.Location = new System.Drawing.Point(592, 120);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(119, 26);
            this.textBoxYear.TabIndex = 18;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(592, 97);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(111, 20);
            this.labelYear.TabIndex = 19;
            this.labelYear.Text = "Введите год:";
            // 
            // buttonExp
            // 
            this.buttonExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.buttonExp.FlatAppearance.BorderSize = 0;
            this.buttonExp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExp.Location = new System.Drawing.Point(592, 153);
            this.buttonExp.Name = "buttonExp";
            this.buttonExp.Size = new System.Drawing.Size(119, 64);
            this.buttonExp.TabIndex = 20;
            this.buttonExp.Text = "Экспорт данных";
            this.buttonExp.UseVisualStyleBackColor = false;
            this.buttonExp.Click += new System.EventHandler(this.buttonExp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Введите предмет:";
            // 
            // textBoxLesson
            // 
            this.textBoxLesson.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxLesson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLesson.Location = new System.Drawing.Point(12, 86);
            this.textBoxLesson.Name = "textBoxLesson";
            this.textBoxLesson.Size = new System.Drawing.Size(217, 26);
            this.textBoxLesson.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Выберите курс:";
            // 
            // comboBoxKurs
            // 
            this.comboBoxKurs.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxKurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKurs.FormattingEnabled = true;
            this.comboBoxKurs.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxKurs.Location = new System.Drawing.Point(12, 138);
            this.comboBoxKurs.Name = "comboBoxKurs";
            this.comboBoxKurs.Size = new System.Drawing.Size(156, 28);
            this.comboBoxKurs.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Выберите семестр:";
            // 
            // comboBoxSemestr
            // 
            this.comboBoxSemestr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSemestr.FormattingEnabled = true;
            this.comboBoxSemestr.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxSemestr.Location = new System.Drawing.Point(12, 192);
            this.comboBoxSemestr.Name = "comboBoxSemestr";
            this.comboBoxSemestr.Size = new System.Drawing.Size(156, 28);
            this.comboBoxSemestr.TabIndex = 26;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(724, 299);
            this.Controls.Add(this.comboBoxSemestr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxKurs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLesson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonExp);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.comboBox_Group);
            this.Controls.Add(this.label_comboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Word";
            this.Text = "VedGen";
            this.Load += new System.EventHandler(this.Word_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_comboBox;
        private System.Windows.Forms.ComboBox comboBox_Group;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Button buttonExp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLesson;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxKurs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSemestr;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}