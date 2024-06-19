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

namespace СтраныЕвропы.Queries
{
    public partial class QueryCurrencyEurDkk : Form
    {
        public QueryCurrencyEurDkk()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void QueryCurrencyEurDkk_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            db.openConnection();
            SqlCommand selectCommand = new SqlCommand("SELECT Название_страны FROM Страна C INNER JOIN Экономика E ON C.Код_страны = E.Код_страны WHERE Валюта = 'EUR' OR Валюта = 'DKK'", db.GetConnection());
            SqlDataReader reader = selectCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            reader.Close();
            db.closeConnection();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
