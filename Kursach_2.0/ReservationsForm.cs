using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Kursach_2._0
{
    public partial class ReservationsForm : Form
    {
        public ReservationsForm()
        {
            InitializeComponent();
        }

        ROOMS rooms = new ROOMS();
        RESERVATION reservation = new RESERVATION();

        // Пошук номера по Id
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            IsNumberExist();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        // Додаємо бронювання
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                int num = Convert.ToInt32(textBoxNumber.Text);
                string fname = textBoxFName.Text;
                string lname = textBoxLName.Text;
                string phone = textBoxPhone.Text;
                DateTime datain = dateTimePickerIn.Value;
                DateTime dataout = dateTimePickerOut.Value;

                DataTable roomsData = rooms.getRoomsById(num);

                if (roomsData.Rows[0]["isfree"].ToString() == "Yes")
                {
                    if(datain.Day < DateTime.Now.Day)
                    {
                        MessageBox.Show("Оберіть дату не пізніше сьогоднішнього дня", "Забронювати кімнату", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (dataout.Day < datain.Day)
                    {
                        MessageBox.Show("Дата виїзду не може бути скоріше ніж дата поселення", "Забронювати кімнату", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (reservation.insertReservatoin(num, fname, lname, phone, datain, dataout))
                        {
                            MessageBox.Show("Нового гостя додано", "Забронювати кімнату", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ChangeGuestList();
                            reservation.IsFreeRoom(num, "No");
                            CleanData();
                        }
                        else
                        {
                            MessageBox.Show("Виникла помилка", "Забронювати кімнату", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                    MessageBox.Show("Цей номер вже зайнятий", "Забронювати кімнату", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Заповнiть всi поля", "Забронювати кімнату", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        // Змінюємо дані про бронювання
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                int num = Convert.ToInt32(textBoxNumber.Text);
                if (IsNumberExist())
                {
                    string fname = textBoxFName.Text;
                    string lname = textBoxLName.Text;
                    string phone = textBoxPhone.Text;
                    DateTime datain = dateTimePickerIn.Value;
                    DateTime dataout = dateTimePickerOut.Value;

                    DataTable roomsData = rooms.getRoomsById(num);

                    if (datain.Day < DateTime.Now.Day)
                    {
                        MessageBox.Show("Оберіть дату не пізніше сьогоднішнього дня", "Забронювати кімнату", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (dataout.Day < datain.Day)
                    {
                        MessageBox.Show("Дата виїзду не може бути скоріше ніж дата поселення", "Забронювати кімнату", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (reservation.updateReservatoin(id, num, fname, lname, phone, datain, dataout))
                        {
                            MessageBox.Show("Дані про гостя змінено", "Змінити дані", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ChangeGuestList();
                            reservation.IsFreeRoom(num, "No");
                            CleanData();
                        }
                        else
                        {
                            MessageBox.Show("Виникла помилка", "Змінити дані", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
        // Видаляємо дані про бронювання
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                int num = Convert.ToInt32(textBoxNumber.Text);
                if (MessageBox.Show("Точно бажаєте скасувати бронювання " + (dataGridView1.CurrentRow.Cells[2].Value).ToString(), "Видалити зображення", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (reservation.deleteReservatoin(id))
                    {
                        MessageBox.Show("Дані про бронювання видалено", "Видалити дані", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ChangeGuestList();
                        reservation.IsFreeRoom(num, "Yes");
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
                MessageBox.Show("Оберіть бронювання", "Видалити дані", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        // Очищаємо дані з компонент
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
        // Функція для відображення змін в списку гостей
        private void ChangeGuestList()
        {
            // Змінюємо висоту колонок
            dataGridView1.RowTemplate.Height = 25;
            // Заповняємо компоненту dataGridView даними з бази даних
            FUNC func = new FUNC();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `reservation`");
            dataGridView1.DataSource = func.getData(command);

            dataGridView1.ClearSelection();
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
            {
                return true;
            }
        }

        private void ReservationsForm_Load(object sender, EventArgs e)
        {
            ChangeGuestList();
            dataGridView1.ClearSelection();
        }
        // Функція для очищення всіх полів
        public void CleanData()
        {
            textBoxFName.Text = "";
            textBoxLName.Text = "";
            textBoxNumber.Text = "";
            textBoxPrice.Text = "";
            textBoxPhone.Text = "";
            dateTimePickerIn.Value = DateTime.Now;
            dateTimePickerOut.Value = DateTime.Now;
        }
        // Функція для відображення даних про клієнта, при виборі його курсором
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNumber.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxFName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxLName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            IsNumberExist();
            dateTimePickerIn.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
            dateTimePickerOut.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[6].Value);
        }
    }
}
