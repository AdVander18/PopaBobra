using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace СтраныЕвропы.Events
{
    public partial class CountryEvent : Form
    {
        public CountryEvent()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void CountryEvent_Load(object sender, EventArgs e)
        {
            this.страныСобытияTableAdapter.Fill(this.страныЕвропыDataSet.СтраныСобытия);
            LoadСтраныСобытияReport();
            this.reportViewer1.RefreshReport();
        }
        DataBase db = new DataBase();

        private void LoadСтраныСобытияReport()
        {

            // Открываем подключение
            db.openConnection();

            // Создаем команду SQL и присваиваем ей подключение
            SqlCommand command = new SqlCommand("SELECT * FROM СтраныСобытия", db.GetConnection());

            // Выполняем SQL-запрос и заполняем DataTable
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            // Установка источника данных для отчета
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dataTable);

            // Убедимся, что указанный путь к отчету правильный
            reportViewer1.LocalReport.ReportPath = @"D:\AllVisualStudio\СтраныЕвропы\СтраныЕвропы\Events\CountryEvent.rdlc";
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.RefreshReport();

            // Закрываем подключение
            db.closeConnection();

        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
