using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;  // не забудь добавить через NuGet

namespace CollegeStudentsApp
{
    public partial class FormStudents : Form
    {
        // Строка подключения к базе данных (поменяй пароль и порт если нужно)
        string connectionString = "Host=192.168.1.48;Username=st53-5;Password=535;Database=CollegeDB";

        // Все элементы формы (объявляем здесь)
        DataGridView dataGridView1;
        Button buttonAdd;
        Button buttonEdit;
        Button buttonDelete;
        Button buttonRefresh;
        TextBox textBoxCard;
        TextBox textBoxCourse;
        TextBox textBoxGroup;
        TextBox textBoxName;
        Label label1, label2, label3, label4;

        public FormStudents()
        {
            // Создаём форму и все элементы
            InitializeMyForm();
            // Загружаем данные из БД
            LoadData();
            dataGridView1.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Regular);
        }

        // Метод для создания интерфейса (всё руками, без дизайнера)
        private void InitializeMyForm()
        {
            this.Text = "Студенты колледжа";
            this.Size = new System.Drawing.Size(800, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Создаём таблицу
            dataGridView1 = new DataGridView();
            dataGridView1.Location = new System.Drawing.Point(12, 12);
            dataGridView1.Size = new System.Drawing.Size(760, 250);
            dataGridView1.ReadOnly = true;  // чтобы нельзя было редактировать прямо в таблице
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Подписка на событие клика по строке
            dataGridView1.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(DataGridView1_RowHeaderMouseClick);

            // Создаём поля для ввода
            label1 = new Label();
            label1.Text = "Номер студенческого билета:";
            label1.Location = new System.Drawing.Point(12, 280);
            label1.Size = new System.Drawing.Size(180, 25);

            textBoxCard = new TextBox();
            textBoxCard.Location = new System.Drawing.Point(200, 280);
            textBoxCard.Size = new System.Drawing.Size(200, 20);

            label2 = new Label();
            label2.Text = "Номер курса (только число):";
            label2.Location = new System.Drawing.Point(12, 310);
            label2.Size = new System.Drawing.Size(180, 25);

            textBoxCourse = new TextBox();
            textBoxCourse.Location = new System.Drawing.Point(200, 310);
            textBoxCourse.Size = new System.Drawing.Size(200, 20);

            label3 = new Label();
            label3.Text = "Название группы:";
            label3.Location = new System.Drawing.Point(12, 340);
            label3.Size = new System.Drawing.Size(180, 25);

            textBoxGroup = new TextBox();
            textBoxGroup.Location = new System.Drawing.Point(200, 340);
            textBoxGroup.Size = new System.Drawing.Size(200, 20);

            label4 = new Label();
            label4.Text = "ФИО студента:";
            label4.Location = new System.Drawing.Point(12, 370);
            label4.Size = new System.Drawing.Size(180, 25);

            textBoxName = new TextBox();
            textBoxName.Location = new System.Drawing.Point(200, 370);
            textBoxName.Size = new System.Drawing.Size(200, 20);

            // Кнопки
            buttonAdd = new Button();
            buttonAdd.Text = "Добавить";
            buttonAdd.Location = new System.Drawing.Point(450, 280);
            buttonAdd.Size = new System.Drawing.Size(100, 30);
            buttonAdd.Click += new EventHandler(ButtonAdd_Click);

            buttonEdit = new Button();
            buttonEdit.Text = "Редактировать";
            buttonEdit.Location = new System.Drawing.Point(560, 280);
            buttonEdit.Size = new System.Drawing.Size(100, 30);
            buttonEdit.Click += new EventHandler(ButtonEdit_Click);

            buttonDelete = new Button();
            buttonDelete.Text = "Удалить";
            buttonDelete.Location = new System.Drawing.Point(670, 280);
            buttonDelete.Size = new System.Drawing.Size(100, 30);
            buttonDelete.Click += new EventHandler(ButtonDelete_Click);

            buttonRefresh = new Button();
            buttonRefresh.Text = "Обновить";
            buttonRefresh.Location = new System.Drawing.Point(670, 320);
            buttonRefresh.Size = new System.Drawing.Size(100, 30);
            buttonRefresh.Click += new EventHandler(ButtonRefresh_Click);

            // Добавляем все элементы на форму
            this.Controls.Add(dataGridView1);
            this.Controls.Add(label1);
            this.Controls.Add(textBoxCard);
            this.Controls.Add(label2);
            this.Controls.Add(textBoxCourse);
            this.Controls.Add(label3);
            this.Controls.Add(textBoxGroup);
            this.Controls.Add(label4);
            this.Controls.Add(textBoxName);
            this.Controls.Add(buttonAdd);
            this.Controls.Add(buttonEdit);
            this.Controls.Add(buttonDelete);
            this.Controls.Add(buttonRefresh);
        }

        // Загрузка данных из PostgreSQL в DataGridView
        private void LoadData()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // В PostgreSQL алиасы (названия колонок) в ДВОЙНЫХ кавычках
                    string sql = "SELECT id, student_card_number AS \"Номер билета\", course_number AS \"Курс\", group_name AS \"Группа\", full_name AS \"ФИО\" FROM students ORDER BY id";

                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;

                    if (dataGridView1.Columns.Contains("id"))
                        dataGridView1.Columns["id"].Visible = false;

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }

