using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Kursach_2._0
{
    public partial class All_Room_RecForm : Form
    {
        public All_Room_RecForm()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonShowRoomImages_Click(object sender, EventArgs e)
        {
            try
            {
                // Показ вибраних фото кімнат в новій формі
                SlideRoomForm slideR = new SlideRoomForm();
                // Повідомити про помилку, якщо номер немає зображень, щоб показати їх
                if (dataGridView1.RowCount != 0)
                {
                    // Отримуємо значення Id кімнат з компоненти dataGridView
                    int roomId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                    slideR.getImage(roomId);
                    slideR.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Номеру обраного типу немає в базі диних, спочатку додайте номер цього типу", "Немає зображень", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Обраний номер немає зображень", "Виберіть номер", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void All_Room_RecForm_Load(object sender, EventArgs e)
        {
            // Змінюємо висоту колонок
            dataGridView1.RowTemplate.Height = 25;
            // Заповняємо компоненту dataGridView даними з бази даних
            FUNC func = new FUNC();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms`");
            dataGridView1.DataSource = func.getData(command);

            dataGridView1.ClearSelection();
        }
    }
}
