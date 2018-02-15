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
    // to add, edit and delete Qualification records.
    // It reads and writes to the following tables with SQL TO LINQ procedures
    //      Qualification
    //      Qualification_Courses
    //      
    // There is an extra tab on this form which displays 2 datagrids.
    // This tab screen is used to add or delete courses to qualifications.
    // The user clicks the record to add or delete and then clicks the 
    // Add or Delete button to perform that action. A panel with basic
    // instructions can be called up by clicking a Help button on that tab.

    public partial class QualificationsForm : Form
    {
        SchoolDataClassesDataContext DB = new SchoolDataClassesDataContext();

        // This bool is used to switch off a section of code that updates the 
        // qualification ID combo box in the updateData method. This item does not need
        // to be refreshed after an update procedure because no course record 
        // has been added or deleted. The benefit of this is that the updated
        // record in the Update Tab can still be displayed after the update
        // process has been completed instead of the first record in the 
        // courses table.
        bool updated = false;

        public QualificationsForm()
        {
            InitializeComponent();
        }

        private void QualificationsForm_Load(object sender, EventArgs e)
        {
            updateData(updated);

            pnlHelpC.Visible = false; // Make sure the Help panel is closed.

            // Load Course data into the available courses dataset view
            // in the Add Delete Courses Tab

            var courseList = (from c in DB.Courses
                              select new { c.CID, c.CName }
                              ).ToList();

            dgvAvailableCoursesC.DataSource = courseList;
            dgvAvailableCoursesC.Columns[0].HeaderText = "ID";
            dgvAvailableCoursesC.Columns[0].Width = 40;
            dgvAvailableCoursesC.Columns[1].HeaderText = "Name";
            dgvAvailableCoursesC.Columns[1].Width = 152;

            // Setup the ToolTips for this form
            toolTip1.SetToolTip(btnAddA, "Add the Qualification Record you have entered");
            toolTip1.SetToolTip(btnAddC, "Add the Course you have selected in Available Courses Table");
            toolTip1.SetToolTip(btnDeleteC, "Delete the Course you have selected in Courses Table");
            toolTip1.SetToolTip(btnDeleteU, "Delete the selected record from Qualifications");
            toolTip1.SetToolTip(btnExitA, "Return to Main Menu");
            toolTip1.SetToolTip(btnExitC, "Return to Main Menu");
            toolTip1.SetToolTip(btnExitU, "Return to Main Menu");
            toolTip1.SetToolTip(btnUpdateU, "Write the updated record to Qualifications");
            toolTip1.SetToolTip(cmbDurationA, "Select the duration period for this qualification from the drop down list");
            toolTip1.SetToolTip(cmbQualificationIDC, "Select the Qualification you wish to inspect from the drop down list");
            toolTip1.SetToolTip(cmbQualificationIDU, "Select the Qualification you wish to update/delete from the drop down list");
            toolTip1.SetToolTip(txtQualificationIDA, "Enter a unique Qualification ID");
            toolTip1.SetToolTip(txtQualificationNameA, "Enter the Qualification Name");
            toolTip1.SetToolTip(txtQualificationNameU, "Change the Qualification Name");
            
        }

        //This method performs the required updates for all tables and combo
        //boxes used by this form.
        private void updateData(bool fromUpdate)
        {
            // Update the Qualification data
            var qualList = (from q in DB.Qualifications
                            select q).ToList();

            // Update the Qualification ID Combo Box
            // as long as this method wasn't called by the
            // update button event method.
            if (fromUpdate == false)
            {
                cmbQualificationIDU.DisplayMember = "QCode";
                cmbQualificationIDU.ValueMember = "QCode";
                cmbQualificationIDU.DataSource = qualList;
            }
            

            // Update the Qualification/Course data
            var qualCourseList = (from c in DB.Qualification_Courses
                                  select c).ToList();

            //Update the Qualification/Course ID Combo Box
            cmbQualificationIDC.DisplayMember = "QCode";
            cmbQualificationIDC.ValueMember = "QCode";
            cmbQualificationIDC.DataSource = qualList;

            // Clear the Text fields on the Add Tab
            txtQualificationIDA.Clear();
            txtQualificationNameA.Clear();
        }


        // This method fills in the Update screen data properties based on 
        // the criteria set by the Qualification ID Combo box selection by using
        // the selectTheRecord method. selectTheRecord method is also called by the
        // btnUpdateU_Click event
        private void cmbQualificationIDU_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectTheRecord();
        }


        // This method ensures that the correct data is displayed after an update 
        // has been performed or the user has selected a different Qualification ID
        // in the update screen. It is called by the cmbQualificationIDU_SelectedIndexChanged
        // and btnUpdateU_Click event

        internal void selectTheRecord()
        {
            string selectedDuration; // Store for the selected Duration branch

            // Select the Qualification record with the Qualification ID
            // selected from the Qualification ID Combo Box

            var qualification = (from q in DB.Qualifications
                                 where q.QCode == cmbQualificationIDU.Text
                                 select q).First();

            txtQualificationNameU.Text = qualification.QName;

            // Put the right duration in the Combo Box
            selectedDuration = qualification.Duration.ToString();

            switch (selectedDuration)
            {
                case "1 month":
                    cmbDurationU.SelectedIndex = 0;
                    break;
                case "2 months":
                    cmbDurationU.SelectedIndex = 1;
                    break;
                case "3 months":
                    cmbDurationU.SelectedIndex = 2;
                    break;
                case "4 months":
                    cmbDurationU.SelectedIndex = 3;
                    break;
                case "5 months":
                    cmbDurationU.SelectedIndex = 4;
                    break;
                case "6 months":
                    cmbDurationU.SelectedIndex = 5;
                    break;
                case "7 months":
                    cmbDurationU.SelectedIndex = 6;
                    break;
                case "8 months":
                    cmbDurationU.SelectedIndex = 7;
                    break;
                case "9 months":
                    cmbDurationU.SelectedIndex = 8;
                    break;
                case "10 months":
                    cmbDurationU.SelectedIndex = 9;
                    break;
                case "11 months":
                    cmbDurationU.SelectedIndex = 10;
                    break;
                case "12 months":
                    cmbDurationU.SelectedIndex = 11;
                    break;
            }
        }
        // This section contains a series of methods that tests the data entry 
        // fields for both the Add and Update Tabs. Each method tests what is the 
        // current screen is and creates an error message if required. They are 
        // activated by the Add and Update Button events.

        // This method tests the qualification ID
        // to make sure that it is not blank.
        // Only required for ADD
        private bool ValidQualificationID(string qualificationID)
        {
            if (qualificationID != "")
            {
                lblQualificationIDMessageA.Text = "";
                return true;
            }
            else
            {
                lblQualificationIDMessageA.Text = "Please enter a valid qualification ID";
                return false;
            }
        }

        // This method tests the qualification name to make sure that it is not blank
        private bool ValidQualificationName(string qualificationname, string tab)
        {
            if (qualificationname != "")
            {
                if (tab == "Add")
                {
                    lblQualificationNameMessageA.Text = "";
                }
                else if (tab == "Update")
                {
                    lblQualificationNameMessageU.Text = "";
                }
                return true;
            }
            else
            {
                if (tab == "Add")
                {
                    lblQualificationNameMessageA.Text = "Please enter a qualification name";
                }
                else if (tab == "Update")
                {
                    lblQualificationNameMessageU.Text = "Please enter a qualification name";
                }
                return false;
            }
        }

        // This method tests the duration entry
        // to make sure that it is not blank.
        // Only required for ADD
        private bool ValidDuration(string duration)
        {
            if (duration != "")
            {
                lblDurationMessageA.Text = "";
                return true;
            }
            else
            {
                lblDurationMessageA.Text = "Please enter a valid duration ID";
                return false;
            }
        }

        // This method updates the Qualification table
        private void btnUpdateU_Click(object sender, EventArgs e)
        {
            try
            {
                // Indicate that this is the Update Tab for Error Message control
                string theTab = "Update";

                // Test that the qualification name has been entered
                if (!ValidQualificationName(txtQualificationNameU.Text, theTab))
                {
                    return;
                }

                // Update the selected record in the Qualifications table
                var qualification = (from q in DB.Qualifications
                                     where q.QCode == cmbQualificationIDU.Text
                                     select q).First();

                qualification.QName = txtQualificationNameU.Text;
                qualification.Duration = cmbDurationU.SelectedItem.ToString();

                // Save the changes that were made
                DB.SubmitChanges();

                // Refresh the Bound Controls
                DB.Refresh(RefreshMode.OverwriteCurrentValues, DB.Qualifications);

                MessageBox.Show("Qualification Code " + qualification.QCode + " updated");

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

        // This method verifies the data added in the Add screen
        // and then writes the data to the Qualifications table.
        private void btnAddA_Click(object sender, EventArgs e)
        {
            try
            {
                // Indicate that this is the Add Tab for Error Message control
                string theTab = "Add";

                // Test that the qualification ID has been entered
                if (!ValidQualificationID(txtQualificationIDA.Text))
                {
                    return;
                }

                // Test that the qualification name has been entered
                if (!ValidQualificationName(txtQualificationNameA.Text, theTab))
                {
                    return;
                }

                // Test that the duration has been selected
                if (!ValidDuration(cmbDurationA.Text))
                {
                    return;
                }

                // Create a new Qualifications object and add its properties
                var newQualification = new Qualification();
                newQualification.QCode = txtQualificationIDA.Text.Trim();
                newQualification.QName = txtQualificationNameA.Text.Trim();
                newQualification.Duration = cmbDurationA.SelectedItem.ToString();
                
                // Add the new Qualification to the database
                DB.Qualifications.InsertOnSubmit(newQualification);
                DB.SubmitChanges();

                MessageBox.Show("Qualification " + newQualification.QCode + " added");
                updateData(updated);
            }

            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        // This method deletes the selected Qualification listed in
        // the Combo box from the Qualification Table. It also
        // deletes the associated Qualification_Course table records too.
        private void btnDeleteU_Click(object sender, EventArgs e)
        {
            try
            {
                var deletedQualification = (from q in DB.Qualifications
                                            where q.QCode == cmbQualificationIDU.Text
                                            select q).First();

                var deletedQualificationCourse = (from c in DB.Qualification_Courses
                                                  where c.QCode == cmbQualificationIDU.Text
                                                  select c).ToList();


                DialogResult d = MessageBox.Show("Are you sure you want to delete this Qualification?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (d == DialogResult.Yes)
                {
                    DB.Qualifications.DeleteOnSubmit(deletedQualification);
                    DB.Qualification_Courses.DeleteAllOnSubmit(deletedQualificationCourse);
                    DB.SubmitChanges();
                    
                    updateData(updated);

                    MessageBox.Show("Qualification deleted");
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

        // This method selects The Qualification/Course data to display based
        // on what is selected in the Qualification ID Combo Box. It also
        // Looks up the Qualification name for the selected qualification.
        // The Available Courses datagrid is updated by the UpdateData method
        private void cmbQualificationIDC_SelectedIndexChanged(object sender, EventArgs e)
        {
            var qualCourseList = (from q in DB.Qualification_Courses
                                  join c in DB.Courses
                                  on q.CID equals c.CID
                                  where q.QCode == cmbQualificationIDC.Text
                                  select new { q.CID, c.CName }
                                  ).ToList();

            dgvCoursesC.DataSource = qualCourseList;
            dgvCoursesC.Columns[0].HeaderText = "ID";
            dgvCoursesC.Columns[0].Width =40;
            dgvCoursesC.Columns[1].HeaderText = "Name";
            dgvCoursesC.Columns[1].Width = 152;

            var qualName = (from n in DB.Qualifications
                            where n.QCode == cmbQualificationIDC.Text
                            select n.QName).First();

            lblQualificationNameC.Text = qualName;
        }

        // This method copies the selected record from the available courses datagrid
        // and copies it to the qualification courses table. Then it updates the 
        // qualification courses datagrid.
        private void btnAddC_Click(object sender, EventArgs e)
        {
            try
            {
                // Store the current selected Combo value so that it 
                // can be selected after the process is finished.
                var theQualificationID = cmbQualificationIDC.SelectedIndex;

                //Select the selected Course ID from the Course datagrid
                int rowSelected = dgvAvailableCoursesC.CurrentCell.RowIndex;
                var selectedCourseIDNumber = dgvAvailableCoursesC.Rows[rowSelected].Cells[0].Value.ToString();

                // Check that it is not already been added to the 
                // selected Qualification
                var cidList = (from q in DB.Qualification_Courses
                                      where q.QCode == cmbQualificationIDC.Text
                                      select q.CID).ToList();

                foreach (int c in cidList)
                {
                    if (c == int.Parse(selectedCourseIDNumber))
                    {
                        MessageBox.Show("The selected course has already been added");
                        return;
                    }
                }
           
                // Use the selected Qualification Code and Course ID to 
                // create a new Qualification_Course record
                var newQualificationCourse = new Qualification_Course();
                newQualificationCourse.QCode = cmbQualificationIDC.SelectedValue.ToString();
                newQualificationCourse.CID = int.Parse(selectedCourseIDNumber);

                DB.Qualification_Courses.InsertOnSubmit(newQualificationCourse);
                DB.SubmitChanges();

                MessageBox.Show("Course added to Qualification");

                updateData(updated);

                // Recall the selected combo value
                cmbQualificationIDC.SelectedIndex = theQualificationID;
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        // This method will delete the selected record in the 
        // Qualification_Course datagrid
        private void btnDeleteC_Click(object sender, EventArgs e)
        {
            try
            {
                // Store the current selected Combo value so that it 
                // can be selected after the process is finished.
                var theQualificationID = cmbQualificationIDC.SelectedIndex;

                // Identify the Qualification_Course record to delete
                // from the datagrid.
                int rowSelected = dgvCoursesC.CurrentCell.RowIndex;
                var selectedCID = dgvCoursesC.Rows[rowSelected].Cells[0].Value;

                var deletedQualificationCourse = (from c in DB.Qualification_Courses
                                                  where c.QCode == cmbQualificationIDU.Text
                                                  && c.CID == (int) selectedCID
                                                  select c).First();


                DialogResult d = MessageBox.Show("Are you sure you want to delete this Qualification?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (d == DialogResult.Yes)
                {
                    DB.Qualification_Courses.DeleteOnSubmit(deletedQualificationCourse);
                    DB.SubmitChanges();

                    updateData(updated);

                    // Recall the selected combo value
                    cmbQualificationIDC.SelectedIndex = theQualificationID;

                    MessageBox.Show("Qualification Course deleted");
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

        // This method exits from the Change Courses screen
        private void btnExitC_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        // Close the Help Panel
        private void btnCloseHelpC_Click(object sender, EventArgs e)
        {
            pnlHelpC.Visible = false;
        }

        // Open the Help Panel
        private void btnHelpC_Click(object sender, EventArgs e)
        {
            pnlHelpC.Visible = true;
        }
    }

}
