namespace Prog.Forms
{
    partial class OutPut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutPut));
            this.buttonExp = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelgroup = new System.Windows.Forms.Label();
            this.labelLesson = new System.Windows.Forms.Label();
            this.textBoxLesson = new System.Windows.Forms.TextBox();
            this.labelKurs = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSemestr = new System.Windows.Forms.ComboBox();
            this.labelyear = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.comboBoxKurs = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExp
            // 
            this.buttonExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.buttonExp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExp.Location = new System.Drawing.Point(630, 171);
            this.buttonExp.Name = "buttonExp";
            this.buttonExp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonExp.Size = new System.Drawing.Size(100, 59);
            this.buttonExp.TabIndex = 0;
            this.buttonExp.Text = "Экспорт данных";
            this.buttonExp.UseVisualStyleBackColor = false;
            this.buttonExp.Click += new System.EventHandler(this.buttonExp_Click);
            // 
            // button_logout
            // 
            this.button_logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_logout.BackgroundImage")));
            this.button_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_logout.Location = new System.Drawing.Point(644, 238);
            this.button_logout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(86, 65);
            this.button_logout.TabIndex = 15;
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.BackColor = System.Drawing.Color.DarkGray;
            this.comboBoxGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(12, 32);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(133, 28);
            this.comboBoxGroup.TabIndex = 16;
            this.comboBoxGroup.SelectedIndexChanged += new System.EventHandler(this.comboBoxGroup_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(229, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(395, 291);
            this.dataGridView1.TabIndex = 17;
            // 
            // labelgroup
            // 
            this.labelgroup.AutoSize = true;
            this.labelgroup.Location = new System.Drawing.Point(8, 9);
            this.labelgroup.Name = "labelgroup";
            this.labelgroup.Size = new System.Drawing.Size(137, 20);
            this.labelgroup.TabIndex = 18;
            this.labelgroup.Text = "Выберите группу";
            // 
            // labelLesson
            // 
            this.labelLesson.AutoSize = true;
            this.labelLesson.Location = new System.Drawing.Point(8, 63);
            this.labelLesson.Name = "labelLesson";
            this.labelLesson.Size = new System.Drawing.Size(151, 20);
            this.labelLesson.TabIndex = 19;
            this.labelLesson.Text = "Введите предмет:";
            // 
            // textBoxLesson
            // 
            this.textBoxLesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.textBoxLesson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLesson.Location = new System.Drawing.Point(12, 86);
            this.textBoxLesson.Name = "textBoxLesson";
            this.textBoxLesson.Size = new System.Drawing.Size(211, 26);
            this.textBoxLesson.TabIndex = 20;
            // 
            // labelKurs
            // 
            this.labelKurs.AutoSize = true;
            this.labelKurs.Location = new System.Drawing.Point(8, 115);
            this.labelKurs.Name = "labelKurs";
            this.labelKurs.Size = new System.Drawing.Size(125, 20);
            this.labelKurs.TabIndex = 21;
            this.labelKurs.Text = "Выберите курс:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Выберите семестр:";
            // 
            // comboBoxSemestr
            // 
            this.comboBoxSemestr.BackColor = System.Drawing.Color.DarkGray;
            this.comboBoxSemestr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSemestr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
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
            this.comboBoxSemestr.Location = new System.Drawing.Point(12, 194);
            this.comboBoxSemestr.Name = "comboBoxSemestr";
            this.comboBoxSemestr.Size = new System.Drawing.Size(133, 28);
            this.comboBoxSemestr.TabIndex = 24;
            // 
            // labelyear
            // 
            this.labelyear.AutoSize = true;
            this.labelyear.Location = new System.Drawing.Point(626, 115);
            this.labelyear.Name = "labelyear";
            this.labelyear.Size = new System.Drawing.Size(111, 20);
            this.labelyear.TabIndex = 25;
            this.labelyear.Text = "Введите год:";
            // 
            // textBoxYear
            // 
            this.textBoxYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172)))));
            this.textBoxYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxYear.Location = new System.Drawing.Point(630, 138);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(100, 26);
            this.textBoxYear.TabIndex = 26;
            // 
            // comboBoxKurs
            // 
            this.comboBoxKurs.BackColor = System.Drawing.Color.DarkGray;
            this.comboBoxKurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKurs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxKurs.FormattingEnabled = true;
            this.comboBoxKurs.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxKurs.Location = new System.Drawing.Point(12, 136);
            this.comboBoxKurs.Name = "comboBoxKurs";
            this.comboBoxKurs.Size = new System.Drawing.Size(133, 28);
            this.comboBoxKurs.TabIndex = 27;
            // 
            // OutPut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(743, 311);
            this.Controls.Add(this.comboBoxKurs);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.labelyear);
            this.Controls.Add(this.comboBoxSemestr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelKurs);
            this.Controls.Add(this.textBoxLesson);
            this.Controls.Add(this.labelLesson);
            this.Controls.Add(this.labelgroup);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.buttonExp);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OutPut";
            this.Text = "VedGen";
            this.Load += new System.EventHandler(this.OutPut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExp;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelgroup;
        private System.Windows.Forms.Label labelLesson;
        private System.Windows.Forms.TextBox textBoxLesson;
        private System.Windows.Forms.Label labelKurs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSemestr;
        private System.Windows.Forms.Label labelyear;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.ComboBox comboBoxKurs;
    }
}