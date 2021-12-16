using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Kursach_2._0
{
    public partial class SlideRoomForm : Form
    {
        public SlideRoomForm()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        DataTable images;
        int position = 0;

        // Створюємо функцію для показу зображень
        public void getImage(int roomId)
        {
            try
            {
                ROOM_IMAGE imageR = new ROOM_IMAGE();
                images = imageR.getRoomImages(roomId);
                if (images.Rows.Count > 0)
                    labelCount.Text = "1";
                displayImage(position);
            }
            catch
            {
                MessageBox.Show("Обраний номер немає зображень", "Виберіть номер", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void displayImage(int index)
        {
            //Відображаємо кількість зображень
            labelTotal.Text = images.Rows.Count.ToString();
            // Відображаємо зображення в pictureBox
            pictureBox1.Image = Image.FromStream(new MemoryStream((byte[])images.Rows[index]["images"]));
        }
        // Показ наступного фото
        private void buttonNext_Click(object sender, EventArgs e)
        {
            position += 1;
            if (position >= images.Rows.Count)
                position = images.Rows.Count - 1;

            labelCount.Text = Convert.ToString(position + 1);
            displayImage(position);
        }
        // Показ попереднього фото
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            position -= 1;
            if (position < 0)
                position = 0;

            labelCount.Text = (Convert.ToInt32(labelCount.Text) - 1).ToString();
            if (Convert.ToInt32(labelCount.Text) < 1)
                labelCount.Text = "1";

            displayImage(position);
        }
    }
}
