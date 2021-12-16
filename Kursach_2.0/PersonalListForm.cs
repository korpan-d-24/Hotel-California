using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;

namespace Kursach_2._0
{
    public partial class PersonalListForm : Form
    {
        public PersonalListForm()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PersonalListForm_Load(object sender, EventArgs e)
        {
            // Змінюємо висоту колонок
            dataGridView1.RowTemplate.Height = 25;
            // Заповняємо компоненту dataGridView даними з бази даних
            FUNC func = new FUNC();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `personal`");
            dataGridView1.DataSource = func.getData(command);

            dataGridView1.ClearSelection();
        }

        private void buttonWriteFile_Click(object sender, EventArgs e)
        {
            // Шлях до файлу
            // Ім'я файлу - guests_list.txt
            // Місце розташування робочий стіл
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\\personal_list.txt";

            using (var writer = new StreamWriter(path))
            {
                // Перевірити си файл існує
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                // Прохід по рядках
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {  // Прохід по стовпцях
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                    }
                    writer.WriteLine();
                }
                writer.Close();
                MessageBox.Show("Дані записано у файл");
            }
        }
    }
}
