namespace SchoolSystem
{
    partial class MarksForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabMarks = new System.Windows.Forms.TabControl();
            this.tabStudent = new System.Windows.Forms.TabPage();
            this.pnlAddStudentS = new System.Windows.Forms.Panel();
            this.pnlUpdateRecordBtnS = new System.Windows.Forms.Panel();
            this.btnPanelUpdateStudentS = new System.Windows.Forms.Button();
            this.pnlCourseIDOverlayS = new System.Windows.Forms.Panel();
            this.txtPanelOverlayCourseIDS = new System.Windows.Forms.TextBox();
            this.lblPanelMarkMessageS = new System.Windows.Forms.Label();
            this.txtPanelMarkS = new System.Windows.Forms.TextBox();
            this.txtPanelStudentIDS = new System.Windows.Forms.TextBox();
            this.lblPanelCourseNameS = new System.Windows.Forms.Label();
            this.cmbPanelCourseIDS = new System.Windows.Forms.ComboBox();
            this.btnPanelCancelS = new System.Windows.Forms.Button();
            this.btnPanelAddStudentS = new System.Windows.Forms.Button();
            this.lblPanelStudentNameS = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMarksByStudentsMessage = new System.Windows.Forms.Label();
            this.btnDeleteS = new System.Windows.Forms.Button();
            this.btnAddStudentS = new System.Windows.Forms.Button();
            this.lblStudentNameLabelS = new System.Windows.Forms.Label();
            this.dgvMarksS = new System.Windows.Forms.DataGridView();
            this.cmbStudentIDS = new System.Windows.Forms.ComboBox();
            this.lblStudentNameS = new System.Windows.Forms.Label();
            this.lblStudentIDS = new System.Windows.Forms.Label();
            this.btnUpdateS = new System.Windows.Forms.Button();
            this.btnExitS = new System.Windows.Forms.Button();
            this.tabCourse = new System.Windows.Forms.TabPage();
            this.lblInstructionC = new System.Windows.Forms.Label();
            this.lblCourseNameLabelC = new System.Windows.Forms.Label();
            this.dgvMarksC = new System.Windows.Forms.DataGridView();
            this.btnExitC = new System.Windows.Forms.Button();
            this.cmbCourseIDC = new System.Windows.Forms.ComboBox();
            this.lblCourseNameC = new System.Windows.Forms.Label();
            this.lblCourseIDC = new System.Windows.Forms.Label();
            this.schoolDBDataSet = new SchoolSystem.SchoolDBDataSet();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabMarks.SuspendLayout();
            this.tabStudent.SuspendLayout();
            this.pnlAddStudentS.SuspendLayout();
            this.pnlUpdateRecordBtnS.SuspendLayout();
            this.pnlCourseIDOverlayS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarksS)).BeginInit();
            this.tabCourse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarksC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMarks
            // 
            this.tabMarks.Controls.Add(this.tabStudent);
            this.tabMarks.Controls.Add(this.tabCourse);
            this.tabMarks.Location = new System.Drawing.Point(13, 13);
            this.tabMarks.Name = "tabMarks";
            this.tabMarks.SelectedIndex = 0;
            this.tabMarks.Size = new System.Drawing.Size(635, 383);
            this.tabMarks.TabIndex = 0;
            // 
            // tabStudent
            // 
            this.tabStudent.Controls.Add(this.pnlAddStudentS);
            this.tabStudent.Controls.Add(this.lblMarksByStudentsMessage);
            this.tabStudent.Controls.Add(this.btnDeleteS);
            this.tabStudent.Controls.Add(this.btnAddStudentS);
            this.tabStudent.Controls.Add(this.lblStudentNameLabelS);
            this.tabStudent.Controls.Add(this.dgvMarksS);
            this.tabStudent.Controls.Add(this.cmbStudentIDS);
            this.tabStudent.Controls.Add(this.lblStudentNameS);
            this.tabStudent.Controls.Add(this.lblStudentIDS);
            this.tabStudent.Controls.Add(this.btnUpdateS);
            this.tabStudent.Controls.Add(this.btnExitS);
            this.tabStudent.Location = new System.Drawing.Point(4, 22);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudent.Size = new System.Drawing.Size(627, 357);
            this.tabStudent.TabIndex = 1;
            this.tabStudent.Text = "View Marks by Student";
            this.tabStudent.UseVisualStyleBackColor = true;
            // 
            // pnlAddStudentS
            // 
            this.pnlAddStudentS.Controls.Add(this.pnlUpdateRecordBtnS);
            this.pnlAddStudentS.Controls.Add(this.pnlCourseIDOverlayS);
            this.pnlAddStudentS.Controls.Add(this.lblPanelMarkMessageS);
            this.pnlAddStudentS.Controls.Add(this.txtPanelMarkS);
            this.pnlAddStudentS.Controls.Add(this.txtPanelStudentIDS);
            this.pnlAddStudentS.Controls.Add(this.lblPanelCourseNameS);
            this.pnlAddStudentS.Controls.Add(this.cmbPanelCourseIDS);
            this.pnlAddStudentS.Controls.Add(this.btnPanelCancelS);
            this.pnlAddStudentS.Controls.Add(this.btnPanelAddStudentS);
            this.pnlAddStudentS.Controls.Add(this.lblPanelStudentNameS);
            this.pnlAddStudentS.Controls.Add(this.label3);
            this.pnlAddStudentS.Controls.Add(this.label2);
            this.pnlAddStudentS.Controls.Add(this.label1);
            this.pnlAddStudentS.Location = new System.Drawing.Point(-4, 0);
            this.pnlAddStudentS.Name = "pnlAddStudentS";
            this.pnlAddStudentS.Size = new System.Drawing.Size(452, 317);
            this.pnlAddStudentS.TabIndex = 15;
            this.pnlAddStudentS.Visible = false;
            // 
            // pnlUpdateRecordBtnS
            // 
            this.pnlUpdateRecordBtnS.Controls.Add(this.btnPanelUpdateStudentS);
            this.pnlUpdateRecordBtnS.Location = new System.Drawing.Point(107, 98);
            this.pnlUpdateRecordBtnS.Name = "pnlUpdateRecordBtnS";
            this.pnlUpdateRecordBtnS.Size = new System.Drawing.Size(103, 54);
            this.pnlUpdateRecordBtnS.TabIndex = 13;
            // 
            // btnPanelUpdateStudentS
            // 
            this.btnPanelUpdateStudentS.Location = new System.Drawing.Point(0, 0);
            this.btnPanelUpdateStudentS.Name = "btnPanelUpdateStudentS";
            this.btnPanelUpdateStudentS.Size = new System.Drawing.Size(103, 23);
            this.btnPanelUpdateStudentS.TabIndex = 12;
            this.btnPanelUpdateStudentS.Text = "&Update Record";
            this.btnPanelUpdateStudentS.UseVisualStyleBackColor = true;
            this.btnPanelUpdateStudentS.Click += new System.EventHandler(this.btnPanelUpdateStudentS_Click);
            // 
            // pnlCourseIDOverlayS
            // 
            this.pnlCourseIDOverlayS.Controls.Add(this.txtPanelOverlayCourseIDS);
            this.pnlCourseIDOverlayS.Location = new System.Drawing.Point(107, 45);
            this.pnlCourseIDOverlayS.Name = "pnlCourseIDOverlayS";
            this.pnlCourseIDOverlayS.Size = new System.Drawing.Size(122, 21);
            this.pnlCourseIDOverlayS.TabIndex = 11;
            // 
            // txtPanelOverlayCourseIDS
            // 
            this.txtPanelOverlayCourseIDS.Location = new System.Drawing.Point(0, 0);
            this.txtPanelOverlayCourseIDS.Name = "txtPanelOverlayCourseIDS";
            this.txtPanelOverlayCourseIDS.ReadOnly = true;
            this.txtPanelOverlayCourseIDS.Size = new System.Drawing.Size(121, 20);
            this.txtPanelOverlayCourseIDS.TabIndex = 9;
            // 
            // lblPanelMarkMessageS
            // 
            this.lblPanelMarkMessageS.AutoSize = true;
            this.lblPanelMarkMessageS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPanelMarkMessageS.Location = new System.Drawing.Point(236, 75);
            this.lblPanelMarkMessageS.Name = "lblPanelMarkMessageS";
            this.lblPanelMarkMessageS.Size = new System.Drawing.Size(0, 13);
            this.lblPanelMarkMessageS.TabIndex = 10;
            // 
            // txtPanelMarkS
            // 
            this.txtPanelMarkS.Location = new System.Drawing.Point(108, 72);
            this.txtPanelMarkS.Name = "txtPanelMarkS";
            this.txtPanelMarkS.Size = new System.Drawing.Size(121, 20);
            this.txtPanelMarkS.TabIndex = 9;
            // 
            // txtPanelStudentIDS
            // 
            this.txtPanelStudentIDS.Location = new System.Drawing.Point(108, 19);
            this.txtPanelStudentIDS.Name = "txtPanelStudentIDS";
            this.txtPanelStudentIDS.ReadOnly = true;
            this.txtPanelStudentIDS.Size = new System.Drawing.Size(121, 20);
            this.txtPanelStudentIDS.TabIndex = 8;
            // 
            // lblPanelCourseNameS
            // 
            this.lblPanelCourseNameS.AutoSize = true;
            this.lblPanelCourseNameS.Location = new System.Drawing.Point(235, 48);
            this.lblPanelCourseNameS.Name = "lblPanelCourseNameS";
            this.lblPanelCourseNameS.Size = new System.Drawing.Size(0, 13);
            this.lblPanelCourseNameS.TabIndex = 7;
            // 
            // cmbPanelCourseIDS
            // 
            this.cmbPanelCourseIDS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPanelCourseIDS.FormattingEnabled = true;
            this.cmbPanelCourseIDS.Location = new System.Drawing.Point(108, 45);
            this.cmbPanelCourseIDS.Name = "cmbPanelCourseIDS";
            this.cmbPanelCourseIDS.Size = new System.Drawing.Size(121, 21);
            this.cmbPanelCourseIDS.TabIndex = 6;
            this.cmbPanelCourseIDS.SelectedIndexChanged += new System.EventHandler(this.cmbPanelCourseIDS_SelectedIndexChanged);
            // 
            // btnPanelCancelS
            // 
            this.btnPanelCancelS.Location = new System.Drawing.Point(217, 98);
            this.btnPanelCancelS.Name = "btnPanelCancelS";
            this.btnPanelCancelS.Size = new System.Drawing.Size(75, 23);
            this.btnPanelCancelS.TabIndex = 5;
            this.btnPanelCancelS.Text = "&Cancel";
            this.btnPanelCancelS.UseVisualStyleBackColor = true;
            this.btnPanelCancelS.Click += new System.EventHandler(this.btnPanelCancelS_Click);
            // 
            // btnPanelAddStudentS
            // 
            this.btnPanelAddStudentS.Location = new System.Drawing.Point(108, 98);
            this.btnPanelAddStudentS.Name = "btnPanelAddStudentS";
            this.btnPanelAddStudentS.Size = new System.Drawing.Size(103, 23);
            this.btnPanelAddStudentS.TabIndex = 4;
            this.btnPanelAddStudentS.Text = "&Enter Record";
            this.btnPanelAddStudentS.UseVisualStyleBackColor = true;
            this.btnPanelAddStudentS.Click += new System.EventHandler(this.btnPanelAddStudentS_Click);
            // 
            // lblPanelStudentNameS
            // 
            this.lblPanelStudentNameS.AutoSize = true;
            this.lblPanelStudentNameS.Location = new System.Drawing.Point(235, 22);
            this.lblPanelStudentNameS.Name = "lblPanelStudentNameS";
            this.lblPanelStudentNameS.Size = new System.Drawing.Size(0, 13);
            this.lblPanelStudentNameS.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Course ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mark";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // lblMarksByStudentsMessage
            // 
            this.lblMarksByStudentsMessage.AutoSize = true;
            this.lblMarksByStudentsMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMarksByStudentsMessage.Location = new System.Drawing.Point(43, 304);
            this.lblMarksByStudentsMessage.Name = "lblMarksByStudentsMessage";
            this.lblMarksByStudentsMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMarksByStudentsMessage.TabIndex = 20;
            // 
            // btnDeleteS
            // 
            this.btnDeleteS.Location = new System.Drawing.Point(232, 277);
            this.btnDeleteS.Name = "btnDeleteS";
            this.btnDeleteS.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteS.TabIndex = 18;
            this.btnDeleteS.Text = "&Delete";
            this.btnDeleteS.UseVisualStyleBackColor = true;
            this.btnDeleteS.Click += new System.EventHandler(this.btnDeleteS_Click);
            // 
            // btnAddStudentS
            // 
            this.btnAddStudentS.Location = new System.Drawing.Point(44, 278);
            this.btnAddStudentS.Name = "btnAddStudentS";
            this.btnAddStudentS.Size = new System.Drawing.Size(83, 23);
            this.btnAddStudentS.TabIndex = 14;
            this.btnAddStudentS.Text = "&Add Course";
            this.btnAddStudentS.UseVisualStyleBackColor = true;
            this.btnAddStudentS.Click += new System.EventHandler(this.btnAddStudentS_Click);
            // 
            // lblStudentNameLabelS
            // 
            this.lblStudentNameLabelS.AutoSize = true;
            this.lblStudentNameLabelS.Location = new System.Drawing.Point(232, 37);
            this.lblStudentNameLabelS.Name = "lblStudentNameLabelS";
            this.lblStudentNameLabelS.Size = new System.Drawing.Size(75, 13);
            this.lblStudentNameLabelS.TabIndex = 13;
            this.lblStudentNameLabelS.Text = "Student Name";
            // 
            // dgvMarksS
            // 
            this.dgvMarksS.AllowUserToAddRows = false;
            this.dgvMarksS.AllowUserToDeleteRows = false;
            this.dgvMarksS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarksS.Location = new System.Drawing.Point(44, 61);
            this.dgvMarksS.Name = "dgvMarksS";
            this.dgvMarksS.ReadOnly = true;
            this.dgvMarksS.Size = new System.Drawing.Size(263, 210);
            this.dgvMarksS.TabIndex = 12;
            // 
            // cmbStudentIDS
            // 
            this.cmbStudentIDS.FormattingEnabled = true;
            this.cmbStudentIDS.Location = new System.Drawing.Point(105, 34);
            this.cmbStudentIDS.Name = "cmbStudentIDS";
            this.cmbStudentIDS.Size = new System.Drawing.Size(121, 21);
            this.cmbStudentIDS.TabIndex = 9;
            this.cmbStudentIDS.SelectedIndexChanged += new System.EventHandler(this.cmbStudentIDS_SelectedIndexChanged);
            // 
            // lblStudentNameS
            // 
            this.lblStudentNameS.AutoSize = true;
            this.lblStudentNameS.Location = new System.Drawing.Point(313, 37);
            this.lblStudentNameS.Name = "lblStudentNameS";
            this.lblStudentNameS.Size = new System.Drawing.Size(0, 13);
            this.lblStudentNameS.TabIndex = 8;
            // 
            // lblStudentIDS
            // 
            this.lblStudentIDS.AutoSize = true;
            this.lblStudentIDS.Location = new System.Drawing.Point(41, 37);
            this.lblStudentIDS.Name = "lblStudentIDS";
            this.lblStudentIDS.Size = new System.Drawing.Size(58, 13);
            this.lblStudentIDS.TabIndex = 7;
            this.lblStudentIDS.Text = "Student ID";
            // 
            // btnUpdateS
            // 
            this.btnUpdateS.Location = new System.Drawing.Point(133, 278);
            this.btnUpdateS.Name = "btnUpdateS";
            this.btnUpdateS.Size = new System.Drawing.Size(92, 23);
            this.btnUpdateS.TabIndex = 16;
            this.btnUpdateS.Text = "&Update Mark";
            this.btnUpdateS.UseVisualStyleBackColor = true;
            this.btnUpdateS.Click += new System.EventHandler(this.btnUpdateS_Click);
            // 
            // btnExitS
            // 
            this.btnExitS.Location = new System.Drawing.Point(319, 277);
            this.btnExitS.Name = "btnExitS";
            this.btnExitS.Size = new System.Drawing.Size(68, 23);
            this.btnExitS.TabIndex = 17;
            this.btnExitS.Text = "E&xit";
            this.btnExitS.UseVisualStyleBackColor = true;
            this.btnExitS.Click += new System.EventHandler(this.btnExitS_Click);
            // 
            // tabCourse
            // 
            this.tabCourse.Controls.Add(this.lblInstructionC);
            this.tabCourse.Controls.Add(this.lblCourseNameLabelC);
            this.tabCourse.Controls.Add(this.dgvMarksC);
            this.tabCourse.Controls.Add(this.btnExitC);
            this.tabCourse.Controls.Add(this.cmbCourseIDC);
            this.tabCourse.Controls.Add(this.lblCourseNameC);
            this.tabCourse.Controls.Add(this.lblCourseIDC);
            this.tabCourse.Location = new System.Drawing.Point(4, 22);
            this.tabCourse.Name = "tabCourse";
            this.tabCourse.Padding = new System.Windows.Forms.Padding(3);
            this.tabCourse.Size = new System.Drawing.Size(627, 357);
            this.tabCourse.TabIndex = 0;
            this.tabCourse.Text = "View Marks by Course";
            this.tabCourse.UseVisualStyleBackColor = true;
            // 
            // lblInstructionC
            // 
            this.lblInstructionC.AutoSize = true;
            this.lblInstructionC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInstructionC.Location = new System.Drawing.Point(48, 302);
            this.lblInstructionC.Name = "lblInstructionC";
            this.lblInstructionC.Size = new System.Drawing.Size(366, 13);
            this.lblInstructionC.TabIndex = 8;
            this.lblInstructionC.Text = "Please go to the View Marks by Student Tab to add or edit a Course Record";
            // 
            // lblCourseNameLabelC
            // 
            this.lblCourseNameLabelC.AutoSize = true;
            this.lblCourseNameLabelC.Location = new System.Drawing.Point(235, 35);
            this.lblCourseNameLabelC.Name = "lblCourseNameLabelC";
            this.lblCourseNameLabelC.Size = new System.Drawing.Size(71, 13);
            this.lblCourseNameLabelC.TabIndex = 7;
            this.lblCourseNameLabelC.Text = "Course Name";
            // 
            // dgvMarksC
            // 
            this.dgvMarksC.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarksC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMarksC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMarksC.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMarksC.Location = new System.Drawing.Point(51, 60);
            this.dgvMarksC.Name = "dgvMarksC";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMarksC.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMarksC.Size = new System.Drawing.Size(378, 210);
            this.dgvMarksC.TabIndex = 6;
            // 
            // btnExitC
            // 
            this.btnExitC.Location = new System.Drawing.Point(51, 276);
            this.btnExitC.Name = "btnExitC";
            this.btnExitC.Size = new System.Drawing.Size(75, 23);
            this.btnExitC.TabIndex = 5;
            this.btnExitC.Text = "E&xit";
            this.btnExitC.UseVisualStyleBackColor = true;
            this.btnExitC.Click += new System.EventHandler(this.btnExitC_Click);
            // 
            // cmbCourseIDC
            // 
            this.cmbCourseIDC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourseIDC.FormattingEnabled = true;
            this.cmbCourseIDC.Location = new System.Drawing.Point(108, 32);
            this.cmbCourseIDC.Name = "cmbCourseIDC";
            this.cmbCourseIDC.Size = new System.Drawing.Size(121, 21);
            this.cmbCourseIDC.TabIndex = 3;
            this.cmbCourseIDC.SelectedIndexChanged += new System.EventHandler(this.cmbCourseIDC_SelectedIndexChanged);
            // 
            // lblCourseNameC
            // 
            this.lblCourseNameC.AutoSize = true;
            this.lblCourseNameC.Location = new System.Drawing.Point(312, 35);
            this.lblCourseNameC.Name = "lblCourseNameC";
            this.lblCourseNameC.Size = new System.Drawing.Size(0, 13);
            this.lblCourseNameC.TabIndex = 2;
            // 
            // lblCourseIDC
            // 
            this.lblCourseIDC.AutoSize = true;
            this.lblCourseIDC.Location = new System.Drawing.Point(48, 35);
            this.lblCourseIDC.Name = "lblCourseIDC";
            this.lblCourseIDC.Size = new System.Drawing.Size(54, 13);
            this.lblCourseIDC.TabIndex = 1;
            this.lblCourseIDC.Text = "Course ID";
            // 
            // schoolDBDataSet
            // 
            this.schoolDBDataSet.DataSetName = "SchoolDBDataSet";
            this.schoolDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MarksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 399);
            this.Controls.Add(this.tabMarks);
            this.Name = "MarksForm";
            this.Text = "Marks";
            this.Load += new System.EventHandler(this.MarksForm_Load);
            this.tabMarks.ResumeLayout(false);
            this.tabStudent.ResumeLayout(false);
            this.tabStudent.PerformLayout();
            this.pnlAddStudentS.ResumeLayout(false);
            this.pnlAddStudentS.PerformLayout();
            this.pnlUpdateRecordBtnS.ResumeLayout(false);
            this.pnlCourseIDOverlayS.ResumeLayout(false);
            this.pnlCourseIDOverlayS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarksS)).EndInit();
            this.tabCourse.ResumeLayout(false);
            this.tabCourse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarksC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMarks;
        private System.Windows.Forms.TabPage tabCourse;
        private System.Windows.Forms.ComboBox cmbCourseIDC;
        private System.Windows.Forms.Label lblCourseNameC;
        private System.Windows.Forms.Label lblCourseIDC;
        private System.Windows.Forms.TabPage tabStudent;
        private System.Windows.Forms.Button btnExitC;
        private System.Windows.Forms.ComboBox cmbStudentIDS;
        private System.Windows.Forms.Label lblStudentNameS;
        private System.Windows.Forms.Label lblStudentIDS;
        private SchoolDBDataSet schoolDBDataSet;
        private System.Windows.Forms.DataGridView dgvMarksC;
        private System.Windows.Forms.DataGridView dgvMarksS;
        private System.Windows.Forms.Label lblCourseNameLabelC;
        private System.Windows.Forms.Label lblStudentNameLabelS;
        private System.Windows.Forms.Button btnAddStudentS;
        private System.Windows.Forms.Panel pnlAddStudentS;
        private System.Windows.Forms.Button btnPanelAddStudentS;
        private System.Windows.Forms.Label lblPanelStudentNameS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPanelCancelS;
        private System.Windows.Forms.TextBox txtPanelMarkS;
        private System.Windows.Forms.TextBox txtPanelStudentIDS;
        private System.Windows.Forms.Label lblPanelCourseNameS;
        private System.Windows.Forms.ComboBox cmbPanelCourseIDS;
        private System.Windows.Forms.Button btnUpdateS;
        private System.Windows.Forms.Button btnExitS;
        private System.Windows.Forms.Label lblInstructionC;
        private System.Windows.Forms.Label lblPanelMarkMessageS;
        private System.Windows.Forms.Button btnDeleteS;
        private System.Windows.Forms.Panel pnlCourseIDOverlayS;
        private System.Windows.Forms.TextBox txtPanelOverlayCourseIDS;
        private System.Windows.Forms.Panel pnlUpdateRecordBtnS;
        private System.Windows.Forms.Button btnPanelUpdateStudentS;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblMarksByStudentsMessage;
    }
}