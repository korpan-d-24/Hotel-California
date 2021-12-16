using System;
using System.Windows.Forms;

namespace Kursach_2._0
{
    public partial class RecephenForm : Form
    {
        public RecephenForm()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        // Кнопка списку номерів
        private void buttonRoom_Click(object sender, EventArgs e)
        {
            All_Room_RecForm allRrForm = new All_Room_RecForm();
            allRrForm.Show(this);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            ClientForm clientF = new ClientForm();
            clientF.Show(this);
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            ReservationsForm reservations = new ReservationsForm();
            reservations.Show(this);
        }
    }
}
