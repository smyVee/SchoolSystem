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
    public partial class StudentsForm : Form
    {
        SchoolDataClassesDataContext DB = new SchoolDataClassesDataContext();
        int postCodeLow, postCodeHigh;

        public StudentsForm()
        {
            InitializeComponent();
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





        //This method performs the required updates for all tables and combo
        //boxes used by this form.
        private void UpdateData()
        {
            // Select the Student record from the Person & Student database
            var studentList = (from p in DB.Persons
                               join s in DB.Students
                               on p.ID equals s.SID
                               select new
                               {
                                   p.ID,
                                   p.FName,
                                   p.LName,
                                   p.DOB,
                                   p.Phone,
                                   p.Add1,
                                   p.Add2,
                                   p.Suburb,
                                   p.State,
                                   p.Postcode,
                                   s.Sdate,
                                   s.QCode
                               }
                           ).ToList();

            // Update the Student ID combo box data
            cmbStudentIDU.DisplayMember = "ID";
            cmbStudentIDU.ValueMember = "ID";
            cmbStudentIDU.DataSource = studentList;

            // Update the Qualification Code Combo Box display
            var qualcodes = (from q in DB.Qualifications
                             select q.QCode).ToList();

            cmbQualificationCodeA.DisplayMember = "QCode";
            cmbQualificationCodeA.ValueMember = "QCode";
            cmbQualificationCodeA.DataSource = qualcodes;

          
        }





        private void StudentsForm_Load(object sender, EventArgs e)
        {
            UpdateData();
            
        }

        // This method fills in the Update screen data properties based on 
        // the criteria set by the Student ID Combo box selection
        private void cmbStudentIDU_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState; // store for the selected state branch statement 

            // Select the Student record from the Person & Student database
            var student = (from p in DB.Persons
                           join s in DB.Students
                           on p.ID equals s.SID
                           where p.ID == Convert.ToInt32(cmbStudentIDU.Text)
                           select new
                           {
                               p.FName,
                               p.LName,
                               p.DOB,
                               p.Phone,
                               p.Add1,
                               p.Add2,
                               p.Suburb,
                               p.State,
                               p.Postcode,
                               s.Sdate,
                               s.QCode
                           }
                           ).First();

            txtFirstNameU.Text = student.FName;
            txtLastNameU.Text = student.LName;
            dtpDateOfBirthU.Value = student.DOB;
            txtPhoneU.Text = student.Phone;
            txtAddress1U.Text = student.Add1;
            txtAddress2U.Text = student.Add2;
            txtSuburbU.Text = student.Suburb;

            // Put the right State in the State Combo Box
            selectedState = student.State;
            switch (selectedState)
            {
                case "NSW":
                    cmbStateU.SelectedIndex = 0;
                    break;
                case "VIC":
                    cmbStateU.SelectedIndex = 1;
                    break;
                case "QLD":
                    cmbStateU.SelectedIndex = 2;
                    break;
                case "SA":
                    cmbStateU.SelectedIndex = 3;
                    break;
                case "WA":
                    cmbStateU.SelectedIndex = 4;
                    break;
                case "ACT":
                    cmbStateU.SelectedIndex = 5;
                    break;
                case "NT":
                    cmbStateU.SelectedIndex = 6;
                    break;
                case "TAS":
                    cmbStateU.SelectedIndex = 7;
                    break;
            }
           
            txtPostcodeU.Text = student.Postcode;
            dtpStartDateU.Value = student.Sdate;

            // Update the Qualification Code Combo Box display
            var qualcodes = (from q in DB.Qualifications
                             select q.QCode).ToList();

            cmbQualificationCodeU.DisplayMember = "QCode";
            cmbQualificationCodeU.ValueMember = "QCode";
            cmbQualificationCodeU.DataSource = qualcodes;

            //Put the correct Qualification Code in the Combo Box
            int codeCount = 0;
            int theCode = 0;
            foreach (string code in qualcodes)
            {
                if (code == student.QCode)
                {
                    theCode = codeCount;
                }
                codeCount++;
            }
            cmbQualificationCodeU.SelectedIndex = theCode;
            
            // Lookup the selected courses name and put it in the adjacent label
            // on the form
            var qualname = (from n in DB.Qualifications
                                where n.QCode == cmbQualificationCodeU.SelectedItem.ToString()
                                select n.QName).First();
            lblQNameU.Text = qualname;
            
        }




        // This method updates the Student table
        private void btnUpdateU_Click(object sender, EventArgs e)
        {
            
            try
            {
                // Update the student record in the person database
                var personList = (from p in DB.Persons
                                   where p.ID == Convert.ToInt32(cmbStudentIDU.Text)
                                   select p ).First();

                personList.FName = txtFirstNameU.Text;
                personList.LName = txtLastNameU.Text;
                personList.DOB = dtpDateOfBirthU.Value;
                personList.Phone = txtPhoneU.Text;
                personList.Add1 = txtAddress1U.Text;
                personList.Add2 = txtAddress2U.Text;
                personList.Suburb = txtSuburbU.Text;
                personList.State = cmbStateU.SelectedItem.ToString();
                personList.Postcode = txtPostcodeU.Text;

                // Save the changes that were made
                DB.SubmitChanges();

                // Refresh the bound controls
                DB.Refresh(RefreshMode.OverwriteCurrentValues, DB.Persons);

                // Update the student record in the Student database
                var studentList = (from s in DB.Students
                                   where s.SID == Convert.ToInt32(cmbStudentIDU.Text)
                                   select s).First();

                studentList.Sdate = dtpStartDateU.Value;
                studentList.QCode = cmbQualificationCodeU.SelectedItem.ToString();

                // Save the changes that were made
                DB.SubmitChanges();

                // Refresh the bound controls
                DB.Refresh(RefreshMode.OverwriteCurrentValues, DB.Students);

                MessageBox.Show("Student ID " + cmbStudentIDU.Text + " was updated"); 
                UpdateData();
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }




        // This method tests the First Name to make sure that it is not blank
        private bool ValidFirstName (string firstName)
        {
            if(firstName != "")
            {
                return true;
            }
            else
            {
                lblFirstNameMessageA.Text = "Please enter a first name";
                return false;
            }
        }



        // This method tests the Last Name to make sure that it is not blank
        private bool ValidLastName(string lastName)
        {
            if (lastName != "")
            {
                return true;
            }
            else
            {
                lblLastNameMessageA.Text = "Please enter a last name";
                return false;
            }
        }



        // This method tests the Phone to make sure that it is not blank
        private bool ValidPhone(string phone)
        {
            if (phone != "")
            {
                return true;
            }
            else
            {
                lblPhoneMessageA.Text = "Please enter a Phone Number";
                return false;
            }
        }


        // This method tests the Phone to make sure that it is not blank
        private bool ValidAddress1(string address1)
        {
            if (address1 != "")
            {
                return true;
            }
            else
            {
                lblAddress1MessageA.Text = "Please enter an Address";
                return false;
            }
        }

        // This method tests the suburb to make sure that it is not blank
        private bool ValidSuburb(string suburb)
        {
            if (suburb != "")
            {
                return true;
            }
            else
            {
                lblSuburbMessageA.Text = "Please enter a Suburb";
                return false;
            }
        }

        // This method tests the state to make sure that it is not blank
        private bool ValidState(string state)
        {
            if (state != "")
            {
                return true;
            }
            else
            {
                lblStateMessageA.Text = "Please select a State";
                return false;
            }

        }
        // This method tests the postcode to make sure that it is not blank
        private bool ValidPostcode(string postcode)
        {
            if (postcode != "")
            {
                return true;
            }
            else
            {
                lblPostcodeMessageA.Text = "Please enter an Postcode";
                return false;
            }
        }

        // Check that the right postcode is selected for the right state.
        private bool ValidPostcodeForState(string state, string postcode)
        {
            if (state == "NT" & int.Parse(postcode) >= 800 & int.Parse(postcode) <= 899)
            {
                return true;
            }
            else if (state == "NSW" | state == "ACT" & int.Parse(postcode) >= 2000 & int.Parse(postcode) <= 2999)
            {
                return true;
            }
            else if (state == "VIC" & int.Parse(postcode) >= 3000 & int.Parse(postcode) <= 3999)
            {
                return true;
            }
            else if (state == "QLD" & int.Parse(postcode) >= 4000 & int.Parse(postcode) <= 4999)
            {
                return true;
            }
            else if (state == "SA" & int.Parse(postcode) >= 5000 & int.Parse(postcode) <= 5999)
            {
                return true;
            }
            else if (state == "WA" & int.Parse(postcode) >= 6000 & int.Parse(postcode) <= 6999)
            {
                return true;
            }

            else
            {
                switch (state)
                {
                    case "NT":
                        lblPostcodeMessageA.Text = "Postcode must be between 0800 and 0899";
                        break;
                    case "NSW":
                        //lblPostcodeMessageA.Text = "Postcode must be between 2000 and 2999";
                    case "ACT":
                        lblPostcodeMessageA.Text = "Postcode must be between 2000 and 2999";
                        break;
                    case "VIC":
                        lblPostcodeMessageA.Text = "Postcode must be between 3000 and 3999";
                        break;
                    case "QLD":
                        lblPostcodeMessageA.Text = "Postcode must be between 4000 and 4999";
                        break;
                    case "SA":
                        lblPostcodeMessageA.Text = "Postcode must be between 5000 and 5999";
                        break;
                    case "WA":
                        lblPostcodeMessageA.Text = "Postcode must be between 6000 and 6999";
                        break;
                    case "TAS":
                        lblPostcodeMessageA.Text = "Postcode must be between 7000 and 7999";
                        break;
                }
                return false;

                
            }

        }


        // This method adds a Student to the preson and Student tables
        // once the data on the form has been validated.
        private void btnAddA_Click(object sender, EventArgs e)
        {
            try
            {
                // Test that a first name has been entered
                if(!ValidFirstName(txtFirstNameA.Text))
                {
                    return;
                }

                // Test that a last name has been entered
                if (!ValidLastName(txtLastNameA.Text))
                {
                    return;
                }

                // Test that a phone number has been entered
                if (!ValidPhone(txtPhoneA.Text))
                {
                    return;
                }

                // Test that address1 has been entered
                if (!ValidAddress1(txtAddress1A.Text))
                {
                    return;
                }

                // Test that a suburb has been entered
                if (!ValidSuburb(txtSuburbA.Text))
                {
                    return;
                }

                // Test that a state has been entered
                if (!ValidState(cmbStateA.Text))
                {
                    return;
                }

                // Test that a postcode has been entered
                if (!ValidPostcode(txtPostcodeA.Text))
                {
                    return;
                }

                // Test that a correct postcode has been entered
                if (!ValidPostcodeForState(cmbStateA.Text, txtPostcodeA.Text))
                {
                    return;
                }
              

                // Create a new person object for the student and add its properties
                var newPerson = new Person();
                newPerson.FName = txtFirstNameA.Text;
                newPerson.LName = txtLastNameA.Text;
                newPerson.DOB = dtpDateOfBirthA.Value;
                newPerson.Phone = txtPhoneA.Text;
                newPerson.Add1 = txtAddress1A.Text;
                newPerson.Add2 = txtAddress2A.Text;
                newPerson.Suburb = txtSuburbA.Text;
                newPerson.State = cmbStateA.SelectedItem.ToString();
                newPerson.Postcode = txtPostcodeA.Text;
                newPerson.Type = "Student";

                // Add the new person to the database
                DB.Persons.InsertOnSubmit(newPerson);
                DB.SubmitChanges();

                // Get the newly created person ID number for the student ID number
                var newPersonID = newPerson.ID;

                // Create new student object and add its properties
                var newStudent = new Student();
                newStudent.SID = newPersonID;
                newStudent.Sdate = dtpStartDateA.Value;
                newStudent.QCode = cmbQualificationCodeA.SelectedItem.ToString();

                // Add the new student specific data to the database
                DB.Students.InsertOnSubmit(newStudent);
                DB.SubmitChanges();

                MessageBox.Show("Student ID " + newPersonID + " was added");

                UpdateData();    
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }





        private void btnDeleteU_Click(object sender, EventArgs e)
        {
            try
            {
                int idToDelete = (int)cmbStudentIDU.SelectedValue;

                // Get the customer that matches the criteria in the Student ID
                // combo box
                var deletedPerson = (from p in DB.Persons
                                     where p.ID == idToDelete
                                     select p).First();

                var deletedStudent = (from s in DB.Students
                                      where s.SID == idToDelete
                                      select s).First();

                DialogResult d = MessageBox.Show("Are you sure you want to delete this Student?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (d == DialogResult.Yes)
                {
                    DB.Persons.DeleteOnSubmit(deletedPerson);
                    DB.SubmitChanges();
                    DB.Students.DeleteOnSubmit(deletedStudent);
                    DB.SubmitChanges();

                    UpdateData();
                    MessageBox.Show("Student deleted");
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





        // Update the Qualification Name label every time the Combo Box value changes
        private void cmbQualificationCodeA_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lookup the selected courses name and put it in the adjacent label
            // on the form
            var qualname = (from n in DB.Qualifications
                            where n.QCode == cmbQualificationCodeA.SelectedItem.ToString()
                            select n.QName).First();
            lblQNameA.Text = qualname;
        }

        // Update the Qualification Name label every time the Combo Box value changes
        private void cmbQualificationCodeU_SelectedIndexChanged(object sender, EventArgs e)
        {
            var qualname = (from n in DB.Qualifications
                            where n.QCode == cmbQualificationCodeU.SelectedItem.ToString()
                            select n.QName).First();
            lblQNameU.Text = qualname;
        }

             
    }
}
