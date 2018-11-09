namespace Hotel
{
    partial class GuestForm
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
            this.components = new System.ComponentModel.Container();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnGuest = new System.Windows.Forms.Button();
            this.panelGuest = new System.Windows.Forms.Panel();
            this.rdbAllGuest = new System.Windows.Forms.RadioButton();
            this.rdbOldGuest = new System.Windows.Forms.RadioButton();
            this.rdbCurrentGuest = new System.Windows.Forms.RadioButton();
            this.lstGuess = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhoneNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCheckIn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCheckOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuGuest = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showCurrentGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showOldGuestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllGuestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.panelCheckIn = new System.Windows.Forms.Panel();
            this.txtFloor = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnCheckIn = new System.Windows.Forms.Button();
            this.dtpCheckInDate = new System.Windows.Forms.DateTimePicker();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtCheckInPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboRoomType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboRoomNo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCheckInName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCheckInId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelCheckOut = new System.Windows.Forms.Panel();
            this.txtCheckInDate1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cboCheckOutName = new System.Windows.Forms.ComboBox();
            this.txtRoomType1 = new System.Windows.Forms.TextBox();
            this.txtRoomNo1 = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.dtpCheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtCheckOutPhone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDuration1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCheckOutId = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnCheckInGuest = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelGuest.SuspendLayout();
            this.menuGuest.SuspendLayout();
            this.panelCheckIn.SuspendLayout();
            this.panelCheckOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainMenu.Location = new System.Drawing.Point(44, 575);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(105, 46);
            this.btnMainMenu.TabIndex = 41;
            this.btnMainMenu.Text = "MainMenu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnGuest
            // 
            this.btnGuest.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuest.Location = new System.Drawing.Point(44, 129);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(105, 46);
            this.btnGuest.TabIndex = 40;
            this.btnGuest.Text = "Guest";
            this.btnGuest.UseVisualStyleBackColor = true;
            this.btnGuest.Click += new System.EventHandler(this.btnGuest_Click);
            // 
            // panelGuest
            // 
            this.panelGuest.Controls.Add(this.rdbAllGuest);
            this.panelGuest.Controls.Add(this.rdbOldGuest);
            this.panelGuest.Controls.Add(this.rdbCurrentGuest);
            this.panelGuest.Controls.Add(this.lstGuess);
            this.panelGuest.Controls.Add(this.label1);
            this.panelGuest.Location = new System.Drawing.Point(180, 58);
            this.panelGuest.Name = "panelGuest";
            this.panelGuest.Size = new System.Drawing.Size(991, 586);
            this.panelGuest.TabIndex = 42;
            // 
            // rdbAllGuest
            // 
            this.rdbAllGuest.AutoSize = true;
            this.rdbAllGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAllGuest.Location = new System.Drawing.Point(853, 332);
            this.rdbAllGuest.Name = "rdbAllGuest";
            this.rdbAllGuest.Size = new System.Drawing.Size(88, 22);
            this.rdbAllGuest.TabIndex = 14;
            this.rdbAllGuest.TabStop = true;
            this.rdbAllGuest.Text = "All Guest";
            this.rdbAllGuest.UseVisualStyleBackColor = true;
            this.rdbAllGuest.CheckedChanged += new System.EventHandler(this.rdbAllGuest_CheckedChanged);
            // 
            // rdbOldGuest
            // 
            this.rdbOldGuest.AutoSize = true;
            this.rdbOldGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOldGuest.Location = new System.Drawing.Point(853, 288);
            this.rdbOldGuest.Name = "rdbOldGuest";
            this.rdbOldGuest.Size = new System.Drawing.Size(96, 22);
            this.rdbOldGuest.TabIndex = 13;
            this.rdbOldGuest.TabStop = true;
            this.rdbOldGuest.Text = "Old Guest";
            this.rdbOldGuest.UseVisualStyleBackColor = true;
            this.rdbOldGuest.CheckedChanged += new System.EventHandler(this.rdbOldGuest_CheckedChanged);
            // 
            // rdbCurrentGuest
            // 
            this.rdbCurrentGuest.AutoSize = true;
            this.rdbCurrentGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCurrentGuest.Location = new System.Drawing.Point(853, 245);
            this.rdbCurrentGuest.Name = "rdbCurrentGuest";
            this.rdbCurrentGuest.Size = new System.Drawing.Size(122, 22);
            this.rdbCurrentGuest.TabIndex = 12;
            this.rdbCurrentGuest.TabStop = true;
            this.rdbCurrentGuest.Text = "Current Guest";
            this.rdbCurrentGuest.UseVisualStyleBackColor = true;
            this.rdbCurrentGuest.CheckedChanged += new System.EventHandler(this.rdbCurrentGuest_CheckedChanged);
            // 
            // lstGuess
            // 
            this.lstGuess.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstGuess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colName,
            this.colPhoneNum,
            this.colRoomNum,
            this.colDuration,
            this.colCheckIn,
            this.colCheckOut});
            this.lstGuess.ContextMenuStrip = this.menuGuest;
            this.lstGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGuess.FullRowSelect = true;
            this.lstGuess.GridLines = true;
            this.lstGuess.Location = new System.Drawing.Point(57, 77);
            this.lstGuess.Name = "lstGuess";
            this.lstGuess.Size = new System.Drawing.Size(773, 492);
            this.lstGuess.TabIndex = 8;
            this.lstGuess.UseCompatibleStateImageBehavior = false;
            this.lstGuess.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 45;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 130;
            // 
            // colPhoneNum
            // 
            this.colPhoneNum.Text = "Phone Number";
            this.colPhoneNum.Width = 130;
            // 
            // colRoomNum
            // 
            this.colRoomNum.Text = "Room No";
            this.colRoomNum.Width = 90;
            // 
            // colDuration
            // 
            this.colDuration.Text = "Duration";
            this.colDuration.Width = 90;
            // 
            // colCheckIn
            // 
            this.colCheckIn.Text = "Check In";
            this.colCheckIn.Width = 140;
            // 
            // colCheckOut
            // 
            this.colCheckOut.Text = "Check Out";
            this.colCheckOut.Width = 140;
            // 
            // menuGuest
            // 
            this.menuGuest.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuGuest.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showCurrentGuestToolStripMenuItem,
            this.showOldGuestToolStripMenuItem,
            this.showAllGuestsToolStripMenuItem});
            this.menuGuest.Name = "menuGuest";
            this.menuGuest.Size = new System.Drawing.Size(211, 76);
            // 
            // showCurrentGuestToolStripMenuItem
            // 
            this.showCurrentGuestToolStripMenuItem.Name = "showCurrentGuestToolStripMenuItem";
            this.showCurrentGuestToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.showCurrentGuestToolStripMenuItem.Text = "Show current guests";
            this.showCurrentGuestToolStripMenuItem.Click += new System.EventHandler(this.showCurrentGuestToolStripMenuItem_Click);
            // 
            // showOldGuestToolStripMenuItem
            // 
            this.showOldGuestToolStripMenuItem.Name = "showOldGuestToolStripMenuItem";
            this.showOldGuestToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.showOldGuestToolStripMenuItem.Text = "Show old guests";
            this.showOldGuestToolStripMenuItem.Click += new System.EventHandler(this.showOldGuestToolStripMenuItem_Click);
            // 
            // showAllGuestsToolStripMenuItem
            // 
            this.showAllGuestsToolStripMenuItem.Name = "showAllGuestsToolStripMenuItem";
            this.showAllGuestsToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.showAllGuestsToolStripMenuItem.Text = "Show all guests";
            this.showAllGuestsToolStripMenuItem.Click += new System.EventHandler(this.showAllGuestsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 51);
            this.label1.TabIndex = 7;
            this.label1.Text = "Guest";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Window;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Hotel.Properties.Resources.cancel;
            this.btnClose.Location = new System.Drawing.Point(1133, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 36);
            this.btnClose.TabIndex = 44;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = global::Hotel.Properties.Resources.minus_symbol;
            this.btnMin.Location = new System.Drawing.Point(1091, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(38, 36);
            this.btnMin.TabIndex = 43;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // panelCheckIn
            // 
            this.panelCheckIn.Controls.Add(this.txtFloor);
            this.panelCheckIn.Controls.Add(this.label18);
            this.panelCheckIn.Controls.Add(this.btnCheckIn);
            this.panelCheckIn.Controls.Add(this.dtpCheckInDate);
            this.panelCheckIn.Controls.Add(this.btnNew);
            this.panelCheckIn.Controls.Add(this.txtCheckInPhone);
            this.panelCheckIn.Controls.Add(this.label9);
            this.panelCheckIn.Controls.Add(this.cboRoomType);
            this.panelCheckIn.Controls.Add(this.label4);
            this.panelCheckIn.Controls.Add(this.txtDuration);
            this.panelCheckIn.Controls.Add(this.label8);
            this.panelCheckIn.Controls.Add(this.label7);
            this.panelCheckIn.Controls.Add(this.cboRoomNo);
            this.panelCheckIn.Controls.Add(this.label6);
            this.panelCheckIn.Controls.Add(this.txtCheckInName);
            this.panelCheckIn.Controls.Add(this.label5);
            this.panelCheckIn.Controls.Add(this.txtCheckInId);
            this.panelCheckIn.Controls.Add(this.label10);
            this.panelCheckIn.Controls.Add(this.label3);
            this.panelCheckIn.Location = new System.Drawing.Point(180, 58);
            this.panelCheckIn.Name = "panelCheckIn";
            this.panelCheckIn.Size = new System.Drawing.Size(991, 586);
            this.panelCheckIn.TabIndex = 45;
            // 
            // txtFloor
            // 
            this.txtFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFloor.Location = new System.Drawing.Point(216, 439);
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.ReadOnly = true;
            this.txtFloor.Size = new System.Drawing.Size(91, 30);
            this.txtFloor.TabIndex = 27;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(101, 442);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 25);
            this.label18.TabIndex = 37;
            this.label18.Text = "Floor";
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckIn.Location = new System.Drawing.Point(729, 424);
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.Size = new System.Drawing.Size(134, 43);
            this.btnCheckIn.TabIndex = 34;
            this.btnCheckIn.Text = "Check In";
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // dtpCheckInDate
            // 
            this.dtpCheckInDate.CustomFormat = "";
            this.dtpCheckInDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckInDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckInDate.Location = new System.Drawing.Point(633, 307);
            this.dtpCheckInDate.Name = "dtpCheckInDate";
            this.dtpCheckInDate.Size = new System.Drawing.Size(230, 30);
            this.dtpCheckInDate.TabIndex = 31;
            this.dtpCheckInDate.Value = new System.DateTime(2018, 10, 20, 0, 0, 0, 0);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(548, 424);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(134, 43);
            this.btnNew.TabIndex = 33;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtCheckInPhone
            // 
            this.txtCheckInPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckInPhone.Location = new System.Drawing.Point(633, 184);
            this.txtCheckInPhone.Name = "txtCheckInPhone";
            this.txtCheckInPhone.Size = new System.Drawing.Size(230, 30);
            this.txtCheckInPhone.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(490, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 25);
            this.label9.TabIndex = 36;
            this.label9.Text = "Phone Number";
            // 
            // cboRoomType
            // 
            this.cboRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomType.FormattingEnabled = true;
            this.cboRoomType.Location = new System.Drawing.Point(216, 309);
            this.cboRoomType.Name = "cboRoomType";
            this.cboRoomType.Size = new System.Drawing.Size(230, 33);
            this.cboRoomType.TabIndex = 24;
            this.cboRoomType.SelectedIndexChanged += new System.EventHandler(this.cboRoomType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(486, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Check In Date";
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(633, 240);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(230, 30);
            this.txtDuration.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(490, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 25);
            this.label8.TabIndex = 32;
            this.label8.Text = "Duration";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(101, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Room Type";
            // 
            // cboRoomNo
            // 
            this.cboRoomNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomNo.FormattingEnabled = true;
            this.cboRoomNo.Location = new System.Drawing.Point(216, 374);
            this.cboRoomNo.Name = "cboRoomNo";
            this.cboRoomNo.Size = new System.Drawing.Size(91, 33);
            this.cboRoomNo.TabIndex = 25;
            this.cboRoomNo.SelectedIndexChanged += new System.EventHandler(this.cboRoomNo_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(101, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Room No";
            // 
            // txtCheckInName
            // 
            this.txtCheckInName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckInName.Location = new System.Drawing.Point(216, 242);
            this.txtCheckInName.Name = "txtCheckInName";
            this.txtCheckInName.Size = new System.Drawing.Size(230, 30);
            this.txtCheckInName.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Name";
            // 
            // txtCheckInId
            // 
            this.txtCheckInId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckInId.Location = new System.Drawing.Point(216, 181);
            this.txtCheckInId.Name = "txtCheckInId";
            this.txtCheckInId.ReadOnly = true;
            this.txtCheckInId.Size = new System.Drawing.Size(230, 30);
            this.txtCheckInId.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(101, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 51);
            this.label3.TabIndex = 7;
            this.label3.Text = "Check-In Form";
            // 
            // panelCheckOut
            // 
            this.panelCheckOut.Controls.Add(this.txtCheckInDate1);
            this.panelCheckOut.Controls.Add(this.label17);
            this.panelCheckOut.Controls.Add(this.cboCheckOutName);
            this.panelCheckOut.Controls.Add(this.txtRoomType1);
            this.panelCheckOut.Controls.Add(this.txtRoomNo1);
            this.panelCheckOut.Controls.Add(this.btnCheckOut);
            this.panelCheckOut.Controls.Add(this.dtpCheckOutDate);
            this.panelCheckOut.Controls.Add(this.btnClear);
            this.panelCheckOut.Controls.Add(this.txtCheckOutPhone);
            this.panelCheckOut.Controls.Add(this.label11);
            this.panelCheckOut.Controls.Add(this.label12);
            this.panelCheckOut.Controls.Add(this.txtDuration1);
            this.panelCheckOut.Controls.Add(this.label13);
            this.panelCheckOut.Controls.Add(this.label14);
            this.panelCheckOut.Controls.Add(this.label15);
            this.panelCheckOut.Controls.Add(this.label16);
            this.panelCheckOut.Controls.Add(this.txtCheckOutId);
            this.panelCheckOut.Controls.Add(this.label19);
            this.panelCheckOut.Controls.Add(this.label20);
            this.panelCheckOut.Location = new System.Drawing.Point(180, 58);
            this.panelCheckOut.Name = "panelCheckOut";
            this.panelCheckOut.Size = new System.Drawing.Size(991, 586);
            this.panelCheckOut.TabIndex = 46;
            // 
            // txtCheckInDate1
            // 
            this.txtCheckInDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckInDate1.Location = new System.Drawing.Point(635, 306);
            this.txtCheckInDate1.Name = "txtCheckInDate1";
            this.txtCheckInDate1.ReadOnly = true;
            this.txtCheckInDate1.Size = new System.Drawing.Size(230, 30);
            this.txtCheckInDate1.TabIndex = 32;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(485, 309);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(136, 25);
            this.label17.TabIndex = 40;
            this.label17.Text = "Check In Date";
            // 
            // cboCheckOutName
            // 
            this.cboCheckOutName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCheckOutName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCheckOutName.FormattingEnabled = true;
            this.cboCheckOutName.Location = new System.Drawing.Point(223, 237);
            this.cboCheckOutName.Name = "cboCheckOutName";
            this.cboCheckOutName.Size = new System.Drawing.Size(230, 33);
            this.cboCheckOutName.TabIndex = 25;
            this.cboCheckOutName.SelectedIndexChanged += new System.EventHandler(this.cboCheckOutName_SelectedIndexChanged);
            // 
            // txtRoomType1
            // 
            this.txtRoomType1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomType1.Location = new System.Drawing.Point(223, 306);
            this.txtRoomType1.Name = "txtRoomType1";
            this.txtRoomType1.ReadOnly = true;
            this.txtRoomType1.Size = new System.Drawing.Size(230, 30);
            this.txtRoomType1.TabIndex = 26;
            // 
            // txtRoomNo1
            // 
            this.txtRoomNo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNo1.Location = new System.Drawing.Point(223, 371);
            this.txtRoomNo1.Name = "txtRoomNo1";
            this.txtRoomNo1.ReadOnly = true;
            this.txtRoomNo1.Size = new System.Drawing.Size(230, 30);
            this.txtRoomNo1.TabIndex = 28;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(493, 458);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(134, 43);
            this.btnCheckOut.TabIndex = 35;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // dtpCheckOutDate
            // 
            this.dtpCheckOutDate.CustomFormat = "";
            this.dtpCheckOutDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCheckOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOutDate.Location = new System.Drawing.Point(635, 369);
            this.dtpCheckOutDate.Name = "dtpCheckOutDate";
            this.dtpCheckOutDate.Size = new System.Drawing.Size(230, 30);
            this.dtpCheckOutDate.TabIndex = 34;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(312, 458);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 43);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtCheckOutPhone
            // 
            this.txtCheckOutPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckOutPhone.Location = new System.Drawing.Point(635, 181);
            this.txtCheckOutPhone.Name = "txtCheckOutPhone";
            this.txtCheckOutPhone.ReadOnly = true;
            this.txtCheckOutPhone.Size = new System.Drawing.Size(230, 30);
            this.txtCheckOutPhone.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(485, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 25);
            this.label11.TabIndex = 39;
            this.label11.Text = "Phone Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(481, 374);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 25);
            this.label12.TabIndex = 38;
            this.label12.Text = "Check Out Date";
            // 
            // txtDuration1
            // 
            this.txtDuration1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration1.Location = new System.Drawing.Point(635, 237);
            this.txtDuration1.Name = "txtDuration1";
            this.txtDuration1.ReadOnly = true;
            this.txtDuration1.Size = new System.Drawing.Size(230, 30);
            this.txtDuration1.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(485, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 25);
            this.label13.TabIndex = 37;
            this.label13.Text = "Duration";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(108, 309);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 25);
            this.label14.TabIndex = 33;
            this.label14.Text = "Room Type";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(108, 374);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 25);
            this.label15.TabIndex = 31;
            this.label15.Text = "Room No";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(108, 242);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 25);
            this.label16.TabIndex = 27;
            this.label16.Text = "Name";
            // 
            // txtCheckOutId
            // 
            this.txtCheckOutId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckOutId.Location = new System.Drawing.Point(223, 178);
            this.txtCheckOutId.Name = "txtCheckOutId";
            this.txtCheckOutId.ReadOnly = true;
            this.txtCheckOutId.Size = new System.Drawing.Size(230, 30);
            this.txtCheckOutId.TabIndex = 23;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(108, 181);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 25);
            this.label19.TabIndex = 24;
            this.label19.Text = "ID";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(378, 52);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(266, 51);
            this.label20.TabIndex = 7;
            this.label20.Text = "Check-Out Form";
            // 
            // btnCheckInGuest
            // 
            this.btnCheckInGuest.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckInGuest.Location = new System.Drawing.Point(44, 204);
            this.btnCheckInGuest.Name = "btnCheckInGuest";
            this.btnCheckInGuest.Size = new System.Drawing.Size(105, 46);
            this.btnCheckInGuest.TabIndex = 47;
            this.btnCheckInGuest.Text = "Check In";
            this.btnCheckInGuest.UseVisualStyleBackColor = true;
            this.btnCheckInGuest.Click += new System.EventHandler(this.btnCheckInGuest_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(44, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 46);
            this.button1.TabIndex = 48;
            this.button1.Text = "Check Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GuestForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1175, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCheckInGuest);
            this.Controls.Add(this.panelCheckOut);
            this.Controls.Add(this.panelCheckIn);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.panelGuest);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnGuest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestForm";
            this.Load += new System.EventHandler(this.GuestForm_Load);
            this.panelGuest.ResumeLayout(false);
            this.panelGuest.PerformLayout();
            this.menuGuest.ResumeLayout(false);
            this.panelCheckIn.ResumeLayout(false);
            this.panelCheckIn.PerformLayout();
            this.panelCheckOut.ResumeLayout(false);
            this.panelCheckOut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnGuest;
        private System.Windows.Forms.Panel panelGuest;
        private System.Windows.Forms.ListView lstGuess;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colPhoneNum;
        private System.Windows.Forms.ColumnHeader colRoomNum;
        private System.Windows.Forms.ColumnHeader colDuration;
        private System.Windows.Forms.ColumnHeader colCheckIn;
        private System.Windows.Forms.ColumnHeader colCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbAllGuest;
        private System.Windows.Forms.RadioButton rdbOldGuest;
        private System.Windows.Forms.RadioButton rdbCurrentGuest;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Panel panelCheckIn;
        private System.Windows.Forms.TextBox txtFloor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnCheckIn;
        private System.Windows.Forms.DateTimePicker dtpCheckInDate;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtCheckInPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboRoomType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboRoomNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCheckInName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCheckInId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip menuGuest;
        private System.Windows.Forms.ToolStripMenuItem showAllGuestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCurrentGuestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showOldGuestToolStripMenuItem;
        private System.Windows.Forms.Panel panelCheckOut;
        private System.Windows.Forms.TextBox txtCheckInDate1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboCheckOutName;
        private System.Windows.Forms.TextBox txtRoomType1;
        private System.Windows.Forms.TextBox txtRoomNo1;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckOutDate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtCheckOutPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDuration1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCheckOutId;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnCheckInGuest;
        private System.Windows.Forms.Button button1;
    }
}