        // Событие - когда пользователь кликает на строку таблицы
        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Получаем выбранную строку
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            // Заполняем текстовые поля данными из выбранной строки
            textBoxCard.Text = row.Cells["Номер билета"].Value.ToString();
            textBoxCourse.Text = row.Cells["Курс"].Value.ToString();
            textBoxGroup.Text = row.Cells["Группа"].Value.ToString();
            textBoxName.Text = row.Cells["ФИО"].Value.ToString();
        }

        // Кнопка "Добавить"
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // Проверяем, что все поля заполнены
            if (textBoxCard.Text == "" || textBoxCourse.Text == "" || textBoxGroup.Text == "" || textBoxName.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            // Проверяем, что курс - это число
            int courseNumber;
            bool isNumber = int.TryParse(textBoxCourse.Text, out courseNumber);
            if (!isNumber)
            {
                MessageBox.Show("Номер курса должен быть числом!");
                return;
            }

            try
            {
                // Открываем соединение
                NpgsqlConnection connection = new NpgsqlConnection(connectionString);
                connection.Open();

                // SQL запрос на добавление новой записи
                string sql = "INSERT INTO students (student_card_number, course_number, group_name, full_name) VALUES (@card, @course, @group, @name)";

                // Создаём команду
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);

                // Добавляем параметры (защита от SQL инъекций)
                command.Parameters.AddWithValue("@card", textBoxCard.Text);
                command.Parameters.AddWithValue("@course", courseNumber);
                command.Parameters.AddWithValue("@group", textBoxGroup.Text);
                command.Parameters.AddWithValue("@name", textBoxName.Text);

                // Выполняем команду
                command.ExecuteNonQuery();

                // Закрываем соединение
                connection.Close();

                // Обновляем таблицу
                LoadData();

                // Очищаем поля
                ClearFields();

                MessageBox.Show("Студент успешно добавлен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при добавлении: " + ex.Message);
            }
        }

        // Кнопка "Редактировать"
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            // Проверяем, выбрана ли строка
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Сначала выберите студента в таблице!");
                return;
            }

            // Получаем ID выбранного студента
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

            // Проверяем заполнение полей
            if (textBoxCard.Text == "" || textBoxCourse.Text == "" || textBoxGroup.Text == "" || textBoxName.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            // Проверяем курс
            int courseNumber;
            if (!int.TryParse(textBoxCourse.Text, out courseNumber))
            {
                MessageBox.Show("Номер курса должен быть числом!");
                return;
            }

            try
            {
                NpgsqlConnection connection = new NpgsqlConnection(connectionString);
                connection.Open();

                // SQL запрос на обновление
                string sql = "UPDATE students SET student_card_number = @card, course_number = @course, group_name = @group, full_name = @name WHERE id = @id";

                NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                command.Parameters.AddWithValue("@card", textBoxCard.Text);
                command.Parameters.AddWithValue("@course", courseNumber);
                command.Parameters.AddWithValue("@group", textBoxGroup.Text);
                command.Parameters.AddWithValue("@name", textBoxName.Text);
                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();

                connection.Close();

                LoadData();
                ClearFields();

                MessageBox.Show("Данные студента обновлены!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при редактировании: " + ex.Message);
            }
        }

        // Кнопка "Удалить"
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            // Проверяем, выбрана ли строка
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Сначала выберите студента в таблице!");
                return;
            }

            // Спрашиваем подтверждение
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить этого студента?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            // Получаем ID
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);

            try
            {
                NpgsqlConnection connection = new NpgsqlConnection(connectionString);
                connection.Open();

                string sql = "DELETE FROM students WHERE id = @id";
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();

                connection.Close();

                LoadData();
                ClearFields();

                MessageBox.Show("Студент удалён!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при удалении: " + ex.Message);
            }
        }

        // Кнопка "Обновить" (просто перезагружает данные)
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearFields();
        }

        // Очистка текстовых полей
        private void ClearFields()
        {
            textBoxCard.Text = "";
            textBoxCourse.Text = "";
            textBoxGroup.Text = "";
            textBoxName.Text = "";
        }
    }
}