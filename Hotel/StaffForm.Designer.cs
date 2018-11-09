namespace Hotel
{
    partial class StaffForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.panelAddStaff = new System.Windows.Forms.Panel();
            this.cboAddStaffSex = new System.Windows.Forms.ComboBox();
            this.txtAddStaffName = new System.Windows.Forms.TextBox();
            this.txtAddStaffSalary = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAddSaffPos = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpAddStaffDob = new System.Windows.Forms.DateTimePicker();
            this.btnAddStaffNew = new System.Windows.Forms.Button();
            this.txtAddStaffPhone = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAddStaffAddress = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAddStaffId = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panelUpdateStaff = new System.Windows.Forms.Panel();
            this.cboUpdateStopWork = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboUpdateName = new System.Windows.Forms.ComboBox();
            this.cboUpdateSex = new System.Windows.Forms.ComboBox();
            this.txtUpdateSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUpdatePos = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dtpUpdateDob = new System.Windows.Forms.DateTimePicker();
            this.btnUpdateStaffNew = new System.Windows.Forms.Button();
            this.txtUpdatePhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUpdateAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panelStaff = new System.Windows.Forms.Panel();
            this.lstStaff = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPosition = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhoneNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSalary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHiredDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colResignDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label27 = new System.Windows.Forms.Label();
            this.panelAddStaff.SuspendLayout();
            this.panelUpdateStaff.SuspendLayout();
            this.panelStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Window;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Hotel.Properties.Resources.cancel;
            this.btnClose.Location = new System.Drawing.Point(1343, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 36);
            this.btnClose.TabIndex = 46;
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
            this.btnMin.Location = new System.Drawing.Point(1301, 2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(38, 36);
            this.btnMin.TabIndex = 45;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainMenu.Location = new System.Drawing.Point(44, 575);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(105, 46);
            this.btnMainMenu.TabIndex = 3;
            this.btnMainMenu.Text = "MainMenu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.Location = new System.Drawing.Point(44, 129);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(105, 46);
            this.btnStaff.TabIndex = 0;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.Location = new System.Drawing.Point(44, 204);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(105, 46);
            this.btnAddStaff.TabIndex = 1;
            this.btnAddStaff.Text = "Add Staff";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Font = new System.Drawing.Font("Monotype Corsiva", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInfo.Location = new System.Drawing.Point(44, 279);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(105, 46);
            this.btnUpdateInfo.TabIndex = 2;
            this.btnUpdateInfo.Text = "Update Info";
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // panelAddStaff
            // 
            this.panelAddStaff.Controls.Add(this.cboAddStaffSex);
            this.panelAddStaff.Controls.Add(this.txtAddStaffName);
            this.panelAddStaff.Controls.Add(this.txtAddStaffSalary);
            this.panelAddStaff.Controls.Add(this.label17);
            this.panelAddStaff.Controls.Add(this.txtAddSaffPos);
            this.panelAddStaff.Controls.Add(this.btnAdd);
            this.panelAddStaff.Controls.Add(this.dtpAddStaffDob);
            this.panelAddStaff.Controls.Add(this.btnAddStaffNew);
            this.panelAddStaff.Controls.Add(this.txtAddStaffPhone);
            this.panelAddStaff.Controls.Add(this.label11);
            this.panelAddStaff.Controls.Add(this.label12);
            this.panelAddStaff.Controls.Add(this.txtAddStaffAddress);
            this.panelAddStaff.Controls.Add(this.label13);
            this.panelAddStaff.Controls.Add(this.label14);
            this.panelAddStaff.Controls.Add(this.label15);
            this.panelAddStaff.Controls.Add(this.label16);
            this.panelAddStaff.Controls.Add(this.txtAddStaffId);
            this.panelAddStaff.Controls.Add(this.label19);
            this.panelAddStaff.Controls.Add(this.label20);
            this.panelAddStaff.Location = new System.Drawing.Point(180, 58);
            this.panelAddStaff.Name = "panelAddStaff";
            this.panelAddStaff.Size = new System.Drawing.Size(1192, 586);
            this.panelAddStaff.TabIndex = 52;
            // 
            // cboAddStaffSex
            // 
            this.cboAddStaffSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddStaffSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAddStaffSex.FormattingEnabled = true;
            this.cboAddStaffSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboAddStaffSex.Location = new System.Drawing.Point(279, 306);
            this.cboAddStaffSex.Name = "cboAddStaffSex";
            this.cboAddStaffSex.Size = new System.Drawing.Size(230, 33);
            this.cboAddStaffSex.TabIndex = 2;
            // 
            // txtAddStaffName
            // 
            this.txtAddStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddStaffName.Location = new System.Drawing.Point(279, 242);
            this.txtAddStaffName.Name = "txtAddStaffName";
            this.txtAddStaffName.Size = new System.Drawing.Size(230, 30);
            this.txtAddStaffName.TabIndex = 1;
            // 
            // txtAddStaffSalary
            // 
            this.txtAddStaffSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddStaffSalary.Location = new System.Drawing.Point(691, 306);
            this.txtAddStaffSalary.Name = "txtAddStaffSalary";
            this.txtAddStaffSalary.Size = new System.Drawing.Size(230, 30);
            this.txtAddStaffSalary.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(541, 309);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(68, 25);
            this.label17.TabIndex = 40;
            this.label17.Text = "Salary";
            // 
            // txtAddSaffPos
            // 
            this.txtAddSaffPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddSaffPos.Location = new System.Drawing.Point(279, 371);
            this.txtAddSaffPos.Name = "txtAddSaffPos";
            this.txtAddSaffPos.Size = new System.Drawing.Size(230, 30);
            this.txtAddSaffPos.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(549, 458);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(134, 43);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpAddStaffDob
            // 
            this.dtpAddStaffDob.CustomFormat = "";
            this.dtpAddStaffDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpAddStaffDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAddStaffDob.Location = new System.Drawing.Point(691, 369);
            this.dtpAddStaffDob.Name = "dtpAddStaffDob";
            this.dtpAddStaffDob.Size = new System.Drawing.Size(230, 30);
            this.dtpAddStaffDob.TabIndex = 7;
            // 
            // btnAddStaffNew
            // 
            this.btnAddStaffNew.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaffNew.Location = new System.Drawing.Point(368, 458);
            this.btnAddStaffNew.Name = "btnAddStaffNew";
            this.btnAddStaffNew.Size = new System.Drawing.Size(134, 43);
            this.btnAddStaffNew.TabIndex = 8;
            this.btnAddStaffNew.Text = "New";
            this.btnAddStaffNew.UseVisualStyleBackColor = true;
            this.btnAddStaffNew.Click += new System.EventHandler(this.btnAddStaffNew_Click);
            // 
            // txtAddStaffPhone
            // 
            this.txtAddStaffPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddStaffPhone.Location = new System.Drawing.Point(691, 181);
            this.txtAddStaffPhone.Name = "txtAddStaffPhone";
            this.txtAddStaffPhone.Size = new System.Drawing.Size(230, 30);
            this.txtAddStaffPhone.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(541, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 25);
            this.label11.TabIndex = 39;
            this.label11.Text = "Phone Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(537, 374);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 25);
            this.label12.TabIndex = 38;
            this.label12.Text = "Date Of Birth";
            // 
            // txtAddStaffAddress
            // 
            this.txtAddStaffAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddStaffAddress.Location = new System.Drawing.Point(691, 242);
            this.txtAddStaffAddress.Name = "txtAddStaffAddress";
            this.txtAddStaffAddress.Size = new System.Drawing.Size(230, 30);
            this.txtAddStaffAddress.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(541, 245);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 25);
            this.label13.TabIndex = 37;
            this.label13.Text = "Address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(164, 309);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 25);
            this.label14.TabIndex = 33;
            this.label14.Text = "Sex";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(164, 374);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 25);
            this.label15.TabIndex = 31;
            this.label15.Text = "Position";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(164, 242);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 25);
            this.label16.TabIndex = 27;
            this.label16.Text = "Name";
            // 
            // txtAddStaffId
            // 
            this.txtAddStaffId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddStaffId.Location = new System.Drawing.Point(279, 178);
            this.txtAddStaffId.Name = "txtAddStaffId";
            this.txtAddStaffId.ReadOnly = true;
            this.txtAddStaffId.Size = new System.Drawing.Size(230, 30);
            this.txtAddStaffId.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(164, 181);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 25);
            this.label19.TabIndex = 24;
            this.label19.Text = "ID";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(457, 36);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(169, 51);
            this.label20.TabIndex = 7;
            this.label20.Text = "Add Staff";
            // 
            // panelUpdateStaff
            // 
            this.panelUpdateStaff.Controls.Add(this.cboUpdateStopWork);
            this.panelUpdateStaff.Controls.Add(this.label8);
            this.panelUpdateStaff.Controls.Add(this.cboUpdateName);
            this.panelUpdateStaff.Controls.Add(this.cboUpdateSex);
            this.panelUpdateStaff.Controls.Add(this.txtUpdateSalary);
            this.panelUpdateStaff.Controls.Add(this.label1);
            this.panelUpdateStaff.Controls.Add(this.txtUpdatePos);
            this.panelUpdateStaff.Controls.Add(this.btnUpdate);
            this.panelUpdateStaff.Controls.Add(this.dtpUpdateDob);
            this.panelUpdateStaff.Controls.Add(this.btnUpdateStaffNew);
            this.panelUpdateStaff.Controls.Add(this.txtUpdatePhone);
            this.panelUpdateStaff.Controls.Add(this.label2);
            this.panelUpdateStaff.Controls.Add(this.label3);
            this.panelUpdateStaff.Controls.Add(this.txtUpdateAddress);
            this.panelUpdateStaff.Controls.Add(this.label4);
            this.panelUpdateStaff.Controls.Add(this.label5);
            this.panelUpdateStaff.Controls.Add(this.label6);
            this.panelUpdateStaff.Controls.Add(this.label7);
            this.panelUpdateStaff.Controls.Add(this.label9);
            this.panelUpdateStaff.Location = new System.Drawing.Point(180, 58);
            this.panelUpdateStaff.Name = "panelUpdateStaff";
            this.panelUpdateStaff.Size = new System.Drawing.Size(1192, 586);
            this.panelUpdateStaff.TabIndex = 53;
            // 
            // cboUpdateStopWork
            // 
            this.cboUpdateStopWork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdateStopWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUpdateStopWork.FormattingEnabled = true;
            this.cboUpdateStopWork.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboUpdateStopWork.Location = new System.Drawing.Point(689, 373);
            this.cboUpdateStopWork.Name = "cboUpdateStopWork";
            this.cboUpdateStopWork.Size = new System.Drawing.Size(230, 33);
            this.cboUpdateStopWork.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(539, 376);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 44;
            this.label8.Text = "Stop Work";
            // 
            // cboUpdateName
            // 
            this.cboUpdateName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUpdateName.FormattingEnabled = true;
            this.cboUpdateName.Location = new System.Drawing.Point(272, 178);
            this.cboUpdateName.Name = "cboUpdateName";
            this.cboUpdateName.Size = new System.Drawing.Size(230, 33);
            this.cboUpdateName.TabIndex = 0;
            this.cboUpdateName.SelectedIndexChanged += new System.EventHandler(this.cboUpdateName_SelectedIndexChanged);
            // 
            // cboUpdateSex
            // 
            this.cboUpdateSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUpdateSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUpdateSex.FormattingEnabled = true;
            this.cboUpdateSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboUpdateSex.Location = new System.Drawing.Point(272, 248);
            this.cboUpdateSex.Name = "cboUpdateSex";
            this.cboUpdateSex.Size = new System.Drawing.Size(230, 33);
            this.cboUpdateSex.TabIndex = 1;
            // 
            // txtUpdateSalary
            // 
            this.txtUpdateSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateSalary.Location = new System.Drawing.Point(689, 245);
            this.txtUpdateSalary.Name = "txtUpdateSalary";
            this.txtUpdateSalary.Size = new System.Drawing.Size(230, 30);
            this.txtUpdateSalary.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(539, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Salary";
            // 
            // txtUpdatePos
            // 
            this.txtUpdatePos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatePos.Location = new System.Drawing.Point(272, 313);
            this.txtUpdatePos.Name = "txtUpdatePos";
            this.txtUpdatePos.Size = new System.Drawing.Size(230, 30);
            this.txtUpdatePos.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(549, 458);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(134, 43);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtpUpdateDob
            // 
            this.dtpUpdateDob.CustomFormat = "";
            this.dtpUpdateDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpUpdateDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUpdateDob.Location = new System.Drawing.Point(689, 308);
            this.dtpUpdateDob.Name = "dtpUpdateDob";
            this.dtpUpdateDob.Size = new System.Drawing.Size(230, 30);
            this.dtpUpdateDob.TabIndex = 6;
            // 
            // btnUpdateStaffNew
            // 
            this.btnUpdateStaffNew.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStaffNew.Location = new System.Drawing.Point(368, 458);
            this.btnUpdateStaffNew.Name = "btnUpdateStaffNew";
            this.btnUpdateStaffNew.Size = new System.Drawing.Size(134, 43);
            this.btnUpdateStaffNew.TabIndex = 8;
            this.btnUpdateStaffNew.Text = "New";
            this.btnUpdateStaffNew.UseVisualStyleBackColor = true;
            this.btnUpdateStaffNew.Click += new System.EventHandler(this.btnUpdateStaffNew_Click);
            // 
            // txtUpdatePhone
            // 
            this.txtUpdatePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdatePhone.Location = new System.Drawing.Point(272, 371);
            this.txtUpdatePhone.Name = "txtUpdatePhone";
            this.txtUpdatePhone.Size = new System.Drawing.Size(230, 30);
            this.txtUpdatePhone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Phone Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(539, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Date Of Birth";
            // 
            // txtUpdateAddress
            // 
            this.txtUpdateAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateAddress.Location = new System.Drawing.Point(689, 181);
            this.txtUpdateAddress.Name = "txtUpdateAddress";
            this.txtUpdateAddress.Size = new System.Drawing.Size(230, 30);
            this.txtUpdateAddress.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(539, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 25);
            this.label4.TabIndex = 37;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(157, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Sex";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(157, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Position";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(157, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(457, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 51);
            this.label9.TabIndex = 7;
            this.label9.Text = "Update Staff";
            // 
            // panelStaff
            // 
            this.panelStaff.Controls.Add(this.lstStaff);
            this.panelStaff.Controls.Add(this.label27);
            this.panelStaff.Location = new System.Drawing.Point(180, 58);
            this.panelStaff.Name = "panelStaff";
            this.panelStaff.Size = new System.Drawing.Size(1192, 586);
            this.panelStaff.TabIndex = 54;
            // 
            // lstStaff
            // 
            this.lstStaff.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstStaff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colName,
            this.colSex,
            this.colPosition,
            this.colPhoneNum,
            this.colAddress,
            this.colSalary,
            this.colDob,
            this.colHiredDate,
            this.colResignDate});
            this.lstStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStaff.FullRowSelect = true;
            this.lstStaff.GridLines = true;
            this.lstStaff.Location = new System.Drawing.Point(26, 86);
            this.lstStaff.Name = "lstStaff";
            this.lstStaff.Size = new System.Drawing.Size(995, 492);
            this.lstStaff.TabIndex = 1;
            this.lstStaff.UseCompatibleStateImageBehavior = false;
            this.lstStaff.View = System.Windows.Forms.View.Details;
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
            // colSex
            // 
            this.colSex.Text = "Sex";
            this.colSex.Width = 70;
            // 
            // colPosition
            // 
            this.colPosition.Text = "Position";
            this.colPosition.Width = 70;
            // 
            // colPhoneNum
            // 
            this.colPhoneNum.Text = "Phone Num";
            this.colPhoneNum.Width = 110;
            // 
            // colAddress
            // 
            this.colAddress.Text = "Address";
            this.colAddress.Width = 130;
            // 
            // colSalary
            // 
            this.colSalary.Text = "Salary";
            this.colSalary.Width = 70;
            // 
            // colDob
            // 
            this.colDob.Text = "Date Of Birth";
            this.colDob.Width = 120;
            // 
            // colHiredDate
            // 
            this.colHiredDate.Text = "Hired Date";
            this.colHiredDate.Width = 120;
            // 
            // colResignDate
            // 
            this.colResignDate.Text = "Resign Date";
            this.colResignDate.Width = 120;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Monotype Corsiva", 25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(489, 11);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(98, 51);
            this.label27.TabIndex = 1;
            this.label27.Text = "Staff";
            // 
            // StaffForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1384, 680);
            this.Controls.Add(this.panelStaff);
            this.Controls.Add(this.panelUpdateStaff);
            this.Controls.Add(this.panelAddStaff);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnStaff);
            this.Controls.Add(this.btnAddStaff);
            this.Controls.Add(this.btnUpdateInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.panelAddStaff.ResumeLayout(false);
            this.panelAddStaff.PerformLayout();
            this.panelUpdateStaff.ResumeLayout(false);
            this.panelUpdateStaff.PerformLayout();
            this.panelStaff.ResumeLayout(false);
            this.panelStaff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.Panel panelAddStaff;
        private System.Windows.Forms.TextBox txtAddStaffName;
        private System.Windows.Forms.TextBox txtAddStaffSalary;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAddSaffPos;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpAddStaffDob;
        private System.Windows.Forms.Button btnAddStaffNew;
        private System.Windows.Forms.TextBox txtAddStaffPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAddStaffAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAddStaffId;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cboAddStaffSex;
        private System.Windows.Forms.Panel panelUpdateStaff;
        private System.Windows.Forms.ComboBox cboUpdateStopWork;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboUpdateName;
        private System.Windows.Forms.TextBox txtUpdateSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUpdatePos;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dtpUpdateDob;
        private System.Windows.Forms.Button btnUpdateStaffNew;
        private System.Windows.Forms.TextBox txtUpdatePhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUpdateAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboUpdateSex;
        private System.Windows.Forms.Panel panelStaff;
        private System.Windows.Forms.ListView lstStaff;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSex;
        private System.Windows.Forms.ColumnHeader colPosition;
        private System.Windows.Forms.ColumnHeader colPhoneNum;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.ColumnHeader colSalary;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ColumnHeader colDob;
        private System.Windows.Forms.ColumnHeader colHiredDate;
        private System.Windows.Forms.ColumnHeader colResignDate;
    }
}