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
    public partial class RoomForm : Form
    {
        List<Room> room = new List<Room>();

        public RoomForm()
        {
            InitializeComponent();
            CreateRoomList();
        }

        // form Load
        private void RoomForm_Load(object sender, EventArgs e)
        {
            btnRoom_Click(sender, e);
            this.lstRoom.ColumnWidthChanging += new ColumnWidthChangingEventHandler(lstRoom_ColumnWidthChanging);
        }

        private void lstRoom_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = this.lstRoom.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }

        #region// 4 Button Room ,Update ,Add ,MainMenu
        private void btnRoom_Click(object sender, EventArgs e)
        {
            panelRoom.BringToFront();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            panelAddRoom.BringToFront();
            btnClearAddRoom_Click(sender, e);
        }

        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            panelUpdateRoom.BringToFront();
            btnClearUpdateRoom_Click(sender, e);
        }
        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            OpenMainForm();
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
        
        #region       // panel room

             //menu Show Available Room
        private void showAvailableRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdbAvailableRoom.Checked = true;
            ShowAvailableRoom();
        }
            //menu Show Occupied Room
        private void showOccupiedRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdbOccupiedRoom.Checked = true;
            ShowOccupiedRoom();
        }
            //menu Show All Room
        private void showAllRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rdbAllRoom.Checked = true;
            RefreshRoomList();
        }
            //when user click on radiobox Available Room
        private void rdbAvailableRoom_CheckedChanged(object sender, EventArgs e)
        {
            ShowAvailableRoom();
        }
          //when user click on radiobox Occupied Room
        private void rdbOccupiedRoom_CheckedChanged(object sender, EventArgs e)
        {
            ShowOccupiedRoom();
        }
            //when user click on radiobox All Room
        private void rdbAllRoom_CheckedChanged(object sender, EventArgs e)
        {
            RefreshRoomList();
        }
        #endregion

        #region //panel Add room 

            // add button in add room panel
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRoom();
            RefreshRoomList();
        }

          // clear button in add room panel
        private void btnClearAddRoom_Click(object sender, EventArgs e)
        {
            txtAddRoomFloor.Clear();
            txtAddRoomId.Clear();
            cboAddRoomType.Text = "";
        }
        #endregion

        #region //panel Update room

        // update button in update room panel
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateRoom();
            RefreshRoomList();
        }

          //clear button in update room panel
        private void btnClearUpdateRoom_Click(object sender, EventArgs e)
        {
            cboRoomNoUpdateRoom.SelectedIndex = -1;
            cboRoomTypeUpdateRoom.Text = "";
            txtFloorUpdateRoom.Clear();
        }

         // update floor when user click on Room No
        private void cboRoomNoUpdateRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchFloor(cboRoomNoUpdateRoom.Text);
            cboRoomTypeUpdateRoom.Text = "";
        }

          //Add Room No to combo box when user click on Room No combo box
        private void cboRoomNoUpdateRoom_Click(object sender, EventArgs e)
        {
            AddRoomNoToComboBox();
        }
        #endregion


        //methods
        void OpenMainForm()
        {
            this.Close();
            MainMenuForm mainMenuForm = new MainMenuForm();
            mainMenuForm.Show();
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

            RefreshRoomList();
        }
           // Add New Room
        void AddRoom()
        {
            if (txtAddRoomId.Text != "" && txtAddRoomFloor.Text != "" && cboAddRoomType.Text != "")
            {
                room.Add(new Room(txtAddRoomId.Text, cboAddRoomType.Text.ToLower(), txtAddRoomFloor.Text, "Available"));
                MessageBox.Show("New Room Added");
                panelRoom.BringToFront();
            }
            else
                MessageBox.Show("Enter All Info");
        }

           // Refresh Room List when Guest Has Checked In
        void RefreshRoomList()
        {
            lstRoom.Items.Clear();// prevent duplicate , clear list room before Add
            foreach (Room tmp in room)
            {
                ListViewItem item = new ListViewItem(tmp.id);
                item.SubItems.Add(tmp.type);
                item.SubItems.Add(tmp.floor);
                item.SubItems.Add(tmp.status);
                lstRoom.Items.Add(item);
            }
        }

            // Update Room
        void UpdateRoom()
        {
            if (cboRoomNoUpdateRoom.Text != "" && cboRoomTypeUpdateRoom.Text != "" && txtFloorUpdateRoom.Text != "")
            {
                int len = room.Count;
                for (int i = 0; i < len; i++)
                {
                    if (room[i].id == cboRoomNoUpdateRoom.Text)
                    {
                        room[i] = new Room(room[i].id, cboRoomTypeUpdateRoom.Text.ToLower(), room[i].floor, room[i].status);
                        MessageBox.Show("Room Updated");
                        panelRoom.BringToFront();
                        break;
                    }
                }
            }
            else
                MessageBox.Show("Enter All Info");
        }

          // Find Floor function
        void SearchFloor(string roomNo)
        {
            foreach (Room tmp in room)
            {
                if (tmp.id == roomNo)
                {
                    txtFloorUpdateRoom.Text = tmp.floor;
                    break;
                }
            }
        }

          // Add Room No in combo box
        void AddRoomNoToComboBox()
        {
            cboRoomNoUpdateRoom.Items.Clear();  // prevent duplicate, clear item before Add
            foreach (Room tmp in room)
            {
                cboRoomNoUpdateRoom.Items.Add(tmp.id);
            }
        }

          // Show Available Room
        void ShowAvailableRoom()
        {
            lstRoom.Items.Clear();
            List<Room> temp = new List<Room>(room);
            int len = temp.Count;
            for (int i = 0; i < len; i++)
            {
                if (temp[i].status == "Available")
                {
                    ListViewItem item = new ListViewItem(temp[i].id);
                    item.SubItems.Add(temp[i].type);
                    item.SubItems.Add(temp[i].floor);
                    item.SubItems.Add(temp[i].status);
                    lstRoom.Items.Add(item);
                }
            }
        }

          // Show Occupied Room
        void ShowOccupiedRoom()
        {
            lstRoom.Items.Clear();
            List<Room> temp = new List<Room>(room);
            int len = temp.Count;
            for (int i = 0; i < len; i++)
            {
                if (temp[i].status == "Occupied")
                {
                    ListViewItem item = new ListViewItem(temp[i].id);
                    item.SubItems.Add(temp[i].type);
                    item.SubItems.Add(temp[i].floor);
                    item.SubItems.Add(temp[i].status);
                    lstRoom.Items.Add(item);
                }
            }
        }
    }
}
