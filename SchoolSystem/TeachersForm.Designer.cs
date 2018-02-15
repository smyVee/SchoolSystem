namespace SchoolSystem
{
    partial class TeachersForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtTeacherRegA = new System.Windows.Forms.TextBox();
            this.lblQNameA = new System.Windows.Forms.Label();
            this.btnExitA = new System.Windows.Forms.Button();
            this.btnAddA = new System.Windows.Forms.Button();
            this.txtPostcodeA = new System.Windows.Forms.TextBox();
            this.txtSuburbA = new System.Windows.Forms.TextBox();
            this.txtAddress2A = new System.Windows.Forms.TextBox();
            this.txtAddress1A = new System.Windows.Forms.TextBox();
            this.txtPhoneA = new System.Windows.Forms.TextBox();
            this.txtLastNameA = new System.Windows.Forms.TextBox();
            this.txtFirstNameA = new System.Windows.Forms.TextBox();
            this.cmbStateA = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirthA = new System.Windows.Forms.DateTimePicker();
            this.lblTeacherRegA = new System.Windows.Forms.Label();
            this.lblPostcodeA = new System.Windows.Forms.Label();
            this.lblStateA = new System.Windows.Forms.Label();
            this.lblSuburbA = new System.Windows.Forms.Label();
            this.lblAddress2A = new System.Windows.Forms.Label();
            this.lblAddress1A = new System.Windows.Forms.Label();
            this.lblPhoneA = new System.Windows.Forms.Label();
            this.lblDateOfBirthA = new System.Windows.Forms.Label();
            this.lblLastNameA = new System.Windows.Forms.Label();
            this.lblFirstNameA = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtTeacherRegU = new System.Windows.Forms.TextBox();
            this.lblTeacherIDU = new System.Windows.Forms.Label();
            this.cmbTeacherIDU = new System.Windows.Forms.ComboBox();
            this.schoolDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDBDataSet = new SchoolSystem.SchoolDBDataSet();
            this.btnDeleteU = new System.Windows.Forms.Button();
            this.btnExitU = new System.Windows.Forms.Button();
            this.btnUpdateU = new System.Windows.Forms.Button();
            this.txtPostcodeU = new System.Windows.Forms.TextBox();
            this.txtSuburbU = new System.Windows.Forms.TextBox();
            this.txtAddress2U = new System.Windows.Forms.TextBox();
            this.txtAddress1U = new System.Windows.Forms.TextBox();
            this.txtPhoneU = new System.Windows.Forms.TextBox();
            this.txtLastNameU = new System.Windows.Forms.TextBox();
            this.txtFirstNameU = new System.Windows.Forms.TextBox();
            this.cmbStateU = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirthU = new System.Windows.Forms.DateTimePicker();
            this.lblTeacherRegU = new System.Windows.Forms.Label();
            this.lblPostcodeU = new System.Windows.Forms.Label();
            this.lblStateU = new System.Windows.Forms.Label();
            this.lblSuburbU = new System.Windows.Forms.Label();
            this.lblAddress2U = new System.Windows.Forms.Label();
            this.lblAddress1U = new System.Windows.Forms.Label();
            this.lblPhoneU = new System.Windows.Forms.Label();
            this.lblDateOfBirthU = new System.Windows.Forms.Label();
            this.lblLastNameU = new System.Windows.Forms.Label();
            this.lblFirstNameU = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(503, 361);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtTeacherRegA);
            this.tabPage1.Controls.Add(this.lblQNameA);
            this.tabPage1.Controls.Add(this.btnExitA);
            this.tabPage1.Controls.Add(this.btnAddA);
            this.tabPage1.Controls.Add(this.txtPostcodeA);
            this.tabPage1.Controls.Add(this.txtSuburbA);
            this.tabPage1.Controls.Add(this.txtAddress2A);
            this.tabPage1.Controls.Add(this.txtAddress1A);
            this.tabPage1.Controls.Add(this.txtPhoneA);
            this.tabPage1.Controls.Add(this.txtLastNameA);
            this.tabPage1.Controls.Add(this.txtFirstNameA);
            this.tabPage1.Controls.Add(this.cmbStateA);
            this.tabPage1.Controls.Add(this.dtpDateOfBirthA);
            this.tabPage1.Controls.Add(this.lblTeacherRegA);
            this.tabPage1.Controls.Add(this.lblPostcodeA);
            this.tabPage1.Controls.Add(this.lblStateA);
            this.tabPage1.Controls.Add(this.lblSuburbA);
            this.tabPage1.Controls.Add(this.lblAddress2A);
            this.tabPage1.Controls.Add(this.lblAddress1A);
            this.tabPage1.Controls.Add(this.lblPhoneA);
            this.tabPage1.Controls.Add(this.lblDateOfBirthA);
            this.tabPage1.Controls.Add(this.lblLastNameA);
            this.tabPage1.Controls.Add(this.lblFirstNameA);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(495, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Teacher";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtTeacherRegA
            // 
            this.txtTeacherRegA.Location = new System.Drawing.Point(150, 236);
            this.txtTeacherRegA.Name = "txtTeacherRegA";
            this.txtTeacherRegA.Size = new System.Drawing.Size(200, 20);
            this.txtTeacherRegA.TabIndex = 50;
            // 
            // lblQNameA
            // 
            this.lblQNameA.AutoSize = true;
            this.lblQNameA.Location = new System.Drawing.Point(356, 261);
            this.lblQNameA.Name = "lblQNameA";
            this.lblQNameA.Size = new System.Drawing.Size(0, 13);
            this.lblQNameA.TabIndex = 49;
            // 
            // btnExitA
            // 
            this.btnExitA.Location = new System.Drawing.Point(231, 286);
            this.btnExitA.Name = "btnExitA";
            this.btnExitA.Size = new System.Drawing.Size(75, 23);
            this.btnExitA.TabIndex = 48;
            this.btnExitA.Text = "E&xit";
            this.btnExitA.UseVisualStyleBackColor = true;
            this.btnExitA.Click += new System.EventHandler(this.btnExitA_Click);
            // 
            // btnAddA
            // 
            this.btnAddA.Location = new System.Drawing.Point(150, 286);
            this.btnAddA.Name = "btnAddA";
            this.btnAddA.Size = new System.Drawing.Size(75, 23);
            this.btnAddA.TabIndex = 47;
            this.btnAddA.Text = "&Add";
            this.btnAddA.UseVisualStyleBackColor = true;
            this.btnAddA.Click += new System.EventHandler(this.btnAddA_Click);
            // 
            // txtPostcodeA
            // 
            this.txtPostcodeA.Location = new System.Drawing.Point(150, 210);
            this.txtPostcodeA.Name = "txtPostcodeA";
            this.txtPostcodeA.Size = new System.Drawing.Size(200, 20);
            this.txtPostcodeA.TabIndex = 45;
            // 
            // txtSuburbA
            // 
            this.txtSuburbA.Location = new System.Drawing.Point(150, 162);
            this.txtSuburbA.Name = "txtSuburbA";
            this.txtSuburbA.Size = new System.Drawing.Size(200, 20);
            this.txtSuburbA.TabIndex = 43;
            // 
            // txtAddress2A
            // 
            this.txtAddress2A.Location = new System.Drawing.Point(150, 138);
            this.txtAddress2A.Name = "txtAddress2A";
            this.txtAddress2A.Size = new System.Drawing.Size(200, 20);
            this.txtAddress2A.TabIndex = 42;
            // 
            // txtAddress1A
            // 
            this.txtAddress1A.Location = new System.Drawing.Point(150, 114);
            this.txtAddress1A.Name = "txtAddress1A";
            this.txtAddress1A.Size = new System.Drawing.Size(200, 20);
            this.txtAddress1A.TabIndex = 41;
            // 
            // txtPhoneA
            // 
            this.txtPhoneA.Location = new System.Drawing.Point(150, 90);
            this.txtPhoneA.Name = "txtPhoneA";
            this.txtPhoneA.Size = new System.Drawing.Size(200, 20);
            this.txtPhoneA.TabIndex = 40;
            // 
            // txtLastNameA
            // 
            this.txtLastNameA.Location = new System.Drawing.Point(150, 42);
            this.txtLastNameA.Name = "txtLastNameA";
            this.txtLastNameA.Size = new System.Drawing.Size(200, 20);
            this.txtLastNameA.TabIndex = 38;
            // 
            // txtFirstNameA
            // 
            this.txtFirstNameA.Location = new System.Drawing.Point(150, 18);
            this.txtFirstNameA.Name = "txtFirstNameA";
            this.txtFirstNameA.Size = new System.Drawing.Size(200, 20);
            this.txtFirstNameA.TabIndex = 37;
            // 
            // cmbStateA
            // 
            this.cmbStateA.FormattingEnabled = true;
            this.cmbStateA.Items.AddRange(new object[] {
            "NSW",
            "VIC",
            "QLD",
            "SA",
            "WA",
            "CST",
            "NT",
            "TAS"});
            this.cmbStateA.Location = new System.Drawing.Point(150, 186);
            this.cmbStateA.Name = "cmbStateA";
            this.cmbStateA.Size = new System.Drawing.Size(200, 21);
            this.cmbStateA.TabIndex = 44;
            // 
            // dtpDateOfBirthA
            // 
            this.dtpDateOfBirthA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirthA.Location = new System.Drawing.Point(150, 68);
            this.dtpDateOfBirthA.Name = "dtpDateOfBirthA";
            this.dtpDateOfBirthA.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirthA.TabIndex = 39;
            // 
            // lblTeacherRegA
            // 
            this.lblTeacherRegA.AutoSize = true;
            this.lblTeacherRegA.Location = new System.Drawing.Point(38, 239);
            this.lblTeacherRegA.Name = "lblTeacherRegA";
            this.lblTeacherRegA.Size = new System.Drawing.Size(106, 13);
            this.lblTeacherRegA.TabIndex = 34;
            this.lblTeacherRegA.Text = "Teacher Registration";
            // 
            // lblPostcodeA
            // 
            this.lblPostcodeA.AutoSize = true;
            this.lblPostcodeA.Location = new System.Drawing.Point(92, 213);
            this.lblPostcodeA.Name = "lblPostcodeA";
            this.lblPostcodeA.Size = new System.Drawing.Size(52, 13);
            this.lblPostcodeA.TabIndex = 33;
            this.lblPostcodeA.Text = "Postcode";
            // 
            // lblStateA
            // 
            this.lblStateA.AutoSize = true;
            this.lblStateA.Location = new System.Drawing.Point(112, 189);
            this.lblStateA.Name = "lblStateA";
            this.lblStateA.Size = new System.Drawing.Size(32, 13);
            this.lblStateA.TabIndex = 32;
            this.lblStateA.Text = "State";
            // 
            // lblSuburbA
            // 
            this.lblSuburbA.AutoSize = true;
            this.lblSuburbA.Location = new System.Drawing.Point(103, 165);
            this.lblSuburbA.Name = "lblSuburbA";
            this.lblSuburbA.Size = new System.Drawing.Size(41, 13);
            this.lblSuburbA.TabIndex = 31;
            this.lblSuburbA.Text = "Suburb";
            // 
            // lblAddress2A
            // 
            this.lblAddress2A.AutoSize = true;
            this.lblAddress2A.Location = new System.Drawing.Point(90, 141);
            this.lblAddress2A.Name = "lblAddress2A";
            this.lblAddress2A.Size = new System.Drawing.Size(54, 13);
            this.lblAddress2A.TabIndex = 30;
            this.lblAddress2A.Text = "Address 2";
            // 
            // lblAddress1A
            // 
            this.lblAddress1A.AutoSize = true;
            this.lblAddress1A.Location = new System.Drawing.Point(90, 117);
            this.lblAddress1A.Name = "lblAddress1A";
            this.lblAddress1A.Size = new System.Drawing.Size(54, 13);
            this.lblAddress1A.TabIndex = 29;
            this.lblAddress1A.Text = "Address 1";
            // 
            // lblPhoneA
            // 
            this.lblPhoneA.AutoSize = true;
            this.lblPhoneA.Location = new System.Drawing.Point(106, 93);
            this.lblPhoneA.Name = "lblPhoneA";
            this.lblPhoneA.Size = new System.Drawing.Size(38, 13);
            this.lblPhoneA.TabIndex = 28;
            this.lblPhoneA.Text = "Phone";
            // 
            // lblDateOfBirthA
            // 
            this.lblDateOfBirthA.AutoSize = true;
            this.lblDateOfBirthA.Location = new System.Drawing.Point(78, 69);
            this.lblDateOfBirthA.Name = "lblDateOfBirthA";
            this.lblDateOfBirthA.Size = new System.Drawing.Size(66, 13);
            this.lblDateOfBirthA.TabIndex = 27;
            this.lblDateOfBirthA.Text = "Date of Birth";
            // 
            // lblLastNameA
            // 
            this.lblLastNameA.AutoSize = true;
            this.lblLastNameA.Location = new System.Drawing.Point(86, 45);
            this.lblLastNameA.Name = "lblLastNameA";
            this.lblLastNameA.Size = new System.Drawing.Size(58, 13);
            this.lblLastNameA.TabIndex = 26;
            this.lblLastNameA.Text = "Last Name";
            // 
            // lblFirstNameA
            // 
            this.lblFirstNameA.AutoSize = true;
            this.lblFirstNameA.Location = new System.Drawing.Point(87, 21);
            this.lblFirstNameA.Name = "lblFirstNameA";
            this.lblFirstNameA.Size = new System.Drawing.Size(57, 13);
            this.lblFirstNameA.TabIndex = 25;
            this.lblFirstNameA.Text = "First Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtTeacherRegU);
            this.tabPage2.Controls.Add(this.lblTeacherIDU);
            this.tabPage2.Controls.Add(this.cmbTeacherIDU);
            this.tabPage2.Controls.Add(this.btnDeleteU);
            this.tabPage2.Controls.Add(this.btnExitU);
            this.tabPage2.Controls.Add(this.btnUpdateU);
            this.tabPage2.Controls.Add(this.txtPostcodeU);
            this.tabPage2.Controls.Add(this.txtSuburbU);
            this.tabPage2.Controls.Add(this.txtAddress2U);
            this.tabPage2.Controls.Add(this.txtAddress1U);
            this.tabPage2.Controls.Add(this.txtPhoneU);
            this.tabPage2.Controls.Add(this.txtLastNameU);
            this.tabPage2.Controls.Add(this.txtFirstNameU);
            this.tabPage2.Controls.Add(this.cmbStateU);
            this.tabPage2.Controls.Add(this.dtpDateOfBirthU);
            this.tabPage2.Controls.Add(this.lblTeacherRegU);
            this.tabPage2.Controls.Add(this.lblPostcodeU);
            this.tabPage2.Controls.Add(this.lblStateU);
            this.tabPage2.Controls.Add(this.lblSuburbU);
            this.tabPage2.Controls.Add(this.lblAddress2U);
            this.tabPage2.Controls.Add(this.lblAddress1U);
            this.tabPage2.Controls.Add(this.lblPhoneU);
            this.tabPage2.Controls.Add(this.lblDateOfBirthU);
            this.tabPage2.Controls.Add(this.lblLastNameU);
            this.tabPage2.Controls.Add(this.lblFirstNameU);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(495, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update / Delete Teacher";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtTeacherRegU
            // 
            this.txtTeacherRegU.Location = new System.Drawing.Point(178, 251);
            this.txtTeacherRegU.Name = "txtTeacherRegU";
            this.txtTeacherRegU.Size = new System.Drawing.Size(200, 20);
            this.txtTeacherRegU.TabIndex = 79;
            // 
            // lblTeacherIDU
            // 
            this.lblTeacherIDU.AutoSize = true;
            this.lblTeacherIDU.Location = new System.Drawing.Point(114, 11);
            this.lblTeacherIDU.Name = "lblTeacherIDU";
            this.lblTeacherIDU.Size = new System.Drawing.Size(61, 13);
            this.lblTeacherIDU.TabIndex = 78;
            this.lblTeacherIDU.Text = "Teacher ID";
            // 
            // cmbTeacherIDU
            // 
            this.cmbTeacherIDU.FormattingEnabled = true;
            this.cmbTeacherIDU.Location = new System.Drawing.Point(178, 8);
            this.cmbTeacherIDU.Name = "cmbTeacherIDU";
            this.cmbTeacherIDU.Size = new System.Drawing.Size(200, 21);
            this.cmbTeacherIDU.TabIndex = 77;
            this.cmbTeacherIDU.SelectedIndexChanged += new System.EventHandler(this.cmbTeacherIDU_SelectedIndexChanged);
            // 
            // schoolDBDataSetBindingSource
            // 
            this.schoolDBDataSetBindingSource.DataSource = this.schoolDBDataSet;
            this.schoolDBDataSetBindingSource.Position = 0;
            // 
            // schoolDBDataSet
            // 
            this.schoolDBDataSet.DataSetName = "SchoolDBDataSet";
            this.schoolDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDeleteU
            // 
            this.btnDeleteU.Location = new System.Drawing.Point(259, 277);
            this.btnDeleteU.Name = "btnDeleteU";
            this.btnDeleteU.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteU.TabIndex = 76;
            this.btnDeleteU.Text = "&Delete";
            this.btnDeleteU.UseVisualStyleBackColor = true;
            this.btnDeleteU.Click += new System.EventHandler(this.btnDeleteU_Click);
            // 
            // btnExitU
            // 
            this.btnExitU.Location = new System.Drawing.Point(340, 277);
            this.btnExitU.Name = "btnExitU";
            this.btnExitU.Size = new System.Drawing.Size(75, 23);
            this.btnExitU.TabIndex = 75;
            this.btnExitU.Text = "E&xit";
            this.btnExitU.UseVisualStyleBackColor = true;
            this.btnExitU.Click += new System.EventHandler(this.btnExitU_Click);
            // 
            // btnUpdateU
            // 
            this.btnUpdateU.Location = new System.Drawing.Point(178, 277);
            this.btnUpdateU.Name = "btnUpdateU";
            this.btnUpdateU.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateU.TabIndex = 74;
            this.btnUpdateU.Text = "&Update";
            this.btnUpdateU.UseVisualStyleBackColor = true;
            this.btnUpdateU.Click += new System.EventHandler(this.btnUpdateU_Click);
            // 
            // txtPostcodeU
            // 
            this.txtPostcodeU.Location = new System.Drawing.Point(178, 227);
            this.txtPostcodeU.Name = "txtPostcodeU";
            this.txtPostcodeU.Size = new System.Drawing.Size(200, 20);
            this.txtPostcodeU.TabIndex = 72;
            // 
            // txtSuburbU
            // 
            this.txtSuburbU.Location = new System.Drawing.Point(178, 179);
            this.txtSuburbU.Name = "txtSuburbU";
            this.txtSuburbU.Size = new System.Drawing.Size(200, 20);
            this.txtSuburbU.TabIndex = 70;
            // 
            // txtAddress2U
            // 
            this.txtAddress2U.Location = new System.Drawing.Point(178, 155);
            this.txtAddress2U.Name = "txtAddress2U";
            this.txtAddress2U.Size = new System.Drawing.Size(200, 20);
            this.txtAddress2U.TabIndex = 69;
            // 
            // txtAddress1U
            // 
            this.txtAddress1U.Location = new System.Drawing.Point(178, 131);
            this.txtAddress1U.Name = "txtAddress1U";
            this.txtAddress1U.Size = new System.Drawing.Size(200, 20);
            this.txtAddress1U.TabIndex = 68;
            // 
            // txtPhoneU
            // 
            this.txtPhoneU.Location = new System.Drawing.Point(178, 107);
            this.txtPhoneU.Name = "txtPhoneU";
            this.txtPhoneU.Size = new System.Drawing.Size(200, 20);
            this.txtPhoneU.TabIndex = 67;
            // 
            // txtLastNameU
            // 
            this.txtLastNameU.Location = new System.Drawing.Point(178, 59);
            this.txtLastNameU.Name = "txtLastNameU";
            this.txtLastNameU.Size = new System.Drawing.Size(200, 20);
            this.txtLastNameU.TabIndex = 65;
            // 
            // txtFirstNameU
            // 
            this.txtFirstNameU.Location = new System.Drawing.Point(178, 35);
            this.txtFirstNameU.Name = "txtFirstNameU";
            this.txtFirstNameU.Size = new System.Drawing.Size(200, 20);
            this.txtFirstNameU.TabIndex = 64;
            // 
            // cmbStateU
            // 
            this.cmbStateU.FormattingEnabled = true;
            this.cmbStateU.Items.AddRange(new object[] {
            "NSW",
            "VIC",
            "QLD",
            "SA",
            "WA",
            "CST",
            "NT",
            "TAS"});
            this.cmbStateU.Location = new System.Drawing.Point(178, 203);
            this.cmbStateU.Name = "cmbStateU";
            this.cmbStateU.Size = new System.Drawing.Size(200, 21);
            this.cmbStateU.TabIndex = 71;
            // 
            // dtpDateOfBirthU
            // 
            this.dtpDateOfBirthU.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirthU.Location = new System.Drawing.Point(178, 85);
            this.dtpDateOfBirthU.Name = "dtpDateOfBirthU";
            this.dtpDateOfBirthU.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirthU.TabIndex = 66;
            // 
            // lblTeacherRegU
            // 
            this.lblTeacherRegU.AutoSize = true;
            this.lblTeacherRegU.Location = new System.Drawing.Point(66, 254);
            this.lblTeacherRegU.Name = "lblTeacherRegU";
            this.lblTeacherRegU.Size = new System.Drawing.Size(106, 13);
            this.lblTeacherRegU.TabIndex = 61;
            this.lblTeacherRegU.Text = "Teacher Registration";
            // 
            // lblPostcodeU
            // 
            this.lblPostcodeU.AutoSize = true;
            this.lblPostcodeU.Location = new System.Drawing.Point(120, 230);
            this.lblPostcodeU.Name = "lblPostcodeU";
            this.lblPostcodeU.Size = new System.Drawing.Size(52, 13);
            this.lblPostcodeU.TabIndex = 60;
            this.lblPostcodeU.Text = "Postcode";
            // 
            // lblStateU
            // 
            this.lblStateU.AutoSize = true;
            this.lblStateU.Location = new System.Drawing.Point(140, 206);
            this.lblStateU.Name = "lblStateU";
            this.lblStateU.Size = new System.Drawing.Size(32, 13);
            this.lblStateU.TabIndex = 59;
            this.lblStateU.Text = "State";
            // 
            // lblSuburbU
            // 
            this.lblSuburbU.AutoSize = true;
            this.lblSuburbU.Location = new System.Drawing.Point(131, 182);
            this.lblSuburbU.Name = "lblSuburbU";
            this.lblSuburbU.Size = new System.Drawing.Size(41, 13);
            this.lblSuburbU.TabIndex = 58;
            this.lblSuburbU.Text = "Suburb";
            // 
            // lblAddress2U
            // 
            this.lblAddress2U.AutoSize = true;
            this.lblAddress2U.Location = new System.Drawing.Point(118, 158);
            this.lblAddress2U.Name = "lblAddress2U";
            this.lblAddress2U.Size = new System.Drawing.Size(54, 13);
            this.lblAddress2U.TabIndex = 57;
            this.lblAddress2U.Text = "Address 2";
            // 
            // lblAddress1U
            // 
            this.lblAddress1U.AutoSize = true;
            this.lblAddress1U.Location = new System.Drawing.Point(118, 134);
            this.lblAddress1U.Name = "lblAddress1U";
            this.lblAddress1U.Size = new System.Drawing.Size(54, 13);
            this.lblAddress1U.TabIndex = 56;
            this.lblAddress1U.Text = "Address 1";
            // 
            // lblPhoneU
            // 
            this.lblPhoneU.AutoSize = true;
            this.lblPhoneU.Location = new System.Drawing.Point(134, 110);
            this.lblPhoneU.Name = "lblPhoneU";
            this.lblPhoneU.Size = new System.Drawing.Size(38, 13);
            this.lblPhoneU.TabIndex = 55;
            this.lblPhoneU.Text = "Phone";
            // 
            // lblDateOfBirthU
            // 
            this.lblDateOfBirthU.AutoSize = true;
            this.lblDateOfBirthU.Location = new System.Drawing.Point(106, 86);
            this.lblDateOfBirthU.Name = "lblDateOfBirthU";
            this.lblDateOfBirthU.Size = new System.Drawing.Size(66, 13);
            this.lblDateOfBirthU.TabIndex = 54;
            this.lblDateOfBirthU.Text = "Date of Birth";
            // 
            // lblLastNameU
            // 
            this.lblLastNameU.AutoSize = true;
            this.lblLastNameU.Location = new System.Drawing.Point(114, 62);
            this.lblLastNameU.Name = "lblLastNameU";
            this.lblLastNameU.Size = new System.Drawing.Size(58, 13);
            this.lblLastNameU.TabIndex = 53;
            this.lblLastNameU.Text = "Last Name";
            // 
            // lblFirstNameU
            // 
            this.lblFirstNameU.AutoSize = true;
            this.lblFirstNameU.Location = new System.Drawing.Point(115, 38);
            this.lblFirstNameU.Name = "lblFirstNameU";
            this.lblFirstNameU.Size = new System.Drawing.Size(57, 13);
            this.lblFirstNameU.TabIndex = 52;
            this.lblFirstNameU.Text = "First Name";
            // 
            // TeachersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 386);
            this.Controls.Add(this.tabControl1);
            this.Name = "TeachersForm";
            this.Text = "Teachers";
            this.Load += new System.EventHandler(this.TeachersForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblQNameA;
        private System.Windows.Forms.Button btnExitA;
        private System.Windows.Forms.Button btnAddA;
        private System.Windows.Forms.TextBox txtPostcodeA;
        private System.Windows.Forms.TextBox txtSuburbA;
        private System.Windows.Forms.TextBox txtAddress2A;
        private System.Windows.Forms.TextBox txtAddress1A;
        private System.Windows.Forms.TextBox txtPhoneA;
        private System.Windows.Forms.TextBox txtLastNameA;
        private System.Windows.Forms.TextBox txtFirstNameA;
        private System.Windows.Forms.ComboBox cmbStateA;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirthA;
        private System.Windows.Forms.Label lblTeacherRegA;
        private System.Windows.Forms.Label lblPostcodeA;
        private System.Windows.Forms.Label lblStateA;
        private System.Windows.Forms.Label lblSuburbA;
        private System.Windows.Forms.Label lblAddress2A;
        private System.Windows.Forms.Label lblAddress1A;
        private System.Windows.Forms.Label lblPhoneA;
        private System.Windows.Forms.Label lblDateOfBirthA;
        private System.Windows.Forms.Label lblLastNameA;
        private System.Windows.Forms.Label lblFirstNameA;
        private System.Windows.Forms.Label lblTeacherIDU;
        private System.Windows.Forms.ComboBox cmbTeacherIDU;
        private System.Windows.Forms.Button btnDeleteU;
        private System.Windows.Forms.Button btnExitU;
        private System.Windows.Forms.Button btnUpdateU;
        private System.Windows.Forms.TextBox txtPostcodeU;
        private System.Windows.Forms.TextBox txtSuburbU;
        private System.Windows.Forms.TextBox txtAddress2U;
        private System.Windows.Forms.TextBox txtAddress1U;
        private System.Windows.Forms.TextBox txtPhoneU;
        private System.Windows.Forms.TextBox txtLastNameU;
        private System.Windows.Forms.TextBox txtFirstNameU;
        private System.Windows.Forms.ComboBox cmbStateU;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirthU;
        private System.Windows.Forms.Label lblTeacherRegU;
        private System.Windows.Forms.Label lblPostcodeU;
        private System.Windows.Forms.Label lblStateU;
        private System.Windows.Forms.Label lblSuburbU;
        private System.Windows.Forms.Label lblAddress2U;
        private System.Windows.Forms.Label lblAddress1U;
        private System.Windows.Forms.Label lblPhoneU;
        private System.Windows.Forms.Label lblDateOfBirthU;
        private System.Windows.Forms.Label lblLastNameU;
        private System.Windows.Forms.Label lblFirstNameU;
        private System.Windows.Forms.TextBox txtTeacherRegU;
        private System.Windows.Forms.TextBox txtTeacherRegA;
        private System.Windows.Forms.BindingSource schoolDBDataSetBindingSource;
        private SchoolDBDataSet schoolDBDataSet;
    }
}