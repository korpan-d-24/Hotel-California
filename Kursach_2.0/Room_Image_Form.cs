using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Kursach_2._0.Properties;
using MySql.Data.MySqlClient;

namespace Kursach_2._0
{
    public partial class Room_Image_Form : Form
    {
        public Room_Image_Form()
        {
            InitializeComponent();
        }

        ROOM_IMAGE roomimage = new ROOM_IMAGE();
        ROOM_TYPE roomT = new ROOM_TYPE();
        FUNC func = new FUNC();

        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Room_Image_Form_Load(object sender, EventArgs e)
        {
            // Заповнити dataGridView всіма властивостями
            MySqlCommand commandRoom = new MySqlCommand("SELECT `id`, `type`, `size` FROM `rooms`"); 
            dataGridView1.DataSource = func.getData(commandRoom);

            // Заповнити listBoxType всіма типами

            listBoxType.DataSource = roomT.getAllTypes();
            listBoxType.DisplayMember = "type";
            listBoxType.ValueMember = "id";

            // Очищаємо початкове встановлення курсору на компонентах
            listBoxType.SelectedItem = null;
            listBoxImageId.SelectedItem = null;
            dataGridView1.ClearSelection();
        }

        private void buttonSelectIm_Click(object sender, EventArgs e)
        {
            // Вибираємо фото 
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxRoomIm.Image = Image.FromFile(opf.FileName);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
                if(dataGridView1.RowCount != 0)
                {
                    int roomId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    MemoryStream pic = new MemoryStream();
                    pictureBoxRoomIm.Image.Save(pic, pictureBoxRoomIm.Image.RawFormat);

                    // Вставляємо фото
                    if (roomimage.insertImage(roomId, pic))
                    {
                        MessageBox.Show("Нове фото кімнати додано", "Додати фото кімнати", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Фото кімнати не знайдено", "Додати фото кімнати", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Данного типу номеру немає в базі данних, спочатку додайте номер такого типу", "Додати фото кімнати", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            // Видаляємо вибране фото

            // Встановлюємо значення id для фото, яке ми хочемо видалити
            try
            {
                int roomId = Convert.ToInt32(listBoxImageId.SelectedValue);

                if(MessageBox.Show("Точно бажаєте видалити зображення?", "Видалити зображення", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if(roomimage.deleteImage(roomId))
                    {
                        MessageBox.Show("Зображення видалено", "Видалити зображення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Зображення не видалено", "Видалити зображення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Зображення не видалено", "Видалити зображення", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAllRooms_Click(object sender, EventArgs e)
        {
            try
            {
                // Показ вибраних фото кімнат в новій формі
                SlideRoomForm slideR = new SlideRoomForm();
                // Повідомити про помилку, якщо номер немає зображень, щоб показати їх
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    
                }
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

        private void listBoxType_Click(object sender, EventArgs e)
        {
            //Показ всіх номерів вибраного типу в компоненті dataGridView
            MySqlCommand commandRoom = new MySqlCommand("SELECT `id`, `type`, `size` FROM `rooms` WHERE `type`=@tp");
            int typeId = Convert.ToInt32(listBoxType.SelectedValue);
            commandRoom.Parameters.Add("@tp", MySqlDbType.Int32).Value = typeId;
            dataGridView1.DataSource = func.getData(commandRoom);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            // Показуємо id фото, вибраного номера в listBox
            int roomId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            listBoxImageId.DataSource = roomimage.getRoomImages(roomId);
            listBoxImageId.DisplayMember = "id";
            listBoxImageId.ValueMember = "id";
        }

        private void listBoxImageId_Click(object sender, EventArgs e)
        {
            // Показ видраного в listBox фото в pictureBox

            // Отримуємо id фото
            int picId = Convert.ToInt32(listBoxImageId.SelectedValue);
            pictureBoxRoomIm.Image = Image.FromStream(roomimage.getImageById(picId));
        }
    }
}
