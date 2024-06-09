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

namespace СтраныЕвропы.Events
{
    public partial class AddEvent : Form
    {
        public AddEvent()
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
        !string.IsNullOrEmpty(tb_Patronymic.Text))
                {
                    var Surname = tb_Surname.Text;
                    var Name = tb_Name.Text;
                    var Patronymic = tb_Patronymic.Text;
                    var addquery = $"insert into Событие (Код_страны, Название_события, Дата) values ('{Surname}', '{Name}', '{Patronymic}')";
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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пример: 01.01.1999 0:00:00");
        }
    }
}
