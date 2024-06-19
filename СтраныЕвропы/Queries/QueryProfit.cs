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
    public partial class QueryProfit : Form
    {
        public QueryProfit()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void QueryProfit_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            db.openConnection();
            SqlCommand selectCommand = new SqlCommand("SELECT Название_страны, ((Доход_на_душу * 100.0) / ВНП) as Процент FROM Страна C INNER JOIN Экономика E ON C.Код_страны = E.Код_страны", db.GetConnection());
            SqlDataReader reader = selectCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            reader.Close();
            db.closeConnection();
        }
    }
}
