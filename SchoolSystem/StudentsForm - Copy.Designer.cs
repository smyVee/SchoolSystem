namespace SchoolSystem
{
    partial class StudentsForm
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
            this.schoolDBDataSet = new SchoolSystem.SchoolDBDataSet();
            this.schoolDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personTableAdapter = new SchoolSystem.SchoolDBDataSetTableAdapters.PersonTableAdapter();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblQNameU = new System.Windows.Forms.Label();
            this.lblStudentIDU = new System.Windows.Forms.Label();
            this.cmbStudentIDU = new System.Windows.Forms.ComboBox();
            this.btnDeleteU = new System.Windows.Forms.Button();
            this.btnExitU = new System.Windows.Forms.Button();
            this.btnUpdateU = new System.Windows.Forms.Button();
            this.cmbQualificationCodeU = new System.Windows.Forms.ComboBox();
            this.txtPostcodeU = new System.Windows.Forms.TextBox();
            this.txtSuburbU = new System.Windows.Forms.TextBox();
            this.txtAddress2U = new System.Windows.Forms.TextBox();
            this.txtAddress1U = new System.Windows.Forms.TextBox();
            this.txtPhoneU = new System.Windows.Forms.TextBox();
            this.txtLastNameU = new System.Windows.Forms.TextBox();
            this.txtFirstNameU = new System.Windows.Forms.TextBox();
            this.cmbStateU = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirthU = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDateU = new System.Windows.Forms.DateTimePicker();
            this.lblQualificationCodeU = new System.Windows.Forms.Label();
            this.lblStartDateU = new System.Windows.Forms.Label();
            this.lblPostcodeU = new System.Windows.Forms.Label();
            this.lblStateU = new System.Windows.Forms.Label();
            this.lblSuburbU = new System.Windows.Forms.Label();
            this.lblAddress2U = new System.Windows.Forms.Label();
            this.lblAddress1U = new System.Windows.Forms.Label();
            this.lblPhoneU = new System.Windows.Forms.Label();
            this.lblDateOfBirthU = new System.Windows.Forms.Label();
            this.lblLastNameU = new System.Windows.Forms.Label();
            this.lblFirstNameU = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblPostcodeMessageA = new System.Windows.Forms.Label();
            this.lblStateMessageA = new System.Windows.Forms.Label();
            this.lblSuburbMessageA = new System.Windows.Forms.Label();
            this.lblAddress1MessageA = new System.Windows.Forms.Label();
            this.lblPhoneMessageA = new System.Windows.Forms.Label();
            this.lblLastNameMessageA = new System.Windows.Forms.Label();
            this.lblFirstNameMessageA = new System.Windows.Forms.Label();
            this.lblQNameA = new System.Windows.Forms.Label();
            this.btnExitA = new System.Windows.Forms.Button();
            this.btnAddA = new System.Windows.Forms.Button();
            this.cmbQualificationCodeA = new System.Windows.Forms.ComboBox();
            this.txtPostcodeA = new System.Windows.Forms.TextBox();
            this.txtSuburbA = new System.Windows.Forms.TextBox();
            this.txtAddress2A = new System.Windows.Forms.TextBox();
            this.txtAddress1A = new System.Windows.Forms.TextBox();
            this.txtPhoneA = new System.Windows.Forms.TextBox();
            this.txtLastNameA = new System.Windows.Forms.TextBox();
            this.txtFirstNameA = new System.Windows.Forms.TextBox();
            this.cmbStateA = new System.Windows.Forms.ComboBox();
            this.dtpDateOfBirthA = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDateA = new System.Windows.Forms.DateTimePicker();
            this.lblQualificationCodeA = new System.Windows.Forms.Label();
            this.lblStartDateA = new System.Windows.Forms.Label();
            this.lblPostcodeA = new System.Windows.Forms.Label();
            this.lblStateA = new System.Windows.Forms.Label();
            this.lblSuburbA = new System.Windows.Forms.Label();
            this.lblAddress2A = new System.Windows.Forms.Label();
            this.lblAddress1A = new System.Windows.Forms.Label();
            this.lblPhoneA = new System.Windows.Forms.Label();
            this.lblDateOfBirthA = new System.Windows.Forms.Label();
            this.lblLastNameA = new System.Windows.Forms.Label();
            this.lblFirstNameA = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // schoolDBDataSet
            // 
            this.schoolDBDataSet.DataSetName = "SchoolDBDataSet";
            this.schoolDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schoolDBDataSetBindingSource
            // 
            this.schoolDBDataSetBindingSource.DataSource = this.schoolDBDataSet;
            this.schoolDBDataSetBindingSource.Position = 0;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.schoolDBDataSetBindingSource;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblQNameU);
            this.tabPage2.Controls.Add(this.lblStudentIDU);
            this.tabPage2.Controls.Add(this.cmbStudentIDU);
            this.tabPage2.Controls.Add(this.btnDeleteU);
            this.tabPage2.Controls.Add(this.btnExitU);
            this.tabPage2.Controls.Add(this.btnUpdateU);
            this.tabPage2.Controls.Add(this.cmbQualificationCodeU);
            this.tabPage2.Controls.Add(this.txtPostcodeU);
            this.tabPage2.Controls.Add(this.txtSuburbU);
            this.tabPage2.Controls.Add(this.txtAddress2U);
            this.tabPage2.Controls.Add(this.txtAddress1U);
            this.tabPage2.Controls.Add(this.txtPhoneU);
            this.tabPage2.Controls.Add(this.txtLastNameU);
            this.tabPage2.Controls.Add(this.txtFirstNameU);
            this.tabPage2.Controls.Add(this.cmbStateU);
            this.tabPage2.Controls.Add(this.dtpDateOfBirthU);
            this.tabPage2.Controls.Add(this.dtpStartDateU);
            this.tabPage2.Controls.Add(this.lblQualificationCodeU);
            this.tabPage2.Controls.Add(this.lblStartDateU);
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
            this.tabPage2.Size = new System.Drawing.Size(601, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update / Delete Student";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblQNameU
            // 
            this.lblQNameU.AutoSize = true;
            this.lblQNameU.Location = new System.Drawing.Point(325, 287);
            this.lblQNameU.Name = "lblQNameU";
            this.lblQNameU.Size = new System.Drawing.Size(0, 13);
            this.lblQNameU.TabIndex = 51;
            // 
            // lblStudentIDU
            // 
            this.lblStudentIDU.AutoSize = true;
            this.lblStudentIDU.Location = new System.Drawing.Point(55, 20);
            this.lblStudentIDU.Name = "lblStudentIDU";
            this.lblStudentIDU.Size = new System.Drawing.Size(58, 13);
            this.lblStudentIDU.TabIndex = 50;
            this.lblStudentIDU.Text = "Student ID";
            // 
            // cmbStudentIDU
            // 
            this.cmbStudentIDU.DataSource = this.personBindingSource;
            this.cmbStudentIDU.DisplayMember = "ID";
            this.cmbStudentIDU.FormattingEnabled = true;
            this.cmbStudentIDU.Location = new System.Drawing.Point(119, 17);
            this.cmbStudentIDU.Name = "cmbStudentIDU";
            this.cmbStudentIDU.Size = new System.Drawing.Size(200, 21);
            this.cmbStudentIDU.TabIndex = 49;
            this.cmbStudentIDU.ValueMember = "ID";
            this.cmbStudentIDU.SelectedIndexChanged += new System.EventHandler(this.cmbStudentIDU_SelectedIndexChanged);
            // 
            // btnDeleteU
            // 
            this.btnDeleteU.Location = new System.Drawing.Point(200, 312);
            this.btnDeleteU.Name = "btnDeleteU";
            this.btnDeleteU.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteU.TabIndex = 48;
            this.btnDeleteU.Text = "&Delete";
            this.btnDeleteU.UseVisualStyleBackColor = true;
            this.btnDeleteU.Click += new System.EventHandler(this.btnDeleteU_Click);
            // 
            // btnExitU
            // 
            this.btnExitU.Location = new System.Drawing.Point(281, 312);
            this.btnExitU.Name = "btnExitU";
            this.btnExitU.Size = new System.Drawing.Size(75, 23);
            this.btnExitU.TabIndex = 47;
            this.btnExitU.Text = "E&xit";
            this.btnExitU.UseVisualStyleBackColor = true;
            this.btnExitU.Click += new System.EventHandler(this.btnExitU_Click);
            // 
            // btnUpdateU
            // 
            this.btnUpdateU.Location = new System.Drawing.Point(119, 312);
            this.btnUpdateU.Name = "btnUpdateU";
            this.btnUpdateU.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateU.TabIndex = 46;
            this.btnUpdateU.Text = "&Update";
            this.btnUpdateU.UseVisualStyleBackColor = true;
            this.btnUpdateU.Click += new System.EventHandler(this.btnUpdateU_Click);
            // 
            // cmbQualificationCodeU
            // 
            this.cmbQualificationCodeU.FormattingEnabled = true;
            this.cmbQualificationCodeU.Location = new System.Drawing.Point(119, 284);
            this.cmbQualificationCodeU.Name = "cmbQualificationCodeU";
            this.cmbQualificationCodeU.Size = new System.Drawing.Size(200, 21);
            this.cmbQualificationCodeU.TabIndex = 45;
            this.cmbQualificationCodeU.SelectedIndexChanged += new System.EventHandler(this.cmbQualificationCodeU_SelectedIndexChanged);
            // 
            // txtPostcodeU
            // 
            this.txtPostcodeU.Location = new System.Drawing.Point(119, 236);
            this.txtPostcodeU.Name = "txtPostcodeU";
            this.txtPostcodeU.Size = new System.Drawing.Size(200, 20);
            this.txtPostcodeU.TabIndex = 44;
            // 
            // txtSuburbU
            // 
            this.txtSuburbU.Location = new System.Drawing.Point(119, 188);
            this.txtSuburbU.Name = "txtSuburbU";
            this.txtSuburbU.Size = new System.Drawing.Size(200, 20);
            this.txtSuburbU.TabIndex = 42;
            // 
            // txtAddress2U
            // 
            this.txtAddress2U.Location = new System.Drawing.Point(119, 164);
            this.txtAddress2U.Name = "txtAddress2U";
            this.txtAddress2U.Size = new System.Drawing.Size(200, 20);
            this.txtAddress2U.TabIndex = 41;
            // 
            // txtAddress1U
            // 
            this.txtAddress1U.Location = new System.Drawing.Point(119, 140);
            this.txtAddress1U.Name = "txtAddress1U";
            this.txtAddress1U.Size = new System.Drawing.Size(200, 20);
            this.txtAddress1U.TabIndex = 40;
            // 
            // txtPhoneU
            // 
            this.txtPhoneU.Location = new System.Drawing.Point(119, 116);
            this.txtPhoneU.Name = "txtPhoneU";
            this.txtPhoneU.Size = new System.Drawing.Size(200, 20);
            this.txtPhoneU.TabIndex = 39;
            // 
            // txtLastNameU
            // 
            this.txtLastNameU.Location = new System.Drawing.Point(119, 68);
            this.txtLastNameU.Name = "txtLastNameU";
            this.txtLastNameU.Size = new System.Drawing.Size(200, 20);
            this.txtLastNameU.TabIndex = 37;
            // 
            // txtFirstNameU
            // 
            this.txtFirstNameU.Location = new System.Drawing.Point(119, 44);
            this.txtFirstNameU.Name = "txtFirstNameU";
            this.txtFirstNameU.Size = new System.Drawing.Size(200, 20);
            this.txtFirstNameU.TabIndex = 36;
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
            this.cmbStateU.Location = new System.Drawing.Point(119, 212);
            this.cmbStateU.Name = "cmbStateU";
            this.cmbStateU.Size = new System.Drawing.Size(200, 21);
            this.cmbStateU.TabIndex = 43;
            // 
            // dtpDateOfBirthU
            // 
            this.dtpDateOfBirthU.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirthU.Location = new System.Drawing.Point(119, 94);
            this.dtpDateOfBirthU.Name = "dtpDateOfBirthU";
            this.dtpDateOfBirthU.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirthU.TabIndex = 38;
            // 
            // dtpStartDateU
            // 
            this.dtpStartDateU.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDateU.Location = new System.Drawing.Point(119, 257);
            this.dtpStartDateU.Name = "dtpStartDateU";
            this.dtpStartDateU.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDateU.TabIndex = 35;
            // 
            // lblQualificationCodeU
            // 
            this.lblQualificationCodeU.AutoSize = true;
            this.lblQualificationCodeU.Location = new System.Drawing.Point(20, 287);
            this.lblQualificationCodeU.Name = "lblQualificationCodeU";
            this.lblQualificationCodeU.Size = new System.Drawing.Size(93, 13);
            this.lblQualificationCodeU.TabIndex = 34;
            this.lblQualificationCodeU.Text = "Qualification Code";
            // 
            // lblStartDateU
            // 
            this.lblStartDateU.AutoSize = true;
            this.lblStartDateU.Location = new System.Drawing.Point(58, 263);
            this.lblStartDateU.Name = "lblStartDateU";
            this.lblStartDateU.Size = new System.Drawing.Size(55, 13);
            this.lblStartDateU.TabIndex = 33;
            this.lblStartDateU.Text = "Start Date";
            // 
            // lblPostcodeU
            // 
            this.lblPostcodeU.AutoSize = true;
            this.lblPostcodeU.Location = new System.Drawing.Point(61, 239);
            this.lblPostcodeU.Name = "lblPostcodeU";
            this.lblPostcodeU.Size = new System.Drawing.Size(52, 13);
            this.lblPostcodeU.TabIndex = 32;
            this.lblPostcodeU.Text = "Postcode";
            // 
            // lblStateU
            // 
            this.lblStateU.AutoSize = true;
            this.lblStateU.Location = new System.Drawing.Point(81, 215);
            this.lblStateU.Name = "lblStateU";
            this.lblStateU.Size = new System.Drawing.Size(32, 13);
            this.lblStateU.TabIndex = 31;
            this.lblStateU.Text = "State";
            // 
            // lblSuburbU
            // 
            this.lblSuburbU.AutoSize = true;
            this.lblSuburbU.Location = new System.Drawing.Point(72, 191);
            this.lblSuburbU.Name = "lblSuburbU";
            this.lblSuburbU.Size = new System.Drawing.Size(41, 13);
            this.lblSuburbU.TabIndex = 30;
            this.lblSuburbU.Text = "Suburb";
            // 
            // lblAddress2U
            // 
            this.lblAddress2U.AutoSize = true;
            this.lblAddress2U.Location = new System.Drawing.Point(59, 167);
            this.lblAddress2U.Name = "lblAddress2U";
            this.lblAddress2U.Size = new System.Drawing.Size(54, 13);
            this.lblAddress2U.TabIndex = 29;
            this.lblAddress2U.Text = "Address 2";
            // 
            // lblAddress1U
            // 
            this.lblAddress1U.AutoSize = true;
            this.lblAddress1U.Location = new System.Drawing.Point(59, 143);
            this.lblAddress1U.Name = "lblAddress1U";
            this.lblAddress1U.Size = new System.Drawing.Size(54, 13);
            this.lblAddress1U.TabIndex = 28;
            this.lblAddress1U.Text = "Address 1";
            // 
            // lblPhoneU
            // 
            this.lblPhoneU.AutoSize = true;
            this.lblPhoneU.Location = new System.Drawing.Point(75, 119);
            this.lblPhoneU.Name = "lblPhoneU";
            this.lblPhoneU.Size = new System.Drawing.Size(38, 13);
            this.lblPhoneU.TabIndex = 27;
            this.lblPhoneU.Text = "Phone";
            // 
            // lblDateOfBirthU
            // 
            this.lblDateOfBirthU.AutoSize = true;
            this.lblDateOfBirthU.Location = new System.Drawing.Point(47, 95);
            this.lblDateOfBirthU.Name = "lblDateOfBirthU";
            this.lblDateOfBirthU.Size = new System.Drawing.Size(66, 13);
            this.lblDateOfBirthU.TabIndex = 26;
            this.lblDateOfBirthU.Text = "Date of Birth";
            // 
            // lblLastNameU
            // 
            this.lblLastNameU.AutoSize = true;
            this.lblLastNameU.Location = new System.Drawing.Point(55, 71);
            this.lblLastNameU.Name = "lblLastNameU";
            this.lblLastNameU.Size = new System.Drawing.Size(58, 13);
            this.lblLastNameU.TabIndex = 25;
            this.lblLastNameU.Text = "Last Name";
            // 
            // lblFirstNameU
            // 
            this.lblFirstNameU.AutoSize = true;
            this.lblFirstNameU.Location = new System.Drawing.Point(56, 47);
            this.lblFirstNameU.Name = "lblFirstNameU";
            this.lblFirstNameU.Size = new System.Drawing.Size(57, 13);
            this.lblFirstNameU.TabIndex = 24;
            this.lblFirstNameU.Text = "First Name";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblPostcodeMessageA);
            this.tabPage1.Controls.Add(this.lblStateMessageA);
            this.tabPage1.Controls.Add(this.lblSuburbMessageA);
            this.tabPage1.Controls.Add(this.lblAddress1MessageA);
            this.tabPage1.Controls.Add(this.lblPhoneMessageA);
            this.tabPage1.Controls.Add(this.lblLastNameMessageA);
            this.tabPage1.Controls.Add(this.lblFirstNameMessageA);
            this.tabPage1.Controls.Add(this.lblQNameA);
            this.tabPage1.Controls.Add(this.btnExitA);
            this.tabPage1.Controls.Add(this.btnAddA);
            this.tabPage1.Controls.Add(this.cmbQualificationCodeA);
            this.tabPage1.Controls.Add(this.txtPostcodeA);
            this.tabPage1.Controls.Add(this.txtSuburbA);
            this.tabPage1.Controls.Add(this.txtAddress2A);
            this.tabPage1.Controls.Add(this.txtAddress1A);
            this.tabPage1.Controls.Add(this.txtPhoneA);
            this.tabPage1.Controls.Add(this.txtLastNameA);
            this.tabPage1.Controls.Add(this.txtFirstNameA);
            this.tabPage1.Controls.Add(this.cmbStateA);
            this.tabPage1.Controls.Add(this.dtpDateOfBirthA);
            this.tabPage1.Controls.Add(this.dtpStartDateA);
            this.tabPage1.Controls.Add(this.lblQualificationCodeA);
            this.tabPage1.Controls.Add(this.lblStartDateA);
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
            this.tabPage1.Size = new System.Drawing.Size(601, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Student";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblPostcodeMessageA
            // 
            this.lblPostcodeMessageA.AutoSize = true;
            this.lblPostcodeMessageA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPostcodeMessageA.Location = new System.Drawing.Point(337, 218);
            this.lblPostcodeMessageA.Name = "lblPostcodeMessageA";
            this.lblPostcodeMessageA.Size = new System.Drawing.Size(0, 13);
            this.lblPostcodeMessageA.TabIndex = 31;
            // 
            // lblStateMessageA
            // 
            this.lblStateMessageA.AutoSize = true;
            this.lblStateMessageA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStateMessageA.Location = new System.Drawing.Point(337, 194);
            this.lblStateMessageA.Name = "lblStateMessageA";
            this.lblStateMessageA.Size = new System.Drawing.Size(0, 13);
            this.lblStateMessageA.TabIndex = 30;
            // 
            // lblSuburbMessageA
            // 
            this.lblSuburbMessageA.AutoSize = true;
            this.lblSuburbMessageA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSuburbMessageA.Location = new System.Drawing.Point(337, 170);
            this.lblSuburbMessageA.Name = "lblSuburbMessageA";
            this.lblSuburbMessageA.Size = new System.Drawing.Size(0, 13);
            this.lblSuburbMessageA.TabIndex = 29;
            // 
            // lblAddress1MessageA
            // 
            this.lblAddress1MessageA.AutoSize = true;
            this.lblAddress1MessageA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddress1MessageA.Location = new System.Drawing.Point(337, 122);
            this.lblAddress1MessageA.Name = "lblAddress1MessageA";
            this.lblAddress1MessageA.Size = new System.Drawing.Size(0, 13);
            this.lblAddress1MessageA.TabIndex = 28;
            // 
            // lblPhoneMessageA
            // 
            this.lblPhoneMessageA.AutoSize = true;
            this.lblPhoneMessageA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPhoneMessageA.Location = new System.Drawing.Point(337, 98);
            this.lblPhoneMessageA.Name = "lblPhoneMessageA";
            this.lblPhoneMessageA.Size = new System.Drawing.Size(0, 13);
            this.lblPhoneMessageA.TabIndex = 27;
            // 
            // lblLastNameMessageA
            // 
            this.lblLastNameMessageA.AutoSize = true;
            this.lblLastNameMessageA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLastNameMessageA.Location = new System.Drawing.Point(337, 50);
            this.lblLastNameMessageA.Name = "lblLastNameMessageA";
            this.lblLastNameMessageA.Size = new System.Drawing.Size(0, 13);
            this.lblLastNameMessageA.TabIndex = 26;
            // 
            // lblFirstNameMessageA
            // 
            this.lblFirstNameMessageA.AutoSize = true;
            this.lblFirstNameMessageA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFirstNameMessageA.Location = new System.Drawing.Point(337, 26);
            this.lblFirstNameMessageA.Name = "lblFirstNameMessageA";
            this.lblFirstNameMessageA.Size = new System.Drawing.Size(0, 13);
            this.lblFirstNameMessageA.TabIndex = 25;
            // 
            // lblQNameA
            // 
            this.lblQNameA.AutoSize = true;
            this.lblQNameA.Location = new System.Drawing.Point(337, 266);
            this.lblQNameA.Name = "lblQNameA";
            this.lblQNameA.Size = new System.Drawing.Size(0, 13);
            this.lblQNameA.TabIndex = 24;
            // 
            // btnExitA
            // 
            this.btnExitA.Location = new System.Drawing.Point(212, 291);
            this.btnExitA.Name = "btnExitA";
            this.btnExitA.Size = new System.Drawing.Size(75, 23);
            this.btnExitA.TabIndex = 23;
            this.btnExitA.Text = "E&xit";
            this.btnExitA.UseVisualStyleBackColor = true;
            this.btnExitA.Click += new System.EventHandler(this.btnExitA_Click);
            // 
            // btnAddA
            // 
            this.btnAddA.Location = new System.Drawing.Point(131, 291);
            this.btnAddA.Name = "btnAddA";
            this.btnAddA.Size = new System.Drawing.Size(75, 23);
            this.btnAddA.TabIndex = 22;
            this.btnAddA.Text = "&Add";
            this.btnAddA.UseVisualStyleBackColor = true;
            this.btnAddA.Click += new System.EventHandler(this.btnAddA_Click);
            // 
            // cmbQualificationCodeA
            // 
            this.cmbQualificationCodeA.FormattingEnabled = true;
            this.cmbQualificationCodeA.Location = new System.Drawing.Point(131, 263);
            this.cmbQualificationCodeA.Name = "cmbQualificationCodeA";
            this.cmbQualificationCodeA.Size = new System.Drawing.Size(200, 21);
            this.cmbQualificationCodeA.TabIndex = 21;
            this.cmbQualificationCodeA.SelectedIndexChanged += new System.EventHandler(this.cmbQualificationCodeA_SelectedIndexChanged);
            // 
            // txtPostcodeA
            // 
            this.txtPostcodeA.Location = new System.Drawing.Point(131, 215);
            this.txtPostcodeA.Name = "txtPostcodeA";
            this.txtPostcodeA.Size = new System.Drawing.Size(200, 20);
            this.txtPostcodeA.TabIndex = 20;
            // 
            // txtSuburbA
            // 
            this.txtSuburbA.Location = new System.Drawing.Point(131, 167);
            this.txtSuburbA.Name = "txtSuburbA";
            this.txtSuburbA.Size = new System.Drawing.Size(200, 20);
            this.txtSuburbA.TabIndex = 18;
            // 
            // txtAddress2A
            // 
            this.txtAddress2A.Location = new System.Drawing.Point(131, 143);
            this.txtAddress2A.Name = "txtAddress2A";
            this.txtAddress2A.Size = new System.Drawing.Size(200, 20);
            this.txtAddress2A.TabIndex = 17;
            // 
            // txtAddress1A
            // 
            this.txtAddress1A.Location = new System.Drawing.Point(131, 119);
            this.txtAddress1A.Name = "txtAddress1A";
            this.txtAddress1A.Size = new System.Drawing.Size(200, 20);
            this.txtAddress1A.TabIndex = 16;
            // 
            // txtPhoneA
            // 
            this.txtPhoneA.Location = new System.Drawing.Point(131, 95);
            this.txtPhoneA.Name = "txtPhoneA";
            this.txtPhoneA.Size = new System.Drawing.Size(200, 20);
            this.txtPhoneA.TabIndex = 15;
            // 
            // txtLastNameA
            // 
            this.txtLastNameA.Location = new System.Drawing.Point(131, 47);
            this.txtLastNameA.Name = "txtLastNameA";
            this.txtLastNameA.Size = new System.Drawing.Size(200, 20);
            this.txtLastNameA.TabIndex = 13;
            // 
            // txtFirstNameA
            // 
            this.txtFirstNameA.Location = new System.Drawing.Point(131, 23);
            this.txtFirstNameA.Name = "txtFirstNameA";
            this.txtFirstNameA.Size = new System.Drawing.Size(200, 20);
            this.txtFirstNameA.TabIndex = 12;
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
            "ACT",
            "NT",
            "TAS"});
            this.cmbStateA.Location = new System.Drawing.Point(131, 191);
            this.cmbStateA.Name = "cmbStateA";
            this.cmbStateA.Size = new System.Drawing.Size(200, 21);
            this.cmbStateA.TabIndex = 19;
            // 
            // dtpDateOfBirthA
            // 
            this.dtpDateOfBirthA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateOfBirthA.Location = new System.Drawing.Point(131, 73);
            this.dtpDateOfBirthA.Name = "dtpDateOfBirthA";
            this.dtpDateOfBirthA.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirthA.TabIndex = 14;
            // 
            // dtpStartDateA
            // 
            this.dtpStartDateA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDateA.Location = new System.Drawing.Point(131, 236);
            this.dtpStartDateA.Name = "dtpStartDateA";
            this.dtpStartDateA.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDateA.TabIndex = 11;
            // 
            // lblQualificationCodeA
            // 
            this.lblQualificationCodeA.AutoSize = true;
            this.lblQualificationCodeA.Location = new System.Drawing.Point(32, 266);
            this.lblQualificationCodeA.Name = "lblQualificationCodeA";
            this.lblQualificationCodeA.Size = new System.Drawing.Size(93, 13);
            this.lblQualificationCodeA.TabIndex = 10;
            this.lblQualificationCodeA.Text = "Qualification Code";
            // 
            // lblStartDateA
            // 
            this.lblStartDateA.AutoSize = true;
            this.lblStartDateA.Location = new System.Drawing.Point(70, 242);
            this.lblStartDateA.Name = "lblStartDateA";
            this.lblStartDateA.Size = new System.Drawing.Size(55, 13);
            this.lblStartDateA.TabIndex = 9;
            this.lblStartDateA.Text = "Start Date";
            // 
            // lblPostcodeA
            // 
            this.lblPostcodeA.AutoSize = true;
            this.lblPostcodeA.Location = new System.Drawing.Point(73, 218);
            this.lblPostcodeA.Name = "lblPostcodeA";
            this.lblPostcodeA.Size = new System.Drawing.Size(52, 13);
            this.lblPostcodeA.TabIndex = 8;
            this.lblPostcodeA.Text = "Postcode";
            // 
            // lblStateA
            // 
            this.lblStateA.AutoSize = true;
            this.lblStateA.Location = new System.Drawing.Point(93, 194);
            this.lblStateA.Name = "lblStateA";
            this.lblStateA.Size = new System.Drawing.Size(32, 13);
            this.lblStateA.TabIndex = 7;
            this.lblStateA.Text = "State";
            // 
            // lblSuburbA
            // 
            this.lblSuburbA.AutoSize = true;
            this.lblSuburbA.Location = new System.Drawing.Point(84, 170);
            this.lblSuburbA.Name = "lblSuburbA";
            this.lblSuburbA.Size = new System.Drawing.Size(41, 13);
            this.lblSuburbA.TabIndex = 6;
            this.lblSuburbA.Text = "Suburb";
            // 
            // lblAddress2A
            // 
            this.lblAddress2A.AutoSize = true;
            this.lblAddress2A.Location = new System.Drawing.Point(71, 146);
            this.lblAddress2A.Name = "lblAddress2A";
            this.lblAddress2A.Size = new System.Drawing.Size(54, 13);
            this.lblAddress2A.TabIndex = 5;
            this.lblAddress2A.Text = "Address 2";
            // 
            // lblAddress1A
            // 
            this.lblAddress1A.AutoSize = true;
            this.lblAddress1A.Location = new System.Drawing.Point(71, 122);
            this.lblAddress1A.Name = "lblAddress1A";
            this.lblAddress1A.Size = new System.Drawing.Size(54, 13);
            this.lblAddress1A.TabIndex = 4;
            this.lblAddress1A.Text = "Address 1";
            // 
            // lblPhoneA
            // 
            this.lblPhoneA.AutoSize = true;
            this.lblPhoneA.Location = new System.Drawing.Point(87, 98);
            this.lblPhoneA.Name = "lblPhoneA";
            this.lblPhoneA.Size = new System.Drawing.Size(38, 13);
            this.lblPhoneA.TabIndex = 3;
            this.lblPhoneA.Text = "Phone";
            // 
            // lblDateOfBirthA
            // 
            this.lblDateOfBirthA.AutoSize = true;
            this.lblDateOfBirthA.Location = new System.Drawing.Point(59, 74);
            this.lblDateOfBirthA.Name = "lblDateOfBirthA";
            this.lblDateOfBirthA.Size = new System.Drawing.Size(66, 13);
            this.lblDateOfBirthA.TabIndex = 2;
            this.lblDateOfBirthA.Text = "Date of Birth";
            // 
            // lblLastNameA
            // 
            this.lblLastNameA.AutoSize = true;
            this.lblLastNameA.Location = new System.Drawing.Point(67, 50);
            this.lblLastNameA.Name = "lblLastNameA";
            this.lblLastNameA.Size = new System.Drawing.Size(58, 13);
            this.lblLastNameA.TabIndex = 1;
            this.lblLastNameA.Text = "Last Name";
            // 
            // lblFirstNameA
            // 
            this.lblFirstNameA.AutoSize = true;
            this.lblFirstNameA.Location = new System.Drawing.Point(68, 26);
            this.lblFirstNameA.Name = "lblFirstNameA";
            this.lblFirstNameA.Size = new System.Drawing.Size(57, 13);
            this.lblFirstNameA.TabIndex = 0;
            this.lblFirstNameA.Text = "First Name";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(609, 405);
            this.tabControl1.TabIndex = 0;
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 430);
            this.Controls.Add(this.tabControl1);
            this.Name = "StudentsForm";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource schoolDBDataSetBindingSource;
        private SchoolDBDataSet schoolDBDataSet;
        private System.Windows.Forms.BindingSource personBindingSource;
        private SchoolDBDataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDeleteU;
        private System.Windows.Forms.Button btnExitU;
        private System.Windows.Forms.Button btnUpdateU;
        private System.Windows.Forms.ComboBox cmbQualificationCodeU;
        private System.Windows.Forms.TextBox txtPostcodeU;
        private System.Windows.Forms.TextBox txtSuburbU;
        private System.Windows.Forms.TextBox txtAddress2U;
        private System.Windows.Forms.TextBox txtAddress1U;
        private System.Windows.Forms.TextBox txtPhoneU;
        private System.Windows.Forms.TextBox txtLastNameU;
        private System.Windows.Forms.TextBox txtFirstNameU;
        private System.Windows.Forms.ComboBox cmbStateU;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirthU;
        private System.Windows.Forms.DateTimePicker dtpStartDateU;
        private System.Windows.Forms.Label lblQualificationCodeU;
        private System.Windows.Forms.Label lblStartDateU;
        private System.Windows.Forms.Label lblPostcodeU;
        private System.Windows.Forms.Label lblStateU;
        private System.Windows.Forms.Label lblSuburbU;
        private System.Windows.Forms.Label lblAddress2U;
        private System.Windows.Forms.Label lblAddress1U;
        private System.Windows.Forms.Label lblPhoneU;
        private System.Windows.Forms.Label lblDateOfBirthU;
        private System.Windows.Forms.Label lblLastNameU;
        private System.Windows.Forms.Label lblFirstNameU;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnExitA;
        private System.Windows.Forms.Button btnAddA;
        private System.Windows.Forms.ComboBox cmbQualificationCodeA;
        private System.Windows.Forms.TextBox txtPostcodeA;
        private System.Windows.Forms.TextBox txtSuburbA;
        private System.Windows.Forms.TextBox txtAddress2A;
        private System.Windows.Forms.TextBox txtAddress1A;
        private System.Windows.Forms.TextBox txtPhoneA;
        private System.Windows.Forms.TextBox txtLastNameA;
        private System.Windows.Forms.TextBox txtFirstNameA;
        private System.Windows.Forms.ComboBox cmbStateA;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirthA;
        private System.Windows.Forms.DateTimePicker dtpStartDateA;
        private System.Windows.Forms.Label lblQualificationCodeA;
        private System.Windows.Forms.Label lblStartDateA;
        private System.Windows.Forms.Label lblPostcodeA;
        private System.Windows.Forms.Label lblStateA;
        private System.Windows.Forms.Label lblSuburbA;
        private System.Windows.Forms.Label lblAddress2A;
        private System.Windows.Forms.Label lblAddress1A;
        private System.Windows.Forms.Label lblPhoneA;
        private System.Windows.Forms.Label lblDateOfBirthA;
        private System.Windows.Forms.Label lblLastNameA;
        private System.Windows.Forms.Label lblFirstNameA;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lblStudentIDU;
        private System.Windows.Forms.ComboBox cmbStudentIDU;
        private System.Windows.Forms.Label lblQNameU;
        private System.Windows.Forms.Label lblQNameA;
        private System.Windows.Forms.Label lblFirstNameMessageA;
        private System.Windows.Forms.Label lblPhoneMessageA;
        private System.Windows.Forms.Label lblLastNameMessageA;
        private System.Windows.Forms.Label lblPostcodeMessageA;
        private System.Windows.Forms.Label lblStateMessageA;
        private System.Windows.Forms.Label lblSuburbMessageA;
        private System.Windows.Forms.Label lblAddress1MessageA;
    }
}