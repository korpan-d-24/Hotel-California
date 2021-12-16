using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Kursach_2._0
{
    public partial class Personal_Form : Form
    {
        public Personal_Form()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            // Додаємо працівника
            Personal personal = new Personal();
            string fname = textBoxFname.Text;
            string lname = textBoxLname.Text;
            string mname = textBoxMname.Text;
            string login = textBoxLogin.Text;
            string pass = textBoxPass.Text;
            string phone = textBoxNumber.Text;
            string position = comboBoxPosada.Text;
            MemoryStream pic = new MemoryStream();
            XOR_Cipher cipher = new XOR_Cipher();
            string key = "24062003";
            var encryptedPassByKeys = cipher.Encrypt(pass, key);
            var encryptedLoginByKeys = cipher.Encrypt(login, key);

            if (verif())
            {
                pictureBoxPersonal.Image.Save(pic, pictureBoxPersonal.Image.RawFormat);

                if(personal.insertWorker(fname, lname, mname, encryptedLoginByKeys, encryptedPassByKeys, phone, position, pic))
                {
                    MessageBox.Show("Нового працiвника додано", "Додати працiвника", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Виникла помилка", "Додати працiвника", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Заповнiть всi поля", "Додати працiвника", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            // Завантажуємо фото з комп'ютера
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPersonal.Image = Image.FromFile(opf.FileName);
            }
        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
                textBoxPass.UseSystemPasswordChar = false;
            else
                textBoxPass.UseSystemPasswordChar = true;
        }

        bool verif()
        {
            if ((textBoxFname.Text.Trim() == "") ||
                (textBoxLname.Text.Trim() == "") ||
                (textBoxMname.Text.Trim() == "") ||
                (comboBoxPosada.Text.Trim() == "") ||
                (textBoxLogin.Text.Trim() == "") ||
                (textBoxPass.Text.Trim() == "") ||
                (textBoxNumber.Text.Trim() == "") ||
                (pictureBoxPersonal.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
