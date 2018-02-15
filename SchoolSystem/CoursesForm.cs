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
    //Written by : Paul Smyth
    //Date of last issue : 9/9/2015
    //
    // This form displays the required data entry mechanisms for the user 
    // to add, edit and delete Courses records.
    // It reads and writes to the following tables with SQL TO LINQ procedures
    //      Course
    //      
    //      
    public partial class CoursesForm : Form
    {
        SchoolDataClassesDataContext DB = new SchoolDataClassesDataContext();

        // This bool is used to switch off a section of code that updates the 
        // course ID combo box in the updateData method. This item does not need
        // to be refreshed after an update procedure because no course record 
        // has been added or deleted. The benefit of this is that the updated
        // record in the Update Tab can still be displayed after the update
        // process has been completed instead of the first record in the 
        // courses table.
        bool updated = false;

        public CoursesForm()
        {
            InitializeComponent();
        }

        private void CoursesForm_Load(object sender, EventArgs e)
        { 
            updateData(updated);

            // Set up the initial help messages
            lblCoursesMessageA.Text = "Enter the new Course details and press the Add Button";
            lblCoursesMessageU.Text = "Select a Course to edit from the Course ID drop down box";

            // Setup the ToolTips for this form
            toolTip1.SetToolTip(btnAddA, "Add the Course Record you have entered");
            toolTip1.SetToolTip(btnDeleteU, "Delete the selected record from Courses");
            toolTip1.SetToolTip(btnExitA, "Return to Main Menu");
            toolTip1.SetToolTip(btnExitU, "Return to Main Menu");
            toolTip1.SetToolTip(btnUpdateU, "Write the updated record to Courses");
            toolTip1.SetToolTip(cmbCourseIDU, "Select the Course ID to edit/delete from the drop down list");
            toolTip1.SetToolTip(cmbQualificationCodeA, "Select a Qualification Code from the drop down list");
            toolTip1.SetToolTip(cmbSemesterA, "Select a Semester from the drop down list");
            toolTip1.SetToolTip(cmbSemesterU, "Select a Semester from the drop down list");
            toolTip1.SetToolTip(cmbTeacherIDA, "Select a Teacher from the drop down list");
            toolTip1.SetToolTip(cmbTeacherIDU, "Select a Teacher from the drop down list");
            toolTip1.SetToolTip(cmbYearA, "Select a Year from the drop down list");
            toolTip1.SetToolTip(cmbYearU, "Select a Year from the drop down list");
            toolTip1.SetToolTip(txtCourseIDA, "Enter a unique Course ID");
            toolTip1.SetToolTip(txtCourseNameA, "Enter the Course Name");
            toolTip1.SetToolTip(txtCourseNameU, "Edit the Course Name");
        }

        // This method performs the required updates for all tables and combo
        // boxes used by this form. It makes sure the correct data is displayed
        // for the chosen ID
        private void updateData(bool fromUpdate)
        {
            // Update the Course data
            var courseList = (from c in DB.Courses
                              select c).ToList();

            // Update the Course ID Combo Box
            // as long as this method wasn't called by the
            // update button event method.
            if (fromUpdate == false)
            {
                cmbCourseIDU.DisplayMember = "CID";
                cmbCourseIDU.ValueMember = "CID";
                cmbCourseIDU.DataSource = courseList;
            }
            

            // Update the Teacher ID Combo Box display
            var teachercodes = (from t in DB.Teachers
                                select t.TID).ToList();

            cmbTeacherIDA.DisplayMember = "TID";
            cmbTeacherIDA.ValueMember = "TID";
            cmbTeacherIDA.DataSource = teachercodes;

            // Update the Qualification Code Combo Box display
            var qualificationcodes = (from q in DB.Qualifications
                                      select q.QCode).ToList();

            cmbQualificationCodeA.DisplayMember = "QCode";
            cmbQualificationCodeA.ValueMember = "QCode";
            cmbQualificationCodeA.DataSource = qualificationcodes;

             // Reset all the Course text Fields in the Add Tab
            txtCourseIDA.Clear();
            txtCourseNameA.Clear();
        }

        // This method performs the selection process for the courses
        // data when either the update screen is updated or the
        // value in the courses id combo box has changed. 
        //  It is called by the cmbCourseIDU_SelectedIndexChanged
        //  and btnUpdateU_Click event
        internal void selectTheRecord()
        {
            String selectedYear; //store for the selected Year branch
            string selectedSemester; //store for the selcted Semester branch

            // Select the Course Record with the Course ID selected
            // from the Course ID Combo Box.
            var course = (from c in DB.Courses
                          where c.CID == Convert.ToInt32(cmbCourseIDU.Text)
                          select new
                          {
                              c.CName,
                              c.Year,
                              c.Semester,
                              c.TID
                          }
                          ).First();

            txtCourseNameU.Text = course.CName;
         
            // Put the right year in the Combo Box. Either year 1
            // year 2 or year 3.
            selectedYear = course.Year.ToString();
            switch (selectedYear)
            {
                case "1":
                    cmbYearU.SelectedIndex = 0;
                    break;
                case "2":
                    cmbYearU.SelectedIndex = 1;
                    break;
                case "3":
                    cmbYearU.SelectedIndex = 2;
                    break;
            }

            // Put the right Semester in the Combo Box
            selectedSemester = course.Semester;
            switch (selectedSemester)
            {
                case "Autumn":
                    cmbSemesterU.SelectedIndex = 0;
                    break;
                case "Winter":
                    cmbSemesterU.SelectedIndex = 1;
                    break;
                case "Spring":
                    cmbSemesterU.SelectedIndex = 2;
                    break;
            }
            // Update the Teacher ID Combo Box display
            var teachercodes = (from t in DB.Teachers
                                select t.TID).ToList();

            cmbTeacherIDU.DisplayMember = "TID";
            cmbTeacherIDU.ValueMember = "TID";
            cmbTeacherIDU.DataSource = teachercodes;

            //Put the correct teacher Code in the Combo Box
            int codeCount = 0;
            int theCode = 0;
            foreach (int code in teachercodes)
            {
                if (code == course.TID)
                {
                    theCode = codeCount;
                }
                codeCount++;
            }
            cmbTeacherIDU.SelectedIndex = theCode;

            // Lookup the selected teachers name and put it in the label
            // adjacent to the Teacher ID combo on the form

            var teacherName = (from t in DB.Persons
                               where t.ID == int.Parse(cmbTeacherIDU.SelectedItem.ToString())
                               select new
                               {
                                   t.FName,
                                   t.LName
                               }).First();

            lblTeacherNameU.Text = teacherName.FName + " " + teacherName.LName;

           

        }
        // This method fills in the Update screen data properties based on 
        // the criteria set by the Course ID Combo box selection
        private void cmbCourseIDU_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectTheRecord();
        }


        // This section contains a series of methods that tests the data entry 
        // fields for both the Add and Update Tabs. Each method tests what is the 
        // current screen is and creates an error message if required. They are 
        // activated by the Add and Update Button events.


        // This method tests the course number to check
        // that it is valid.
        // Only required for Add
        private bool ValidCourseID(string courseID)
        { 
            if (courseID == "")
            {
                lblCourseIDMessageA.Text = "Please enter a valid numeric course number";
                return false;
            }
            else if (int.Parse(courseID) >= 0 & int.Parse(courseID) <= 99999)
            {
                lblCourseIDMessageA.Text = "";
                return true;
            }
            else
            {
                lblCourseIDMessageA.Text = "Please enter a valid numeric course number";
                return false;
            }
        }


        // This method tests the course number to check that it is 
        // not a duplicate. Only required for Add 
        private bool validUniqueCourseNumber(string courseID)
        {
            // Lookup the existing course numbers
            var coursenumbers = (from c in DB.Courses
                                 select c.CID).ToList();   


            foreach (int course in coursenumbers)
            {
                if (course == int.Parse(courseID))
                {
                    lblCourseIDMessageA.Text = "This course number has already been used";
                    return false;
                }
            }
            lblCourseIDMessageA.Text = "";
            return true;
        }

        // This method tests the course name to make sure that it is not blank
        private bool ValidCourseName(string coursename, string tab)
        {
            if (coursename != "")
            {
                if (tab == "Add")
                {
                    lblCourseNameMessageA.Text = "";
                }
                else if (tab == "Update")
                {
                    lblCourseNameMessageU.Text = "";
                }
                return true;
            }
            else
            {
                if (tab == "Add")
                {
                    lblCourseNameMessageA.Text = "Please enter a course name";
                }
                else if (tab == "Update")
                {
                    lblCourseNameMessageU.Text = "Please enter a course name";
                }
                return false;
            }
        } 

        // This method tests the year to make sure that it is not blank
        // Only required for Add
        private bool ValidYear(string year)
        {
            if (year != "")
            {
                lblYearMessageA.Text = "";
                return true;
            }
            else
            {
                lblYearMessageA.Text = "Please select a year";
                return false;
            }
        }

        // This method tests the semester to make sure that it is not blank
        // Only required for Add
        private bool ValidSemester(string semester)
        {
            if (semester != "")
            {
                lblSemesterMessageA.Text = "";
                return true;
            }
            else
            {
                lblSemesterMessageA.Text = "Please select a semester";
                return false;
            }
        }

        // This method updates the Course table
        private void btnUpdateU_Click(object sender, EventArgs e)
        {
            try
            {
                // Indicate that this is the Update Tab for Error Message control
                string theTab = "Update";

                // Test that a course name has been entered
                if (!ValidCourseName(txtCourseNameU.Text, theTab))
                {
                    return;
                }

                // Update the Course record in the Courses Table
                var courseList = (from c in DB.Courses
                                  where c.CID == Convert.ToInt32(cmbCourseIDU.Text)
                                  select c).First();

                courseList.CName = txtCourseNameU.Text.Trim();
                courseList.Year = (int)int.Parse(cmbYearU.SelectedItem.ToString());
                courseList.Semester = cmbSemesterU.SelectedItem.ToString();
                courseList.TID = (int)cmbTeacherIDU.SelectedItem;

                // Save the changes that were made
                DB.SubmitChanges();

                // Refresh the Bound controls
                DB.Refresh(RefreshMode.OverwriteCurrentValues, DB.Courses);

                lblCoursesMessageU.Text = "Course ID " + cmbCourseIDU.Text + " has been updated";

                updated = true;
                updateData(updated);
                selectTheRecord();
                updated = false;
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        // This method adds data to the Courses table
        private void btnAddA_Click(object sender, EventArgs e)
        {
            try
            {
                // Indicate that this is the Add Tab for Error Message control
                string theTab = "Add";

                // Test that a valid course number has been entered
                if (!ValidCourseID(txtCourseIDA.Text))
                {
                    return;
                }

                // Test that a unique Course number has been entered
                if (!validUniqueCourseNumber(txtCourseIDA.Text))
                {
                    return;
                }

                // Test that a course name has been entered
                if (!ValidCourseName(txtCourseNameA.Text, theTab))
                {
                    return;
                }

                // Test that a year has been selected
                if (!ValidYear(cmbYearA.Text))
                {
                    return;
                }

                // Test that a semester has been selected
                if (!ValidSemester(cmbSemesterA.Text))
                {
                    return;
                }

                // Create a new Courses object and add its properties
                var newCourse = new Course();
                newCourse.CID = int.Parse(txtCourseIDA.Text.ToString());
                newCourse.CName = txtCourseNameA.Text.Trim();
                newCourse.Year = int.Parse(cmbYearA.SelectedItem.ToString());
                newCourse.Semester = cmbSemesterA.SelectedItem.ToString();
                newCourse.TID = int.Parse(cmbTeacherIDA.SelectedItem.ToString());

                // Add the new course to the database
                DB.Courses.InsertOnSubmit(newCourse);
                DB.SubmitChanges();

                // Create a new Qualification_Courses object and
                // add its properties
                var newQualCourse = new Qualification_Course();
                newQualCourse.QCode = cmbQualificationCodeA.SelectedItem.ToString();
                newQualCourse.CID = int.Parse(txtCourseIDA.Text.ToString());

                // Add the new record to the database
                DB.Qualification_Courses.InsertOnSubmit(newQualCourse);
                DB.SubmitChanges();

                lblCoursesMessageA.Text = "Course ID " + txtCourseIDA.Text + " added";

                updateData(updated);
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        // This method deletes the selected rcord in the update screen
        // from the Courses table.
        private void btnDeleteU_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the course that matches the criteria in the course ID
                // combo box
               
                var deletedCourse = (from c in DB.Courses
                                     where c.CID == (int)cmbCourseIDU.SelectedValue
                                     select c).First();

                DialogResult d = MessageBox.Show("Are you sure you want to delete this Course?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (d == DialogResult.Yes)
                {
                    DB.Courses.DeleteOnSubmit(deletedCourse);
                    
                    DB.SubmitChanges();

                    updateData(updated);

                    MessageBox.Show("Course deleted");
                }

                else if (d == DialogResult.No)
                {
                    MessageBox.Show("Delete operation cancelled");
                }
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        //Lookup the selected teachers name and put it in the adjacent label
        //in the Update form
        private void cmbTeacherIDU_SelectedIndexChanged(object sender, EventArgs e)
        {
            var teacherName = (from t in DB.Persons
                               where t.ID == int.Parse(cmbTeacherIDU.SelectedItem.ToString())
                               select new
                               {
                                   t.FName,
                                   t.LName
                               }).First();

            lblTeacherNameU.Text = teacherName.FName + " " + teacherName.LName;
        }

        // Lookup the selected teachers name and put it in the adjacent label
        // in the Add form
        private void cmbTeacherIDA_SelectedIndexChanged(object sender, EventArgs e)
        {
            var teacherName = (from t in DB.Persons
                               where t.ID == int.Parse(cmbTeacherIDA.SelectedItem.ToString())
                               select new
                               {
                                   t.FName,
                                   t.LName
                               }).First();

            lblTeacherNameA.Text = teacherName.FName + " " + teacherName.LName;
        }

        // Lookup the selected qualification name and put it in the adjacent
        // label in the Add form
        private void cmbQualificationCodeA_SelectedIndexChanged(object sender, EventArgs e)
        {
            var qualificationName = (from q in DB.Qualifications
                                     where q.QCode == cmbQualificationCodeA.Text
                                     select q.QName).First();

            lblQualificationNameA.Text = qualificationName;
        }

        // This method exits from the Add screen
        private void btnExitA_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        // This method exits from the Update screen
        private void btnExitU_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }
    }
}
