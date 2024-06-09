using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using СтраныЕвропы.Economy;

namespace СтраныЕвропы.Events
{
    public partial class Event : Form
    {
        private readonly checkUser _user;
        public Event(checkUser user)
        {
            InitializeComponent();
            _user = user;
        }
        private void IsAdmin()
        {
            label6.Enabled = _user.IsAdmin;
            panel2.Enabled = _user.IsAdmin;

        }
        DataBase dataBase = new DataBase(); //создание объекта класса базы данных
        int selectedRow; // какая строка выбрана в данный момент в DataGridView   

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("Код_события", "Id");
            dataGridView1.Columns.Add("Код_страны", "Код страны");
            dataGridView1.Columns.Add("Название_события", "Событие");
            dataGridView1.Columns.Add("Дата", "Дата события");
            dataGridView1.Columns.Add("IsNew", String.Empty);
            dataGridView1.Columns["IsNew"].Visible = false;
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

                string queryString = $"Select * from Событие";
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
        private void Search(DataGridView dgw)
        {
            // блок try/catch для отлавливания исключений при работе с базой данных
            try
            {
                dgw.Rows.Clear();
                string searchingString = $"select * from Событие where concat (Код_события, Код_страны, Название_события, Дата) like '%" + tb_Search.Text + "%'";
                SqlCommand com = new SqlCommand(searchingString, dataBase.GetConnection());
                dataBase.openConnection();
                SqlDataReader read = com.ExecuteReader();
                while (read.Read())
                {
                    ReadSingleRow(dgw, read);
                }
                read.Close();
            }
            catch (SqlException ex) // ловим исключение, если оно возникло
            {
                MessageBox.Show("При выполнении поиска возникла ошибка: " + ex.Message);
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
                    string checkSql = "DECLARE @result BIT; EXEC CheckIfRelationExists @id, @result OUTPUT; SELECT @result AS HasRelation";
                    SqlCommand checkCommand = new SqlCommand(checkSql, dataBase.GetConnection());
                    checkCommand.Parameters.Add("@id", SqlDbType.Int).Value = idToDelete;

                    try
                    {
                        dataBase.openConnection();
                        bool hasRelation = (bool)checkCommand.ExecuteScalar();

                        if (hasRelation)
                        {
                            MessageBox.Show("Невозможно удалить запись, так как существуют связанные данные в других таблицах.");
                        }
                        else
                        {
                            string sql = "DELETE FROM Событие WHERE Код_события = @id;";

                            SqlCommand command = new SqlCommand(sql, dataBase.GetConnection());
                            command.Parameters.Add("@id", SqlDbType.Int).Value = idToDelete;

                            command.ExecuteNonQuery();
                            dataGridView1.Rows.RemoveAt(index);
                        }
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
        private new void Update()
        {
            // блок try/catch для отлавливания исключений при работе с базой данных
            try
            {
                dataBase.openConnection();
                for (int index = 0; index < dataGridView1.Rows.Count; index++)
                {
                    if (dataGridView1.Rows[index].Cells[4].Value != null && dataGridView1.Rows[index].Cells[4].Value is RowState)
                    {
                        var rowState = (RowState)dataGridView1.Rows[index].Cells[4].Value;
                        if (rowState == RowState.Modified)
                        {
                            var id = dataGridView1.Rows[index].Cells[0].Value.ToString();
                            var Country = dataGridView1.Rows[index].Cells[1].Value.ToString();
                            var Capital = dataGridView1.Rows[index].Cells[2].Value.ToString();
                            var Pupils = dataGridView1.Rows[index].Cells[3].Value.ToString();
                            var S2 = dataGridView1.Rows[index].Cells[4].Value.ToString();
                            var changeQuery = $"update Событие set Код_страны = '{Country}', Название_события = '{Capital}', Дата = '{Pupils}' where Код_события = '{id}'";
                            var command = new SqlCommand(changeQuery, dataBase.GetConnection());
                            command.ExecuteNonQuery();

                            dataGridView1.Rows[index].Cells[4].Value = RowState.Existed; // обновление состояния строки
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("При обновлении данных возникла ошибка: " + ex.Message);
            }
            finally
            {
                dataBase.closeConnection();
            }
        }

        private void Change()
        {
            try
            {
                var selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
                var Id = tb_Id.Text;
                var Surname = tb_Surname.Text;
                var Name = tb_Name.Text;
                var Patronymic = tb_Patronymic.Text;
                if (dataGridView1.Rows[selectedRowIndex].Cells["Код_события"].Value.ToString() != string.Empty)
                {
                    dataGridView1.Rows[selectedRowIndex].SetValues(Id, Surname, Name, Patronymic);
                    dataGridView1.Rows[selectedRowIndex].Cells["IsNew"].Value = RowState.Modified;
                }
                else
                {
                    MessageBox.Show("ID не может быть пустым!");
                }
            }
            //Ловим исключение, если оно возникло, и выводим сообщение об ошибке
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при изменении записи: {ex.Message}");
            }
        }
        private void ClearFields()
        {
            tb_Id.Text = "";
            tb_Surname.Text = "";
            tb_Name.Text = "";
            tb_Patronymic.Text = "";
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void pb_Refresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void pb_Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                // Заполняем поля ввода текста значениями из выбранной строки DataGridView
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                tb_Id.Text = row.Cells[0].Value.ToString();
                tb_Surname.Text = row.Cells[1].Value.ToString();
                tb_Name.Text = row.Cells[2].Value.ToString();
                tb_Patronymic.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            deleteRow();
            ClearFields();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Change();
            ClearFields();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Update();
            RefreshDataGrid(dataGridView1);
        }

       

        private void btn_New_Click(object sender, EventArgs e)
        {
            AddEvent addEvent= new AddEvent();
            addEvent.ShowDialog();
        }
        private void Applications_Load(object sender, EventArgs e)
        {
            CreateColumns(); // вызов функции, которая создает столбцы
            RefreshDataGrid(dataGridView1); // заполнение DataGridView данными
            IsAdmin();
            // объявить доступность панели и метки при загрузке формы
        }
    }
}
