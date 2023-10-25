namespace Prog.Forms
{
    partial class Group
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Group));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddGr = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.textBox_namegr = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddStud = new System.Windows.Forms.Button();
            this.button_output = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите группу";
            // 
            // buttonAddGr
            // 
            this.buttonAddGr.BackColor = System.Drawing.Color.Silver;
            this.buttonAddGr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddGr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAddGr.Location = new System.Drawing.Point(17, 64);
            this.buttonAddGr.Name = "buttonAddGr";
            this.buttonAddGr.Size = new System.Drawing.Size(121, 58);
            this.buttonAddGr.TabIndex = 4;
            this.buttonAddGr.Text = "Добавить группу";
            this.buttonAddGr.UseVisualStyleBackColor = false;
            this.buttonAddGr.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_logout
            // 
            this.button_logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_logout.BackgroundImage")));
            this.button_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_logout.Location = new System.Drawing.Point(594, 235);
            this.button_logout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(86, 65);
            this.button_logout.TabIndex = 15;
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // textBox_namegr
            // 
            this.textBox_namegr.Location = new System.Drawing.Point(17, 32);
            this.textBox_namegr.Name = "textBox_namegr";
            this.textBox_namegr.Size = new System.Drawing.Size(121, 26);
            this.textBox_namegr.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FIO});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(148, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(415, 291);
            this.dataGridView1.TabIndex = 17;
            // 
            // FIO
            // 
            this.FIO.HeaderText = "ФИО";
            this.FIO.Name = "FIO";
            this.FIO.Width = 370;
            // 
            // buttonAddStud
            // 
            this.buttonAddStud.BackColor = System.Drawing.Color.Silver;
            this.buttonAddStud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonAddStud.Location = new System.Drawing.Point(569, 12);
            this.buttonAddStud.Name = "buttonAddStud";
            this.buttonAddStud.Size = new System.Drawing.Size(111, 75);
            this.buttonAddStud.TabIndex = 18;
            this.buttonAddStud.Text = "Добавить студентов";
            this.buttonAddStud.UseVisualStyleBackColor = false;
            this.buttonAddStud.Click += new System.EventHandler(this.buttonAddStud_Click);
            // 
            // button_output
            // 
            this.button_output.BackColor = System.Drawing.Color.Silver;
            this.button_output.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_output.Location = new System.Drawing.Point(17, 220);
            this.button_output.Name = "button_output";
            this.button_output.Size = new System.Drawing.Size(121, 75);
            this.button_output.TabIndex = 19;
            this.button_output.Text = "Вывести данные";
            this.button_output.UseVisualStyleBackColor = false;
            this.button_output.Click += new System.EventHandler(this.button_output_Click);
            // 
            // Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(689, 307);
            this.Controls.Add(this.button_output);
            this.Controls.Add(this.buttonAddStud);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_namegr);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.buttonAddGr);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Group";
            this.Text = "VedGen";
            this.Load += new System.EventHandler(this.Group_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddGr;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.TextBox textBox_namegr;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.Button buttonAddStud;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_output;
    }
}