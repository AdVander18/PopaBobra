using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace СтраныЕвропы
{
    public partial class Administration : Form
    {
        public Administration()
        {
            InitializeComponent();
        }
        DataBase dataBase = new DataBase(); //создание объекта класса базы данных
        int selectedRow; // какая строка выбрана в данный момент в DataGridView   

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id_user", "Id");
            dataGridView1.Columns.Add("Login_user", "Логин");
            dataGridView1.Columns.Add("Password_user", "Пароль");
            var checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.HeaderText = ("Администратор");
            dataGridView1.Columns.Add(checkColumn);
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            var values = new object[record.FieldCount];

            for (int i = 0; i < record.FieldCount; i++)
            {
                // Проверяем, является ли значение null
                if (!record.IsDBNull(i))
                {
                    values[i] = record.GetValue(i);
                }
                else
                {
                    values[i] = "N/A"; // Или любое другое значение по умолчанию
                }
            }

            dgw.Rows.Add(values);
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            // блок try/catch для отлавливания исключений при работе с базой данных
            try
            {
                dgw.Rows.Clear(); // очистка всех строк

                string queryString = $"Select * from register";
                SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());
                dataBase.openConnection();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ReadSingleRow(dgw, reader);
                }
                reader.Close();
            }
            catch (SqlException ex) // ловим исключение, если оно возникло
            {
                MessageBox.Show("Возникла ошибка при работе с базой данных: " + ex.Message);
            }
            finally // в любом случае закрываем соединение с базой данных
            {
                dataBase.closeConnection();
            }
        }
        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() != string.Empty)
            {
                int idToDelete = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                var result = MessageBox.Show("Вы уверены, что хотите удалить эту запись?", "Подтверждение удаления", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        dataBase.openConnection();
                        
                            string sql = "DELETE FROM register WHERE id_user = @id;";

                            SqlCommand command = new SqlCommand(sql, dataBase.GetConnection());
                            command.Parameters.Add("@id", SqlDbType.Int).Value = idToDelete;

                            command.ExecuteNonQuery();
                            dataGridView1.Rows.RemoveAt(index);
                        
                    }
                    catch (SqlException ex)
                    {
                        // обработка исключения
                        MessageBox.Show("Возникла ошибка: " + ex.Message);
                    }
                    finally
                    {
                        dataBase.closeConnection();
                    }
                }
            }
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Administration_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            for(int index=0;index<dataGridView1.Rows.Count; index++)
            {
                var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                var isadmin = dataGridView1.Rows[index].Cells[3].Value.ToString();
                var changeQuery = $"UPDATE register SET is_admin = '{isadmin}' WHERE id_user = '{id}'";
                var command = new SqlCommand(changeQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();
            }
            dataBase.closeConnection();
            RefreshDataGrid(dataGridView1);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            deleteRow();
            RefreshDataGrid(dataGridView1);
        }
    }
}
