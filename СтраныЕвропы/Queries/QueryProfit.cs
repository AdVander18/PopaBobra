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

            // открыть соединение
            db.openConnection();

            // Создается команда SQL
            SqlCommand selectCommand = new SqlCommand("SELECT Название_страны, ((Доход_на_душу * 100.0) / ВНП) as Процент FROM Страна C INNER JOIN Экономика E ON C.Код_страны = E.Код_страны", db.GetConnection());

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
