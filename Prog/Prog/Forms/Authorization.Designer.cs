namespace Prog
{
    partial class Authorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.label_auth = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.checkBox_pass = new System.Windows.Forms.CheckBox();
            this.buttonReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.Color.Silver;
            this.buttonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogIn.Location = new System.Drawing.Point(14, 147);
            this.buttonLogIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(112, 35);
            this.buttonLogIn.TabIndex = 0;
            this.buttonLogIn.Text = "Войти";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBox_log
            // 
            this.textBox_log.Location = new System.Drawing.Point(108, 52);
            this.textBox_log.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.Size = new System.Drawing.Size(224, 26);
            this.textBox_log.TabIndex = 1;
            // 
            // label_auth
            // 
            this.label_auth.AutoSize = true;
            this.label_auth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_auth.Location = new System.Drawing.Point(82, 9);
            this.label_auth.Name = "label_auth";
            this.label_auth.Size = new System.Drawing.Size(177, 29);
            this.label_auth.TabIndex = 2;
            this.label_auth.Text = "Авторизация";
            this.label_auth.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_login.Location = new System.Drawing.Point(13, 52);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(75, 24);
            this.label_login.TabIndex = 3;
            this.label_login.Text = "Логин:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_password.Location = new System.Drawing.Point(13, 103);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(88, 24);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Пароль:";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(108, 101);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(224, 26);
            this.textBox_password.TabIndex = 5;
            // 
            // checkBox_pass
            // 
            this.checkBox_pass.AutoSize = true;
            this.checkBox_pass.Location = new System.Drawing.Point(12, 185);
            this.checkBox_pass.Name = "checkBox_pass";
            this.checkBox_pass.Size = new System.Drawing.Size(144, 24);
            this.checkBox_pass.TabIndex = 6;
            this.checkBox_pass.Text = "Скрыть пароль";
            this.checkBox_pass.UseVisualStyleBackColor = true;
            this.checkBox_pass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.Color.Silver;
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReg.Location = new System.Drawing.Point(134, 147);
            this.buttonReg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(198, 35);
            this.buttonReg.TabIndex = 7;
            this.buttonReg.Text = "Зарегистрироваться ";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(345, 206);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.checkBox_pass);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label_auth);
            this.Controls.Add(this.textBox_log);
            this.Controls.Add(this.buttonLogIn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authorization";
            this.Text = "VedGen";
            this.Load += new System.EventHandler(this.Auth_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.Label label_auth;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.CheckBox checkBox_pass;
        private System.Windows.Forms.Button buttonReg;
    }
}

