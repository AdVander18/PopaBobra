using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СтраныЕвропы
{
    public partial class Registration : Form
    {
        DataBase dataBase = new DataBase();
        public Registration()
        {
            InitializeComponent();
        }

        private void tb_Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void linklb_Login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.Show();
        }

        private Boolean checkUser()
        {
            var login = tb_Login.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string queryString = $"select id_user, login_user, password_user, is_admin from register where login_user = '{login}'";
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует!");
                return true;
            }
            else
            {
                return false;
            }
        }
        byte[] userImage = null;
        private void btn_Registration_Click(object sender, EventArgs e)
        {
            var login = tb_Login.Text;
            var password = tb_Password.Text;

            if (checkUser())
            {
                return;
            }

            try
            {
                dataBase.openConnection();

                string queryString = $"insert into register(login_user, password_user, picture, is_admin) values(@Login, @Password, @Picture, 0)";

                using (SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection()))
                {
                    // Здесь мы используем параметры, чтобы предотвратить SQL Injection
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);

                    if (userImage != null)
                    {
                        command.Parameters.AddWithValue("@Picture", userImage);
                    }
                    else
                    {
                        // Если изображение не было выбрано, сохраняем DBNull
                        command.Parameters.AddWithValue("@Picture", DBNull.Value);
                    }

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Аккаунт успешно создан!", "Успех");
                        userImage = null; // очищаем изображение после успешного сохранения
                        Login loginForm = new Login();
                        this.Hide();
                        loginForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Аккаунт не создан!");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ошибка при сохранении аккаунта: " + ex.Message);
            }
            finally
            {
                dataBase.closeConnection();
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            tb_Password.PasswordChar = '*';
            tb_Login.MaxLength = 50;
            tb_Password.MaxLength = 50;
        }

        private void btn_AddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog.FileName);
                using (MemoryStream ms = new MemoryStream())
                {
                    image.Save(ms, image.RawFormat);
                    userImage = ms.ToArray();
                }
            }

        }
    }
}
