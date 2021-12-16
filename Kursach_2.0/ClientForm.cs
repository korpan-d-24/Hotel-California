using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Kursach_2._0
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        ROOMS rooms = new ROOMS();
        Guests guest = new Guests();

        // Пошук номера по Id
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            IsNumberExist();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        // Додаємо гостя в готель
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                int num = Convert.ToInt32(textBoxNumber.Text);
                string fname = textBoxFName.Text;
                string lname = textBoxLName.Text;
                string phone = textBoxPhone.Text;
                int days = (int)numericUpDay.Value;
                int sum = (Convert.ToInt32(textBoxPrice.Text) * days);

                DataTable roomsData = rooms.getRoomsById(num);

                if(roomsData.Rows[0]["isfree"].ToString() == "Yes")
                {
                    if (guest.insertGuests(num, fname, lname, phone, sum, days))
                    {
                        MessageBox.Show("Нового гостя додано", "Додати гостя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ChangeGuestList();
                        guest.IsFreeRoom(num, "No");
                        CleanData();
                    }
                    else
                    {
                        MessageBox.Show("Виникла помилка", "Додати гостя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Цей номер вже зайнятий", "Додати гостя", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Заповнiть всi поля", "Додати гостя", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            ChangeGuestList();
            dataGridView1.ClearSelection();
        }
        // Функція для відображення змін в списку гостей
        private void ChangeGuestList()
        {
            // Змінюємо висоту колонок
            dataGridView1.RowTemplate.Height = 25;
            // Заповняємо компоненту dataGridView даними з бази даних
            FUNC func = new FUNC();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `guests`");
            dataGridView1.DataSource = func.getData(command);

            dataGridView1.ClearSelection();
        }

        // Змінюємо інформацію про гостя в готелі
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                
                int num = Convert.ToInt32(textBoxNumber.Text);
                if(IsNumberExist())
                {
                    string fname = textBoxFName.Text;
                    string lname = textBoxLName.Text;
                    string phone = textBoxPhone.Text;
                    int days = (int)numericUpDay.Value;
                    int sum = (Convert.ToInt32(textBoxPrice.Text) * days);

                    DataTable roomsData = rooms.getRoomsById(num);

                        if (guest.updateGuests(id, num, fname, lname, phone, sum, days))
                        {
                            MessageBox.Show("Дані про гостя змінено", "Змінити дані", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ChangeGuestList();
                            guest.IsFreeRoom(num, "No");
                            CleanData();
                        }
                        else
                        {
                            MessageBox.Show("Виникла помилка", "Змінити дані", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
                else
                    MessageBox.Show("Номера під такий id не існує", "Забронювати кімнату", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Заповнiть всi поля", "Змінити дані", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        // Функція для відображення даних про клієнта, при виборі його курсором
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNumber.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxFName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxLName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxPrice.Text = (Convert.ToInt32(dataGridView1.CurrentRow.Cells[5].Value) / Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value)).ToString();
            numericUpDay.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value);
        }
        // Видаляємо інформацію про гостя в готелі
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                int num = Convert.ToInt32(textBoxNumber.Text);
                if (MessageBox.Show("Точно бажаєте видалити гостя " + (dataGridView1.CurrentRow.Cells[2].Value).ToString(), "Видалити зображення", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (guest.deleteGuests(id))
                    {
                        MessageBox.Show("Дані про гостя видалено", "Видалити дані", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ChangeGuestList();
                        guest.IsFreeRoom(num, "Yes");
                        CleanData();
                    }
                    else
                    {
                        MessageBox.Show("Виникла помилка", "Видалити дані", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    CleanData();
            }
            catch
            {
                MessageBox.Show("Оберіть гостя", "Видалити дані", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonCleanData_Click(object sender, EventArgs e)
        {
            CleanData();
        }
        // Функція для пошуку кімнати
        public bool IsNumberExist()
        {
            try
            {

                // Беремо id(номер) кімнати
                int id = Convert.ToInt32(textBoxNumber.Text);
                MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms` WHERE `id`=@id");
                DataTable roomsData = rooms.getRoomsById(id);

                // Виводимо дані про кімнату
                textBoxPrice.Text = roomsData.Rows[0]["price"].ToString();
                return true;

            }
            catch
            {
                if (textBoxNumber.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Спочатку введіть номер кімнати", "Введіть номер кімнати", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxPrice.Text = "";
                    return false;
                }
                else
                {
                    MessageBox.Show("Кімната під таким номером відсутня", "Кімнату не знайдено", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBoxPrice.Text = "";
                    return false;
                }

            }
        }

        public bool verif()
        {
            if ((textBoxFName.Text.Trim() == "") ||
                (textBoxLName.Text.Trim() == "") ||
                (textBoxNumber.Text.Trim() == "") ||
                (textBoxPrice.Text.Trim() == "") ||
                (textBoxPhone.Text.Trim() == ""))
            {
                return false;
            }
            else
                return true;
        }
        // Функція для очищення всіх полів
        public void CleanData()
        {
            textBoxFName.Text = "";
            textBoxLName.Text = "";
            textBoxNumber.Text = "";
            textBoxPrice.Text = "";
            textBoxPhone.Text = "";
            numericUpDay.Value = 1;
        }

    }
}
