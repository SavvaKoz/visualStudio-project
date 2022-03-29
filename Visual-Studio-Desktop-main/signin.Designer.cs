
namespace WindowsFormsApp1_Murygin
{
    partial class signin
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
            this.p_top = new System.Windows.Forms.Panel();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.l_login = new System.Windows.Forms.Label();
            this.btn_enter = new System.Windows.Forms.Button();
            this.l_password = new System.Windows.Forms.Label();
            this.cb_password = new System.Windows.Forms.CheckBox();
            this.l_captcha = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // p_top
            // 
            this.p_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(193)))), ((int)(((byte)(0)))));
            this.p_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_top.Location = new System.Drawing.Point(0, 0);
            this.p_top.Name = "p_top";
            this.p_top.Size = new System.Drawing.Size(784, 110);
            this.p_top.TabIndex = 0;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_password.Location = new System.Drawing.Point(333, 265);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(180, 37);
            this.tb_password.TabIndex = 1;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // tb_login
            // 
            this.tb_login.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_login.Location = new System.Drawing.Point(333, 182);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(180, 37);
            this.tb_login.TabIndex = 2;
            // 
            // l_login
            // 
            this.l_login.AutoSize = true;
            this.l_login.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_login.Location = new System.Drawing.Point(245, 190);
            this.l_login.Name = "l_login";
            this.l_login.Size = new System.Drawing.Size(82, 29);
            this.l_login.TabIndex = 3;
            this.l_login.Text = "Логин:";
            // 
            // btn_enter
            // 
            this.btn_enter.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_enter.Location = new System.Drawing.Point(384, 348);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(84, 37);
            this.btn_enter.TabIndex = 4;
            this.btn_enter.Text = "Войти";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // l_password
            // 
            this.l_password.AutoSize = true;
            this.l_password.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_password.Location = new System.Drawing.Point(231, 268);
            this.l_password.Name = "l_password";
            this.l_password.Size = new System.Drawing.Size(96, 29);
            this.l_password.TabIndex = 5;
            this.l_password.Text = "Пароль:";
            // 
            // cb_password
            // 
            this.cb_password.AutoSize = true;
            this.cb_password.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_password.Location = new System.Drawing.Point(519, 275);
            this.cb_password.Name = "cb_password";
            this.cb_password.Size = new System.Drawing.Size(159, 27);
            this.cb_password.TabIndex = 6;
            this.cb_password.Text = "Показать пароль";
            this.cb_password.UseVisualStyleBackColor = true;
            this.cb_password.CheckedChanged += new System.EventHandler(this.cb_password_CheckedChanged);
            // 
            // l_captcha
            // 
            this.l_captcha.AutoSize = true;
            this.l_captcha.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_captcha.Location = new System.Drawing.Point(485, 310);
            this.l_captcha.Name = "l_captcha";
            this.l_captcha.Size = new System.Drawing.Size(134, 26);
            this.l_captcha.TabIndex = 7;
            this.l_captcha.Text = "l_captchatext";
            this.l_captcha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(368, 316);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(784, 565);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.l_captcha);
            this.Controls.Add(this.cb_password);
            this.Controls.Add(this.l_password);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.l_login);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.p_top);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "signin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма авторизации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel p_top;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Label l_login;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Label l_password;
        private System.Windows.Forms.CheckBox cb_password;
        private System.Windows.Forms.Label l_captcha;
        private System.Windows.Forms.TextBox textBox1;
    }
}

