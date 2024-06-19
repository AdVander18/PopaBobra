﻿using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace СтраныЕвропы.Queries
{
    public partial class _10Years : Form
    {
        public _10Years()
        {
            InitializeComponent();
        }

        private void _10Years_Load(object sender, EventArgs e)
        {
            LoadСтраныСобытияReport();
            this.reportViewer1.RefreshReport();
        }
        DataBase db = new DataBase();
        private void LoadСтраныСобытияReport()
        {
            db.openConnection();

            SqlCommand command = new SqlCommand("SELECT * FROM ЕвропейскиеСобытия", db.GetConnection());

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", dataTable);

            reportViewer1.LocalReport.ReportPath = @"D:\AllVisualStudio\СтраныЕвропы\СтраныЕвропы\Queries\EventsIn10YearsReport.rdlc";
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.RefreshReport();

            db.closeConnection();
        }
    }
}
