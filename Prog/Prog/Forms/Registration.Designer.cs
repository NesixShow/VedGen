namespace Prog.Forms
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.checkBox_pass = new System.Windows.Forms.CheckBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.label_reg = new System.Windows.Forms.Label();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.button_reg = new System.Windows.Forms.Button();
            this.button_logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // checkBox_pass
            // 
            this.checkBox_pass.AutoSize = true;
            this.checkBox_pass.Location = new System.Drawing.Point(16, 202);
            this.checkBox_pass.Name = "checkBox_pass";
            this.checkBox_pass.Size = new System.Drawing.Size(144, 24);
            this.checkBox_pass.TabIndex = 13;
            this.checkBox_pass.Text = "Скрыть пароль";
            this.checkBox_pass.UseVisualStyleBackColor = true;
            this.checkBox_pass.CheckedChanged += new System.EventHandler(this.checkBox_pass_CheckedChanged);
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(107, 89);
            this.textBox_pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(224, 26);
            this.textBox_pass.TabIndex = 12;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_password.Location = new System.Drawing.Point(12, 91);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(88, 24);
            this.label_password.TabIndex = 11;
            this.label_password.Text = "Пароль:";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.Location = new System.Drawing.Point(12, 53);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(75, 24);
            this.label_login.TabIndex = 10;
            this.label_login.Text = "Логин:";
            // 
            // label_reg
            // 
            this.label_reg.AutoSize = true;
            this.label_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_reg.Location = new System.Drawing.Point(81, 10);
            this.label_reg.Name = "label_reg";
            this.label_reg.Size = new System.Drawing.Size(175, 29);
            this.label_reg.TabIndex = 9;
            this.label_reg.Text = "Регистрация";
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(107, 53);
            this.textBox_log.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.Size = new System.Drawing.Size(224, 26);
            this.textBox_log.TabIndex = 8;
            // 
            // button_reg
            // 
            this.button_reg.BackColor = System.Drawing.Color.Silver;
            this.button_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_reg.Location = new System.Drawing.Point(14, 159);
            this.button_reg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_reg.Name = "button_reg";
            this.button_reg.Size = new System.Drawing.Size(202, 43);
            this.button_reg.TabIndex = 7;
            this.button_reg.Text = "Зарегистрироваться";
            this.button_reg.UseVisualStyleBackColor = false;
            this.button_reg.Click += new System.EventHandler(this.button_reg_Click);
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.LightGray;
            this.button_logout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_logout.BackgroundImage")));
            this.button_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_logout.Location = new System.Drawing.Point(238, 161);
            this.button_logout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(93, 41);
            this.button_logout.TabIndex = 14;
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Роль:";
            // 
            // textBoxRole
            // 
            this.textBoxRole.Location = new System.Drawing.Point(-329, 125);
            this.textBoxRole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.Size = new System.Drawing.Size(224, 26);
            this.textBoxRole.TabIndex = 16;
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(107, 123);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(224, 28);
            this.comboBoxRole.TabIndex = 17;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(345, 225);
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.textBoxRole);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_logout);
            this.Controls.Add(this.checkBox_pass);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label_reg);
            this.Controls.Add(this.textBox_log);
            this.Controls.Add(this.button_reg);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registration";
            this.Text = "VedGen";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_pass;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_reg;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.Button button_reg;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.ComboBox comboBoxRole;
    }
}