using Kursach_2._0.Properties;
using System;
using System.Data;
using System.Windows.Forms;

namespace Kursach_2._0
{
    public partial class Type_Form : Form
    {
        public Type_Form()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        ROOM_TYPE rType = new ROOM_TYPE();

        private void Type_Form_Load(object sender, EventArgs e)
        {
            // Заповнення listBox усіма типами
            LoadListboxData();
            // Виводимо кількість типів
            displayTypesCount();
        }
        // Додаємо новий тип
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string type = textBoxType.Text;
            string description = textBoxDescr.Text;

            if(!type.Trim().Equals(""))
            {
                if(rType.insertType(type,description))
                {
                    MessageBox.Show("Тип додано", "Додати тип", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListboxData();
                    // Виводимо кількість типів
                    displayTypesCount();
                }
                    
                else
                    MessageBox.Show("Тип не додано", "Додати тип", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Спочатку введіть тип кімнати", "Додати тип", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        // Відобразити дані в textBox з listBox натиненням на нього
        private void listBoxTypes_Click(object sender, EventArgs e)
        {
            DataRow dr = rType.getAllTypes().Rows[listBoxTypes.SelectedIndex];
            textBoxNumber.Text = dr.ItemArray[0].ToString();
            textBoxType.Text = dr.ItemArray[1].ToString();
            textBoxDescr.Text = dr.ItemArray[2].ToString();
        }
        // Змінення виділеного типу
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxNumber.Text);
                string type = textBoxType.Text;
                string description = textBoxDescr.Text;

                if (!type.Trim().Equals(""))
                {
                    if (rType.editType(id, type, description))
                    {
                        MessageBox.Show("Тип змінено", "Змінити тип", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListboxData();
                        // Виводимо кількість типів
                        displayTypesCount();
                    }    
                    else
                        MessageBox.Show("Тип не змінено", "Змінити тип", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Спочатку введіть тип кімнати", "Змінити тип", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch
            {
                MessageBox.Show("Не вибрано тип", "Змінити тип", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Видалення виділеного типу
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxNumber.Text);

                // Перед видаленням спочатку показуємо попередження
                if (MessageBox.Show("Точно видалити обраний тип?", "Видалити тип", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (rType.deleteType(id))
                    {
                        MessageBox.Show("Тип видалено", "Видалити тип", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Оновлюємо listbox
                        LoadListboxData();
                        // Виводимо кількість типів
                        displayTypesCount();
                        // Очищаємо textBoxes
                        textBoxNumber.Text = "";
                        textBoxType.Text = "";
                        textBoxDescr.Text = "";
                    }
                    else
                        MessageBox.Show("Тип не видалено", "Видалити тип", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Не вибрано тип", "Видалити тип", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Створення функції для заповнення listBox усіма типами
        public void LoadListboxData()
        {
            listBoxTypes.DataSource = rType.getAllTypes();
            listBoxTypes.DisplayMember = "type";
            listBoxTypes.ValueMember = "id";

            // Видалення виділеного з listBox
            listBoxTypes.SelectedItem = null;
        }
        // Виводимо кількість типів
        public void displayTypesCount()
        {
            labelCount.Text = listBoxTypes.Items.Count + " Тип(ів) ";
        }
    }
}
