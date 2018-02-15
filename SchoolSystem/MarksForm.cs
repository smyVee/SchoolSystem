using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSystem
{
    public partial class MarksForm : Form
    {
        SchoolDataClassesDataContext DB = new SchoolDataClassesDataContext();

        public MarksForm()
        {
            InitializeComponent();
        }

        // This is what happens when the form is first loaded
        private void MarksForm_Load(object sender, EventArgs e)
        {
            var studentList = (from s in DB.Persons
                               where s.Type == "Student"
                               select new { s.ID, s.FName, s.LName }
                              ).ToList();
            cmbStudentIDS.DisplayMember = "ID";
            cmbStudentIDS.ValueMember = "ID";
            cmbStudentIDS.DataSource = studentList;

            var courseList = (from c in DB.Courses
                              select new { c.CID, c.CName }
                                  ).ToList();

            cmbCourseIDC.DisplayMember = "CID";
            cmbCourseIDC.ValueMember = "CID";
            cmbCourseIDC.DataSource = courseList;

            // Switch off the add student course panel
            // It will be switched on when the user clicks the 
            // Add Course button in the view by students tab. 
            pnlAddStudentS.Visible = false;

            // Put the default tab header in place
            tabStudent.Text = "View Marks by Student";

            // Set up the ToolTips for this form
            toolTip1.SetToolTip(btnAddStudentS, "Click here to go to the Add Record Screen");
            toolTip1.SetToolTip(btnDeleteS, "Click here to delete the selected record in the Grid");
            toolTip1.SetToolTip(btnExitC, "Click here to return to the Main Menu");
            toolTip1.SetToolTip(btnExitS, "Click here to return to the Main Menu");
            toolTip1.SetToolTip(btnPanelAddStudentS, "Click here to save the Record");
            toolTip1.SetToolTip(btnPanelCancelS, "Click here to cancel the edit. The Record will not be added");
            toolTip1.SetToolTip(btnPanelUpdateStudentS, "Click here to update the Record");
            toolTip1.SetToolTip(btnUpdateS, "Click here to go to the Update Screen for the selected record in the Grid");
            toolTip1.SetToolTip(cmbPanelCourseIDS, "Select a Course ID from the drop down list");
            toolTip1.SetToolTip(cmbCourseIDC, "Select a Course ID from the drop down list");
            toolTip1.SetToolTip(cmbStudentIDS, "Select a Student ID from the drop down list");
            toolTip1.SetToolTip(txtPanelMarkS, "Enter a mark between 0 and 100 (decimal values are not permitted)");
            

            lblMarksByStudentsMessage.Text = "Click on a record to select it to update or delete it";
        }

        // This method fills in the Marks by Course screen data properties based on 
        // the criteria set by the Course ID Combo box selection
        private void cmbCourseIDC_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectTheCourse();
        }

        // This method runs the script called by cmbCourseIDC_SelectedIndexChanged
        // event. It is seperated because it is also called by the
        // btnPanelAddStudentS_Click to make sure that the latest course
        // information is displayed in the courses dgv after a student
        // course record has been added.
        internal void selectTheCourse()
        {
            // Reset the datagrid before performing the query
            // because this method seems to append new columns
            // to the datagrid when it is run.
            dgvMarksC.DataSource = null;
            dgvMarksC.Columns.Clear();
            dgvMarksC.Rows.Clear();

            // Select the Courses Marks with the Course ID 
            // selected in the Course ID Combo Box
            var marksByCourseList = (from c in DB.Student_Courses
                                     join p in DB.Persons
                                     on c.SID equals p.ID
                                     where c.CID == Convert.ToInt32(cmbCourseIDC.Text)
                                     select new { c.SID, p.FName, p.LName, c.Mark }
                                     ).ToList();

            dgvMarksC.DataSource = marksByCourseList;

            // Setup the by course datagrid
            dgvMarksC.Columns[0].HeaderText = "ID";
            dgvMarksC.Columns[0].Width = 60;
            dgvMarksC.Columns[0].ReadOnly = true;
            dgvMarksC.Columns[1].HeaderText = "First Name";
            dgvMarksC.Columns[1].Width = 120;
            dgvMarksC.Columns[1].ReadOnly = true;
            dgvMarksC.Columns[2].HeaderText = "Last Name";
            dgvMarksC.Columns[2].Width = 120;
            dgvMarksC.Columns[2].ReadOnly = true;
            dgvMarksC.Columns[3].HeaderText = "Mark";
            dgvMarksC.Columns[3].Width = 40;

            // Get the Course name for the selected Course ID
            // displayed in the Combo Box
            var courseName = (from n in DB.Courses
                              where n.CID == Convert.ToInt32(cmbCourseIDC.Text)
                              select n.CName).First();

            lblCourseNameC.Text = courseName;
        }

        // This method deletes a record from the  student view datagrid
        private void btnDeleteS_Click(object sender, EventArgs e)
        {
            try
            {
                // Make the selected row go a different colour.
                dgvMarksS.CurrentRow.DefaultCellStyle.BackColor = Color.Red;

                DialogResult d = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);               

                if (d == DialogResult.Yes)
                {
                    // Pick the criteria from the chosen row in the datagrid
                    int rowSelected = dgvMarksS.CurrentCell.RowIndex;
                    int deleteStudentID = Convert.ToInt32(cmbStudentIDS.Text);
                    int deleteCourseID = int.Parse(dgvMarksS.Rows[rowSelected].Cells[0].Value.ToString());

                    // Get the record that matches the criteria
                    var deleteStudentCourse = (from s in DB.Student_Courses
                                               where s.SID == deleteStudentID
                                               && s.CID == deleteCourseID
                                               select s).First();

                    DB.Student_Courses.DeleteOnSubmit(deleteStudentCourse);
                    DB.SubmitChanges();

                    lblMarksByStudentsMessage.Text = "Course Record deleted";
                    dgvMarksS.CurrentRow.DefaultCellStyle.BackColor = Color.White;

                    // This method call makes sure that the course
                    // tab details have been updated.
                    selectTheCourse();
                    // Update the Marks by student screen
                    updateMarksByStudent();
                }
                else if (d == DialogResult.No)
                {
                    lblMarksByStudentsMessage.Text = "Delete operation cancelled";
                    dgvMarksS.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                    return;
                }
                else
                {
                    throw new NotSupportedException();
                }
                   
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }


        // This method fills in the Marks by Student screen data properties based on 
        // the criteria set by the Student ID Combo box selection
        private void cmbStudentIDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateMarksByStudent();
        }

        internal void updateMarksByStudent()
        {
            // Change the Tab header
            tabStudent.Text = "View Marks by Student";

            // Reset the data grid before running the query
            // because this method seems to append new columns
            // to the datagrid when it is run.
            dgvMarksS.DataSource = null;
            dgvMarksS.Columns.Clear();
            dgvMarksS.Rows.Clear();

            // Select the Courses Marks with the student ID 
            // selected i n the Course ID Combo Box
            var marksByStudentList = (from s in DB.Student_Courses
                                      join c in DB.Courses
                                      on s.CID equals c.CID
                                      where s.SID == Convert.ToInt32(cmbStudentIDS.Text)
                                      select new { s.CID, c.CName, s.Mark }
                                          ).ToList();


            dgvMarksS.DataSource = marksByStudentList;

            // Set up the  by students Datagrid 
            dgvMarksS.Columns[0].HeaderText = "ID";
            dgvMarksS.Columns[0].Width = 60;
            dgvMarksS.Columns[0].ReadOnly = true;
            dgvMarksS.Columns[1].HeaderText = "Course Name";
            dgvMarksS.Columns[1].Width = 120;
            dgvMarksS.Columns[1].ReadOnly = true;
            dgvMarksS.Columns[2].HeaderText = "Mark";
            dgvMarksS.Columns[2].Width = 40;

            // Get the Student name for the selected Student ID
            // displayed in the Combo Box
            var studentName = (from n in DB.Persons
                               where n.ID == Convert.ToInt32(cmbStudentIDS.Text)
                               select new { n.FName, n.LName }
                                   ).First();

            lblStudentNameS.Text = studentName.FName + " " + studentName.LName;
        }
        // This method presents the Add Student Course panel and fills
        // the required data ready for data entry.
        private void btnAddStudentS_Click(object sender, EventArgs e)
        {
            string editing = "Add";
            tabStudent.Text = "Add a Student Course / Mark"; //Change the Tab Header
            displayTheEditPanel(editing);
        }

        private void btnUpdateS_Click(object sender, EventArgs e)
        {
            string editing = "Update";
            tabStudent.Text = "Update a Student Mark";
            displayTheEditPanel(editing);
        }

        internal void displayTheEditPanel(string edited)
        {
            pnlAddStudentS.Visible = true;
            pnlCourseIDOverlayS.Visible = false;
            pnlUpdateRecordBtnS.Visible = false;

            if (edited == "Add")
            {
                
                txtPanelMarkS.Text = "0"; // default value displayed

                // Update the Course ID Combo Box
                var courseList = (from c in DB.Courses
                                  select c.CID).ToList();

                cmbPanelCourseIDS.DisplayMember = "CID";
                cmbPanelCourseIDS.ValueMember = "CID";
                cmbPanelCourseIDS.DataSource = courseList;
            }
            else if (edited == "Update")
            {
                // Cover up the Course ID Combo box with a Course ID label.
                // The combo box is not required in Update.
                pnlCourseIDOverlayS.Visible = true;
                pnlUpdateRecordBtnS.Visible = true;
 
                int rowSelected = dgvMarksS.CurrentCell.RowIndex;
                txtPanelOverlayCourseIDS.Text = dgvMarksS.Rows[rowSelected].Cells[0].Value.ToString();
                txtPanelMarkS.Text = dgvMarksS.Rows[rowSelected].Cells[2].Value.ToString();

                // Get the Course Name for the panel
                var courseName = (from n in DB.Courses
                                  where n.CID == int.Parse(txtPanelOverlayCourseIDS.Text)
                                  select n.CName).First();

                lblPanelCourseNameS.Text = courseName;
            }
            
            txtPanelStudentIDS.Text = cmbStudentIDS.Text;
            lblPanelStudentNameS.Text = lblStudentNameS.Text;
        }
        // This method selects the course name in the Add Student Course panel
        // when the Course ID combo box value changes
        private void cmbPanelCourseIDS_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the Course Name
            var courseName = (from n in DB.Courses
                              where n.CID == int.Parse(cmbPanelCourseIDS.SelectedItem.ToString())
                              select n.CName).First();

            lblPanelCourseNameS.Text = courseName;
        }

        // This method updates the Student Course table with the data
        // that was entered on the add student course panel. It also 
        // puts the Student ID that was selected for editing back into
        // the Student ID combo box.
        private void btnPanelAddStudentS_Click(object sender, EventArgs e)
        {
            string editing = "Add";
            addOrUpdateMark(editing);
        }

        private void btnPanelUpdateStudentS_Click(object sender, EventArgs e)
        {
            string editing = "Update";
            addOrUpdateMark(editing);
        }

        // This method is the guts of the Add / Update procedure called
        // by btnPanelAddStudentS_Click or btnPanelUpdateStudentS_Click
        // button event.
        internal void addOrUpdateMark(string edited)
        {
            try
            {
                // Test the Mark value to see if it is a numeric
                // and not a string or decimal
                if (!validMarkIsNumber(txtPanelMarkS.Text))
                {
                    return;
                }

                // Test the Mark value to see if it is between 0 and 99
                if (!validMarkInRange(txtPanelMarkS.Text))
                {
                    return;
                }

                if (edited == "Add")
                {
                    // Test that the course ID has not already been selected for this student
                    if (!validUniqueCourseNumber(cmbPanelCourseIDS.SelectedItem.ToString()))
                    {
                        return;
                    }

                    // Write to the student courses table.
                    var newStudentCourse = new Student_Course();
                    newStudentCourse.SID = int.Parse(txtPanelStudentIDS.Text);
                    newStudentCourse.CID = int.Parse(cmbPanelCourseIDS.SelectedItem.ToString());
                    newStudentCourse.Mark = int.Parse(txtPanelMarkS.Text);

                    // 
                    DB.Student_Courses.InsertOnSubmit(newStudentCourse);
                    DB.SubmitChanges();
                }
                else if (edited == "Update")
                {
                    var updateStudentCourse = (from u in DB.Student_Courses
                                                where u.SID == int.Parse(txtPanelStudentIDS.Text)
                                                && u.CID == int.Parse(txtPanelOverlayCourseIDS.Text)
                                                select u).First();

                    updateStudentCourse.Mark = int.Parse(txtPanelMarkS.Text);

                    // Save the changes that were made
                    DB.SubmitChanges();

                    // Refresh the bound controls
                    DB.Refresh(RefreshMode.OverwriteCurrentValues, DB.Student_Courses);
                }

                //Put the existing Student ID back in the Student Combo Box
                var studentListPanel = (from s in DB.Persons
                               where s.Type == "Student"
                               select s.ID).ToList();

                cmbStudentIDS.DisplayMember = "ID";
                cmbStudentIDS.ValueMember = "ID";
                cmbStudentIDS.DataSource = studentListPanel;

                int codeCount = 0;
                int theCode = 0;
                foreach (int id in studentListPanel)
                {
                    if (id == int.Parse(txtPanelStudentIDS.Text))
                    {
                        theCode = codeCount;
                    }
                    codeCount++;
                }
                cmbStudentIDS.SelectedIndex = theCode;

                // This method call makes sure that the course
                // tab details have been updated.
                selectTheCourse();

                // Switch off the Add Student Course panel
                pnlAddStudentS.Visible = false;

                if (edited == "Add")
                {
                    lblMarksByStudentsMessage.Text = "Student Course details added";
                }
                else if (edited == "Update")
                {
                    lblMarksByStudentsMessage.Text = "Student Course mark updated";
                }
                tabStudent.Text = "View Marks by Student"; //Change the Tab Header
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        // This method checks to see if the mark is an actual integer
        private bool validMarkIsNumber(string markToCheck)
        {
            int number;
            bool result = Int32.TryParse(markToCheck, out number);

            if (result)
            {
                lblPanelMarkMessageS.Text = "";
                return true;
            }
            else
            {
                lblPanelMarkMessageS.Text = "Enter a whole number between 0 and 100";
                return false;
            }

        }

        // This method checks to see if the mark number is between 0 and 100
        private bool validMarkInRange(string markToCheck)
        {
            if (int.Parse(markToCheck) >= 0 && int.Parse(markToCheck) <= 100)
            {
                lblPanelMarkMessageS.Text = "";
                return true;
            }
            else
            {
                lblPanelMarkMessageS.Text = "Enter a whole number between 0 and 100";
                return false;
            }
        }

        // This method checks to see if the course number hasn't already
        // been seleceted for the selected student.
        private bool validUniqueCourseNumber(string courseID)
        {
            // Get the list of courses for the student
            var coursenumbers = (from c in DB.Student_Courses
                                 where c.SID == Convert.ToInt32(txtPanelStudentIDS.Text)
                                 select c.CID).ToList();

            // See if the selected course is on the list.
            foreach (int course in coursenumbers)
            {
                if (course == int.Parse(courseID))
                {
                    //lblPanelCourseNameS.ForeColor = 192, 0, 0;                                    ??
                    lblPanelCourseNameS.Text = "This course number is already used by the student";
                    return false;
                }
            }
            return true;
        }


        private void btnPanelCancelS_Click(object sender, EventArgs e)
        {
            pnlAddStudentS.Visible = false;
            tabStudent.Text = "View Marks by Student"; //Change the Tab Header
            lblMarksByStudentsMessage.Text = "Add/Edit function cancelled";
        }

        // This method exits the Marks by Student Screen
        private void btnExitS_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        // This method exits the Marks by Course Screen
        private void btnExitC_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        

        

       

        

       
       

        

    }

}
