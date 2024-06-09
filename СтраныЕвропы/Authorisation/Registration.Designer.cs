namespace СтраныЕвропы
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
            this.tb_Login = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_Registration = new System.Windows.Forms.Button();
            this.linklb_Login = new System.Windows.Forms.LinkLabel();
            this.lb_Login = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.btn_AddPicture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Login
            // 
            this.tb_Login.Location = new System.Drawing.Point(12, 30);
            this.tb_Login.Name = "tb_Login";
            this.tb_Login.Size = new System.Drawing.Size(101, 20);
            this.tb_Login.TabIndex = 0;
            this.tb_Login.TextChanged += new System.EventHandler(this.tb_Login_TextChanged);
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(12, 69);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(101, 20);
            this.tb_Password.TabIndex = 3;
            // 
            // btn_Registration
            // 
            this.btn_Registration.Location = new System.Drawing.Point(12, 95);
            this.btn_Registration.Name = "btn_Registration";
            this.btn_Registration.Size = new System.Drawing.Size(101, 23);
            this.btn_Registration.TabIndex = 4;
            this.btn_Registration.Text = "Регистрация";
            this.btn_Registration.UseVisualStyleBackColor = true;
            this.btn_Registration.Click += new System.EventHandler(this.btn_Registration_Click);
            // 
            // linklb_Login
            // 
            this.linklb_Login.AutoSize = true;
            this.linklb_Login.Location = new System.Drawing.Point(13, 121);
            this.linklb_Login.Name = "linklb_Login";
            this.linklb_Login.Size = new System.Drawing.Size(98, 13);
            this.linklb_Login.TabIndex = 5;
            this.linklb_Login.TabStop = true;
            this.linklb_Login.Text = "Уже есть аккаунт";
            this.linklb_Login.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklb_Login_LinkClicked);
            // 
            // lb_Login
            // 
            this.lb_Login.AutoSize = true;
            this.lb_Login.Location = new System.Drawing.Point(12, 11);
            this.lb_Login.Name = "lb_Login";
            this.lb_Login.Size = new System.Drawing.Size(41, 13);
            this.lb_Login.TabIndex = 6;
            this.lb_Login.Text = "Логин:";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Location = new System.Drawing.Point(12, 53);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(48, 13);
            this.lb_Password.TabIndex = 7;
            this.lb_Password.Text = "Пароль:";
            // 
            // btn_AddPicture
            // 
            this.btn_AddPicture.Location = new System.Drawing.Point(12, 138);
            this.btn_AddPicture.Name = "btn_AddPicture";
            this.btn_AddPicture.Size = new System.Drawing.Size(101, 23);
            this.btn_AddPicture.TabIndex = 8;
            this.btn_AddPicture.Text = "Добавить фото";
            this.btn_AddPicture.UseVisualStyleBackColor = true;
            this.btn_AddPicture.Click += new System.EventHandler(this.btn_AddPicture_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(125, 185);
            this.Controls.Add(this.btn_AddPicture);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_Login);
            this.Controls.Add(this.linklb_Login);
            this.Controls.Add(this.btn_Registration);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Login;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Registration;
        private System.Windows.Forms.LinkLabel linklb_Login;
        private System.Windows.Forms.Label lb_Login;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.Button btn_AddPicture;
    }
}