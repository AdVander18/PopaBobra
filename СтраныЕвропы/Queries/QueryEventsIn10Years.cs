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

namespace СтраныЕвропы
{
    public partial class QueryEventsIn10Years : Form
    {
        public QueryEventsIn10Years()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void QueryEventsIn10Years_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            db.openConnection();
            SqlCommand selectCommand = new SqlCommand("SELECT Название_события FROM Событие WHERE Дата >= DATEADD(YEAR, -10, GETDATE())", db.GetConnection());
            SqlDataReader reader = selectCommand.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dataGridView1.DataSource = dt;
            reader.Close();
            db.closeConnection();

        }
    }
}
