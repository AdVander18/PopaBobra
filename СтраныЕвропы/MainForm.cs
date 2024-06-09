using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection.Emit;
using System.Windows.Forms;
using СтраныЕвропы.Events;
using СтраныЕвропы.Queries;

namespace СтраныЕвропы
{
    public partial class MainForm : Form
    {
        DataBase dataBase = new DataBase();
        private readonly checkUser _user;
        private readonly string _userId;
        public MainForm(string userId)
        {
            InitializeComponent();
            _userId = userId;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string queryString = $"select id_user, login_user, is_admin from register WHERE id_user = {_userId}";  // запрашиваем данные о пользователе с id = _userId
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            _user = new checkUser(table.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[2]));

        }

        private void IsAdmin()
        {
            btn_Admin.Enabled = _user.IsAdmin;

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Image userImage = GetImageFromDatabase(_userId);
            pictureBox1.Image = userImage;
            IsAdmin();
        }
        public Image GetImageFromDatabase(string userId)
        {
            DataBase db = new DataBase();
            db.openConnection();

            try
            {
                using (SqlCommand command = new SqlCommand(
                    "SELECT Picture FROM register WHERE id_user = @id_user", db.GetConnection()))
                {
                    command.Parameters.Add(new SqlParameter("id_user", userId));

                    byte[] imageBytes = command.ExecuteScalar() as byte[];

                    if (imageBytes != null)
                    {
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            return Image.FromStream(ms);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Обрабатываете и логируете исключение здесь
            }
            finally
            {
                db.closeConnection();
            }

            return null; // или возвращаем стандартное изображение
        }

        private void btn_Countries_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string queryString = $"select id_user, is_admin from register WHERE id_user = {_userId}";  // запрашиваем данные о пользователе с id = _userId
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            var user = new checkUser(table.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[1]));
            Countries countries = new Countries(user);
            countries.ShowDialog();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            Administration administration = new Administration();
            administration.ShowDialog();
        }

        private void btn_Events_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string queryString = $"select id_user, is_admin from register WHERE id_user = {_userId}";  // запрашиваем данные о пользователе с id = _userId
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            var user = new checkUser(table.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[1]));
            Event @event = new Event(user);
            @event.ShowDialog();
        }

        private void btn_Economy_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string queryString = $"select id_user, is_admin from register WHERE id_user = {_userId}";  // запрашиваем данные о пользователе с id = _userId
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            var user = new checkUser(table.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[1]));
            Economy.Economy countries = new Economy.Economy(user);
            countries.ShowDialog();
        }

        private void btn_EventsIn10Years_Click(object sender, EventArgs e)
        {
            QueryEventsIn10Years queryEventsIn10Years = new QueryEventsIn10Years();
            queryEventsIn10Years.ShowDialog();
        }

        private void btn_CurrencyEurDkk_Click(object sender, EventArgs e)
        {
            QueryCurrencyEurDkk queryCurrency = new QueryCurrencyEurDkk();
            queryCurrency.ShowDialog();
        }

        private void btn_Profit_Click(object sender, EventArgs e)
        {
            QueryProfit queryProfit = new QueryProfit();
            queryProfit.ShowDialog();
        }

        private void btn_NobEvents_Click(object sender, EventArgs e)
        {
            QueryNonEvents queryNonEvents = new QueryNonEvents();
            queryNonEvents.ShowDialog();
        }
    }
}
