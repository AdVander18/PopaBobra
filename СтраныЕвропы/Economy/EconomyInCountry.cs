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

namespace СтраныЕвропы.Economy
{
    public partial class EconomyInCountry : Form
    {
        public EconomyInCountry()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }

        private void EconomyInCountry_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            // Открываем соединение
            db.openConnection();

            SqlCommand command = new SqlCommand("GetEconomyByCountry", db.GetConnection());
            command.CommandType = CommandType.StoredProcedure;

            // Добавляем параметр @CountryName
            command.Parameters.AddWithValue("@CountryName", tb_EC.Text);

            SqlDataReader reader;

            try
            {
                reader = command.ExecuteReader();

                // Создам новую таблицу DataTable.
                DataTable dt = new DataTable();

                // Заполняем DataTable данными из DataReader
                dt.Load(reader);

                // Настраиваем DataGridView, чтобы он отображал данные из DataTable.
                dataGridView1.DataSource = dt;

                // Опционально: Расширяем столбцы для отображения в DataGridView
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Закрываем соединение
                db.closeConnection();
            }

        }
    }
}
