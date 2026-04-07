using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace CollegeStudentsApp
{
    public class FormStudents : Form  // ← убрал partial
    {
        string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=123;Database=CollegeDB";

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
            // Сначала создаём элементы
            InitializeMyForm();

            // Проверка: добавились ли элементы?
            MessageBox.Show("Элементов на форме: " + this.Controls.Count);

            // Потом загружаем данные
            LoadData();
        }

        private void InitializeMyForm()
        {
            this.Text = "Студенты колледжа";
            this.Size = new System.Drawing.Size(800, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            // Важно! Цвет фона, чтобы видеть границы
            this.BackColor = System.Drawing.Color.LightGray;

            // Создаём таблицу
            dataGridView1 = new DataGridView();
            dataGridView1.Location = new System.Drawing.Point(12, 12);
            dataGridView1.Size = new System.Drawing.Size(760, 250);
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;  // чтобы было видно
            dataGridView1.RowHeaderMouseClick += DataGridView1_RowHeaderMouseClick;

            // Создаём поля для ввода
            label1 = new Label();
            label1.Text = "Номер студенческого билета:";
            label1.Location = new System.Drawing.Point(12, 280);
            label1.Size = new System.Drawing.Size(180, 25);
            label1.BackColor = System.Drawing.Color.White;  // чтобы было видно

            textBoxCard = new TextBox();
            textBoxCard.Location = new System.Drawing.Point(200, 280);
            textBoxCard.Size = new System.Drawing.Size(250, 20);

            label2 = new Label();
            label2.Text = "Номер курса (только число):";
            label2.Location = new System.Drawing.Point(12, 310);
            label2.Size = new System.Drawing.Size(180, 25);
            label2.BackColor = System.Drawing.Color.White;

            textBoxCourse = new TextBox();
            textBoxCourse.Location = new System.Drawing.Point(200, 310);
            textBoxCourse.Size = new System.Drawing.Size(250, 20);

            label3 = new Label();
            label3.Text = "Название группы:";
            label3.Location = new System.Drawing.Point(12, 340);
            label3.Size = new System.Drawing.Size(180, 25);
            label3.BackColor = System.Drawing.Color.White;

            textBoxGroup = new TextBox();
            textBoxGroup.Location = new System.Drawing.Point(200, 340);
            textBoxGroup.Size = new System.Drawing.Size(250, 20);

            label4 = new Label();
            label4.Text = "ФИО студента:";
            label4.Location = new System.Drawing.Point(12, 370);
            label4.Size = new System.Drawing.Size(180, 25);
            label4.BackColor = System.Drawing.Color.White;

            textBoxName = new TextBox();
            textBoxName.Location = new System.Drawing.Point(200, 370);
            textBoxName.Size = new System.Drawing.Size(250, 20);

            // Кнопки
            buttonAdd = new Button();
            buttonAdd.Text = "Добавить";
            buttonAdd.Location = new System.Drawing.Point(480, 280);
            buttonAdd.Size = new System.Drawing.Size(100, 30);
            buttonAdd.BackColor = System.Drawing.Color.LightGreen;
            buttonAdd.Click += ButtonAdd_Click;

            buttonEdit = new Button();
            buttonEdit.Text = "Редактировать";
            buttonEdit.Location = new System.Drawing.Point(590, 280);
            buttonEdit.Size = new System.Drawing.Size(100, 30);
            buttonEdit.BackColor = System.Drawing.Color.LightYellow;
            buttonEdit.Click += ButtonEdit_Click;

            buttonDelete = new Button();
            buttonDelete.Text = "Удалить";
            buttonDelete.Location = new System.Drawing.Point(480, 320);
            buttonDelete.Size = new System.Drawing.Size(100, 30);
            buttonDelete.BackColor = System.Drawing.Color.LightCoral;
            buttonDelete.Click += ButtonDelete_Click;

            buttonRefresh = new Button();
            buttonRefresh.Text = "Обновить";
            buttonRefresh.Location = new System.Drawing.Point(590, 320);
            buttonRefresh.Size = new System.Drawing.Size(100, 30);
            buttonRefresh.BackColor = System.Drawing.Color.LightBlue;
            buttonRefresh.Click += ButtonRefresh_Click;

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

            // Проверка: сколько элементов добавили?
            MessageBox.Show("Добавлено элементов: " + this.Controls.Count);
        }

        // ... остальные методы (LoadData, ButtonAdd_Click и т.д.) остаются те же ...

        private void LoadData()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT id, student_card_number AS 'Номер билета', course_number AS 'Курс', group_name AS 'Группа', full_name AS 'ФИО' FROM students ORDER BY id";
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sql, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;

                    if (dataGridView1.Columns.Contains("id"))
                        dataGridView1.Columns["id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message);
            }
        }

        // Добавьте остальные методы (ButtonAdd_Click, ButtonEdit_Click и т.д.)
        // Они такие же, как в вашем коде

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBoxCard.Text = row.Cells["Номер билета"].Value?.ToString() ?? "";
                textBoxCourse.Text = row.Cells["Курс"].Value?.ToString() ?? "";
                textBoxGroup.Text = row.Cells["Группа"].Value?.ToString() ?? "";
                textBoxName.Text = row.Cells["ФИО"].Value?.ToString() ?? "";
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // ваш существующий код
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            // ваш существующий код
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            // ваш существующий код
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearFields();
        }

        private void ClearFields()
        {
            textBoxCard.Text = "";
            textBoxCourse.Text = "";
            textBoxGroup.Text = "";
            textBoxName.Text = "";
        }
    }
}