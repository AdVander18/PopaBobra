namespace СтраныЕвропы.Economy
{
    partial class AddEconomy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEconomy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_Department = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Product = new System.Windows.Forms.Label();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Surname = new System.Windows.Forms.TextBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.lb_TypeProduct = new System.Windows.Forms.Label();
            this.tb_Patronymic = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lb_Department);
            this.panel1.Location = new System.Drawing.Point(97, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 64);
            this.panel1.TabIndex = 46;
            // 
            // lb_Department
            // 
            this.lb_Department.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Department.Location = new System.Drawing.Point(2, 7);
            this.lb_Department.Name = "lb_Department";
            this.lb_Department.Size = new System.Drawing.Size(205, 48);
            this.lb_Department.TabIndex = 1;
            this.lb_Department.Text = "Добавление информации об экономике";
            this.lb_Department.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Валюта(3 буквы):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Валовой национальный продукт:";
            // 
            // lb_Product
            // 
            this.lb_Product.AutoSize = true;
            this.lb_Product.Location = new System.Drawing.Point(131, 123);
            this.lb_Product.Name = "lb_Product";
            this.lb_Product.Size = new System.Drawing.Size(69, 13);
            this.lb_Product.TabIndex = 43;
            this.lb_Product.Text = "Код страны:";
            // 
            // tb_Phone
            // 
            this.tb_Phone.Location = new System.Drawing.Point(206, 198);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(202, 20);
            this.tb_Phone.TabIndex = 42;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(206, 146);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(202, 20);
            this.tb_Name.TabIndex = 41;
            // 
            // tb_Surname
            // 
            this.tb_Surname.Location = new System.Drawing.Point(206, 120);
            this.tb_Surname.Name = "tb_Surname";
            this.tb_Surname.Size = new System.Drawing.Size(202, 20);
            this.tb_Surname.TabIndex = 40;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(249, 289);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(159, 101);
            this.btn_Save.TabIndex = 39;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lb_TypeProduct
            // 
            this.lb_TypeProduct.AutoSize = true;
            this.lb_TypeProduct.Location = new System.Drawing.Point(116, 175);
            this.lb_TypeProduct.Name = "lb_TypeProduct";
            this.lb_TypeProduct.Size = new System.Drawing.Size(84, 13);
            this.lb_TypeProduct.TabIndex = 49;
            this.lb_TypeProduct.Text = "Доход на душу:";
            // 
            // tb_Patronymic
            // 
            this.tb_Patronymic.Location = new System.Drawing.Point(206, 172);
            this.tb_Patronymic.Name = "tb_Patronymic";
            this.tb_Patronymic.Size = new System.Drawing.Size(202, 20);
            this.tb_Patronymic.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // AddEconomy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 403);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_Product);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Surname);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lb_TypeProduct);
            this.Controls.Add(this.tb_Patronymic);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEconomy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEconomy";
            this.Load += new System.EventHandler(this.AddEconomy_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Department;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Product;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Surname;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lb_TypeProduct;
        private System.Windows.Forms.TextBox tb_Patronymic;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}