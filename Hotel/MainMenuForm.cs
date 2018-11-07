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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
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
        #endregion

        #region //Close and Min Button
        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
