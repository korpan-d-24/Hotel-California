using Kursach_2._0.Properties;
using System;
using System.Data;
using System.Windows.Forms;

namespace Kursach_2._0
{
    public partial class Rooms_Form : Form
    {
        public Rooms_Form()
        {
            InitializeComponent();
        }

        ROOMS rooms = new ROOMS();

        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Rooms_Form_Load(object sender, EventArgs e)
        {
            // Передаємо в ComboBox значення типів кімнат з Type
            ROOM_TYPE roomT = new ROOM_TYPE();
            comboBoxType.DataSource = roomT.getAllTypes();
            comboBoxType.DisplayMember = "type";
            comboBoxType.ValueMember = "id";
        }
        // Додати нову кімнату до списку
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int type = Convert.ToInt32(comboBoxType.SelectedValue.ToString());
                string isfree = "Yes";
                int size = Convert.ToInt32(textBoxSize.Text);
                string price = textBoxPrice.Text;
                string address = textBoxAddress.Text;
                string description = textBoxDescr.Text;
                int bedrooms = (int)numericUpBedrooms.Value;
                int bathrooms = (int)numericUpBathrooms.Value;
                int room = (int)numericUpRooms.Value;

                Boolean hasBalcony = checkBalcony.Checked;
                Boolean hasMbar = checkMbar.Checked;
                Boolean hasWzone = checkWorkzone.Checked;
                Boolean hasCond = checkCond.Checked;
                Boolean hasTV = checkTV.Checked;

                //MessageBox.Show(" Балкон " + hasBalcony + " Міні-бар " + hasMbar + " Робоча зона " + hasWzone + " Кондиціонер " + hasCond + " Телевізор " + hasTV);

                if (verifTextBox())
                {
                    if (rooms.insertRoom(new ROOMS(0, type, isfree, size, bathrooms, bedrooms, room, price, address, description, hasBalcony, hasMbar, hasWzone, hasCond, hasTV)))
                    {
                        MessageBox.Show("Нову кімнату додано", "Додати кімнату", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                    }
                    else
                    {
                        MessageBox.Show("Нову кімнату не  додано", "Додати кімнату", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Спочатку заповніть необхідні поля (Розмір - ціна - адреса - опис)", "Додати кімнату", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка при додаванні кімнати", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Змінити інформацію про існуючу кімнату
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxNumber.Text);
                int type = Convert.ToInt32(comboBoxType.SelectedValue.ToString());
                string isfree = "Yes";
                int size = Convert.ToInt32(textBoxSize.Text);
                string price = textBoxPrice.Text;
                string address = textBoxAddress.Text;
                string description = textBoxDescr.Text;
                int bedrooms = (int)numericUpBedrooms.Value;
                int bathrooms = (int)numericUpBathrooms.Value;
                int room = (int)numericUpRooms.Value;

                Boolean hasBalcony = checkBalcony.Checked;
                Boolean hasMbar = checkMbar.Checked;
                Boolean hasWzone = checkWorkzone.Checked;
                Boolean hasCond = checkCond.Checked;
                Boolean hasTV = checkTV.Checked;

                //MessageBox.Show(" Балкон " + hasBalcony + " Міні-бар " + hasMbar + " Робоча зона " + hasWzone + " Кондиціонер " + hasCond + " Телевізор " + hasTV);

                if (verifTextBox())
                {
                    if (rooms.updateRoom(new ROOMS(id, type, isfree, size, bathrooms, bedrooms, room, price, address, description, hasBalcony, hasMbar, hasWzone, hasCond, hasTV)))
                    {
                        MessageBox.Show("Дані змінено", "Знінити кімнату", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                    }
                    else
                    {
                        MessageBox.Show("Дані не змінено", "Знінити кімнату", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Спочатку заповніть необхідні поля (Розмір - ціна - адреса - опис)", "Додати кімнату", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка при редагуванні кімнати", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Видалити інформацію про існуючу кімнату
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxNumber.Text);

                // Перед видаленням спочатку показуємо попередження
                if (MessageBox.Show("Точно видалити обрані дані?", "Видалити дані", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (rooms.deleteRoom(id))
                    {
                        MessageBox.Show("Дані видалено", "Видалити кімнату", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                    }
                    else
                    {
                        MessageBox.Show("Дані не видалено", "Видалити кімнату", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch 
            {
                MessageBox.Show("Введіть існуючий номер кімнати", "Помилка при видалені кімнати", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Пошук кімнати по номеру
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Беремо id(номер) кімнати
                int id = Convert.ToInt32(textBoxNumber.Text);
                // Беремо дані про кімнату використовуючи id
                DataTable roomsData = rooms.getRoomsById(id);

                // Виводимо дані про кімнату
                textBoxSize.Text = roomsData.Rows[0]["size"].ToString();
                textBoxPrice.Text = roomsData.Rows[0]["price"].ToString();
                textBoxAddress.Text = roomsData.Rows[0]["address"].ToString();
                textBoxDescr.Text = roomsData.Rows[0]["description"].ToString();
                comboBoxType.SelectedValue = roomsData.Rows[0]["type"];
                numericUpBathrooms.Value = Convert.ToDecimal(roomsData.Rows[0]["bathrooms"]);
                numericUpBedrooms.Value = Convert.ToDecimal(roomsData.Rows[0]["bedrooms"]);
                numericUpRooms.Value = Convert.ToDecimal(roomsData.Rows[0]["room"]);
                checkBalcony.Checked = (bool)roomsData.Rows[0]["balcony"];
                checkCond.Checked = (bool)roomsData.Rows[0]["conditioner"];
                checkMbar.Checked = (bool)roomsData.Rows[0]["mbar"];
                checkWorkzone.Checked = (bool)roomsData.Rows[0]["workzone"];
                checkTV.Checked = (bool)roomsData.Rows[0]["TV"];
            }
            catch
            {
                if(textBoxNumber.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Спочатку введіть номер кімнати", "Введіть номер кімнати", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    clearFields();
                }
                else
                {
                    MessageBox.Show("Кімната під таким номером відсутня", "Кімнату не знайдено", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    clearFields();
                }
                
            }
        }

        private void buttonAllRooms_Click(object sender, EventArgs e)
        {
            All_Room_Form allRoom = new All_Room_Form();
            allRoom.ShowDialog();
        }

        public bool verifTextBox()
        {
            if ((textBoxSize.Text.Trim() == "") ||
                (textBoxPrice.Text.Trim() == "") ||
                (textBoxAddress.Text.Trim() == "") ||
                (textBoxDescr.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // Функція для очищення всіх компонент
        public void clearFields()
        {
            textBoxNumber.Text = "";
            textBoxSize.Text = "";
            textBoxPrice.Text = "";
            textBoxAddress.Text = "";
            textBoxDescr.Text = "";
            comboBoxType.SelectedIndex = 0;
            numericUpBathrooms.Value = 0;
            numericUpBedrooms.Value = 0;
            numericUpRooms.Value = 0;
            checkBalcony.Checked = false;
            checkCond.Checked = false;
            checkMbar.Checked = false;
            checkWorkzone.Checked = false;
            checkTV.Checked = false;
        }

        private void buttonShowRoomImages_Click(object sender, EventArgs e)
        {
            try
            {
                int roomId = Convert.ToInt32(textBoxNumber.Text);
                SlideRoomForm slideRoom = new SlideRoomForm();
                slideRoom.getImage(roomId);
                slideRoom.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Не правильно обраний Id номера", "Виберіть Id номер", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
