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

    public struct Staff
    {
        public string id { get; set; }
        public string name { get; set; }
        public string sex { get; set; }
        public string dob { get; set; }
        public string pos { get; set; }
        public string address { get; set; }
        public string phoneNum { get; set; }
        public string salary { get; set; }
        public string hiredDate { get; set; }
        public string resignDate { get; set; }

        public Staff(string id_,string name_,string sex_,string dob_,string pos_,string address_,string phone_,string salary_,string hiredDate_,string resignDate_)
        {
            id = id_;
            name = name_;
            sex = sex_;
            dob = dob_;
            pos = pos_;
            address = address_;
            phoneNum = phone_;
            salary = salary_;
            hiredDate = hiredDate_;
            resignDate = resignDate_;
        }
    }
    #endregion
    public partial class MainMenuForm : Form
    {
        List<Staff> staff = new List<Staff>();
        List<Room> room = new List<Room>();
        List<Guest> guest = new List<Guest>();
        public MainMenuForm(List<Room> room1, List<Guest> guest1,List<Staff> staff1)
        {
            if (room1.Count == 0)
                CreateRoomList();
            else
                room = room1;
            guest = guest1;
            staff = staff1;
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
            OpenStaffForm();
        }

        private void picStaff_Click(object sender, EventArgs e)
        {
            OpenStaffForm();
        }

        private void lblStaff_Click(object sender, EventArgs e)
        {
            OpenStaffForm();
        }

        private void lblDetail3_Click(object sender, EventArgs e)
        {
            OpenStaffForm();
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
            RoomForm roomForm = new RoomForm(room,guest,staff);
            roomForm.Show();
        }

        void OpenGuestForm()
        {
            this.Hide();
            GuestForm guestForm = new GuestForm(room,guest,staff);
            guestForm.Show();
        }

        void OpenStaffForm()
        {
            this.Hide();
            StaffForm staffForm = new StaffForm(room, guest,staff);
            staffForm.Show();
        }
        //Create room
        void CreateRoomList()
        {
            room.Add(new Room("101", "Single", "1", "Available"));
            room.Add(new Room("102", "Double", "1", "Available"));
            room.Add(new Room("103", "Triple", "1", "Available"));
            room.Add(new Room("104", "Quad", "1", "Available"));

            room.Add(new Room("201", "Single", "2", "Available"));
            room.Add(new Room("202", "Double", "2", "Available"));
            room.Add(new Room("203", "Triple", "2", "Available"));
            room.Add(new Room("204", "Quad", "2", "Available"));

            room.Add(new Room("301", "Single", "3", "Available"));
            room.Add(new Room("302", "Double", "3", "Available"));
            room.Add(new Room("303", "Triple", "3", "Available"));
            room.Add(new Room("304", "Quad", "3", "Available"));

        }

       
    }
}
