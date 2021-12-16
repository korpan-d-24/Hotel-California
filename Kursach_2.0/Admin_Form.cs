using System;
using System.Windows.Forms;

namespace Kursach_2._0
{
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonType_Click(object sender, EventArgs e)
        {
            Type_Form type = new Type_Form();
            type.Show();
        }

        private void buttonRooms_Click(object sender, EventArgs e)
        {
            Rooms_Form rooms = new Rooms_Form();
            rooms.Show();
        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            Room_Image_Form roomIm = new Room_Image_Form();
            roomIm.Show();
        }

        private void buttonGuestList_Click(object sender, EventArgs e)
        {
            GuestListForm guestList = new GuestListForm();
            guestList.Show();
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            ReservationListForm reservationList = new ReservationListForm();
            reservationList.Show(this);
        }

        private void buttonPersonal_Click(object sender, EventArgs e)
        {
            PersonalListForm personalList = new PersonalListForm();
            personalList.Show(this);
        }
    }
}
