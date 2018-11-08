using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    #region // struct Room and Guest
    public struct Room
    {
        public string id { get; set; }
        public string type { get; set; }
        public string floor { get; set; }
        public string status { get; set; }

        public Room(string d, string t, string f, string s)
        {
            id = d;
            type = t;
            floor = f;
            status = s;
        }
    }

    public struct Guest
    {
        public string id { get; set; }
        public string name { get; set; }
        public string phoneNum { get; set; }
        public string roomType { get; set; }
        public string duration { get; set; }
        public string roomNum { get; set; }
        public string checkIn { get; set; }
        public string checkOut { get; set; }

        public Guest(string d, string n, string p, string r, string t, string du, string In, string Out)
        {
            id = d;
            name = n;
            phoneNum = p;
            roomNum = r;
            roomType = t;
            duration = du;
            checkIn = In;
            checkOut = Out;
        }
    }
    #endregion
    public partial class MainMenuForm : Form
    {
        List<Room> room = new List<Room>();
        List<Guest> guest = new List<Guest>();
        public MainMenuForm(List<Room> room1, List<Guest> guest1)
        {
            if (room1.Count == 0)
                CreateRoomList();
            else
                room = room1;
            guest = guest1;
            InitializeComponent();
        }
        #region //Panel Room
        private void picRoom_MouseEnter(object sender, EventArgs e)
        {
            panelRoom.BorderStyle = BorderStyle.FixedSingle;
        }

        private void lblRoom_MouseEnter(object sender, EventArgs e)
        {
            panelRoom.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panelRoom_MouseEnter(object sender, EventArgs e)
        {
            panelRoom.BorderStyle = BorderStyle.FixedSingle;
        }

        private void lblDetail1_MouseEnter(object sender, EventArgs e)
        {
            panelRoom.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panelRoom_MouseLeave(object sender, EventArgs e)
        {
            panelRoom.BorderStyle = BorderStyle.None;
        }

        private void panelRoom_Click(object sender, EventArgs e)
        {
            OpenRoomForm();
        }

        private void picRoom_Click(object sender, EventArgs e)
        {
            OpenRoomForm();
        }

        private void lblRoom_Click(object sender, EventArgs e)
        {
            OpenRoomForm();
        }

        private void lblDetail1_Click(object sender, EventArgs e)
        {
            OpenRoomForm();
        }
        #endregion

        #region //Panel Guest
        private void picGuest_MouseEnter(object sender, EventArgs e)
        {
            panelGuest.BorderStyle = BorderStyle.FixedSingle;
        }

        private void lblGuest_MouseEnter(object sender, EventArgs e)
        {
            panelGuest.BorderStyle = BorderStyle.FixedSingle;
        }

        private void lblDetail2_MouseEnter(object sender, EventArgs e)
        {
            panelGuest.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panelGuest_MouseEnter(object sender, EventArgs e)
        {
            panelGuest.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panelGuest_MouseLeave(object sender, EventArgs e)
        {
            panelGuest.BorderStyle = BorderStyle.None;
        }

        private void panelGuest_Click(object sender, EventArgs e)
        {
            OpenGuestForm();
        }

        private void picGuest_Click(object sender, EventArgs e)
        {
            OpenGuestForm();
        }

        private void lblGuest_Click(object sender, EventArgs e)
        {
            OpenGuestForm();
        }

        private void lblDetail2_Click(object sender, EventArgs e)
        {
            OpenGuestForm();
        }
        #endregion

        #region // Panel Staff
        private void picStaff_MouseEnter(object sender, EventArgs e)
        {
            panelStaff.BorderStyle = BorderStyle.FixedSingle;
        }

        private void lblStaff_MouseEnter(object sender, EventArgs e)
        {
            panelStaff.BorderStyle = BorderStyle.FixedSingle;
        }

        private void lblDetail3_MouseEnter(object sender, EventArgs e)
        {
            panelStaff.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panelStaff_MouseEnter(object sender, EventArgs e)
        {
            panelStaff.BorderStyle = BorderStyle.FixedSingle;
        }

        private void panelStaff_MouseLeave(object sender, EventArgs e)
        {
            panelStaff.BorderStyle = BorderStyle.None;
        }

        private void panelStaff_Click(object sender, EventArgs e)
        {
            MessageBox.Show("9.99$ to unlock this feature");
        }

        private void picStaff_Click(object sender, EventArgs e)
        {
            MessageBox.Show("9.99$ to unlock this feature");
        }

        private void lblStaff_Click(object sender, EventArgs e)
        {
            MessageBox.Show("9.99$ to unlock this feature");
        }

        private void lblDetail3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("9.99$ to unlock this feature");
        }
        #endregion

        #region //Close and Min Button
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.White;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

       


        //methods
        void OpenRoomForm()
        {
            this.Hide();
            RoomForm roomForm = new RoomForm(room,guest);
            roomForm.Show();
        }

        void OpenGuestForm()
        {
            this.Hide();
            GuestForm guestForm = new GuestForm(room,guest);
            guestForm.Show();
        }
        //Create room
        void CreateRoomList()
        {
            room.Add(new Room("101", "single", "1", "Available"));
            room.Add(new Room("102", "double", "1", "Available"));
            room.Add(new Room("103", "triple", "1", "Available"));
            room.Add(new Room("104", "quad", "1", "Available"));

            room.Add(new Room("201", "single", "2", "Available"));
            room.Add(new Room("202", "double", "2", "Available"));
            room.Add(new Room("203", "triple", "2", "Available"));
            room.Add(new Room("204", "quad", "2", "Available"));

            room.Add(new Room("301", "single", "3", "Available"));
            room.Add(new Room("302", "double", "3", "Available"));
            room.Add(new Room("303", "triple", "3", "Available"));
            room.Add(new Room("304", "quad", "3", "Available"));

        }

       
    }
}
