﻿namespace СтраныЕвропы
{
    partial class Countries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Countries));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.lb_Department = new System.Windows.Forms.Label();
            this.pb_Search = new System.Windows.Forms.PictureBox();
            this.pb_Refresh = new System.Windows.Forms.PictureBox();
            this.pb_Clear = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_Map = new System.Windows.Forms.TextBox();
            this.lb_Map = new System.Windows.Forms.Label();
            this.lk_lb = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_E_mail = new System.Windows.Forms.Label();
            this.tb_Patronymic = new System.Windows.Forms.TextBox();
            this.lb_ProductType = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lb_Count = new System.Windows.Forms.Label();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.tb_Surname = new System.Windows.Forms.TextBox();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.lb_Phone = new System.Windows.Forms.Label();
            this.lb_Product = new System.Windows.Forms.Label();
            this.lb_Id = new System.Windows.Forms.Label();
            this.lb_Write = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Refresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Clear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 82);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tb_Search);
            this.tabPage1.Controls.Add(this.lb_Department);
            this.tabPage1.Controls.Add(this.pb_Search);
            this.tabPage1.Controls.Add(this.pb_Refresh);
            this.tabPage1.Controls.Add(this.pb_Clear);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 56);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Отдел 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(667, 18);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(116, 20);
            this.tb_Search.TabIndex = 8;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // lb_Department
            // 
            this.lb_Department.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Department.Location = new System.Drawing.Point(0, -4);
            this.lb_Department.Name = "lb_Department";
            this.lb_Department.Size = new System.Drawing.Size(118, 60);
            this.lb_Department.TabIndex = 1;
            this.lb_Department.Text = "Страны";
            this.lb_Department.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_Search
            // 
            this.pb_Search.Image = ((System.Drawing.Image)(resources.GetObject("pb_Search.Image")));
            this.pb_Search.Location = new System.Drawing.Point(625, 10);
            this.pb_Search.Name = "pb_Search";
            this.pb_Search.Size = new System.Drawing.Size(38, 36);
            this.pb_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Search.TabIndex = 7;
            this.pb_Search.TabStop = false;
            // 
            // pb_Refresh
            // 
            this.pb_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("pb_Refresh.Image")));
            this.pb_Refresh.Location = new System.Drawing.Point(581, 10);
            this.pb_Refresh.Name = "pb_Refresh";
            this.pb_Refresh.Size = new System.Drawing.Size(38, 36);
            this.pb_Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Refresh.TabIndex = 6;
            this.pb_Refresh.TabStop = false;
            this.pb_Refresh.Click += new System.EventHandler(this.pb_Refresh_Click);
            // 
            // pb_Clear
            // 
            this.pb_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Clear.Image = ((System.Drawing.Image)(resources.GetObject("pb_Clear.Image")));
            this.pb_Clear.Location = new System.Drawing.Point(537, 10);
            this.pb_Clear.Name = "pb_Clear";
            this.pb_Clear.Size = new System.Drawing.Size(38, 36);
            this.pb_Clear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Clear.TabIndex = 5;
            this.pb_Clear.TabStop = false;
            this.pb_Clear.Click += new System.EventHandler(this.pb_Clear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(796, 217);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tb_Map);
            this.panel1.Controls.Add(this.lb_Map);
            this.panel1.Controls.Add(this.lk_lb);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lb_E_mail);
            this.panel1.Controls.Add(this.tb_Patronymic);
            this.panel1.Controls.Add(this.lb_ProductType);
            this.panel1.Controls.Add(this.tb_Name);
            this.panel1.Controls.Add(this.lb_Count);
            this.panel1.Controls.Add(this.tb_Phone);
            this.panel1.Controls.Add(this.tb_Surname);
            this.panel1.Controls.Add(this.tb_Id);
            this.panel1.Controls.Add(this.lb_Phone);
            this.panel1.Controls.Add(this.lb_Product);
            this.panel1.Controls.Add(this.lb_Id);
            this.panel1.Controls.Add(this.lb_Write);
            this.panel1.Location = new System.Drawing.Point(13, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 235);
            this.panel1.TabIndex = 2;
            // 
            // tb_Map
            // 
            this.tb_Map.Location = new System.Drawing.Point(150, 180);
            this.tb_Map.Name = "tb_Map";
            this.tb_Map.Size = new System.Drawing.Size(100, 20);
            this.tb_Map.TabIndex = 31;
            // 
            // lb_Map
            // 
            this.lb_Map.AutoSize = true;
            this.lb_Map.Location = new System.Drawing.Point(49, 183);
            this.lb_Map.Name = "lb_Map";
            this.lb_Map.Size = new System.Drawing.Size(95, 13);
            this.lb_Map.TabIndex = 30;
            this.lb_Map.Text = "Ссылка на карту:";
            // 
            // lk_lb
            // 
            this.lk_lb.AutoSize = true;
            this.lk_lb.Location = new System.Drawing.Point(151, 209);
            this.lk_lb.Name = "lk_lb";
            this.lk_lb.Size = new System.Drawing.Size(46, 13);
            this.lk_lb.TabIndex = 29;
            this.lk_lb.TabStop = true;
            this.lk_lb.Text = "Ссылка";
            this.lk_lb.Visible = false;
            this.lk_lb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lk_lb_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // lb_E_mail
            // 
            this.lb_E_mail.AutoSize = true;
            this.lb_E_mail.Location = new System.Drawing.Point(104, 211);
            this.lb_E_mail.Name = "lb_E_mail";
            this.lb_E_mail.Size = new System.Drawing.Size(40, 13);
            this.lb_E_mail.TabIndex = 26;
            this.lb_E_mail.Text = "Карта:";
            // 
            // tb_Patronymic
            // 
            this.tb_Patronymic.Location = new System.Drawing.Point(150, 124);
            this.tb_Patronymic.Name = "tb_Patronymic";
            this.tb_Patronymic.Size = new System.Drawing.Size(100, 20);
            this.tb_Patronymic.TabIndex = 25;
            // 
            // lb_ProductType
            // 
            this.lb_ProductType.AutoSize = true;
            this.lb_ProductType.Location = new System.Drawing.Point(78, 127);
            this.lb_ProductType.Name = "lb_ProductType";
            this.lb_ProductType.Size = new System.Drawing.Size(66, 13);
            this.lb_ProductType.TabIndex = 24;
            this.lb_ProductType.Text = "Население:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(150, 98);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(100, 20);
            this.tb_Name.TabIndex = 23;
            // 
            // lb_Count
            // 
            this.lb_Count.AutoSize = true;
            this.lb_Count.Location = new System.Drawing.Point(92, 101);
            this.lb_Count.Name = "lb_Count";
            this.lb_Count.Size = new System.Drawing.Size(52, 13);
            this.lb_Count.TabIndex = 22;
            this.lb_Count.Text = "Столица:";
            // 
            // tb_Phone
            // 
            this.tb_Phone.Location = new System.Drawing.Point(150, 150);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(100, 20);
            this.tb_Phone.TabIndex = 21;
            // 
            // tb_Surname
            // 
            this.tb_Surname.Location = new System.Drawing.Point(150, 72);
            this.tb_Surname.Name = "tb_Surname";
            this.tb_Surname.Size = new System.Drawing.Size(100, 20);
            this.tb_Surname.TabIndex = 20;
            // 
            // tb_Id
            // 
            this.tb_Id.Location = new System.Drawing.Point(150, 46);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(100, 20);
            this.tb_Id.TabIndex = 19;
            // 
            // lb_Phone
            // 
            this.lb_Phone.AutoSize = true;
            this.lb_Phone.Location = new System.Drawing.Point(87, 153);
            this.lb_Phone.Name = "lb_Phone";
            this.lb_Phone.Size = new System.Drawing.Size(57, 13);
            this.lb_Phone.TabIndex = 18;
            this.lb_Phone.Text = "Площадь:";
            // 
            // lb_Product
            // 
            this.lb_Product.AutoSize = true;
            this.lb_Product.Location = new System.Drawing.Point(44, 75);
            this.lb_Product.Name = "lb_Product";
            this.lb_Product.Size = new System.Drawing.Size(100, 13);
            this.lb_Product.TabIndex = 17;
            this.lb_Product.Text = "Название страны:";
            // 
            // lb_Id
            // 
            this.lb_Id.AutoSize = true;
            this.lb_Id.Location = new System.Drawing.Point(123, 49);
            this.lb_Id.Name = "lb_Id";
            this.lb_Id.Size = new System.Drawing.Size(21, 13);
            this.lb_Id.TabIndex = 16;
            this.lb_Id.Text = "ID:";
            // 
            // lb_Write
            // 
            this.lb_Write.AutoSize = true;
            this.lb_Write.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Write.Location = new System.Drawing.Point(68, 9);
            this.lb_Write.Name = "lb_Write";
            this.lb_Write.Size = new System.Drawing.Size(65, 23);
            this.lb_Write.TabIndex = 1;
            this.lb_Write.Text = "Запись:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(650, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Управление записями";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Save);
            this.panel2.Controls.Add(this.btn_Edit);
            this.panel2.Controls.Add(this.btn_Delete);
            this.panel2.Controls.Add(this.btn_New);
            this.panel2.Location = new System.Drawing.Point(654, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 137);
            this.panel2.TabIndex = 28;
            // 
            // btn_Save
            // 
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Save.Location = new System.Drawing.Point(0, 69);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(141, 23);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Сохранить";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Edit.Location = new System.Drawing.Point(0, 46);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(141, 23);
            this.btn_Edit.TabIndex = 2;
            this.btn_Edit.Text = "Изменить";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Delete.Location = new System.Drawing.Point(0, 23);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(141, 23);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "Удалить";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_New
            // 
            this.btn_New.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_New.Location = new System.Drawing.Point(0, 0);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(141, 23);
            this.btn_New.TabIndex = 0;
            this.btn_New.Text = "Новая запись";
            this.btn_New.UseVisualStyleBackColor = true;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // Countries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Countries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Страны";
            this.Load += new System.EventHandler(this.Applications_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Refresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Clear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lb_Department;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.PictureBox pb_Search;
        private System.Windows.Forms.PictureBox pb_Refresh;
        private System.Windows.Forms.PictureBox pb_Clear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_Write;
        private System.Windows.Forms.Label lb_E_mail;
        private System.Windows.Forms.TextBox tb_Patronymic;
        private System.Windows.Forms.Label lb_ProductType;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lb_Count;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.TextBox tb_Surname;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.Label lb_Phone;
        private System.Windows.Forms.Label lb_Product;
        private System.Windows.Forms.Label lb_Id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lk_lb;
        private System.Windows.Forms.TextBox tb_Map;
        private System.Windows.Forms.Label lb_Map;
    }
}