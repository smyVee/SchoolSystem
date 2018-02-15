namespace SchoolSystem
{
    partial class QualificationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QualificationsForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblDurationMessageA = new System.Windows.Forms.Label();
            this.lblQualificationNameMessageA = new System.Windows.Forms.Label();
            this.lblQualificationIDMessageA = new System.Windows.Forms.Label();
            this.txtQualificationIDA = new System.Windows.Forms.TextBox();
            this.lblQualificationIDA = new System.Windows.Forms.Label();
            this.cmbDurationA = new System.Windows.Forms.ComboBox();
            this.txtQualificationNameA = new System.Windows.Forms.TextBox();
            this.lblDurationA = new System.Windows.Forms.Label();
            this.lblQualificationNameA = new System.Windows.Forms.Label();
            this.btnExitA = new System.Windows.Forms.Button();
            this.btnAddA = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblQualificationNameMessageU = new System.Windows.Forms.Label();
            this.cmbDurationU = new System.Windows.Forms.ComboBox();
            this.btnExitU = new System.Windows.Forms.Button();
            this.cmbQualificationIDU = new System.Windows.Forms.ComboBox();
            this.lblQualificationIDU = new System.Windows.Forms.Label();
            this.txtQualificationNameU = new System.Windows.Forms.TextBox();
            this.lblDurationU = new System.Windows.Forms.Label();
            this.lblQualificationNameU = new System.Windows.Forms.Label();
            this.btnDeleteU = new System.Windows.Forms.Button();
            this.btnUpdateU = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlHelpC = new System.Windows.Forms.Panel();
            this.lblHelp2 = new System.Windows.Forms.Label();
            this.lblHelp3 = new System.Windows.Forms.Label();
            this.lblHelp4 = new System.Windows.Forms.Label();
            this.btnCloseHelpC = new System.Windows.Forms.Button();
            this.lblHelp1 = new System.Windows.Forms.Label();
            this.btnHelpC = new System.Windows.Forms.Button();
            this.lblAvailableCoursesC = new System.Windows.Forms.Label();
            this.lblQualificationNameC = new System.Windows.Forms.Label();
            this.lblCoursesInQualC = new System.Windows.Forms.Label();
            this.btnAddC = new System.Windows.Forms.Button();
            this.btnDeleteC = new System.Windows.Forms.Button();
            this.dgvAvailableCoursesC = new System.Windows.Forms.DataGridView();
            this.dgvCoursesC = new System.Windows.Forms.DataGridView();
            this.cmbQualificationIDC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExitC = new System.Windows.Forms.Button();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schoolDBDataSet = new SchoolSystem.SchoolDBDataSet();
            this.courseTableAdapter = new SchoolSystem.SchoolDBDataSetTableAdapters.CourseTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlHelpC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableCoursesC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoursesC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(556, 364);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblDurationMessageA);
            this.tabPage1.Controls.Add(this.lblQualificationNameMessageA);
            this.tabPage1.Controls.Add(this.lblQualificationIDMessageA);
            this.tabPage1.Controls.Add(this.txtQualificationIDA);
            this.tabPage1.Controls.Add(this.lblQualificationIDA);
            this.tabPage1.Controls.Add(this.cmbDurationA);
            this.tabPage1.Controls.Add(this.txtQualificationNameA);
            this.tabPage1.Controls.Add(this.lblDurationA);
            this.tabPage1.Controls.Add(this.lblQualificationNameA);
            this.tabPage1.Controls.Add(this.btnExitA);
            this.tabPage1.Controls.Add(this.btnAddA);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(539, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblDurationMessageA
            // 
            this.lblDurationMessageA.AutoSize = true;
            this.lblDurationMessageA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDurationMessageA.Location = new System.Drawing.Point(246, 87);
            this.lblDurationMessageA.Name = "lblDurationMessageA";
            this.lblDurationMessageA.Size = new System.Drawing.Size(0, 13);
            this.lblDurationMessageA.TabIndex = 22;
            // 
            // lblQualificationNameMessageA
            // 
            this.lblQualificationNameMessageA.AutoSize = true;
            this.lblQualificationNameMessageA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblQualificationNameMessageA.Location = new System.Drawing.Point(246, 60);
            this.lblQualificationNameMessageA.Name = "lblQualificationNameMessageA";
            this.lblQualificationNameMessageA.Size = new System.Drawing.Size(0, 13);
            this.lblQualificationNameMessageA.TabIndex = 9;
            // 
            // lblQualificationIDMessageA
            // 
            this.lblQualificationIDMessageA.AutoSize = true;
            this.lblQualificationIDMessageA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblQualificationIDMessageA.Location = new System.Drawing.Point(246, 34);
            this.lblQualificationIDMessageA.Name = "lblQualificationIDMessageA";
            this.lblQualificationIDMessageA.Size = new System.Drawing.Size(0, 13);
            this.lblQualificationIDMessageA.TabIndex = 8;
            // 
            // txtQualificationIDA
            // 
            this.txtQualificationIDA.Location = new System.Drawing.Point(119, 31);
            this.txtQualificationIDA.Name = "txtQualificationIDA";
            this.txtQualificationIDA.Size = new System.Drawing.Size(121, 20);
            this.txtQualificationIDA.TabIndex = 7;
            // 
            // lblQualificationIDA
            // 
            this.lblQualificationIDA.AutoSize = true;
            this.lblQualificationIDA.Location = new System.Drawing.Point(34, 34);
            this.lblQualificationIDA.Name = "lblQualificationIDA";
            this.lblQualificationIDA.Size = new System.Drawing.Size(79, 13);
            this.lblQualificationIDA.TabIndex = 6;
            this.lblQualificationIDA.Text = "Qualification ID";
            // 
            // cmbDurationA
            // 
            this.cmbDurationA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurationA.FormattingEnabled = true;
            this.cmbDurationA.Items.AddRange(new object[] {
            "1 month",
            "2 months",
            "3 months",
            "4 months",
            "5 months",
            "6 months",
            "7 months",
            "8 months",
            "9 months",
            "10 months",
            "11 months",
            "12 months"});
            this.cmbDurationA.Location = new System.Drawing.Point(119, 84);
            this.cmbDurationA.Name = "cmbDurationA";
            this.cmbDurationA.Size = new System.Drawing.Size(121, 21);
            this.cmbDurationA.TabIndex = 5;
            // 
            // txtQualificationNameA
            // 
            this.txtQualificationNameA.Location = new System.Drawing.Point(119, 57);
            this.txtQualificationNameA.Name = "txtQualificationNameA";
            this.txtQualificationNameA.Size = new System.Drawing.Size(121, 20);
            this.txtQualificationNameA.TabIndex = 4;
            // 
            // lblDurationA
            // 
            this.lblDurationA.AutoSize = true;
            this.lblDurationA.Location = new System.Drawing.Point(66, 87);
            this.lblDurationA.Name = "lblDurationA";
            this.lblDurationA.Size = new System.Drawing.Size(47, 13);
            this.lblDurationA.TabIndex = 3;
            this.lblDurationA.Text = "Duration";
            // 
            // lblQualificationNameA
            // 
            this.lblQualificationNameA.AutoSize = true;
            this.lblQualificationNameA.Location = new System.Drawing.Point(17, 60);
            this.lblQualificationNameA.Name = "lblQualificationNameA";
            this.lblQualificationNameA.Size = new System.Drawing.Size(96, 13);
            this.lblQualificationNameA.TabIndex = 2;
            this.lblQualificationNameA.Text = "Qualification Name";
            // 
            // btnExitA
            // 
            this.btnExitA.Location = new System.Drawing.Point(200, 110);
            this.btnExitA.Name = "btnExitA";
            this.btnExitA.Size = new System.Drawing.Size(75, 23);
            this.btnExitA.TabIndex = 1;
            this.btnExitA.Text = "E&xit";
            this.btnExitA.UseVisualStyleBackColor = true;
            this.btnExitA.Click += new System.EventHandler(this.btnExitA_Click);
            // 
            // btnAddA
            // 
            this.btnAddA.Location = new System.Drawing.Point(119, 110);
            this.btnAddA.Name = "btnAddA";
            this.btnAddA.Size = new System.Drawing.Size(75, 23);
            this.btnAddA.TabIndex = 0;
            this.btnAddA.Text = "&Add";
            this.btnAddA.UseVisualStyleBackColor = true;
            this.btnAddA.Click += new System.EventHandler(this.btnAddA_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblQualificationNameMessageU);
            this.tabPage2.Controls.Add(this.cmbDurationU);
            this.tabPage2.Controls.Add(this.btnExitU);
            this.tabPage2.Controls.Add(this.cmbQualificationIDU);
            this.tabPage2.Controls.Add(this.lblQualificationIDU);
            this.tabPage2.Controls.Add(this.txtQualificationNameU);
            this.tabPage2.Controls.Add(this.lblDurationU);
            this.tabPage2.Controls.Add(this.lblQualificationNameU);
            this.tabPage2.Controls.Add(this.btnDeleteU);
            this.tabPage2.Controls.Add(this.btnUpdateU);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(539, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update / Delete";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblQualificationNameMessageU
            // 
            this.lblQualificationNameMessageU.AutoSize = true;
            this.lblQualificationNameMessageU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblQualificationNameMessageU.Location = new System.Drawing.Point(266, 57);
            this.lblQualificationNameMessageU.Name = "lblQualificationNameMessageU";
            this.lblQualificationNameMessageU.Size = new System.Drawing.Size(0, 13);
            this.lblQualificationNameMessageU.TabIndex = 20;
            // 
            // cmbDurationU
            // 
            this.cmbDurationU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurationU.FormattingEnabled = true;
            this.cmbDurationU.Items.AddRange(new object[] {
            "1 month",
            "2 months",
            "3 months",
            "4 months",
            "5 months",
            "6 months",
            "7 months",
            "8 months",
            "9 months",
            "10 months",
            "11 months",
            "12 months"});
            this.cmbDurationU.Location = new System.Drawing.Point(139, 80);
            this.cmbDurationU.Name = "cmbDurationU";
            this.cmbDurationU.Size = new System.Drawing.Size(121, 21);
            this.cmbDurationU.TabIndex = 19;
            // 
            // btnExitU
            // 
            this.btnExitU.Location = new System.Drawing.Point(301, 107);
            this.btnExitU.Name = "btnExitU";
            this.btnExitU.Size = new System.Drawing.Size(75, 23);
            this.btnExitU.TabIndex = 18;
            this.btnExitU.Text = "E&xit";
            this.btnExitU.UseVisualStyleBackColor = true;
            this.btnExitU.Click += new System.EventHandler(this.btnExitU_Click);
            // 
            // cmbQualificationIDU
            // 
            this.cmbQualificationIDU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQualificationIDU.FormattingEnabled = true;
            this.cmbQualificationIDU.Location = new System.Drawing.Point(139, 27);
            this.cmbQualificationIDU.Name = "cmbQualificationIDU";
            this.cmbQualificationIDU.Size = new System.Drawing.Size(121, 21);
            this.cmbQualificationIDU.TabIndex = 17;
            this.cmbQualificationIDU.SelectedIndexChanged += new System.EventHandler(this.cmbQualificationIDU_SelectedIndexChanged);
            // 
            // lblQualificationIDU
            // 
            this.lblQualificationIDU.AutoSize = true;
            this.lblQualificationIDU.Location = new System.Drawing.Point(54, 30);
            this.lblQualificationIDU.Name = "lblQualificationIDU";
            this.lblQualificationIDU.Size = new System.Drawing.Size(79, 13);
            this.lblQualificationIDU.TabIndex = 16;
            this.lblQualificationIDU.Text = "Qualification ID";
            // 
            // txtQualificationNameU
            // 
            this.txtQualificationNameU.Location = new System.Drawing.Point(139, 54);
            this.txtQualificationNameU.Name = "txtQualificationNameU";
            this.txtQualificationNameU.Size = new System.Drawing.Size(121, 20);
            this.txtQualificationNameU.TabIndex = 12;
            // 
            // lblDurationU
            // 
            this.lblDurationU.AutoSize = true;
            this.lblDurationU.Location = new System.Drawing.Point(86, 84);
            this.lblDurationU.Name = "lblDurationU";
            this.lblDurationU.Size = new System.Drawing.Size(47, 13);
            this.lblDurationU.TabIndex = 11;
            this.lblDurationU.Text = "Duration";
            // 
            // lblQualificationNameU
            // 
            this.lblQualificationNameU.AutoSize = true;
            this.lblQualificationNameU.Location = new System.Drawing.Point(37, 57);
            this.lblQualificationNameU.Name = "lblQualificationNameU";
            this.lblQualificationNameU.Size = new System.Drawing.Size(96, 13);
            this.lblQualificationNameU.TabIndex = 10;
            this.lblQualificationNameU.Text = "Qualification Name";
            // 
            // btnDeleteU
            // 
            this.btnDeleteU.Location = new System.Drawing.Point(220, 107);
            this.btnDeleteU.Name = "btnDeleteU";
            this.btnDeleteU.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteU.TabIndex = 9;
            this.btnDeleteU.Text = "&Delete";
            this.btnDeleteU.UseVisualStyleBackColor = true;
            this.btnDeleteU.Click += new System.EventHandler(this.btnDeleteU_Click);
            // 
            // btnUpdateU
            // 
            this.btnUpdateU.Location = new System.Drawing.Point(139, 107);
            this.btnUpdateU.Name = "btnUpdateU";
            this.btnUpdateU.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateU.TabIndex = 8;
            this.btnUpdateU.Text = "&Update";
            this.btnUpdateU.UseVisualStyleBackColor = true;
            this.btnUpdateU.Click += new System.EventHandler(this.btnUpdateU_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pnlHelpC);
            this.tabPage3.Controls.Add(this.btnHelpC);
            this.tabPage3.Controls.Add(this.lblAvailableCoursesC);
            this.tabPage3.Controls.Add(this.lblQualificationNameC);
            this.tabPage3.Controls.Add(this.lblCoursesInQualC);
            this.tabPage3.Controls.Add(this.btnAddC);
            this.tabPage3.Controls.Add(this.btnDeleteC);
            this.tabPage3.Controls.Add(this.dgvAvailableCoursesC);
            this.tabPage3.Controls.Add(this.dgvCoursesC);
            this.tabPage3.Controls.Add(this.cmbQualificationIDC);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.btnExitC);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(548, 338);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Add / Delete Courses";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnlHelpC
            // 
            this.pnlHelpC.Controls.Add(this.lblHelp2);
            this.pnlHelpC.Controls.Add(this.lblHelp3);
            this.pnlHelpC.Controls.Add(this.lblHelp4);
            this.pnlHelpC.Controls.Add(this.btnCloseHelpC);
            this.pnlHelpC.Controls.Add(this.lblHelp1);
            this.pnlHelpC.Location = new System.Drawing.Point(13, 3);
            this.pnlHelpC.Name = "pnlHelpC";
            this.pnlHelpC.Size = new System.Drawing.Size(532, 332);
            this.pnlHelpC.TabIndex = 31;
            // 
            // lblHelp2
            // 
            this.lblHelp2.AutoSize = true;
            this.lblHelp2.Location = new System.Drawing.Point(38, 42);
            this.lblHelp2.Name = "lblHelp2";
            this.lblHelp2.Size = new System.Drawing.Size(372, 39);
            this.lblHelp2.TabIndex = 4;
            this.lblHelp2.Text = resources.GetString("lblHelp2.Text");
            // 
            // lblHelp3
            // 
            this.lblHelp3.AutoSize = true;
            this.lblHelp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp3.Location = new System.Drawing.Point(9, 96);
            this.lblHelp3.Name = "lblHelp3";
            this.lblHelp3.Size = new System.Drawing.Size(250, 13);
            this.lblHelp3.TabIndex = 3;
            this.lblHelp3.Text = "To delete a Course from the Courses Table";
            // 
            // lblHelp4
            // 
            this.lblHelp4.AutoSize = true;
            this.lblHelp4.Location = new System.Drawing.Point(38, 125);
            this.lblHelp4.Name = "lblHelp4";
            this.lblHelp4.Size = new System.Drawing.Size(340, 78);
            this.lblHelp4.TabIndex = 2;
            this.lblHelp4.Text = resources.GetString("lblHelp4.Text");
            // 
            // btnCloseHelpC
            // 
            this.btnCloseHelpC.Location = new System.Drawing.Point(425, 215);
            this.btnCloseHelpC.Name = "btnCloseHelpC";
            this.btnCloseHelpC.Size = new System.Drawing.Size(75, 23);
            this.btnCloseHelpC.TabIndex = 1;
            this.btnCloseHelpC.Text = "&Close";
            this.btnCloseHelpC.UseVisualStyleBackColor = true;
            this.btnCloseHelpC.Click += new System.EventHandler(this.btnCloseHelpC_Click);
            // 
            // lblHelp1
            // 
            this.lblHelp1.AutoSize = true;
            this.lblHelp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp1.Location = new System.Drawing.Point(9, 15);
            this.lblHelp1.Name = "lblHelp1";
            this.lblHelp1.Size = new System.Drawing.Size(291, 13);
            this.lblHelp1.TabIndex = 0;
            this.lblHelp1.Text = "To copy an available Course to the Courses Table";
            // 
            // btnHelpC
            // 
            this.btnHelpC.Location = new System.Drawing.Point(455, 14);
            this.btnHelpC.Name = "btnHelpC";
            this.btnHelpC.Size = new System.Drawing.Size(75, 23);
            this.btnHelpC.TabIndex = 30;
            this.btnHelpC.Text = "&Help";
            this.btnHelpC.UseVisualStyleBackColor = true;
            this.btnHelpC.Click += new System.EventHandler(this.btnHelpC_Click);
            // 
            // lblAvailableCoursesC
            // 
            this.lblAvailableCoursesC.AutoSize = true;
            this.lblAvailableCoursesC.Location = new System.Drawing.Point(275, 44);
            this.lblAvailableCoursesC.Name = "lblAvailableCoursesC";
            this.lblAvailableCoursesC.Size = new System.Drawing.Size(91, 13);
            this.lblAvailableCoursesC.TabIndex = 29;
            this.lblAvailableCoursesC.Text = "Available Courses";
            // 
            // lblQualificationNameC
            // 
            this.lblQualificationNameC.AutoSize = true;
            this.lblQualificationNameC.Location = new System.Drawing.Point(224, 19);
            this.lblQualificationNameC.Name = "lblQualificationNameC";
            this.lblQualificationNameC.Size = new System.Drawing.Size(0, 13);
            this.lblQualificationNameC.TabIndex = 27;
            // 
            // lblCoursesInQualC
            // 
            this.lblCoursesInQualC.AutoSize = true;
            this.lblCoursesInQualC.Location = new System.Drawing.Point(12, 44);
            this.lblCoursesInQualC.Name = "lblCoursesInQualC";
            this.lblCoursesInQualC.Size = new System.Drawing.Size(45, 13);
            this.lblCoursesInQualC.TabIndex = 26;
            this.lblCoursesInQualC.Text = "Courses";
            // 
            // btnAddC
            // 
            this.btnAddC.Location = new System.Drawing.Point(15, 272);
            this.btnAddC.Name = "btnAddC";
            this.btnAddC.Size = new System.Drawing.Size(75, 23);
            this.btnAddC.TabIndex = 25;
            this.btnAddC.Text = "&Add";
            this.btnAddC.UseVisualStyleBackColor = true;
            this.btnAddC.Click += new System.EventHandler(this.btnAddC_Click);
            // 
            // btnDeleteC
            // 
            this.btnDeleteC.Location = new System.Drawing.Point(96, 272);
            this.btnDeleteC.Name = "btnDeleteC";
            this.btnDeleteC.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteC.TabIndex = 24;
            this.btnDeleteC.Text = "&Delete";
            this.btnDeleteC.UseVisualStyleBackColor = true;
            this.btnDeleteC.Click += new System.EventHandler(this.btnDeleteC_Click);
            // 
            // dgvAvailableCoursesC
            // 
            this.dgvAvailableCoursesC.AllowUserToAddRows = false;
            this.dgvAvailableCoursesC.AllowUserToDeleteRows = false;
            this.dgvAvailableCoursesC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableCoursesC.Location = new System.Drawing.Point(278, 60);
            this.dgvAvailableCoursesC.Name = "dgvAvailableCoursesC";
            this.dgvAvailableCoursesC.ReadOnly = true;
            this.dgvAvailableCoursesC.Size = new System.Drawing.Size(252, 206);
            this.dgvAvailableCoursesC.TabIndex = 23;
            // 
            // dgvCoursesC
            // 
            this.dgvCoursesC.AllowUserToAddRows = false;
            this.dgvCoursesC.AllowUserToDeleteRows = false;
            this.dgvCoursesC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoursesC.Location = new System.Drawing.Point(15, 60);
            this.dgvCoursesC.Name = "dgvCoursesC";
            this.dgvCoursesC.ReadOnly = true;
            this.dgvCoursesC.Size = new System.Drawing.Size(235, 206);
            this.dgvCoursesC.TabIndex = 22;
            // 
            // cmbQualificationIDC
            // 
            this.cmbQualificationIDC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQualificationIDC.FormattingEnabled = true;
            this.cmbQualificationIDC.Location = new System.Drawing.Point(97, 16);
            this.cmbQualificationIDC.Name = "cmbQualificationIDC";
            this.cmbQualificationIDC.Size = new System.Drawing.Size(121, 21);
            this.cmbQualificationIDC.TabIndex = 21;
            this.cmbQualificationIDC.SelectedIndexChanged += new System.EventHandler(this.cmbQualificationIDC_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Qualification ID";
            // 
            // btnExitC
            // 
            this.btnExitC.Location = new System.Drawing.Point(177, 272);
            this.btnExitC.Name = "btnExitC";
            this.btnExitC.Size = new System.Drawing.Size(75, 23);
            this.btnExitC.TabIndex = 19;
            this.btnExitC.Text = "E&xit";
            this.btnExitC.UseVisualStyleBackColor = true;
            this.btnExitC.Click += new System.EventHandler(this.btnExitC_Click);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.schoolDBDataSetBindingSource;
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
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // QualificationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 388);
            this.Controls.Add(this.tabControl1);
            this.Name = "QualificationsForm";
            this.Text = "Qualifications";
            this.Load += new System.EventHandler(this.QualificationsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.pnlHelpC.ResumeLayout(false);
            this.pnlHelpC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableCoursesC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoursesC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtQualificationNameA;
        private System.Windows.Forms.Label lblDurationA;
        private System.Windows.Forms.Label lblQualificationNameA;
        private System.Windows.Forms.Button btnExitA;
        private System.Windows.Forms.Button btnAddA;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnExitC;
        private System.Windows.Forms.ComboBox cmbDurationA;
        private System.Windows.Forms.TextBox txtQualificationIDA;
        private System.Windows.Forms.Label lblQualificationIDA;
        private System.Windows.Forms.Label lblAvailableCoursesC;
        private System.Windows.Forms.Label lblQualificationNameC;
        private System.Windows.Forms.Label lblCoursesInQualC;
        private System.Windows.Forms.Button btnAddC;
        private System.Windows.Forms.Button btnDeleteC;
        private System.Windows.Forms.DataGridView dgvAvailableCoursesC;
        private System.Windows.Forms.DataGridView dgvCoursesC;
        private System.Windows.Forms.ComboBox cmbQualificationIDC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource schoolDBDataSetBindingSource;
        private SchoolDBDataSet schoolDBDataSet;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private SchoolDBDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.Label lblQualificationIDMessageA;
        private System.Windows.Forms.Label lblQualificationNameMessageA;
        private System.Windows.Forms.Label lblDurationMessageA;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblQualificationNameMessageU;
        private System.Windows.Forms.ComboBox cmbDurationU;
        private System.Windows.Forms.Button btnExitU;
        private System.Windows.Forms.ComboBox cmbQualificationIDU;
        private System.Windows.Forms.Label lblQualificationIDU;
        private System.Windows.Forms.TextBox txtQualificationNameU;
        private System.Windows.Forms.Label lblDurationU;
        private System.Windows.Forms.Label lblQualificationNameU;
        private System.Windows.Forms.Button btnDeleteU;
        private System.Windows.Forms.Button btnUpdateU;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlHelpC;
        private System.Windows.Forms.Button btnCloseHelpC;
        private System.Windows.Forms.Label lblHelp1;
        private System.Windows.Forms.Button btnHelpC;
        private System.Windows.Forms.Label lblHelp2;
        private System.Windows.Forms.Label lblHelp3;
        private System.Windows.Forms.Label lblHelp4;
    }
}