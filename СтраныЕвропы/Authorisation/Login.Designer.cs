namespace СтраныЕвропы
{
    partial class Login
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
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.linklb_Registration = new System.Windows.Forms.LinkLabel();
            this.lb_Password = new System.Windows.Forms.Label();
            this.lb_Login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(12, 30);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(101, 20);
            this.tb_Login.TabIndex = 1;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(12, 69);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(101, 20);
            this.tb_Password.TabIndex = 2;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(12, 95);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(101, 23);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Войти";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // linklb_Registration
            // 
            this.linklb_Registration.AutoSize = true;
            this.linklb_Registration.Location = new System.Drawing.Point(22, 121);
            this.linklb_Registration.Name = "linklb_Registration";
            this.linklb_Registration.Size = new System.Drawing.Size(75, 13);
            this.linklb_Registration.TabIndex = 4;
            this.linklb_Registration.TabStop = true;
            this.linklb_Registration.Text = "Нет аккаунта";
            this.linklb_Registration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklb_Registration_LinkClicked);
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Location = new System.Drawing.Point(12, 53);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(48, 13);
            this.lb_Password.TabIndex = 9;
            this.lb_Password.Text = "Пароль:";
            // 
            // lb_Login
            // 
            this.lb_Login.AutoSize = true;
            this.lb_Login.Location = new System.Drawing.Point(12, 11);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Size = new System.Drawing.Size(41, 13);
            this.lb_Login.TabIndex = 8;
            this.lb_Login.Text = "Логин:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(125, 150);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_Login);
            this.Controls.Add(this.linklb_Registration);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.LinkLabel linklb_Registration;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Label lb_Login;
    }
}