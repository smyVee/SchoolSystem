namespace SchoolSystem
{
    partial class CoursesForm
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
            this.lblQualificationNameA = new System.Windows.Forms.Label();
            this.lblQualificationCodeA = new System.Windows.Forms.Label();
            this.cmbQualificationCodeA = new System.Windows.Forms.ComboBox();
            this.lblSemesterMessageA = new System.Windows.Forms.Label();
            this.lblYearMessageA = new System.Windows.Forms.Label();
            this.lblCourseNameMessageA = new System.Windows.Forms.Label();
            this.lblCourseIDMessageA = new System.Windows.Forms.Label();
            this.txtCourseIDA = new System.Windows.Forms.TextBox();
            this.lblCourseIDA = new System.Windows.Forms.Label();
            this.cmbSemesterA = new System.Windows.Forms.ComboBox();
            this.cmbYearA = new System.Windows.Forms.ComboBox();
            this.lblTeacherNameA = new System.Windows.Forms.Label();
            this.cmbTeacherIDA = new System.Windows.Forms.ComboBox();
            this.lblTeacherIDA = new System.Windows.Forms.Label();
            this.btnExitA = new System.Windows.Forms.Button();
            this.btnAddA = new System.Windows.Forms.Button();
            this.txtCourseNameA = new System.Windows.Forms.TextBox();
            this.lblSemesterA = new System.Windows.Forms.Label();
            this.lblYearA = new System.Windows.Forms.Label();
            this.lblCourseNameA = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblCourseNameMessageU = new System.Windows.Forms.Label();
            this.lblTeacherNameU = new System.Windows.Forms.Label();
            this.cmbTeacherIDU = new System.Windows.Forms.ComboBox();
            this.lblTeacherIDU = new System.Windows.Forms.Label();
            this.cmbSemesterU = new System.Windows.Forms.ComboBox();
            this.cmbYearU = new System.Windows.Forms.ComboBox();
            this.btnDeleteU = new System.Windows.Forms.Button();
            this.cmbCourseIDU = new System.Windows.Forms.ComboBox();
            this.lblCourseIDU = new System.Windows.Forms.Label();
            this.btnExitU = new System.Windows.Forms.Button();
            this.btnUpdateU = new System.Windows.Forms.Button();
            this.txtCourseNameU = new System.Windows.Forms.TextBox();
            this.lblSemesterU = new System.Windows.Forms.Label();
            this.lblYearU = new System.Windows.Forms.Label();
            this.lblCourseNameU = new System.Windows.Forms.Label();
            this.qualificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDBDataSet = new SchoolSystem.SchoolDBDataSet();
            this.qualificationTableAdapter = new SchoolSystem.SchoolDBDataSetTableAdapters.QualificationTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblCoursesMessageA = new System.Windows.Forms.Label();
            this.lblCoursesMessageU = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(503, 329);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblCoursesMessageA);
            this.tabPage1.Controls.Add(this.lblQualificationNameA);
            this.tabPage1.Controls.Add(this.lblQualificationCodeA);
            this.tabPage1.Controls.Add(this.cmbQualificationCodeA);
            this.tabPage1.Controls.Add(this.lblSemesterMessageA);
            this.tabPage1.Controls.Add(this.lblYearMessageA);
            this.tabPage1.Controls.Add(this.lblCourseNameMessageA);
            this.tabPage1.Controls.Add(this.lblCourseIDMessageA);
            this.tabPage1.Controls.Add(this.txtCourseIDA);
            this.tabPage1.Controls.Add(this.lblCourseIDA);
            this.tabPage1.Controls.Add(this.cmbSemesterA);
            this.tabPage1.Controls.Add(this.cmbYearA);
            this.tabPage1.Controls.Add(this.lblTeacherNameA);
            this.tabPage1.Controls.Add(this.cmbTeacherIDA);
            this.tabPage1.Controls.Add(this.lblTeacherIDA);
            this.tabPage1.Controls.Add(this.btnExitA);
            this.tabPage1.Controls.Add(this.btnAddA);
            this.tabPage1.Controls.Add(this.txtCourseNameA);
            this.tabPage1.Controls.Add(this.lblSemesterA);
            this.tabPage1.Controls.Add(this.lblYearA);
            this.tabPage1.Controls.Add(this.lblCourseNameA);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(495, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblQualificationNameA
            // 
            this.lblQualificationNameA.AutoSize = true;
            this.lblQualificationNameA.Location = new System.Drawing.Point(270, 157);
            this.lblQualificationNameA.Name = "lblQualificationNameA";
            this.lblQualificationNameA.Size = new System.Drawing.Size(0, 13);
            this.lblQualificationNameA.TabIndex = 57;
            // 
            // lblQualificationCodeA
            // 
            this.lblQualificationCodeA.AutoSize = true;
            this.lblQualificationCodeA.Location = new System.Drawing.Point(32, 157);
            this.lblQualificationCodeA.Name = "lblQualificationCodeA";
            this.lblQualificationCodeA.Size = new System.Drawing.Size(93, 13);
            this.lblQualificationCodeA.TabIndex = 56;
            this.lblQualificationCodeA.Text = "Qualification Code";
            // 
            // cmbQualificationCodeA
            // 
            this.cmbQualificationCodeA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQualificationCodeA.FormattingEnabled = true;
            this.cmbQualificationCodeA.Items.AddRange(new object[] {
            "Autumn",
            "Winter",
            "Spring"});
            this.cmbQualificationCodeA.Location = new System.Drawing.Point(131, 154);
            this.cmbQualificationCodeA.Name = "cmbQualificationCodeA";
            this.cmbQualificationCodeA.Size = new System.Drawing.Size(133, 21);
            this.cmbQualificationCodeA.TabIndex = 55;
            this.cmbQualificationCodeA.SelectedIndexChanged += new System.EventHandler(this.cmbQualificationCodeA_SelectedIndexChanged);
            // 
            // lblSemesterMessageA
            // 
            this.lblSemesterMessageA.AutoSize = true;
            this.lblSemesterMessageA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSemesterMessageA.Location = new System.Drawing.Point(270, 104);
            this.lblSemesterMessageA.Name = "lblSemesterMessageA";
            this.lblSemesterMessageA.Size = new System.Drawing.Size(0, 13);
            this.lblSemesterMessageA.TabIndex = 54;
            // 
            // lblYearMessageA
            // 
            this.lblYearMessageA.AutoSize = true;
            this.lblYearMessageA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblYearMessageA.Location = new System.Drawing.Point(270, 78);
            this.lblYearMessageA.Name = "lblYearMessageA";
            this.lblYearMessageA.Size = new System.Drawing.Size(0, 13);
            this.lblYearMessageA.TabIndex = 53;
            // 
            // lblCourseNameMessageA
            // 
            this.lblCourseNameMessageA.AutoSize = true;
            this.lblCourseNameMessageA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCourseNameMessageA.Location = new System.Drawing.Point(270, 52);
            this.lblCourseNameMessageA.Name = "lblCourseNameMessageA";
            this.lblCourseNameMessageA.Size = new System.Drawing.Size(0, 13);
            this.lblCourseNameMessageA.TabIndex = 52;
            // 
            // lblCourseIDMessageA
            // 
            this.lblCourseIDMessageA.AutoSize = true;
            this.lblCourseIDMessageA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCourseIDMessageA.Location = new System.Drawing.Point(270, 26);
            this.lblCourseIDMessageA.Name = "lblCourseIDMessageA";
            this.lblCourseIDMessageA.Size = new System.Drawing.Size(0, 13);
            this.lblCourseIDMessageA.TabIndex = 51;
            // 
            // txtCourseIDA
            // 
            this.txtCourseIDA.Location = new System.Drawing.Point(131, 23);
            this.txtCourseIDA.Name = "txtCourseIDA";
            this.txtCourseIDA.Size = new System.Drawing.Size(133, 20);
            this.txtCourseIDA.TabIndex = 50;
            // 
            // lblCourseIDA
            // 
            this.lblCourseIDA.AutoSize = true;
            this.lblCourseIDA.Location = new System.Drawing.Point(71, 26);
            this.lblCourseIDA.Name = "lblCourseIDA";
            this.lblCourseIDA.Size = new System.Drawing.Size(54, 13);
            this.lblCourseIDA.TabIndex = 49;
            this.lblCourseIDA.Text = "Course ID";
            // 
            // cmbSemesterA
            // 
            this.cmbSemesterA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemesterA.FormattingEnabled = true;
            this.cmbSemesterA.Items.AddRange(new object[] {
            "Autumn",
            "Winter",
            "Spring"});
            this.cmbSemesterA.Location = new System.Drawing.Point(131, 101);
            this.cmbSemesterA.Name = "cmbSemesterA";
            this.cmbSemesterA.Size = new System.Drawing.Size(133, 21);
            this.cmbSemesterA.TabIndex = 48;
            // 
            // cmbYearA
            // 
            this.cmbYearA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYearA.FormattingEnabled = true;
            this.cmbYearA.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbYearA.Location = new System.Drawing.Point(131, 75);
            this.cmbYearA.Name = "cmbYearA";
            this.cmbYearA.Size = new System.Drawing.Size(133, 21);
            this.cmbYearA.TabIndex = 47;
            // 
            // lblTeacherNameA
            // 
            this.lblTeacherNameA.AutoSize = true;
            this.lblTeacherNameA.Location = new System.Drawing.Point(270, 130);
            this.lblTeacherNameA.Name = "lblTeacherNameA";
            this.lblTeacherNameA.Size = new System.Drawing.Size(0, 13);
            this.lblTeacherNameA.TabIndex = 46;
            // 
            // cmbTeacherIDA
            // 
            this.cmbTeacherIDA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeacherIDA.FormattingEnabled = true;
            this.cmbTeacherIDA.Items.AddRange(new object[] {
            "Autumn",
            "Winter",
            "Spring"});
            this.cmbTeacherIDA.Location = new System.Drawing.Point(131, 127);
            this.cmbTeacherIDA.Name = "cmbTeacherIDA";
            this.cmbTeacherIDA.Size = new System.Drawing.Size(133, 21);
            this.cmbTeacherIDA.TabIndex = 45;
            this.cmbTeacherIDA.SelectedIndexChanged += new System.EventHandler(this.cmbTeacherIDA_SelectedIndexChanged);
            // 
            // lblTeacherIDA
            // 
            this.lblTeacherIDA.AutoSize = true;
            this.lblTeacherIDA.Location = new System.Drawing.Point(64, 130);
            this.lblTeacherIDA.Name = "lblTeacherIDA";
            this.lblTeacherIDA.Size = new System.Drawing.Size(61, 13);
            this.lblTeacherIDA.TabIndex = 44;
            this.lblTeacherIDA.Text = "Teacher ID";
            // 
            // btnExitA
            // 
            this.btnExitA.Location = new System.Drawing.Point(212, 190);
            this.btnExitA.Name = "btnExitA";
            this.btnExitA.Size = new System.Drawing.Size(75, 23);
            this.btnExitA.TabIndex = 17;
            this.btnExitA.Text = "E&xit";
            this.btnExitA.UseVisualStyleBackColor = true;
            this.btnExitA.Click += new System.EventHandler(this.btnExitA_Click);
            // 
            // btnAddA
            // 
            this.btnAddA.Location = new System.Drawing.Point(131, 190);
            this.btnAddA.Name = "btnAddA";
            this.btnAddA.Size = new System.Drawing.Size(75, 23);
            this.btnAddA.TabIndex = 16;
            this.btnAddA.Text = "&Add";
            this.btnAddA.UseVisualStyleBackColor = true;
            this.btnAddA.Click += new System.EventHandler(this.btnAddA_Click);
            // 
            // txtCourseNameA
            // 
            this.txtCourseNameA.Location = new System.Drawing.Point(131, 49);
            this.txtCourseNameA.Name = "txtCourseNameA";
            this.txtCourseNameA.Size = new System.Drawing.Size(133, 20);
            this.txtCourseNameA.TabIndex = 12;
            // 
            // lblSemesterA
            // 
            this.lblSemesterA.AutoSize = true;
            this.lblSemesterA.Location = new System.Drawing.Point(74, 104);
            this.lblSemesterA.Name = "lblSemesterA";
            this.lblSemesterA.Size = new System.Drawing.Size(51, 13);
            this.lblSemesterA.TabIndex = 10;
            this.lblSemesterA.Text = "Semester";
            // 
            // lblYearA
            // 
            this.lblYearA.AutoSize = true;
            this.lblYearA.Location = new System.Drawing.Point(96, 78);
            this.lblYearA.Name = "lblYearA";
            this.lblYearA.Size = new System.Drawing.Size(29, 13);
            this.lblYearA.TabIndex = 9;
            this.lblYearA.Text = "Year";
            // 
            // lblCourseNameA
            // 
            this.lblCourseNameA.AutoSize = true;
            this.lblCourseNameA.Location = new System.Drawing.Point(54, 52);
            this.lblCourseNameA.Name = "lblCourseNameA";
            this.lblCourseNameA.Size = new System.Drawing.Size(71, 13);
            this.lblCourseNameA.TabIndex = 8;
            this.lblCourseNameA.Text = "Course Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblCoursesMessageU);
            this.tabPage2.Controls.Add(this.lblCourseNameMessageU);
            this.tabPage2.Controls.Add(this.lblTeacherNameU);
            this.tabPage2.Controls.Add(this.cmbTeacherIDU);
            this.tabPage2.Controls.Add(this.lblTeacherIDU);
            this.tabPage2.Controls.Add(this.cmbSemesterU);
            this.tabPage2.Controls.Add(this.cmbYearU);
            this.tabPage2.Controls.Add(this.btnDeleteU);
            this.tabPage2.Controls.Add(this.cmbCourseIDU);
            this.tabPage2.Controls.Add(this.lblCourseIDU);
            this.tabPage2.Controls.Add(this.btnExitU);
            this.tabPage2.Controls.Add(this.btnUpdateU);
            this.tabPage2.Controls.Add(this.txtCourseNameU);
            this.tabPage2.Controls.Add(this.lblSemesterU);
            this.tabPage2.Controls.Add(this.lblYearU);
            this.tabPage2.Controls.Add(this.lblCourseNameU);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(495, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update / Delete";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblCourseNameMessageU
            // 
            this.lblCourseNameMessageU.AutoSize = true;
            this.lblCourseNameMessageU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCourseNameMessageU.Location = new System.Drawing.Point(246, 44);
            this.lblCourseNameMessageU.Name = "lblCourseNameMessageU";
            this.lblCourseNameMessageU.Size = new System.Drawing.Size(0, 13);
            this.lblCourseNameMessageU.TabIndex = 52;
            // 
            // lblTeacherNameU
            // 
            this.lblTeacherNameU.AutoSize = true;
            this.lblTeacherNameU.Location = new System.Drawing.Point(246, 123);
            this.lblTeacherNameU.Name = "lblTeacherNameU";
            this.lblTeacherNameU.Size = new System.Drawing.Size(0, 13);
            this.lblTeacherNameU.TabIndex = 43;
            // 
            // cmbTeacherIDU
            // 
            this.cmbTeacherIDU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeacherIDU.FormattingEnabled = true;
            this.cmbTeacherIDU.Items.AddRange(new object[] {
            "Autumn",
            "Winter",
            "Spring"});
            this.cmbTeacherIDU.Location = new System.Drawing.Point(107, 120);
            this.cmbTeacherIDU.Name = "cmbTeacherIDU";
            this.cmbTeacherIDU.Size = new System.Drawing.Size(133, 21);
            this.cmbTeacherIDU.TabIndex = 42;
            this.cmbTeacherIDU.SelectedIndexChanged += new System.EventHandler(this.cmbTeacherIDU_SelectedIndexChanged);
            // 
            // lblTeacherIDU
            // 
            this.lblTeacherIDU.AutoSize = true;
            this.lblTeacherIDU.Location = new System.Drawing.Point(40, 123);
            this.lblTeacherIDU.Name = "lblTeacherIDU";
            this.lblTeacherIDU.Size = new System.Drawing.Size(61, 13);
            this.lblTeacherIDU.TabIndex = 41;
            this.lblTeacherIDU.Text = "Teacher ID";
            // 
            // cmbSemesterU
            // 
            this.cmbSemesterU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemesterU.FormattingEnabled = true;
            this.cmbSemesterU.Items.AddRange(new object[] {
            "Autumn",
            "Winter",
            "Spring"});
            this.cmbSemesterU.Location = new System.Drawing.Point(107, 93);
            this.cmbSemesterU.Name = "cmbSemesterU";
            this.cmbSemesterU.Size = new System.Drawing.Size(133, 21);
            this.cmbSemesterU.TabIndex = 40;
            // 
            // cmbYearU
            // 
            this.cmbYearU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYearU.FormattingEnabled = true;
            this.cmbYearU.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbYearU.Location = new System.Drawing.Point(107, 67);
            this.cmbYearU.Name = "cmbYearU";
            this.cmbYearU.Size = new System.Drawing.Size(133, 21);
            this.cmbYearU.TabIndex = 39;
            // 
            // btnDeleteU
            // 
            this.btnDeleteU.Location = new System.Drawing.Point(186, 147);
            this.btnDeleteU.Name = "btnDeleteU";
            this.btnDeleteU.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteU.TabIndex = 38;
            this.btnDeleteU.Text = "&Delete";
            this.btnDeleteU.UseVisualStyleBackColor = true;
            this.btnDeleteU.Click += new System.EventHandler(this.btnDeleteU_Click);
            // 
            // cmbCourseIDU
            // 
            this.cmbCourseIDU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourseIDU.FormattingEnabled = true;
            this.cmbCourseIDU.Location = new System.Drawing.Point(107, 14);
            this.cmbCourseIDU.Name = "cmbCourseIDU";
            this.cmbCourseIDU.Size = new System.Drawing.Size(133, 21);
            this.cmbCourseIDU.TabIndex = 37;
            this.cmbCourseIDU.SelectedIndexChanged += new System.EventHandler(this.cmbCourseIDU_SelectedIndexChanged);
            // 
            // lblCourseIDU
            // 
            this.lblCourseIDU.AutoSize = true;
            this.lblCourseIDU.Location = new System.Drawing.Point(47, 17);
            this.lblCourseIDU.Name = "lblCourseIDU";
            this.lblCourseIDU.Size = new System.Drawing.Size(54, 13);
            this.lblCourseIDU.TabIndex = 36;
            this.lblCourseIDU.Text = "Course ID";
            // 
            // btnExitU
            // 
            this.btnExitU.Location = new System.Drawing.Point(267, 147);
            this.btnExitU.Name = "btnExitU";
            this.btnExitU.Size = new System.Drawing.Size(75, 23);
            this.btnExitU.TabIndex = 31;
            this.btnExitU.Text = "E&xit";
            this.btnExitU.UseVisualStyleBackColor = true;
            this.btnExitU.Click += new System.EventHandler(this.btnExitU_Click);
            // 
            // btnUpdateU
            // 
            this.btnUpdateU.Location = new System.Drawing.Point(107, 147);
            this.btnUpdateU.Name = "btnUpdateU";
            this.btnUpdateU.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateU.TabIndex = 30;
            this.btnUpdateU.Text = "&Update";
            this.btnUpdateU.UseVisualStyleBackColor = true;
            this.btnUpdateU.Click += new System.EventHandler(this.btnUpdateU_Click);
            // 
            // txtCourseNameU
            // 
            this.txtCourseNameU.Location = new System.Drawing.Point(107, 41);
            this.txtCourseNameU.Name = "txtCourseNameU";
            this.txtCourseNameU.Size = new System.Drawing.Size(133, 20);
            this.txtCourseNameU.TabIndex = 26;
            // 
            // lblSemesterU
            // 
            this.lblSemesterU.AutoSize = true;
            this.lblSemesterU.Location = new System.Drawing.Point(50, 96);
            this.lblSemesterU.Name = "lblSemesterU";
            this.lblSemesterU.Size = new System.Drawing.Size(51, 13);
            this.lblSemesterU.TabIndex = 24;
            this.lblSemesterU.Text = "Semester";
            // 
            // lblYearU
            // 
            this.lblYearU.AutoSize = true;
            this.lblYearU.Location = new System.Drawing.Point(72, 70);
            this.lblYearU.Name = "lblYearU";
            this.lblYearU.Size = new System.Drawing.Size(29, 13);
            this.lblYearU.TabIndex = 23;
            this.lblYearU.Text = "Year";
            // 
            // lblCourseNameU
            // 
            this.lblCourseNameU.AutoSize = true;
            this.lblCourseNameU.Location = new System.Drawing.Point(30, 44);
            this.lblCourseNameU.Name = "lblCourseNameU";
            this.lblCourseNameU.Size = new System.Drawing.Size(71, 13);
            this.lblCourseNameU.TabIndex = 22;
            this.lblCourseNameU.Text = "Course Name";
            // 
            // qualificationBindingSource
            // 
            this.qualificationBindingSource.DataMember = "Qualification";
            this.qualificationBindingSource.DataSource = this.schoolDBDataSet;
            // 
            // schoolDBDataSet
            // 
            this.schoolDBDataSet.DataSetName = "SchoolDBDataSet";
            this.schoolDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qualificationTableAdapter
            // 
            this.qualificationTableAdapter.ClearBeforeFill = true;
            // 
            // lblCoursesMessageA
            // 
            this.lblCoursesMessageA.AutoSize = true;
            this.lblCoursesMessageA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCoursesMessageA.Location = new System.Drawing.Point(128, 231);
            this.lblCoursesMessageA.Name = "lblCoursesMessageA";
            this.lblCoursesMessageA.Size = new System.Drawing.Size(0, 13);
            this.lblCoursesMessageA.TabIndex = 58;
            // 
            // lblCoursesMessageU
            // 
            this.lblCoursesMessageU.AutoSize = true;
            this.lblCoursesMessageU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCoursesMessageU.Location = new System.Drawing.Point(104, 188);
            this.lblCoursesMessageU.Name = "lblCoursesMessageU";
            this.lblCoursesMessageU.Size = new System.Drawing.Size(0, 13);
            this.lblCoursesMessageU.TabIndex = 53;
            // 
            // CoursesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 335);
            this.Controls.Add(this.tabControl1);
            this.Name = "CoursesForm";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.CoursesForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtCourseNameA;
        private System.Windows.Forms.Label lblSemesterA;
        private System.Windows.Forms.Label lblYearA;
        private System.Windows.Forms.Label lblCourseNameA;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnExitA;
        private System.Windows.Forms.Button btnAddA;
        private System.Windows.Forms.ComboBox cmbCourseIDU;
        private System.Windows.Forms.Label lblCourseIDU;
        private System.Windows.Forms.Button btnExitU;
        private System.Windows.Forms.Button btnUpdateU;
        private System.Windows.Forms.TextBox txtCourseNameU;
        private System.Windows.Forms.Label lblSemesterU;
        private System.Windows.Forms.Label lblYearU;
        private System.Windows.Forms.Label lblCourseNameU;
        private System.Windows.Forms.Button btnDeleteU;
        private System.Windows.Forms.ComboBox cmbSemesterU;
        private System.Windows.Forms.ComboBox cmbYearU;
        private SchoolDBDataSet schoolDBDataSet;
        private System.Windows.Forms.BindingSource qualificationBindingSource;
        private SchoolDBDataSetTableAdapters.QualificationTableAdapter qualificationTableAdapter;
        private System.Windows.Forms.ComboBox cmbTeacherIDU;
        private System.Windows.Forms.Label lblTeacherIDU;
        private System.Windows.Forms.Label lblTeacherNameU;
        private System.Windows.Forms.Label lblTeacherNameA;
        private System.Windows.Forms.ComboBox cmbTeacherIDA;
        private System.Windows.Forms.Label lblTeacherIDA;
        private System.Windows.Forms.ComboBox cmbSemesterA;
        private System.Windows.Forms.ComboBox cmbYearA;
        private System.Windows.Forms.TextBox txtCourseIDA;
        private System.Windows.Forms.Label lblCourseIDA;
        private System.Windows.Forms.Label lblSemesterMessageA;
        private System.Windows.Forms.Label lblYearMessageA;
        private System.Windows.Forms.Label lblCourseNameMessageA;
        private System.Windows.Forms.Label lblCourseIDMessageA;
        private System.Windows.Forms.Label lblCourseNameMessageU;
        private System.Windows.Forms.Label lblQualificationNameA;
        private System.Windows.Forms.Label lblQualificationCodeA;
        private System.Windows.Forms.ComboBox cmbQualificationCodeA;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblCoursesMessageA;
        private System.Windows.Forms.Label lblCoursesMessageU;

    }
}