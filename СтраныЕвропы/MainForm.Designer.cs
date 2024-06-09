namespace СтраныЕвропы
{
    partial class MainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Countries = new System.Windows.Forms.Button();
            this.btn_Events = new System.Windows.Forms.Button();
            this.btn_Economy = new System.Windows.Forms.Button();
            this.btn_EventsInCountries = new System.Windows.Forms.Button();
            this.btn_EconomyInCountries = new System.Windows.Forms.Button();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.btn_EventsIn10Years = new System.Windows.Forms.Button();
            this.btn_CurrencyEurDkk = new System.Windows.Forms.Button();
            this.btn_Profit = new System.Windows.Forms.Button();
            this.btn_NobEvents = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Countries
            // 
            this.btn_Countries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Countries.Location = new System.Drawing.Point(139, 13);
            this.btn_Countries.Name = "btn_Countries";
            this.btn_Countries.Size = new System.Drawing.Size(649, 91);
            this.btn_Countries.TabIndex = 1;
            this.btn_Countries.Text = "Страны";
            this.btn_Countries.UseVisualStyleBackColor = true;
            this.btn_Countries.Click += new System.EventHandler(this.btn_Countries_Click);
            // 
            // btn_Events
            // 
            this.btn_Events.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Events.Location = new System.Drawing.Point(13, 110);
            this.btn_Events.Name = "btn_Events";
            this.btn_Events.Size = new System.Drawing.Size(775, 91);
            this.btn_Events.TabIndex = 2;
            this.btn_Events.Text = "События";
            this.btn_Events.UseVisualStyleBackColor = true;
            this.btn_Events.Click += new System.EventHandler(this.btn_Events_Click);
            // 
            // btn_Economy
            // 
            this.btn_Economy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Economy.Location = new System.Drawing.Point(13, 206);
            this.btn_Economy.Name = "btn_Economy";
            this.btn_Economy.Size = new System.Drawing.Size(775, 91);
            this.btn_Economy.TabIndex = 3;
            this.btn_Economy.Text = "Экономика";
            this.btn_Economy.UseVisualStyleBackColor = true;
            this.btn_Economy.Click += new System.EventHandler(this.btn_Economy_Click);
            // 
            // btn_EventsInCountries
            // 
            this.btn_EventsInCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_EventsInCountries.Location = new System.Drawing.Point(13, 303);
            this.btn_EventsInCountries.Name = "btn_EventsInCountries";
            this.btn_EventsInCountries.Size = new System.Drawing.Size(775, 91);
            this.btn_EventsInCountries.TabIndex = 4;
            this.btn_EventsInCountries.Text = "События в странах";
            this.btn_EventsInCountries.UseVisualStyleBackColor = true;
            this.btn_EventsInCountries.Click += new System.EventHandler(this.btn_EventsInCountries_Click);
            // 
            // btn_EconomyInCountries
            // 
            this.btn_EconomyInCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_EconomyInCountries.Location = new System.Drawing.Point(13, 400);
            this.btn_EconomyInCountries.Name = "btn_EconomyInCountries";
            this.btn_EconomyInCountries.Size = new System.Drawing.Size(775, 91);
            this.btn_EconomyInCountries.TabIndex = 5;
            this.btn_EconomyInCountries.Text = "Экономика в странах";
            this.btn_EconomyInCountries.UseVisualStyleBackColor = true;
            this.btn_EconomyInCountries.Click += new System.EventHandler(this.btn_EconomyInCountries_Click);
            // 
            // btn_Admin
            // 
            this.btn_Admin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Admin.Location = new System.Drawing.Point(0, 876);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(788, 23);
            this.btn_Admin.TabIndex = 6;
            this.btn_Admin.Text = "Управление";
            this.btn_Admin.UseVisualStyleBackColor = true;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // btn_EventsIn10Years
            // 
            this.btn_EventsIn10Years.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_EventsIn10Years.Location = new System.Drawing.Point(13, 497);
            this.btn_EventsIn10Years.Name = "btn_EventsIn10Years";
            this.btn_EventsIn10Years.Size = new System.Drawing.Size(775, 91);
            this.btn_EventsIn10Years.TabIndex = 7;
            this.btn_EventsIn10Years.Text = "Исторические события, произошедшие в Европе за последние 10 лет";
            this.btn_EventsIn10Years.UseVisualStyleBackColor = true;
            this.btn_EventsIn10Years.Click += new System.EventHandler(this.btn_EventsIn10Years_Click);
            // 
            // btn_CurrencyEurDkk
            // 
            this.btn_CurrencyEurDkk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_CurrencyEurDkk.Location = new System.Drawing.Point(13, 594);
            this.btn_CurrencyEurDkk.Name = "btn_CurrencyEurDkk";
            this.btn_CurrencyEurDkk.Size = new System.Drawing.Size(775, 91);
            this.btn_CurrencyEurDkk.TabIndex = 8;
            this.btn_CurrencyEurDkk.Text = "Валюты  «EUR» или «DKK»";
            this.btn_CurrencyEurDkk.UseVisualStyleBackColor = true;
            this.btn_CurrencyEurDkk.Click += new System.EventHandler(this.btn_CurrencyEurDkk_Click);
            // 
            // btn_Profit
            // 
            this.btn_Profit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Profit.Location = new System.Drawing.Point(13, 688);
            this.btn_Profit.Name = "btn_Profit";
            this.btn_Profit.Size = new System.Drawing.Size(775, 91);
            this.btn_Profit.TabIndex = 9;
            this.btn_Profit.Text = "Вычисление процента дохода на душу населения к валовому национальному продукту";
            this.btn_Profit.UseVisualStyleBackColor = true;
            this.btn_Profit.Click += new System.EventHandler(this.btn_Profit_Click);
            // 
            // btn_NobEvents
            // 
            this.btn_NobEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_NobEvents.Location = new System.Drawing.Point(13, 785);
            this.btn_NobEvents.Name = "btn_NobEvents";
            this.btn_NobEvents.Size = new System.Drawing.Size(775, 91);
            this.btn_NobEvents.TabIndex = 10;
            this.btn_NobEvents.Text = "Нет ни одного исторического события";
            this.btn_NobEvents.UseVisualStyleBackColor = true;
            this.btn_NobEvents.Click += new System.EventHandler(this.btn_NobEvents_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btn_NobEvents);
            this.Controls.Add(this.btn_Profit);
            this.Controls.Add(this.btn_CurrencyEurDkk);
            this.Controls.Add(this.btn_EventsIn10Years);
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.btn_EconomyInCountries);
            this.Controls.Add(this.btn_EventsInCountries);
            this.Controls.Add(this.btn_Economy);
            this.Controls.Add(this.btn_Events);
            this.Controls.Add(this.btn_Countries);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Countries;
        private System.Windows.Forms.Button btn_Events;
        private System.Windows.Forms.Button btn_Economy;
        private System.Windows.Forms.Button btn_EventsInCountries;
        private System.Windows.Forms.Button btn_EconomyInCountries;
        private System.Windows.Forms.Button btn_Admin;
        private System.Windows.Forms.Button btn_EventsIn10Years;
        private System.Windows.Forms.Button btn_CurrencyEurDkk;
        private System.Windows.Forms.Button btn_Profit;
        private System.Windows.Forms.Button btn_NobEvents;
    }
}