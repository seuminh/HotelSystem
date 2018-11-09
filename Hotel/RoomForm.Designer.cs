namespace Hotel
{
    partial class RoomForm
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
            this.panelRoom = new System.Windows.Forms.Panel();
            this.rdbAllRoom = new System.Windows.Forms.RadioButton();
            this.rdbOccupiedRoom = new System.Windows.Forms.RadioButton();
            this.rdbAvailableRoom = new System.Windows.Forms.RadioButton();
            this.lstRoom = new System.Windows.Forms.ListView();
            this.colRoomNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colFloor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuRoom = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showAvailableRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showOccupiedRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllRoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.panelUpdateRoom = new System.Windows.Forms.Panel();
            this.txtFloorUpdateRoom = new System.Windows.Forms.TextBox();
            this.cboRoomNoUpdateRoom = new System.Windows.Forms.ComboBox();
            this.btnClearUpdateRoom = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cboRoomTypeUpdateRoom = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.panelAddRoom = new System.Windows.Forms.Panel();
            this.btnClearAddRoom = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboAddRoomType = new System.Windows.Forms.ComboBox();
            this.txtAddRoomFloor = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtAddRoomId = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.panelRoom.SuspendLayout();
            this.menuRoom.SuspendLayout();
            this.panelUpdateRoom.SuspendLayout();
            this.panelAddRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRoom
            // 
            this.panelRoom.Controls.Add(this.rdbAllRoom);
            this.panelRoom.Controls.Add(this.rdbOccupiedRoom);
            this.panelRoom.Controls.Add(this.rdbAvailableRoom);
            this.panelRoom.Controls.Add(this.lstRoom);
            this.panelRoom.Controls.Add(this.Label2);
            this.panelRoom.Location = new System.Drawing.Point(155, 56);
            this.panelRoom.Name = "panelRoom";
            this.panelRoom.Size = new System.Drawing.Size(807, 484);
            this.panelRoom.TabIndex = 5;
            // 
            // rdbAllRoom
            // 
            this.rdbAllRoom.AutoSize = true;
            this.rdbAllRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAllRoom.Location = new System.Drawing.Point(628, 284);
            this.rdbAllRoom.Name = "rdbAllRoom";
            this.rdbAllRoom.Size = new System.Drawing.Size(90, 22);
            this.rdbAllRoom.TabIndex = 11;
            this.rdbAllRoom.TabStop = true;
            this.rdbAllRoom.Text = "All Room";
            this.rdbAllRoom.UseVisualStyleBackColor = true;
            this.rdbAllRoom.CheckedChanged += new System.EventHandler(this.rdbAllRoom_CheckedChanged);
            // 
            // rdbOccupiedRoom
            // 
            this.rdbOccupiedRoom.AutoSize = true;
            this.rdbOccupiedRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOccupiedRoom.Location = new System.Drawing.Point(628, 240);
            this.rdbOccupiedRoom.Name = "rdbOccupiedRoom";
            this.rdbOccupiedRoom.Size = new System.Drawing.Size(138, 22);
            this.rdbOccupiedRoom.TabIndex = 10;
            this.rdbOccupiedRoom.TabStop = true;
            this.rdbOccupiedRoom.Text = "Occupied Room";
            this.rdbOccupiedRoom.UseVisualStyleBackColor = true;
            this.rdbOccupiedRoom.CheckedChanged += new System.EventHandler(this.rdbOccupiedRoom_CheckedChanged);
            // 
            // rdbAvailableRoom
            // 
            this.rdbAvailableRoom.AutoSize = true;
            this.rdbAvailableRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAvailableRoom.Location = new System.Drawing.Point(628, 197);
            this.rdbAvailableRoom.Name = "rdbAvailableRoom";
            this.rdbAvailableRoom.Size = new System.Drawing.Size(132, 22);
            this.rdbAvailableRoom.TabIndex = 9;
            this.rdbAvailableRoom.TabStop = true;
            this.rdbAvailableRoom.Text = "Available Room";
            this.rdbAvailableRoom.UseVisualStyleBackColor = true;
            this.rdbAvailableRoom.CheckedChanged += new System.EventHandler(this.rdbAvailableRoom_CheckedChanged);
            // 
            // lstRoom
            // 
            this.lstRoom.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstRoom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRoomNo,
            this.colRoomType,
            this.colFloor,
            this.colStatus});
            this.lstRoom.ContextMenuStrip = this.menuRoom;
            this.lstRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRoom.FullRowSelect = true;
            this.lstRoom.GridLines = true;
            this.lstRoom.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstRoom.Location = new System.Drawing.Point(48, 88);
            this.lstRoom.MultiSelect = false;
            this.lstRoom.Name = "lstRoom";
            this.lstRoom.Size = new System.Drawing.Size(560, 367);
            this.lstRoom.TabIndex = 8;
            this.lstRoom.TileSize = new System.Drawing.Size(300, 50);
            this.lstRoom.UseCompatibleStateImageBehavior = false;
            this.lstRoom.View = System.Windows.Forms.View.Details;
            // 
            // colRoomNo
            // 
            this.colRoomNo.Text = "Room No";
            this.colRoomNo.Width = 100;
            // 
            // colRoomType
            // 
            this.colRoomType.Text = "Room Type";
            this.colRoomType.Width = 160;
            // 
            // colFloor
            // 
            this.colFloor.Text = "Floor";
            this.colFloor.Width = 130;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 160;
            // 
            // menuRoom
            // 
            this.menuRoom.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuRoom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAvailableRoomToolStripMenuItem,
            this.showOccupiedRoomToolStripMenuItem,
            this.showAllRoomsToolStripMenuItem});
            this.menuRoom.Name = "menuRoom";
            this.menuRoom.Size = new System.Drawing.Size(228, 76);
            // 
            // showAvailableRoomToolStripMenuItem
            // 
            this.showAvailableRoomToolStripMenuItem.Name = "showAvailableRoomToolStripMenuItem";
            this.showAvailableRoomToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.showAvailableRoomToolStripMenuItem.Text = "Show Available rooms";
            this.showAvailableRoomToolStripMenuItem.Click += new System.EventHandler(this.showAvailableRoomToolStripMenuItem_Click);
            // 
            // showOccupiedRoomToolStripMenuItem
            // 
            this.showOccupiedRoomToolStripMenuItem.Name = "showOccupiedRoomToolStripMenuItem";
            this.showOccupiedRoomToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.showOccupiedRoomToolStripMenuItem.Text = "Show Occupied rooms";
            this.showOccupiedRoomToolStripMenuItem.Click += new System.EventHandler(this.showOccupiedRoomToolStripMenuItem_Click);
            // 
            // showAllRoomsToolStripMenuItem
            // 
            this.showAllRoomsToolStripMenuItem.Name = "showAllRoomsToolStripMenuItem";
            this.showAllRoomsToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.showAllRoomsToolStripMenuItem.Text = "Show All rooms";
            this.showAllRoomsToolStripMenuItem.Click += new System.EventHandler(this.showAllRoomsToolStripMenuItem_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(259, 23);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(107, 51);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Room";
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRoom.Location = new System.Drawing.Point(44, 278);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(105, 46);
            this.btnUpdateRoom.TabIndex = 6;
            this.btnUpdateRoom.Text = "Update Room";
            this.btnUpdateRoom.UseVisualStyleBackColor = true;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRoom.Location = new System.Drawing.Point(44, 194);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(105, 46);
            this.btnAddRoom.TabIndex = 5;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.Location = new System.Drawing.Point(44, 113);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(105, 46);
            this.btnRoom.TabIndex = 7;
            this.btnRoom.Text = "Room";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            // 
            // panelUpdateRoom
            // 
            this.panelUpdateRoom.Controls.Add(this.txtFloorUpdateRoom);
            this.panelUpdateRoom.Controls.Add(this.cboRoomNoUpdateRoom);
            this.panelUpdateRoom.Controls.Add(this.btnClearUpdateRoom);
            this.panelUpdateRoom.Controls.Add(this.btnUpdate);
            this.panelUpdateRoom.Controls.Add(this.cboRoomTypeUpdateRoom);
            this.panelUpdateRoom.Controls.Add(this.label25);
            this.panelUpdateRoom.Controls.Add(this.label26);
            this.panelUpdateRoom.Controls.Add(this.label27);
            this.panelUpdateRoom.Controls.Add(this.label28);
            this.panelUpdateRoom.Location = new System.Drawing.Point(155, 56);
            this.panelUpdateRoom.Name = "panelUpdateRoom";
            this.panelUpdateRoom.Size = new System.Drawing.Size(807, 484);
            this.panelUpdateRoom.TabIndex = 33;
            // 
            // txtFloorUpdateRoom
            // 
            this.txtFloorUpdateRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFloorUpdateRoom.Location = new System.Drawing.Point(343, 301);
            this.txtFloorUpdateRoom.Name = "txtFloorUpdateRoom";
            this.txtFloorUpdateRoom.ReadOnly = true;
            this.txtFloorUpdateRoom.Size = new System.Drawing.Size(230, 30);
            this.txtFloorUpdateRoom.TabIndex = 33;
            // 
            // cboRoomNoUpdateRoom
            // 
            this.cboRoomNoUpdateRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoomNoUpdateRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomNoUpdateRoom.FormattingEnabled = true;
            this.cboRoomNoUpdateRoom.Location = new System.Drawing.Point(343, 157);
            this.cboRoomNoUpdateRoom.Name = "cboRoomNoUpdateRoom";
            this.cboRoomNoUpdateRoom.Size = new System.Drawing.Size(230, 33);
            this.cboRoomNoUpdateRoom.TabIndex = 32;
            this.cboRoomNoUpdateRoom.SelectedIndexChanged += new System.EventHandler(this.cboRoomNoUpdateRoom_SelectedIndexChanged);
            this.cboRoomNoUpdateRoom.Click += new System.EventHandler(this.cboRoomNoUpdateRoom_Click);
            // 
            // btnClearUpdateRoom
            // 
            this.btnClearUpdateRoom.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearUpdateRoom.Location = new System.Drawing.Point(468, 398);
            this.btnClearUpdateRoom.Name = "btnClearUpdateRoom";
            this.btnClearUpdateRoom.Size = new System.Drawing.Size(105, 46);
            this.btnClearUpdateRoom.TabIndex = 31;
            this.btnClearUpdateRoom.Text = "Clear";
            this.btnClearUpdateRoom.UseVisualStyleBackColor = true;
            this.btnClearUpdateRoom.Click += new System.EventHandler(this.btnClearUpdateRoom_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(278, 398);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 46);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cboRoomTypeUpdateRoom
            // 
            this.cboRoomTypeUpdateRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoomTypeUpdateRoom.FormattingEnabled = true;
            this.cboRoomTypeUpdateRoom.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple",
            "Quad"});
            this.cboRoomTypeUpdateRoom.Location = new System.Drawing.Point(343, 228);
            this.cboRoomTypeUpdateRoom.Name = "cboRoomTypeUpdateRoom";
            this.cboRoomTypeUpdateRoom.Size = new System.Drawing.Size(230, 33);
            this.cboRoomTypeUpdateRoom.TabIndex = 30;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(228, 304);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(56, 25);
            this.label25.TabIndex = 29;
            this.label25.Text = "Floor";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(228, 231);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(113, 25);
            this.label26.TabIndex = 27;
            this.label26.Text = "Room Type";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(228, 160);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(93, 25);
            this.label27.TabIndex = 25;
            this.label27.Text = "Room No";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(324, 57);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(228, 51);
            this.label28.TabIndex = 7;
            this.label28.Text = "Update Room";
            // 
            // panelAddRoom
            // 
            this.panelAddRoom.Controls.Add(this.btnClearAddRoom);
            this.panelAddRoom.Controls.Add(this.btnAdd);
            this.panelAddRoom.Controls.Add(this.cboAddRoomType);
            this.panelAddRoom.Controls.Add(this.txtAddRoomFloor);
            this.panelAddRoom.Controls.Add(this.label24);
            this.panelAddRoom.Controls.Add(this.label23);
            this.panelAddRoom.Controls.Add(this.txtAddRoomId);
            this.panelAddRoom.Controls.Add(this.label22);
            this.panelAddRoom.Controls.Add(this.label21);
            this.panelAddRoom.Location = new System.Drawing.Point(155, 56);
            this.panelAddRoom.Name = "panelAddRoom";
            this.panelAddRoom.Size = new System.Drawing.Size(807, 484);
            this.panelAddRoom.TabIndex = 34;
            // 
            // btnClearAddRoom
            // 
            this.btnClearAddRoom.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAddRoom.Location = new System.Drawing.Point(468, 398);
            this.btnClearAddRoom.Name = "btnClearAddRoom";
            this.btnClearAddRoom.Size = new System.Drawing.Size(105, 46);
            this.btnClearAddRoom.TabIndex = 31;
            this.btnClearAddRoom.Text = "Clear";
            this.btnClearAddRoom.UseVisualStyleBackColor = true;
            this.btnClearAddRoom.Click += new System.EventHandler(this.btnClearAddRoom_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(278, 398);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 46);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cboAddRoomType
            // 
            this.cboAddRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAddRoomType.FormattingEnabled = true;
            this.cboAddRoomType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple",
            "Quad"});
            this.cboAddRoomType.Location = new System.Drawing.Point(343, 223);
            this.cboAddRoomType.Name = "cboAddRoomType";
            this.cboAddRoomType.Size = new System.Drawing.Size(230, 33);
            this.cboAddRoomType.TabIndex = 30;
            // 
            // txtAddRoomFloor
            // 
            this.txtAddRoomFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddRoomFloor.Location = new System.Drawing.Point(343, 301);
            this.txtAddRoomFloor.Name = "txtAddRoomFloor";
            this.txtAddRoomFloor.Size = new System.Drawing.Size(230, 30);
            this.txtAddRoomFloor.TabIndex = 28;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(228, 304);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 25);
            this.label24.TabIndex = 29;
            this.label24.Text = "Floor";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(228, 231);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(113, 25);
            this.label23.TabIndex = 27;
            this.label23.Text = "Room Type";
            // 
            // txtAddRoomId
            // 
            this.txtAddRoomId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddRoomId.Location = new System.Drawing.Point(343, 157);
            this.txtAddRoomId.Name = "txtAddRoomId";
            this.txtAddRoomId.Size = new System.Drawing.Size(230, 30);
            this.txtAddRoomId.TabIndex = 24;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(228, 160);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(31, 25);
            this.label22.TabIndex = 25;
            this.label22.Text = "ID";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(324, 57);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(178, 51);
            this.label21.TabIndex = 7;
            this.label21.Text = "Add Room";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainMenu.Location = new System.Drawing.Point(44, 455);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(105, 46);
            this.btnMainMenu.TabIndex = 37;
            this.btnMainMenu.Text = "MainMenu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Window;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Hotel.Properties.Resources.cancel;
            this.btnClose.Location = new System.Drawing.Point(931, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 30);
            this.btnClose.TabIndex = 36;
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
            this.btnMin.Location = new System.Drawing.Point(895, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(31, 30);
            this.btnMin.TabIndex = 35;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // RoomForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(965, 565);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.panelAddRoom);
            this.Controls.Add(this.panelUpdateRoom);
            this.Controls.Add(this.btnRoom);
            this.Controls.Add(this.panelRoom);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.btnUpdateRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            this.panelRoom.ResumeLayout(false);
            this.panelRoom.PerformLayout();
            this.menuRoom.ResumeLayout(false);
            this.panelUpdateRoom.ResumeLayout(false);
            this.panelUpdateRoom.PerformLayout();
            this.panelAddRoom.ResumeLayout(false);
            this.panelAddRoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRoom;
        private System.Windows.Forms.ListView lstRoom;
        private System.Windows.Forms.ColumnHeader colRoomNo;
        private System.Windows.Forms.ColumnHeader colRoomType;
        private System.Windows.Forms.ColumnHeader colFloor;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button btnUpdateRoom;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Panel panelUpdateRoom;
        private System.Windows.Forms.TextBox txtFloorUpdateRoom;
        private System.Windows.Forms.ComboBox cboRoomNoUpdateRoom;
        private System.Windows.Forms.Button btnClearUpdateRoom;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cboRoomTypeUpdateRoom;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Panel panelAddRoom;
        private System.Windows.Forms.Button btnClearAddRoom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cboAddRoomType;
        private System.Windows.Forms.TextBox txtAddRoomFloor;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtAddRoomId;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.RadioButton rdbAllRoom;
        private System.Windows.Forms.RadioButton rdbOccupiedRoom;
        private System.Windows.Forms.RadioButton rdbAvailableRoom;
        private System.Windows.Forms.ContextMenuStrip menuRoom;
        private System.Windows.Forms.ToolStripMenuItem showAvailableRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showOccupiedRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllRoomsToolStripMenuItem;
    }
}