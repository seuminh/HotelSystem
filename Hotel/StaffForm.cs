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
    public partial class StaffForm : Form
    {
        List<Room> room = new List<Room>();
        List<Guest> guest = new List<Guest>();
        List<Staff> staff = new List<Staff>();
        int staffId;
        int updateStaffId;
        string updateStaffhd;

        public StaffForm(List<Room> room1, List<Guest> guest1, List<Staff> staff1)
        {
            room = room1;
            guest = guest1;
            staff = staff1;
            staffId = staff.Count+1;
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            btnStaff_Click(sender, e);
        }

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

        #region // 4 Buttons Staff, Add, Update, MainMenu

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            panelAddStaff.BringToFront();
            txtAddStaffId.Text = staffId.ToString();
            btnAddStaffNew_Click(sender, e);
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            cboUpdateName.Items.Clear();
            panelUpdateStaff.BringToFront();
            AddStaffNametoComboUpdate();
            btnUpdateStaffNew_Click(sender, e);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            RefreshStaffList();
            panelStaff.BringToFront();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            OpenMainForm();
        }
        #endregion



        #region //Panel Add Staff

        //Button New
        private void btnAddStaffNew_Click(object sender, EventArgs e)
        {
            txtAddStaffId.Text = staffId.ToString();
            txtAddStaffName.Clear();
            txtAddStaffPhone.Clear();
            txtAddStaffSalary.Clear();
            txtAddSaffPos.Clear();
            txtAddStaffAddress.Clear();
            cboAddStaffSex.SelectedIndex = -1;
            dtpAddStaffDob.Value = DateTime.Now;
        }
            
            //Button Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddStaffName.Text != "" && cboAddStaffSex.Text != "" && txtAddSaffPos.Text != "" && txtAddStaffPhone.Text != "" && txtAddStaffAddress.Text != "" && txtAddStaffSalary.Text != "")
            {
                string staffdob = dtpAddStaffDob.Value.ToShortDateString();
                Staff tmp = new Staff(txtAddStaffId.Text, txtAddStaffName.Text, cboAddStaffSex.Text, staffdob, txtAddSaffPos.Text, txtAddStaffAddress.Text, txtAddStaffPhone.Text, txtAddStaffSalary.Text, DateTime.Now.ToShortDateString(),"");
                staff.Add(tmp);
                MessageBox.Show("New Staff has been Added");
                staffId++;
                RefreshStaffList();
                panelStaff.BringToFront();           
            }
            else
                MessageBox.Show("Please Input All Fill");
        }
        #endregion




        #region //Panel Update Staff
            
            //Button New
        private void btnUpdateStaffNew_Click(object sender, EventArgs e)
        {
            cboUpdateName.SelectedIndex = -1;
            cboUpdateSex.SelectedIndex= -1;
            txtUpdatePhone.Clear();
            txtUpdatePos.Clear();
            txtUpdateAddress.Clear();
            txtUpdateSalary.Clear();
            dtpUpdateDob.Value = DateTime.Now;
            cboUpdateStopWork.SelectedIndex = -1;
        }
          
            //Button Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cboUpdateName.Text != "")
            {
                if (txtUpdatePos.Text != "" && txtUpdatePhone.Text != "" && txtUpdateAddress.Text != "" && txtUpdateSalary.Text != "")
                {
                    if (cboUpdateStopWork.SelectedIndex == 0)
                    {
                        int tmpid = updateStaffId;
                        staff[tmpid-1] = new Staff(tmpid.ToString(), cboUpdateName.Text, cboUpdateSex.Text, dtpUpdateDob.Value.ToShortDateString(),txtUpdatePos.Text, txtUpdateAddress.Text, txtUpdatePhone.Text, txtUpdateSalary.Text,updateStaffhd , DateTime.Now.ToShortDateString());
                        RefreshStaffList();
                        MessageBox.Show("Update Successful");
                        panelStaff.BringToFront();
                    }
                    else
                    {
                        int tmpid = updateStaffId;
                        staff[tmpid-1] = new Staff(tmpid.ToString(), cboUpdateName.Text, cboUpdateSex.Text, dtpUpdateDob.Value.ToShortDateString(),txtUpdatePos.Text,txtUpdateAddress.Text, txtUpdatePhone.Text, txtUpdateSalary.Text,updateStaffhd ,"");
                        RefreshStaffList();
                        MessageBox.Show("Update Successful");
                        panelStaff.BringToFront();
                    }
                }
                else
                    MessageBox.Show("Input All Fill");
            }
            else
                MessageBox.Show("Please Select Staff Name to Update any Info");
        }

            //when user select name in combo box
        private void cboUpdateName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowStaffInfo();
        }


        #endregion

        

        //methods
        void OpenMainForm()
        {
            this.Close();
            MainMenuForm mainMenuForm = new MainMenuForm(room, guest,staff);
            mainMenuForm.Show();
        }

        void UpdateStaff(string str,int n)
        {
           
        }

        //show staff info when user select staff name in Update Staff
        void ShowStaffInfo()
        {
            List<Staff> temp = new List<Staff>();
            foreach (Staff tmp in staff)
            {
                if (tmp.resignDate == "")
                    temp.Add(tmp);
            }
            int len = cboUpdateName.SelectedIndex;
            for (int i = 0; i <=len; i++)
            {
                if (temp[i].name == cboUpdateName.Text)
                {
                    updateStaffId = Convert.ToInt32(temp[i].id);
                    updateStaffhd = temp[i].hiredDate;
                    cboUpdateSex.Text = temp[i].sex;
                    txtUpdatePos.Text = temp[i].pos;
                    txtUpdatePhone.Text = temp[i].phoneNum;
                    txtUpdateSalary.Text = temp[i].salary;
                    txtUpdateAddress.Text = temp[i].address;
                    cboUpdateStopWork.SelectedIndex = 1;
                    dtpUpdateDob.Value =DateTime.Now;

                }
            }
        }

        //Add Staff Name to combo box in Panel Update
        void AddStaffNametoComboUpdate()
        {
            foreach(Staff tmp in staff)
            {
                if (tmp.resignDate == "")
                {
                    cboUpdateName.Items.Add(tmp.name);
                }
            }
        }

        // Add Staff to Staff List
        void RefreshStaffList()
        {
            lstStaff.Items.Clear();
            foreach(Staff tmp in staff)
            {
                ListViewItem item = new ListViewItem(tmp.id);
                item.SubItems.Add(tmp.name);
                item.SubItems.Add(tmp.sex);
                item.SubItems.Add(tmp.pos);
                item.SubItems.Add(tmp.phoneNum);
                item.SubItems.Add(tmp.address);
                item.SubItems.Add(tmp.salary);
                item.SubItems.Add(tmp.dob);
                item.SubItems.Add(tmp.hiredDate);
                item.SubItems.Add(tmp.resignDate);
                lstStaff.Items.Add(item);
            }
        }

       
    }
}
