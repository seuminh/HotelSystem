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
    public partial class GuestForm : Form
    {
        List<string> roomType = new List<string>();
        List<Room> room = new List<Room>();
        List<Guest> guest = new List<Guest>();
        List<Staff> staff = new List<Staff>();
        int guestId;

        public GuestForm(List<Room> room1, List<Guest> guest1, List<Staff> staff1)
        {
            room = room1;
            guest = guest1;
            staff = staff1;
            guestId = guest.Count + 1;
            InitializeComponent();
        }

        private void GuestForm_Load(object sender, EventArgs e)
        {
            btnGuest_Click(sender, e);
        }

        #region // 4 buttons Guest, CheckIn, Checkout, MainMenu
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            OpenMainForm();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            RefreshGuestList();
            panelGuest.BringToFront();
        }
        private void btnCheckInGuest_Click_1(object sender, EventArgs e)
        {
            panelCheckIn.BringToFront();
            txtCheckInId.Text = guestId.ToString();
            AddRoomType();
            btnNew_Click(sender, e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panelCheckOut.BringToFront();
            AddGuestToComboBox();
        }

      
        #endregion

        #region //Close and Min Button
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            OpenMainForm();
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

        #region //panel Guest

            //Menu show All guests
        private void showAllGuestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdbAllGuest.Checked = true;
            RefreshGuestList();
        }

            //Menu show current guests
        private void showCurrentGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdbCurrentGuest.Checked = true;
            ShowCurrentGuest();
        }

            //Menu show old guests
        private void showOldGuestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdbOldGuest.Checked = true;
            ShowOldGuest();
        }

            //when user click on radiobox Current Guest
        private void rdbCurrentGuest_CheckedChanged(object sender, EventArgs e)
        {
            ShowCurrentGuest();
        }

            //when user click on radiobox Old Guest
        private void rdbOldGuest_CheckedChanged(object sender, EventArgs e)
        {
            ShowOldGuest();
        }

            // //when user click on radiobox All Guest
        private void rdbAllGuest_CheckedChanged(object sender, EventArgs e)
        {
            RefreshGuestList();
        }
        #endregion
        
        #region //Panel Check In
        //check In button in Check In panel
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (txtCheckInName.Text != "" && cboRoomNo.Text != "" && cboRoomType.Text != "" && txtCheckInPhone.Text != "" && txtDuration.Text != "")
            {
                dtpCheckInDate.Value = DateTime.Now;
                string checkInDateTime = dtpCheckInDate.Value.ToString("MM/dd/yyyy H:mm");
                Guest temp = new Guest(txtCheckInId.Text, txtCheckInName.Text, txtCheckInPhone.Text, cboRoomNo.Text, cboRoomType.Text, txtDuration.Text, checkInDateTime, "");
                AddGuest(temp);
                MessageBox.Show(txtCheckInName.Text + " has Checked In");
                ChangeStatusRoom(cboRoomNo.Text);
                guestId++;  // increase ID after Check In
                panelGuest.BringToFront();
            }
            else
                MessageBox.Show("Please Input All Fill");
        }

        //new button in Check IN panel
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtCheckInId.Text = guestId.ToString();
            txtCheckInName.Clear();
            txtCheckInPhone.Clear();
            cboRoomNo.SelectedIndex = -1;
            cboRoomType.SelectedIndex = -1;
            txtDuration.Clear();
            dtpCheckInDate.Value = DateTime.Now;
            txtFloor.Clear();
        }

        //When User select Room Type
        private void cboRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFloor.Clear();
            AddRoomNotoComboBox(cboRoomType.Text);
        }

        //Find Floor Room
        private void cboRoomNo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SearchFloorCheckIn(cboRoomNo.Text);
        }
        #endregion

        #region // Panel Check Out
        // check out button in checkout panel
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (cboCheckOutName.Text != "")
            {
                CheckOutGuest();
                MessageBox.Show(cboCheckOutName.Text + " Has checked Out");
                btnClear_Click(sender, e);
            }
            else
                MessageBox.Show("Please Select Guest Name");
        }
        // clear button in check out panel
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCheckOutId.Clear();
            cboCheckOutName.SelectedIndex = -1;
            txtCheckOutPhone.Clear();
            txtRoomNo1.Clear();
            txtRoomType1.Clear();
            txtDuration1.Clear();
            txtCheckInDate1.Clear();
            dtpCheckOutDate.Value = DateTime.Now;
        }

        // when user select guest name in combobox
        private void cboCheckOutName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGuestInformation(cboCheckOutName.Text);
        }
        #endregion

        //methods
        void OpenMainForm()
        {
            this.Close();
            MainMenuForm mainMenuForm = new MainMenuForm(room,guest,staff);
            mainMenuForm.Show();
        }

        // Refresh Guest List when Guest Has Checked Out
        void RefreshGuestList()
        {
            lstGuess.Items.Clear();  // clear guest list and add new;
            foreach (Guest tmp in guest)
            {
                ListViewItem item = new ListViewItem(tmp.id);
                item.SubItems.Add(tmp.name);
                item.SubItems.Add(tmp.phoneNum);
                item.SubItems.Add(tmp.roomNum);
                item.SubItems.Add(tmp.duration);
                item.SubItems.Add(tmp.checkIn);
                item.SubItems.Add(tmp.checkOut);
                lstGuess.Items.Add(item);
            }
        }

        //Show Current Guest
        void ShowCurrentGuest()
        {
            lstGuess.Items.Clear();
            List<Guest> temp = new List<Guest>(guest);
            int len = temp.Count;
            for (int i = 0; i < len; i++)
            {
                if (temp[i].checkOut == "")
                {
                    ListViewItem item = new ListViewItem(temp[i].id);
                    item.SubItems.Add(temp[i].name);
                    item.SubItems.Add(temp[i].phoneNum);
                    item.SubItems.Add(temp[i].roomNum);
                    item.SubItems.Add(temp[i].duration);
                    item.SubItems.Add(temp[i].checkIn);
                    item.SubItems.Add(temp[i].checkOut);
                    lstGuess.Items.Add(item);
                }
            }
        }

        //Show Old Guest
        void ShowOldGuest()
        {
            lstGuess.Items.Clear();
            List<Guest> temp = new List<Guest>(guest);
            int len = temp.Count;
            for (int i = 0; i < len; i++)
            {
                if (temp[i].checkOut != "")
                {
                    ListViewItem item = new ListViewItem(temp[i].id);
                    item.SubItems.Add(temp[i].name);
                    item.SubItems.Add(temp[i].phoneNum);
                    item.SubItems.Add(temp[i].roomNum);
                    item.SubItems.Add(temp[i].duration);
                    item.SubItems.Add(temp[i].checkIn);
                    item.SubItems.Add(temp[i].checkOut);
                    lstGuess.Items.Add(item);
                }
            }
        }

        // When Guest Check In , Add Guest to List Guest
        void AddGuest(Guest tmp)
        {
            ListViewItem item = new ListViewItem(tmp.id);
            item.SubItems.Add(tmp.name);
            item.SubItems.Add(tmp.phoneNum);
            item.SubItems.Add(tmp.roomNum);
            item.SubItems.Add(tmp.duration);
            item.SubItems.Add(tmp.checkIn);
            item.SubItems.Add(tmp.checkOut);
            lstGuess.Items.Add(item);
            guest.Add(new Guest(tmp.id, tmp.name, tmp.phoneNum, tmp.roomNum, tmp.roomType, tmp.duration, tmp.checkIn, tmp.checkOut)); // Add Guest
        }

        // Change status Room From Available to Occupied
        void ChangeStatusRoom(string id)
        {
            int len = room.Count;
            for (int i = 0; i < len; i++)
            {
                if (room[i].id == id)
                {
                    room[i] = new Room(room[i].id, room[i].type, room[i].floor, "Occupied");
                    break;
                }
            }
        }

        // Add Room No in combo box when user select Room Type
        void AddRoomNotoComboBox(string roomType)
        {
            cboRoomNo.Items.Clear(); // prevent duplicate after Change status
            foreach (Room tmp in room)
            {
                if (tmp.status == "Available" && tmp.type == roomType)
                    cboRoomNo.Items.Add(tmp.id);
            }
        }

        // Find Floor function Check In
        void SearchFloorCheckIn(string roomNo)
        {
            foreach (Room tmp in room)
            {
                if (tmp.id == roomNo)
                {
                    txtFloor.Text = tmp.floor;
                    break;
                }
            }
        }

        //Check Out
        void CheckOutGuest()
        {
            int len = guest.Count();
            for (int i = 0; i < len; i++)
            {
                if (guest[i].id == txtCheckOutId.Text && guest[i].checkOut == "")
                {
                    dtpCheckOutDate.Value = DateTime.Now;
                    string checkOutDateTime = dtpCheckOutDate.Value.ToString("MM/dd/yyyy H:mm");
                    guest[i] = new Guest(guest[i].id, guest[i].name, guest[i].phoneNum, guest[i].roomNum, guest[i].roomType, guest[i].duration, guest[i].checkIn, checkOutDateTime);
                    break;
                }
            }
            int len1 = room.Count;
            for (int j = 0; j < len1; j++)
            {
                if (room[j].id == txtRoomNo1.Text)
                {
                    room[j] = new Room(room[j].id, room[j].type, room[j].floor, "Available");
                    break;
                }
            }
            RefreshGuestList();
        }

        //when user choose Guest name in combobox, show all Information
        void ShowGuestInformation(string name)
        {
            List<Guest> temp = new List<Guest>();
            foreach (Guest tmp in guest)
            {
                if (tmp.checkOut == "")
                    temp.Add(tmp);
            }
            int len = cboCheckOutName.SelectedIndex;
            for (int i = 0; i <= len; i++)
            {
                if (temp[i].name == name)
                {
                    txtCheckOutId.Text = temp[i].id;
                    txtCheckOutPhone.Text = temp[i].phoneNum;
                    txtRoomNo1.Text = temp[i].roomNum;
                    txtRoomType1.Text = temp[i].roomType;
                    txtCheckInDate1.Text = temp[i].checkIn;
                    txtDuration1.Text = temp[i].duration;
                }
            }
        }

        // In Check Out Form, add guests to combo box
        void AddGuestToComboBox()
        {
            cboCheckOutName.Items.Clear();
            foreach (Guest tmp in guest)
            {
                if (tmp.checkOut == "")
                    cboCheckOutName.Items.Add(tmp.name);
            }
        }

        // Add room type for Combo Box
        void AddRoomType()
        {
            int len = room.Count;
            int itemCount = 0;
            for(int i = 0; i < len; i++)
            {
                if (!roomType.Contains(room[i].type.ToString()))
                {
                    roomType.Add(room[i].type.ToString());
                    itemCount++;
                }
            }
            for(int j = 0; j < itemCount; j++)
            {
                cboRoomType.Items.Add(roomType[j].ToString());
            }
        }
    }
}