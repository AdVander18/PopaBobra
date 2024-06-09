using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace СтраныЕвропы
{
    public partial class Login : Form
    {
        DataBase dataBase = new DataBase();
        public Login()
        {
            InitializeComponent();

        }

        private void linklb_Registration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var login = tb_Login.Text;
            var password = tb_Password.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string queryString = $"select id_user, login_user, password_user, is_admin, Picture from register where login_user = '{login}' and password_user = '{password}'";
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count == 1)
            {
                var userId = table.Rows[0].ItemArray[0].ToString(); // Получаем ID пользователя
                var user = new checkUser(table.Rows[0].ItemArray[1].ToString(), Convert.ToBoolean(table.Rows[0].ItemArray[3]));
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Countries countries = new Countries(user);
                MainForm mainForm = new MainForm(userId); // инициализируем главную форму с ID пользователя
                mainForm.Show();
            }
            else
                MessageBox.Show("Такого аккаунта не существует!", "Эхх!", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
