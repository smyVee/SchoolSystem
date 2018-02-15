namespace SchoolSystem
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
            this.btnLogoff = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnQualifications = new System.Windows.Forms.Button();
            this.btnMarks = new System.Windows.Forms.Button();
            this.btnAdministrators = new System.Windows.Forms.Button();
            this.btnTeachers = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.lblMainMenuMessage = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogoff
            // 
            this.btnLogoff.Location = new System.Drawing.Point(265, 194);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(113, 45);
            this.btnLogoff.TabIndex = 0;
            this.btnLogoff.Text = "&Logoff";
            this.btnLogoff.UseVisualStyleBackColor = true;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.Location = new System.Drawing.Point(27, 143);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(113, 45);
            this.btnCourses.TabIndex = 1;
            this.btnCourses.Text = "&Courses";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnQualifications
            // 
            this.btnQualifications.Location = new System.Drawing.Point(146, 143);
            this.btnQualifications.Name = "btnQualifications";
            this.btnQualifications.Size = new System.Drawing.Size(113, 45);
            this.btnQualifications.TabIndex = 2;
            this.btnQualifications.Text = "&Qualifications";
            this.btnQualifications.UseVisualStyleBackColor = true;
            this.btnQualifications.Click += new System.EventHandler(this.btnQualifications_Click);
            // 
            // btnMarks
            // 
            this.btnMarks.Location = new System.Drawing.Point(265, 143);
            this.btnMarks.Name = "btnMarks";
            this.btnMarks.Size = new System.Drawing.Size(113, 45);
            this.btnMarks.TabIndex = 3;
            this.btnMarks.Text = "&Marks";
            this.btnMarks.UseVisualStyleBackColor = true;
            this.btnMarks.Click += new System.EventHandler(this.btnMarks_Click);
            // 
            // btnAdministrators
            // 
            this.btnAdministrators.Location = new System.Drawing.Point(265, 92);
            this.btnAdministrators.Name = "btnAdministrators";
            this.btnAdministrators.Size = new System.Drawing.Size(113, 45);
            this.btnAdministrators.TabIndex = 4;
            this.btnAdministrators.Text = "&Administrators";
            this.btnAdministrators.UseVisualStyleBackColor = true;
            this.btnAdministrators.Click += new System.EventHandler(this.btnAdministrators_Click);
            // 
            // btnTeachers
            // 
            this.btnTeachers.Location = new System.Drawing.Point(146, 92);
            this.btnTeachers.Name = "btnTeachers";
            this.btnTeachers.Size = new System.Drawing.Size(113, 45);
            this.btnTeachers.TabIndex = 5;
            this.btnTeachers.Text = "&Teachers";
            this.btnTeachers.UseVisualStyleBackColor = true;
            this.btnTeachers.Click += new System.EventHandler(this.btnTeachers_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(27, 92);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(113, 45);
            this.btnStudents.TabIndex = 6;
            this.btnStudents.Text = "&Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(27, 194);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(113, 45);
            this.btnChangePassword.TabIndex = 7;
            this.btnChangePassword.Text = "Change &Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lblMainMenuMessage
            // 
            this.lblMainMenuMessage.AutoSize = true;
            this.lblMainMenuMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMainMenuMessage.Location = new System.Drawing.Point(24, 254);
            this.lblMainMenuMessage.Name = "lblMainMenuMessage";
            this.lblMainMenuMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMainMenuMessage.TabIndex = 8;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe Script", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblHeader.Location = new System.Drawing.Point(46, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(315, 53);
            this.lblHeader.TabIndex = 9;
            this.lblHeader.Text = "ABC High School";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 349);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.lblMainMenuMessage);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.btnTeachers);
            this.Controls.Add(this.btnAdministrators);
            this.Controls.Add(this.btnMarks);
            this.Controls.Add(this.btnQualifications);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.btnLogoff);
            this.Name = "MainMenuForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnQualifications;
        private System.Windows.Forms.Button btnMarks;
        private System.Windows.Forms.Button btnAdministrators;
        private System.Windows.Forms.Button btnTeachers;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label lblMainMenuMessage;
        private System.Windows.Forms.Label lblHeader;

    }
}