namespace Hotel
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panelRoom = new System.Windows.Forms.Panel();
            this.lblDetail1 = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.picRoom = new System.Windows.Forms.PictureBox();
            this.panelGuest = new System.Windows.Forms.Panel();
            this.lblDetail2 = new System.Windows.Forms.Label();
            this.lblGuest = new System.Windows.Forms.Label();
            this.picGuest = new System.Windows.Forms.PictureBox();
            this.panelStaff = new System.Windows.Forms.Panel();
            this.lblDetail3 = new System.Windows.Forms.Label();
            this.lblStaff = new System.Windows.Forms.Label();
            this.picStaff = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRoom)).BeginInit();
            this.panelGuest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGuest)).BeginInit();
            this.panelStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome";
            // 
            // panelRoom
            // 
            this.panelRoom.Controls.Add(this.lblDetail1);
            this.panelRoom.Controls.Add(this.lblRoom);
            this.panelRoom.Controls.Add(this.picRoom);
            this.panelRoom.Location = new System.Drawing.Point(40, 152);
            this.panelRoom.Name = "panelRoom";
            this.panelRoom.Size = new System.Drawing.Size(190, 88);
            this.panelRoom.TabIndex = 3;
            this.panelRoom.Click += new System.EventHandler(this.panelRoom_Click);
            this.panelRoom.MouseEnter += new System.EventHandler(this.panelRoom_MouseEnter);
            this.panelRoom.MouseLeave += new System.EventHandler(this.panelRoom_MouseLeave);
            // 
            // lblDetail1
            // 
            this.lblDetail1.AutoSize = true;
            this.lblDetail1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail1.ForeColor = System.Drawing.Color.Gray;
            this.lblDetail1.Location = new System.Drawing.Point(72, 52);
            this.lblDetail1.Name = "lblDetail1";
            this.lblDetail1.Size = new System.Drawing.Size(108, 15);
            this.lblDetail1.TabIndex = 5;
            this.lblDetail1.Text = "Check,Add,Update";
            this.lblDetail1.Click += new System.EventHandler(this.lblDetail1_Click);
            this.lblDetail1.MouseEnter += new System.EventHandler(this.lblDetail1_MouseEnter);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.Location = new System.Drawing.Point(72, 18);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(53, 20);
            this.lblRoom.TabIndex = 4;
            this.lblRoom.Text = "Room";
            this.lblRoom.Click += new System.EventHandler(this.lblRoom_Click);
            this.lblRoom.MouseEnter += new System.EventHandler(this.lblRoom_MouseEnter);
            // 
            // picRoom
            // 
            this.picRoom.Image = global::Hotel.Properties.Resources.room;
            this.picRoom.Location = new System.Drawing.Point(20, 18);
            this.picRoom.Name = "picRoom";
            this.picRoom.Size = new System.Drawing.Size(46, 54);
            this.picRoom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picRoom.TabIndex = 4;
            this.picRoom.TabStop = false;
            this.picRoom.Click += new System.EventHandler(this.picRoom_Click);
            this.picRoom.MouseEnter += new System.EventHandler(this.picRoom_MouseEnter);
            // 
            // panelGuest
            // 
            this.panelGuest.Controls.Add(this.lblDetail2);
            this.panelGuest.Controls.Add(this.lblGuest);
            this.panelGuest.Controls.Add(this.picGuest);
            this.panelGuest.Location = new System.Drawing.Point(271, 152);
            this.panelGuest.Name = "panelGuest";
            this.panelGuest.Size = new System.Drawing.Size(190, 88);
            this.panelGuest.TabIndex = 6;
            this.panelGuest.Click += new System.EventHandler(this.panelGuest_Click);
            this.panelGuest.MouseEnter += new System.EventHandler(this.panelGuest_MouseEnter);
            this.panelGuest.MouseLeave += new System.EventHandler(this.panelGuest_MouseLeave);
            // 
            // lblDetail2
            // 
            this.lblDetail2.AutoSize = true;
            this.lblDetail2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail2.ForeColor = System.Drawing.Color.Gray;
            this.lblDetail2.Location = new System.Drawing.Point(72, 52);
            this.lblDetail2.Name = "lblDetail2";
            this.lblDetail2.Size = new System.Drawing.Size(89, 30);
            this.lblDetail2.TabIndex = 5;
            this.lblDetail2.Text = "Guest,CheckIn,\r\nCheckout";
            this.lblDetail2.Click += new System.EventHandler(this.lblDetail2_Click);
            this.lblDetail2.MouseEnter += new System.EventHandler(this.lblDetail2_MouseEnter);
            // 
            // lblGuest
            // 
            this.lblGuest.AutoSize = true;
            this.lblGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuest.Location = new System.Drawing.Point(72, 18);
            this.lblGuest.Name = "lblGuest";
            this.lblGuest.Size = new System.Drawing.Size(54, 20);
            this.lblGuest.TabIndex = 4;
            this.lblGuest.Text = "Guest";
            this.lblGuest.Click += new System.EventHandler(this.lblGuest_Click);
            this.lblGuest.MouseEnter += new System.EventHandler(this.lblGuest_MouseEnter);
            // 
            // picGuest
            // 
            this.picGuest.Image = global::Hotel.Properties.Resources.guest;
            this.picGuest.Location = new System.Drawing.Point(20, 18);
            this.picGuest.Name = "picGuest";
            this.picGuest.Size = new System.Drawing.Size(46, 54);
            this.picGuest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picGuest.TabIndex = 4;
            this.picGuest.TabStop = false;
            this.picGuest.Click += new System.EventHandler(this.picGuest_Click);
            this.picGuest.MouseEnter += new System.EventHandler(this.picGuest_MouseEnter);
            // 
            // panelStaff
            // 
            this.panelStaff.Controls.Add(this.lblDetail3);
            this.panelStaff.Controls.Add(this.lblStaff);
            this.panelStaff.Controls.Add(this.picStaff);
            this.panelStaff.Location = new System.Drawing.Point(497, 152);
            this.panelStaff.Name = "panelStaff";
            this.panelStaff.Size = new System.Drawing.Size(190, 88);
            this.panelStaff.TabIndex = 6;
            this.panelStaff.Click += new System.EventHandler(this.panelStaff_Click);
            this.panelStaff.MouseEnter += new System.EventHandler(this.panelStaff_MouseEnter);
            this.panelStaff.MouseLeave += new System.EventHandler(this.panelStaff_MouseLeave);
            // 
            // lblDetail3
            // 
            this.lblDetail3.AutoSize = true;
            this.lblDetail3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetail3.ForeColor = System.Drawing.Color.Gray;
            this.lblDetail3.Location = new System.Drawing.Point(72, 52);
            this.lblDetail3.Name = "lblDetail3";
            this.lblDetail3.Size = new System.Drawing.Size(108, 15);
            this.lblDetail3.TabIndex = 5;
            this.lblDetail3.Text = "Staff Management";
            this.lblDetail3.Click += new System.EventHandler(this.lblDetail3_Click);
            this.lblDetail3.MouseEnter += new System.EventHandler(this.lblDetail3_MouseEnter);
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.Location = new System.Drawing.Point(72, 18);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(44, 20);
            this.lblStaff.TabIndex = 4;
            this.lblStaff.Text = "Staff";
            this.lblStaff.Click += new System.EventHandler(this.lblStaff_Click);
            this.lblStaff.MouseEnter += new System.EventHandler(this.lblStaff_MouseEnter);
            // 
            // picStaff
            // 
            this.picStaff.Image = global::Hotel.Properties.Resources.staff;
            this.picStaff.Location = new System.Drawing.Point(20, 18);
            this.picStaff.Name = "picStaff";
            this.picStaff.Size = new System.Drawing.Size(46, 54);
            this.picStaff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picStaff.TabIndex = 4;
            this.picStaff.TabStop = false;
            this.picStaff.Click += new System.EventHandler(this.picStaff_Click);
            this.picStaff.MouseEnter += new System.EventHandler(this.picStaff_MouseEnter);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = global::Hotel.Properties.Resources.minus_symbol;
            this.btnMin.Location = new System.Drawing.Point(657, 2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(31, 30);
            this.btnMin.TabIndex = 1;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Window;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Hotel.Properties.Resources.cancel;
            this.btnClose.Location = new System.Drawing.Point(694, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // MainMenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(726, 356);
            this.Controls.Add(this.panelStaff);
            this.Controls.Add(this.panelGuest);
            this.Controls.Add(this.panelRoom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelRoom.ResumeLayout(false);
            this.panelRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picRoom)).EndInit();
            this.panelGuest.ResumeLayout(false);
            this.panelGuest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGuest)).EndInit();
            this.panelStaff.ResumeLayout(false);
            this.panelStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStaff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelRoom;
        private System.Windows.Forms.Label lblDetail1;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.PictureBox picRoom;
        private System.Windows.Forms.Panel panelGuest;
        private System.Windows.Forms.Label lblDetail2;
        private System.Windows.Forms.Label lblGuest;
        private System.Windows.Forms.PictureBox picGuest;
        private System.Windows.Forms.Panel panelStaff;
        private System.Windows.Forms.Label lblDetail3;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.PictureBox picStaff;
    }
}

