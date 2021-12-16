using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Kursach_2._0
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPasswd.Checked)
                textBoxPassword.UseSystemPasswordChar = false;
            else
                textBoxPassword.UseSystemPasswordChar = true;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            My_DB db = new My_DB();
            XOR_Cipher cipher = new XOR_Cipher();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `personal` WHERE `login`=@lgn AND `password`=@pass AND`position`=@pos", db.getConnection);
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            string key = "24062003";
            command.Parameters.Add("@lgn", MySqlDbType.VarChar).Value = cipher.Encrypt(login, key); 
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = cipher.Encrypt(password, key);
            command.Parameters.Add("@pos", MySqlDbType.VarChar).Value = comboBoxPosada.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0) // Якщо користувача індефіковано, то викликаємо головну форму
            {
                if (comboBoxPosada.Text == "Адміністратор")
                {
                    Admin_Form adminF = new Admin_Form();
                    adminF.Show(this);
                }
                else if(comboBoxPosada.Text == "Рецепшн")
                {
                    RecephenForm recephenF = new RecephenForm();
                    recephenF.Show(this);
                }
            }
            else
                MessageBox.Show("Неправильний пароль, ім'я або посада", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Personal_Form persf = new Personal_Form();
            persf.Show(this);
        }
    }
}
