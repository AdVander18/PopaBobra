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
    public partial class QueryNonEvents : Form
    {
        public QueryNonEvents()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void QueryNonEvents_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            // открыть соединение
            db.openConnection();

            // Создается команда SQL
            SqlCommand selectCommand = new SqlCommand("SELECT Название_страны FROM Страна WHERE Код_страны NOT IN (SELECT DISTINCT Код_страны FROM Событие)", db.GetConnection());

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
