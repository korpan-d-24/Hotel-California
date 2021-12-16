using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Kursach_2._0
{
    public partial class All_Room_Form : Form
    {
        public All_Room_Form()
        {
            InitializeComponent();
        }

        private void All_Room_Form_Load(object sender, EventArgs e)
        {

            // Змінюємо висоту колонок
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.AllowUserToAddRows = false;
            // Заповняємо компоненту dataGridView даними з бази даних
            FUNC func = new FUNC();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms`");
            dataGridView1.DataSource = func.getData(command);

            dataGridView1.ClearSelection();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
