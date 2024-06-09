using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace СтраныЕвропы.Economy
{
    public partial class AddEconomy : Form
    {
        public AddEconomy()
        {
            InitializeComponent();
        }
        DataBase dataBase = new DataBase();
        private void btn_Save_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            try
            {
                if (!string.IsNullOrEmpty(tb_Surname.Text) &&
        !string.IsNullOrEmpty(tb_Name.Text) &&
        !string.IsNullOrEmpty(tb_Patronymic.Text) &&
        !string.IsNullOrEmpty(tb_Phone.Text))
                {
                    var Surname = tb_Surname.Text;
                    var Name = tb_Name.Text;
                    var Patronymic = tb_Patronymic.Text;
                    var Phone = tb_Phone.Text;
                    var addquery = $"insert into Экономика (Код_страны, ВНП, Доход_на_душу, Валюта) values ('{Surname}', '{Name}', '{Patronymic}', '{Phone}')";
                    var command = new SqlCommand(addquery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Запись успешно создана!", "Успехъ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    dataBase.closeConnection();
                }
                else
                {
                    MessageBox.Show("Поля не должны быть пустыми!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Непредвиденная ошибка!");
            }
        }
    }
}
