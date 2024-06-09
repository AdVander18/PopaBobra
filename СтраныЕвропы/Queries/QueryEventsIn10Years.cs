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

            // открыть соединение
            db.openConnection();

            // Создается команда SQL
            SqlCommand selectCommand = new SqlCommand("SELECT Название_события FROM Событие WHERE Дата >= DATEADD(YEAR, -10, GETDATE())", db.GetConnection());

            // Выполняется команда
            SqlDataReader reader = selectCommand.ExecuteReader();

            // Создаем новую таблицу DataTable.
            DataTable dt = new DataTable();

            // Заполняем DataTable данными из DataReader
            dt.Load(reader);

            // Настройка DataGridView для отображения данных из DataTable.
            dataGridView1.DataSource = dt;

            reader.Close();

            // закрыть соединение
            db.closeConnection();

        }
    }
}
