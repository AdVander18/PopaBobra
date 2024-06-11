using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace СтраныЕвропы.Economy
{
    public partial class CountryEconomy : Form
    {
        public CountryEconomy()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void CountryEconomy_Load(object sender, EventArgs e)
        {
            LoadСтраныСобытияReport();
            this.reportViewer1.RefreshReport();
        }
        DataBase db = new DataBase();
        private void LoadСтраныСобытияReport()
        {

            // Открываем подключение
            db.openConnection();

            // Создаем команду SQL и присваиваем ей подключение
            SqlCommand command = new SqlCommand("SELECT * FROM СтраныЭкономика", db.GetConnection());

            // Выполняем SQL-запрос и заполняем DataTable
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            // Установка источника данных для отчета
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dataTable);

            // Убедимся, что указанный путь к отчету правильный
            reportViewer1.LocalReport.ReportPath = @"D:\AllVisualStudio\СтраныЕвропы\СтраныЕвропы\Economy\CountryEconomy.rdlc";
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.RefreshReport();

            // Закрываем подключение
            db.closeConnection();

        }
    }
}
