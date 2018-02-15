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
    // to add, edit and delete student, teacher and administrator records.
    // It reads and writes to the following tables with SQL TO LINQ procedures
    //      Person
    //      Teacher
    //      Student
    //      Administration
    //
    //                 NOTE
    //Even though this form is called StudentsForm, it also includes
    //code to operate the requirements for the Teacher and
    //Administrator forms too. This version was neccessary to
    //reduce the code duplication that resulted from running
    //three very similar forms.


    public partial class StudentsForm : Form
    {
        SchoolDataClassesDataContext DB = new SchoolDataClassesDataContext();

        // This bool is used to switch off a section of code that updates the 
        // Person ID combo box in the updateData method. This item does not need
        // to be refreshed after an update procedure because no course record 
        // has been added or deleted. The benefit of this is that the updated
        // record in the Update Tab can still be displayed after the update
        // process has been completed instead of the first record in the 
        // courses table.
        bool updated = false;

        public StudentsForm()
        {
            InitializeComponent();
        }


        private void StudentsForm_Load(object sender, EventArgs e)
        {
            // Update the form header
            this.Text = MainMenuForm.MenuChoice + " Form";

            // Set up the initial help messages
            lblAddMessage.Text = "Enter the new " + MainMenuForm.MenuChoice + " details and press the Add Button";
            lblUpdateMessage.Text = "Select a " + MainMenuForm.MenuChoice + " ID to edit from the Course ID drop down box";

            UpdateData(updated);  // resets the fields and combo boxes  

            // Setup the form according to what menu option was selected.
            // The fields relating to person will stay the same on the form
            // and extra fields will be added for the required student,
            // teacher or administrator option.

            if (MainMenuForm.MenuChoice == "Student")
            {
                lblQNameA.Enabled = true;
                lblQNameU.Enabled = true;
                lblQualificationCodeA.Enabled = true;
                lblQualificationCodeU.Enabled = true;
                cmbQualificationCodeA.Enabled = true;
                cmbQualificationCodeU.Enabled = true;
                lblStartDateA.Enabled = true;
                lblStartDateU.Enabled = true;
                dtpStartDateA.Enabled = true;
                dtpStartDateU.Enabled = true;
                lblTeacherRegA.Enabled = false;
                lblTeacherRegU.Enabled = false;
                lblTeacherRegMessageA.Enabled = false;
                lblTeacherRegMessageU.Enabled = false;
                txtTeacherRegA.Enabled = false;
                txtTeacherRegU.Enabled = false;
                lblAdminRoleA.Enabled = false;
                lblAdminRoleU.Enabled = false;
                lblAdminRoleMessageA.Enabled = false;
                lblAdminRoleMessageU.Enabled = false;
                txtAdminRoleA.Enabled = false;
                txtAdminRoleU.Enabled = false;

            }
            else if (MainMenuForm.MenuChoice == "Teacher")
            {
                lblQNameA.Enabled = false;
                lblQNameU.Enabled = false;
                lblQualificationCodeA.Enabled = false;
                lblQualificationCodeU.Enabled = false;
                cmbQualificationCodeA.Enabled = false;
                cmbQualificationCodeU.Enabled = false;
                lblStartDateA.Enabled = false;
                lblStartDateU.Enabled = false;
                dtpStartDateA.Enabled = false;
                dtpStartDateU.Enabled = false;
                lblTeacherRegA.Enabled = true;
                lblTeacherRegU.Enabled = true;
                lblTeacherRegMessageA.Enabled = true;
                lblTeacherRegMessageU.Enabled = true;
                txtTeacherRegA.Enabled = true;
                txtTeacherRegU.Enabled = true;
                lblAdminRoleA.Enabled = false;
                lblAdminRoleU.Enabled = false;
                lblAdminRoleMessageA.Enabled = false;
                lblAdminRoleMessageU.Enabled = false;
                txtAdminRoleA.Enabled = false;
                txtAdminRoleU.Enabled = false;
            }
            else if (MainMenuForm.MenuChoice == "Administrator")
            {
                lblQNameA.Enabled = false;
                lblQNameU.Enabled = false;
                lblQualificationCodeA.Enabled = false;
                lblQualificationCodeU.Enabled = false;
                cmbQualificationCodeA.Enabled = false;
                cmbQualificationCodeU.Enabled = false;
                lblStartDateA.Enabled = false;
                lblStartDateU.Enabled = false;
                dtpStartDateA.Enabled = false;
                dtpStartDateU.Enabled = false;
                lblTeacherRegA.Enabled = false;
                lblTeacherRegU.Enabled = false;
                lblTeacherRegMessageA.Enabled = false;
                lblTeacherRegMessageU.Enabled = false;
                txtTeacherRegA.Enabled = false;
                txtTeacherRegU.Enabled = false;
                lblAdminRoleA.Enabled = true;
                lblAdminRoleU.Enabled = true;
                lblAdminRoleMessageA.Enabled = true;
                lblAdminRoleMessageU.Enabled = true;
                txtAdminRoleA.Enabled = true;
                txtAdminRoleU.Enabled = true;
            }
            else
            {
                throw new NotSupportedException();
            }

            // Setup thetooltips for ths form
            toolTip1.SetToolTip(btnAddA, "Add the " + MainMenuForm.MenuChoice + " Record you have entered");
            toolTip1.SetToolTip(btnDeleteU, "Delete the selected record from " + MainMenuForm.MenuChoice + "s");
            toolTip1.SetToolTip(btnExitA, "Return to Main Menu");
            toolTip1.SetToolTip(btnExitU, "Return to Main Menu");
            toolTip1.SetToolTip(btnUpdateU, "Update the " + MainMenuForm.MenuChoice + " Record you have entered");
            toolTip1.SetToolTip(cmbPersonIDU, "Select the "+ MainMenuForm.MenuChoice + " ID to edit/delete from the drop down list");
            toolTip1.SetToolTip(cmbQualificationCodeA, "Select a Qualification Code from the drop down list");
            toolTip1.SetToolTip(cmbQualificationCodeU, "Select a Qualification Code from the drop down list");
            toolTip1.SetToolTip(cmbStateA, "Select a State from the drop down list");
            toolTip1.SetToolTip(cmbStateU, "Select a State from the drop down list");
            toolTip1.SetToolTip(txtAddress1A, "Input the first line of the Address. This is required");
            toolTip1.SetToolTip(txtAddress1U, "Input the first line of the Address. This is required");
            toolTip1.SetToolTip(txtAddress2A, "Input the second line of the Address. This is optional");
            toolTip1.SetToolTip(txtAddress2U, "Input the second line of the Address. This is optional");
            toolTip1.SetToolTip(txtPhoneA, "Input a phone number. Either a mobile number or a land line number with the correct area code for the state. This is required");
            toolTip1.SetToolTip(txtPhoneU, "Input a phone number. Either a mobile number or a land line number with the correct area code for the state. This is required");
            toolTip1.SetToolTip(txtPostcodeA, "Input the Postcode. This is required");
            toolTip1.SetToolTip(txtPostcodeU, "Input the Postcode. This is required");
            toolTip1.SetToolTip(txtSuburbA, "Input the Suburb. This is required");
            toolTip1.SetToolTip(txtSuburbU, "Input the Suburb. This is required");
            toolTip1.SetToolTip(txtTeacherRegA, "Input the Teacher Registration. This is required");
            toolTip1.SetToolTip(txtTeacherRegU, "Input the Teacher Registration. This is required");
            toolTip1.SetToolTip(txtFirstNameA, "Input the First Name. This is required");
            toolTip1.SetToolTip(txtFirstNameU, "Input the First Name. This is required");
            toolTip1.SetToolTip(txtLastNameA, "Input the Last Name. This is required");
            toolTip1.SetToolTip(txtLastNameU, "Input the Last Name. This is required");
            toolTip1.SetToolTip(dtpDateOfBirthA, "Select the Date of Birth");
            toolTip1.SetToolTip(dtpDateOfBirthU, "Select the Date of Birth");
            toolTip1.SetToolTip(dtpStartDateA, "Select the Student's Start Date");
            toolTip1.SetToolTip(dtpStartDateU, "Select the Student's Start Date");
        }      

        // This method performs the required screen updates for all text and combo
        // boxes used by this form. It is called by the btnAddA_Click
        //  and btnUpdateU_Click event
        private void UpdateData(bool fromUpdate)
        {
            if (MainMenuForm.MenuChoice == "Student")
            {
                // Select the Student record from the Person & Student database
                var personList = (from p in DB.Persons
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

                // Update the Person ID combo box data
                // as long as this method wasn't called by the
                // update button event method.
                if (fromUpdate == false)
                {
                    cmbPersonIDU.DisplayMember = "ID";
                    cmbPersonIDU.ValueMember = "ID";
                    cmbPersonIDU.DataSource = personList;
                }
                

                // Update the Qualification Code Combo Box display
                var qualcodes = (from q in DB.Qualifications
                                 select q.QCode).ToList();

                cmbQualificationCodeA.DisplayMember = "QCode";
                cmbQualificationCodeA.ValueMember = "QCode";
                cmbQualificationCodeA.DataSource = qualcodes;

                // Reset the Student start date to todays date
                //  on the Add Tab
                dtpStartDateA.Value = DateTime.Today;                                       
            }
             else if (MainMenuForm.MenuChoice == "Teacher")
            {
               // Select the teacher record from the Person & Teacher database
            var teacherList = (from p in DB.Persons
                               join t in DB.Teachers
                               on p.ID equals t.TID
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
                                   t.RegNo
                               }
                           ).ToList();

            // Update the Student ID combo box data
            // as long as this method wasn't called by the
            // update button event method.
            if (fromUpdate == false)
            {
                cmbPersonIDU.DisplayMember = "ID";
                cmbPersonIDU.ValueMember = "ID";
                cmbPersonIDU.DataSource = teacherList;
            }
            txtTeacherRegA.Clear(); // reset the teacher registration text field on the Add Tab

            }
            else if (MainMenuForm.MenuChoice == "Administrator")
            {
                // Select the Administrator record from the Person & Administrator database
                var adminList = (from p in DB.Persons
                                 join a in DB.Administrations
                                 on p.ID equals a.AID
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
                                     a.Role
                                 }
                               ).ToList();

                // Update the Student ID combo box data
                // as long as this method wasn't called by the
                // update button event method.
                if (fromUpdate == false)
                {
                    cmbPersonIDU.DisplayMember = "ID";
                    cmbPersonIDU.ValueMember = "ID";
                    cmbPersonIDU.DataSource = adminList;
                }
                txtAdminRoleA.Clear(); // reset the Administrator registration text field on the Add Tab
            }
            else
            {
                throw new NotSupportedException();
            }

            // Reset all the Person Fields on the Add Tab
            txtFirstNameA.Clear();
            txtLastNameA.Clear();
            dtpDateOfBirthA.Value = DateTime.Today; // Reset the birthday to todays date
            txtPhoneA.Clear();
            txtAddress1A.Clear();
            txtAddress2A.Clear();
            txtSuburbA.Clear();
            txtPostcodeA.Clear();
                 
        }

        // This method ensures that the correct data is displayed for the student, teacher
        // and administrator when either the update screen is updated or the
        // value in the student id combo box has changed. 
        //  It is called by the cmbStudentIDU_SelectedIndexChanged
        //  and btnUpdateU_Click events
        internal void selectTheRecord()
        {
            string selectedState; // store for the selected state branch statement 

            // Select the Student record from the Person & Student database

            var person = (from p in DB.Persons
                          where p.ID == Convert.ToInt32(cmbPersonIDU.Text)
                          select p).First();

            txtFirstNameU.Text = person.FName;
            txtLastNameU.Text = person.LName;
            dtpDateOfBirthU.Value = person.DOB;
            txtPhoneU.Text = person.Phone;
            txtAddress1U.Text = person.Add1;
            txtAddress2U.Text = person.Add2;
            txtSuburbU.Text = person.Suburb;

            // Put the right State in the State Combo Box
            selectedState = person.State;
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
                default:
                    throw new NotSupportedException();
            }

            txtPostcodeU.Text = person.Postcode;

            if (MainMenuForm.MenuChoice == "Student")
            {
                // Select the required data
                var student = (from s in DB.Students
                               where s.SID == Convert.ToInt32(cmbPersonIDU.Text)
                               select s).First();

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
            else if (MainMenuForm.MenuChoice == "Teacher")
            {
                // Select the required data
                var teacher = (from t in DB.Teachers
                               where t.TID == Convert.ToInt32(cmbPersonIDU.Text)
                               select t.RegNo).First();

                txtTeacherRegU.Text = teacher;
            }
            else if (MainMenuForm.MenuChoice == "Administrator")
            {
                // Select the required data
                var admin = (from a in DB.Administrations
                             where a.AID == Convert.ToInt32(cmbPersonIDU.Text)
                             select a.Role).First();

                txtAdminRoleU.Text = admin;
            }
            else
            {
                throw new NotSupportedException();
            }
        }
        // This method fills in the Update screen data properties based on 
        // the criteria set by the Student ID Combo box selection. The script that
        // performs this has been moved to the selectTheRecord method.
        private void cmbStudentIDU_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectTheRecord();
        }

        // This section contains a series of methods that tests the data entry 
        // fields for both the Add and Update Tabs. Each method tests what is the 
        // current screen is and creates an error message if required. They are 
        // activated by the Add and Update Button events.


        // This method tests the First Name to make sure that it is not blank
        private bool ValidFirstName (string firstName, string tab)
        {
            if(firstName != "")
            {
                if (tab == "Add")
                {
                    lblFirstNameMessageA.Text = "";
                }
                else if (tab == "Update")
                {
                    lblFirstNameMessageU.Text = "";
                }
                return true;
            }
            else
            {
                if (tab == "Add")
                {
                    lblFirstNameMessageA.Text = "Please enter a first name";
                }
                else if(tab == "Update")
                {
                    lblFirstNameMessageU.Text = "Please enter a first name";
                }
                return false;
            }
        }

        // This method tests the Last Name to make sure that it is not blank
        private bool ValidLastName(string lastName, string tab)
        {
            if (lastName != "")
            {
                if (tab == "Add")
                {
                    lblLastNameMessageA.Text = "";
                }
                else if (tab == "Update")
                {
                    lblLastNameMessageU.Text = "";
                }
                return true;
            }
            else
            {
                if (tab == "Add")
                {
                    lblLastNameMessageA.Text = "Please enter a last name";
                }
                else if (tab == "Update")
                {
                    lblLastNameMessageU.Text = "Please enter a last name";
                }
                return false;
            }
        }

        // This method tests the birth date to make sure it is not the current
        // date - ie, it hasn't been overlooked
        private bool BirthNotToday(DateTime dob, string tab)
        {
            if (dob != DateTime.Today)
            {
                if (tab == "Add")
                {
                    lblDOBMessageA.Text = "";
                }
                else if (tab == "Update")
                {
                    lblDOBMessageU.Text = "";
                }
                return true;
            }
            else
            {
                if (tab == "Add")
                {
                    lblDOBMessageA.Text = "Please enter the correct birth date";
                }
                else if (tab == "Update")
                {
                    lblDOBMessageU.Text = "Please enter the correct birth date";
                }
                return false;
            }
        }

        // This method tests the Phone to make sure that it is not blank
        private bool ValidPhone(string phone, string tab)
        {
            if (phone != "")
            {
                if (tab == "Add")
                {
                    lblPhoneMessageA.Text = "";
                }
                else if (tab == "Update")
                {
                    lblPhoneMessageU.Text = "";
                }
                return true;
            }
            else
            {
                if (tab == "Add")
                {
                    lblPhoneMessageA.Text = "Please enter a phone number";
                }
                else if (tab == "Update")
                {
                    lblPhoneMessageU.Text = "Please enter a phone number";
                }
                return false;
            }
        }

        // This method tests the phone number to make sure that it is a numeric
        private bool ValidPhoneNumber(string phoneNumber, string tab)
        {
           
            if (tab == "Add")
            {
                int n1;
                bool isNumber = int.TryParse(txtPhoneA.Text, out n1);
                if (isNumber == true)
                {
                    lblPhoneMessageA.Text = "";
                    return true;
                }
                else
                {
                    lblPhoneMessageA.Text = "Please enter just numbers for phone number";
                    return false;
                }
            }

            else //if (tab == "Update")
            {
                int n1;
                bool isNumber = int.TryParse(txtPhoneU.Text, out n1);
                if (isNumber == true)
                {
                    lblPhoneMessageU.Text = "";
                    return true;
                }
                else
                {
                    lblPhoneMessageU.Text = "Please enter just numbers for phone number";
                    return false;
                }

            }
        }



        // This method tests the phone number entry to check that it is only 10 characters long
        private bool ValidPhoneNumberLength(string phone, string tab)
        {
            if (phone.Length == 10)
            {
                if (tab == "Add")
                {
                    lblPhoneMessageA.Text = "";
                }
                else if (tab == "Update")
                {
                    lblPhoneMessageU.Text = "";
                }
                return true;
            }
            else
            {
                if (tab == "Add")
                {
                    lblPhoneMessageA.Text = "Please enter just 10 digits for phone number";
                }
                else if (tab == "Update")
                {
                    lblPhoneMessageU.Text = "Please enter just 10 digits phone number";
                }
                return false;
            }
        }

        // Check that the right telephone area code is selected for the right state.
        private bool ValidPhoneForState(string state, string phone, string tab)
        {
            if ((state == "NSW" | state == "ACT") & int.Parse(phone.Substring(0, 2)) == 02)
            {
                if (tab == "Add")
                {
                    lblPhoneMessageA.Text = "";
                }
                else if (tab == "Update")
                {
                    lblPhoneMessageU.Text = "";
                }
                return true;
            }
            else if (state == "VIC" & int.Parse(phone.Substring(0, 2)) == 03)
            {
                if (tab == "Add")
                {
                    lblPhoneMessageA.Text = "";
                }
                else if (tab == "Update")
                {
                    lblPhoneMessageU.Text = "";
                }
                return true;
            }
            else if (state == "QLD" & int.Parse(phone.Substring(0, 2)) == 07)
            {
                if (tab == "Add")
                {
                    lblPhoneMessageA.Text = "";
                }
                else if (tab == "Update")
                {
                    lblPhoneMessageU.Text = "";
                }
                return true;
            }
            else if (state == "SA" & int.Parse(phone.Substring(0, 2)) == 08)
            {
                if (tab == "Add")
                {
                    lblPhoneMessageA.Text = "";
                }
                else if (tab == "Update")
                {
                    lblPhoneMessageU.Text = "";
                }
                return true;
            }
            else if (state == "WA" & int.Parse(phone.Substring(0, 2)) == 08)
            {
                if (tab == "Add")
                {
                    lblPhoneMessageA.Text = "";
                }
                else if (tab == "Update")
                {
                    lblPhoneMessageU.Text = "";
                }
                return true;
            }
            else if (state == "NT" & int.Parse(phone.Substring(0, 2)) == 08)
            {
                if (tab == "Add")
                {
                    lblPhoneMessageA.Text = "";
                }
                else if (tab == "Update")
                {
                    lblPhoneMessageU.Text = "";
                }
                return true;
            }
            else if (int.Parse(phone.Substring(0, 2)) == 04) // Mobile Phone
            {
                if (tab == "Add")
                {
                    lblPhoneMessageA.Text = "";
                }
                else if (tab == "Update")
                {
                    lblPhoneMessageU.Text = "";
                }
                return true;
            }

            else
            {
                switch (state)
                {
                    case "NSW":
                    case "ACT":
                        if (tab == "Add")
                        {
                            lblPhoneMessageA.Text = "Please change the Area Code to 02";
                        }
                        else if (tab == "Update")
                        {
                            lblPhoneMessageU.Text = "Please change the Area Code to 02";
                        }
                        break;
                    case "VIC":
                    case "TAS":
                        if (tab == "Add")
                        {
                            lblPhoneMessageA.Text = "Please change the Area Code to 03";
                        }
                        else if (tab == "Update")
                        {
                            lblPhoneMessageU.Text = "Please change the Area Code to 03";
                        };
                        break;
                    case "QLD":
                        if (tab == "Add")
                        {
                            lblPhoneMessageA.Text = "Please change the Area Code to 07";
                        }
                        else if (tab == "Update")
                        {
                            lblPhoneMessageU.Text = "Please change the Area Code to 07";
                        }
                        break;
                    case "NT":
                    case "SA":
                    case "WA":
                        if (tab == "Add")
                        {
                            lblPhoneMessageA.Text = "Please change the Area Code to 08";
                        }
                        else if (tab == "Update")
                        {
                            lblPhoneMessageU.Text = "Please change the Area Code to 08";
                        };
                        break;
                    case "":
                        if (tab == "Add")
                        {
                            lblPhoneMessageA.Text = "Please select a State to verify the area code";
                        }
                        else if (tab == "Update")
                        {
                            lblPhoneMessageU.Text = "Please select a State to verify the area code";
                        }
                        break;
                    default:
                        throw new NotSupportedException();
                }
                return false;
            }
        }


        // This method tests the address1 to make sure that it is not blank
        private bool ValidAddress1(string address1, string tab)
        {
            if (address1 != "")
            {
                if (tab == "Add")
                {
                    lblAddress1MessageA.Text = "";
                }
                else if (tab == "Update")
                {
                    lblAddress1MessageU.Text = "";
                }
                return true;
            }
            else
            {
                if (tab == "Add")
                {
                    lblAddress1MessageA.Text = "Please enter an address";
                }
                else if (tab == "Update")
                {
                    lblAddress1MessageU.Text = "Please enter an address";
                }
                return false;
            }
        }

        // This method tests the suburb to make sure that it is not blank
        private bool ValidSuburb(string suburb, string tab)
        {
            if (suburb != "")
            {
                if (tab == "Add")
                {
                    lblSuburbMessageA.Text = "";
                }
                else if (tab == "Update")
                {
                    lblSuburbMessageU.Text = "";
                }
                return true;
            }
            else
            {
                if (tab == "Add")
                {
                    lblSuburbMessageA.Text = "Please enter an suburb";
                }
                else if (tab == "Update")
                {
                    lblSuburbMessageU.Text = "Please enter an suburb";
                }
                return false;
            }
        }

        // This method tests the state to make sure that it is not blank
        private bool ValidState(string state, string tab)
        {
            if (state != "")
            {
                if (tab == "Add")
                {
                    lblStateMessageA.Text = "";
                }
                else if (tab == "Update")
                {
                    lblStateMessageU.Text = "";
                }
                return true;
            }
            else
            {
                if (tab == "Add")
                {
                    lblStateMessageA.Text = "Please select a state";
                }
                else if (tab == "Update")
                {
                    lblStateMessageU.Text = "Please select a state";
                }
                return false;
            }

        }
        // This method tests the postcode to make sure that it is not blank
        private bool ValidPostcode(string postcode, string tab)
        {
            if (postcode != "")
            {
                if (tab == "Add")
                {
                    lblPostcodeMessageA.Text = "";
                }
                else if (tab == "Update")
                {
                    lblPostcodeMessageU.Text = "";
                }
                return true;
            }
            else
            {
                if (tab == "Add")
                {
                    lblPostcodeMessageA.Text = "Please enter a postcode";
                }
                else if (tab == "Update")
                {
                    lblPostcodeMessageU.Text = "Please enter a postcode";
                }
                return false;
            }
        }

        // This method tests the postcode to make sure that it is a numeric
        private bool ValidPostcodeNumber(string postcode, string tab)
        {
            if (tab == "Add")
            {
                int n1;
                bool isNumber = int.TryParse(txtPostcodeA.Text, out n1);

                if (isNumber == true)
                {
                    lblPostcodeMessageA.Text = "";
                    return true;
                }
                else
                {
                    lblPostcodeMessageA.Text = "Please enter a numeric value for postcode";
                    return false;
                }
            }
            else // tab = Update
            {
                int n1;
                bool isNumber = int.TryParse(txtPostcodeU.Text, out n1);

                if (isNumber == true)
                {
                    lblPostcodeMessageU.Text = "";
                    return true;
                }
                else
                {
                    lblPostcodeMessageU.Text = "Please enter a numeric value for postcode";
                    return false;
                }
            }
            
        }

        // Check that the right postcode is selected for the right state.
        private bool ValidPostcodeForState(string state, string postcode, string tab)
        {
            if (state == "NT" & int.Parse(postcode) >= 800 & int.Parse(postcode) <= 899)
            {
                if (tab == "Add")
                {
                    lblPostcodeMessageA.Text = "";
                }
                else if (tab == "Update")
                {
                    lblPostcodeMessageU.Text = "";
                }
                return true;
            }
            else if ((state == "NSW" | state == "ACT") & int.Parse(postcode) >= 2000 & int.Parse(postcode) <= 2999)
            {
                if (tab == "Add")
                {
                    lblPostcodeMessageA.Text = "";
                }
                else if (tab == "Update")
                {
                    lblPostcodeMessageU.Text = "";
                }
                return true;
            }
            else if (state == "VIC" & int.Parse(postcode) >= 3000 & int.Parse(postcode) <= 3999)
            {
                if (tab == "Add")
                {
                    lblPostcodeMessageA.Text = "";
                }
                else if (tab == "Update")
                {
                    lblPostcodeMessageU.Text = "";
                }
                return true;
            }
            else if (state == "QLD" & int.Parse(postcode) >= 4000 & int.Parse(postcode) <= 4999)
            {
                if (tab == "Add")
                {
                    lblPostcodeMessageA.Text = "";
                }
                else if (tab == "Update")
                {
                    lblPostcodeMessageU.Text = "";
                }
                return true;
            }
            else if (state == "SA" & int.Parse(postcode) >= 5000 & int.Parse(postcode) <= 5999)
            {
                if (tab == "Add")
                {
                    lblPostcodeMessageA.Text = "";
                }
                else if (tab == "Update")
                {
                    lblPostcodeMessageU.Text = "";
                }
                return true;
            }
            else if (state == "WA" & int.Parse(postcode) >= 6000 & int.Parse(postcode) <= 6999)
            {
                if (tab == "Add")
                {
                    lblPostcodeMessageA.Text = "";
                }
                else if (tab == "Update")
                {
                    lblPostcodeMessageU.Text = "";
                }
                return true;
            }

            else
            {
                switch (state)
                {
                    case "NT":
                        if (tab == "Add")
                        {
                            lblPostcodeMessageA.Text = "Postcode must be between 0800 and 0899";
                        }
                        else if (tab == "Update")
                        {
                            lblPostcodeMessageU.Text = "Postcode must be between 0800 and 0899";
                        }
                        break;
                    case "NSW":
                    case "ACT":
                        if (tab == "Add")
                        {
                            lblPostcodeMessageA.Text = "Postcode must be between 2000 and 2999";
                        }
                        else if (tab == "Update")
                        {
                            lblPostcodeMessageU.Text = "Postcode must be between 2000 and 2999";
                        }
                        break;
                    case "VIC":
                        if (tab == "Add")
                        {
                            lblPostcodeMessageA.Text = "Postcode must be between 3000 and 3999";
                        }
                        else if (tab == "Update")
                        {
                            lblPostcodeMessageU.Text = "Postcode must be between 3000 and 3999";
                        }
                        break;
                    case "QLD":
                        if (tab == "Add")
                        {
                            lblPostcodeMessageA.Text = "Postcode must be between 4000 and 4999";
                        }
                        else if (tab == "Update")
                        {
                            lblPostcodeMessageU.Text = "Postcode must be between 4000 and 4999";
                        }
                        break;
                    case "SA":
                        if (tab == "Add")
                        {
                            lblPostcodeMessageA.Text = "Postcode must be between 5000 and 5999";
                        }
                        else if (tab == "Update")
                        {
                            lblPostcodeMessageU.Text = "Postcode must be between 5000 and 5999";
                        }
                        break;
                    case "WA":
                        if (tab == "Add")
                        {
                            lblPostcodeMessageA.Text = "Postcode must be between 6000 and 6999";
                        }
                        else if (tab == "Update")
                        {
                            lblPostcodeMessageU.Text = "Postcode must be between 6000 and 6999";
                        }
                        break;
                    case "TAS":
                        if (tab == "Add")
                        {
                            lblPostcodeMessageA.Text = "Postcode must be between 7000 and 7999";
                        }
                        else if (tab == "Update")
                        {
                            lblPostcodeMessageU.Text = "Postcode must be between 7000 and 7999";
                        }
                        break;
                    case "": // make sure that there is something entered for state
                        if (tab == "Add")
                        {
                            lblPostcodeMessageA.Text = "Please select a State to verify the postcode";
                        }
                        else if (tab == "Update")
                        {
                            lblPostcodeMessageU.Text = "Please select a State to verify the postcode";
                        }
                        break;
                    default:
                        throw new NotSupportedException();
                }
                return false; 
            }
        }

        // Check that data has been entered for the teachers registration
        private bool validateRegistration(string registrationNo, string tab)
        {
            if (registrationNo != "")
            {
                if (tab == "Add")
                {
                    lblTeacherRegMessageA.Text = "";
                }
                else if (tab == "Update")
                {
                    lblTeacherRegMessageU.Text = "";
                }
                return true;
            }
            else
            {
                if (tab == "Add")
                {
                    lblTeacherRegMessageA.Text = "Please enter a registration number";
                }
                else if (tab == "Update")
                {
                    lblTeacherRegMessageU.Text = "Please enter a registration number";
                }
                return false;
            }
        }
            // Check that data has been entered for the administrator role
        private bool validateRole(string roleName, string tab)
        {
            if (roleName != "")
            {
                if (tab == "Add")
                {
                    lblAdminRoleMessageA .Text = "";
                }
                else if (tab == "Update")
                {
                    lblAdminRoleMessageU.Text = "";
                }
                return true;
            }
            else
            {
                if (tab == "Add")
                {
                    lblAdminRoleMessageA.Text = "Please enter an admin role";
                }
                else if (tab == "Update")
                {
                    lblAdminRoleMessageU.Text = "Please enter an admin role";
                }
                return false;
            }
        }

        // This method adds a Person to the Person and 
        // Student/Teacher/Administrator tables
        // once the data on the form has been validated.
        private void btnAddA_Click(object sender, EventArgs e)
        {
            try
            {
                // Indicate that this is the Add Tab for Error Message control
                string theTab = "Add";

                // This section of code applies to the data entry fields
                // for the Person table

                // Test that a first name has been entered
                if(!ValidFirstName(txtFirstNameA.Text, theTab))
                {
                    return;
                }

                // Test that a last name has been entered
                if (!ValidLastName(txtLastNameA.Text, theTab))
                {
                    return;
                }

                // Test that a proper birth date has been entered
                if (!BirthNotToday(dtpDateOfBirthA.Value, theTab))
                {
                    return;
                }

                // Test that a phone number has been entered
                if (!ValidPhone(txtPhoneA.Text, theTab))
                {
                    return;
                }

                // Test that the phone number is numeric
                if (!ValidPhoneNumber(txtPhoneA.Text, theTab))
                {
                    return;
                }

                // Test that the phone number has only 10 digits
                if (!ValidPhoneNumberLength(txtPhoneA.Text, theTab))
                {
                    return;
                }

                // Test that the correct area code for phone number has been entered
                if (!ValidPhoneForState(cmbStateA.Text, txtPhoneA.Text, theTab))
                {
                    return;
                }

                // Test that address1 has been entered
                if (!ValidAddress1(txtAddress1A.Text, theTab))
                {
                    return;
                }

                // Test that a suburb has been entered
                if (!ValidSuburb(txtSuburbA.Text, theTab))
                {
                    return;
                }

                // Test that a state has been entered
                if (!ValidState(cmbStateA.Text, theTab))
                {
                    return;
                }

                // Test that a postcode has been entered
                if (!ValidPostcode(txtPostcodeA.Text, theTab))
                {
                    return;
                }

                // Test that the postcode is a numeric
                if (!ValidPostcodeNumber(txtPostcodeA.Text, theTab))
                {
                    return;
                }

                // Test that a correct postcode has been entered
                if (!ValidPostcodeForState(cmbStateA.Text, txtPostcodeA.Text, theTab))
                {
                    return;
                }

                // Test that a Teacher Registration has been entered
                if (MainMenuForm.MenuChoice == "Teacher")
                {
                    if (!validateRegistration(txtTeacherRegA.Text, theTab))
                    {
                        return;
                    }
                }

                // Test that an admin role has been entered
                if (MainMenuForm.MenuChoice == "Administrator")
                {
                    if (!validateRole(txtAdminRoleA.Text, theTab))
                    {
                        return;
                    }
                }
                // Create a new person object for the student and add its properties
                var newPerson = new Person();
                newPerson.FName = txtFirstNameA.Text.Trim();
                newPerson.LName = txtLastNameA.Text.Trim();
                newPerson.DOB = dtpDateOfBirthA.Value;
                newPerson.Phone = txtPhoneA.Text;
                newPerson.Add1 = txtAddress1A.Text.Trim();
                newPerson.Add2 = txtAddress2A.Text.Trim();
                newPerson.Suburb = txtSuburbA.Text.Trim();
                newPerson.State = cmbStateA.SelectedItem.ToString();
                newPerson.Postcode = txtPostcodeA.Text.Trim();
                newPerson.Type = MainMenuForm.MenuChoice; // either Student, Teacher or Administrator

                // Add the new person to the database
                DB.Persons.InsertOnSubmit(newPerson);
                DB.SubmitChanges();

                // Get the newly created person ID number
                var newPersonID = newPerson.ID;

                
                if (MainMenuForm.MenuChoice == "Student")
                {
                    // Create new student object and add its properties
                    var newStudent = new Student();
                    newStudent.SID = newPersonID;
                    newStudent.Sdate = dtpStartDateA.Value;
                    newStudent.QCode = cmbQualificationCodeA.SelectedItem.ToString();

                    // Add the new student specific data to the database
                    DB.Students.InsertOnSubmit(newStudent);
                    DB.SubmitChanges();

                    // Setup the required courses for the Student_Course Table
                    try
                    {
                        var courseNumbers = (from c in DB.Qualification_Courses
                                             where c.QCode == cmbQualificationCodeA.SelectedItem.ToString()
                                             select c.CID).ToList();

                        int index = 0;
                        foreach (int c in courseNumbers)
                        {
                            var newStudentCourse = new Student_Course();
                            newStudentCourse.CID = courseNumbers[index];
                            newStudentCourse.SID = newPersonID;
                            newStudentCourse.Mark = 0;
                            DB.Student_Courses.InsertOnSubmit(newStudentCourse);
                            DB.SubmitChanges();
                            index++;

                        }
                    }

                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                else if (MainMenuForm.MenuChoice == "Teacher")
                {
                    // Create new teacher object and add its properties
                    var newTeacher = new Teacher();
                    newTeacher.TID = newPersonID;
                    newTeacher.RegNo = txtTeacherRegA.Text.Trim();
                    newTeacher.Password = "teacher"; // A new Default password

                    // Add the new teacher specific data to the database
                    DB.Teachers.InsertOnSubmit(newTeacher);
                    DB.SubmitChanges();

                    lblAddMessage.Text = "Teacher ID " + newPersonID + " was added with a temporary password 'teacher'. \r\nPlease get " + txtFirstNameA.Text + " to change this password as soon as possible";
                }
                else if (MainMenuForm.MenuChoice == "Administrator")
                {
                    // Create new administrator object and add its properties
                     var newAdministration = new Administration();
                    newAdministration.AID = newPersonID;
                    newAdministration.Role = txtAdminRoleA.Text.Trim();
                    newAdministration.Password = "adminis"; // A new default password

                    // Add the new student specific data to the database
                    DB.Administrations.InsertOnSubmit(newAdministration);
                    DB.SubmitChanges();

                    lblUpdateMessage.Text = "Administrator ID " + newPersonID + " was added with a temporary password 'adminis'. \r\nPlease get " + txtFirstNameA.Text + " to change this password as soon as possible";
                }
                else
                {
                    throw new NotSupportedException();
                }

                lblUpdateMessage.Text = "ID " + newPersonID + " was added";

                UpdateData(updated);    
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        // This method updates the Person and Student/Teacher/Administration
        // table once the data has been validated.
        private void btnUpdateU_Click(object sender, EventArgs e)
        {
            // Indicate that this is the Update Tab for Error Message control
            string theTab = "Update";
            try
            {
                // Test that a first name has been entered
                if (!ValidFirstName(txtFirstNameU.Text, theTab))
                {
                    return;
                }

                // Test that a last name has been entered
                if (!ValidLastName(txtLastNameU.Text, theTab))
                {
                    return;
                }

                // Test that a proper birth date has been entered
                if (!BirthNotToday(dtpDateOfBirthU.Value, theTab))
                {
                    return;
                }

                // Test that a phone number has been entered
                if (!ValidPhone(txtPhoneU.Text, theTab))
                {
                    return;
                }

                // Test that the phone number is numeric
                if (!ValidPhoneNumber(txtPhoneU.Text, theTab))
                {
                    return;
                }

                // Test that the phone number has only 10 digits
                if (!ValidPhoneNumberLength(txtPhoneU.Text, theTab))
                {
                    return;
                }

                // Test that the correct area code for phone number has been entered
                if (!ValidPhoneForState(cmbStateU.Text, txtPhoneU.Text, theTab))
                {
                    return;
                }

                // Test that address1 has been entered
                if (!ValidAddress1(txtAddress1U.Text, theTab))
                {
                    return;
                }

                // Test that a suburb has been entered
                if (!ValidSuburb(txtSuburbU.Text, theTab))
                {
                    return;
                }

                // Test that a state has been entered
                if (!ValidState(cmbStateU.Text, theTab))
                {
                    return;
                }

                // Test that a postcode has been entered
                if (!ValidPostcode(txtPostcodeU.Text, theTab))
                {
                    return;
                }

                // Test that the postcode is a numeric
                if (!ValidPostcodeNumber(txtPostcodeU.Text, theTab))
                {
                    return;
                }

                // Test that a correct postcode has been entered
                if (!ValidPostcodeForState(cmbStateU.Text, txtPostcodeU.Text, theTab))
                {
                    return;
                }

                // Test that a Teacher Registration has been entered
                if (MainMenuForm.MenuChoice == "Teacher")
                {
                    if (!validateRegistration(txtTeacherRegU.Text, theTab))
                    {
                        return;
                    }
                }

                // Test that an admin role has been entered
                if (MainMenuForm.MenuChoice == "Administrator")
                {
                    if (!validateRole(txtAdminRoleU.Text, theTab))
                    {
                        return;
                    }
                }

                // Update the student record in the person database
                var personList = (from p in DB.Persons
                                  where p.ID == Convert.ToInt32(cmbPersonIDU.Text)
                                  select p).First();

                personList.FName = txtFirstNameU.Text.Trim();
                personList.LName = txtLastNameU.Text.Trim();
                personList.DOB = dtpDateOfBirthU.Value;
                personList.Phone = txtPhoneU.Text.Trim();
                personList.Add1 = txtAddress1U.Text.Trim();
                personList.Add2 = txtAddress2U.Text.Trim();
                personList.Suburb = txtSuburbU.Text.Trim();
                personList.State = cmbStateU.SelectedItem.ToString();
                personList.Postcode = txtPostcodeU.Text.Trim();

                // Save the changes that were made
                DB.SubmitChanges();

                // Refresh the bound controls
                DB.Refresh(RefreshMode.OverwriteCurrentValues, DB.Persons);

                if (MainMenuForm.MenuChoice == "Student")
                {
                    // Update the student record in the Student database
                    var studentList = (from s in DB.Students
                                       where s.SID == Convert.ToInt32(cmbPersonIDU.Text)
                                       select s).First();

                    studentList.Sdate = dtpStartDateU.Value;
                    studentList.QCode = cmbQualificationCodeU.SelectedItem.ToString();

                    // Save the changes that were made
                    DB.SubmitChanges();

                    // Refresh the bound controls
                    DB.Refresh(RefreshMode.OverwriteCurrentValues, DB.Students);
                }
                else if (MainMenuForm.MenuChoice == "Teacher")
                {
                    //  Update the teacher object and add its properties
                    var teacherList = (from t in DB.Teachers
                                       where t.TID == Convert.ToInt32(cmbPersonIDU.Text)
                                       select t).First();

                    teacherList.RegNo = txtTeacherRegU.Text.Trim();

                    // Save the changes that were made
                    DB.SubmitChanges();

                    // Refresh the bound controls
                    DB.Refresh(RefreshMode.OverwriteCurrentValues, DB.Teachers);
                }
                else if (MainMenuForm.MenuChoice == "Administrator")
                {
                    // Update the administrator object and add its properties
                    var adminList = (from a in DB.Administrations
                                   where a.AID == Convert.ToInt32(cmbPersonIDU.Text)
                                   select a).First();

                    adminList.Role = txtAdminRoleU.Text.Trim();

                    // Save the changes that were made
                    DB.SubmitChanges();

                    // Refresh the bound controls
                    DB.Refresh(RefreshMode.OverwriteCurrentValues, DB.Administrations);
                }
                else
                {
                    throw new NotSupportedException();
                }

                lblUpdateMessage.Text = "ID " + cmbPersonIDU.Text + " was updated";

                updated = true; // Do not reset the Person ID combo box
                UpdateData(updated);
                selectTheRecord();
                updated = false;
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        // This method deletes the selected Person id in the update table's
        // id combo box. 
        private void btnDeleteU_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult d = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (d == DialogResult.Yes)
                {
                    int idToDelete = (int)cmbPersonIDU.SelectedValue;

                    // Get the record that matches the criteria in the ID
                    // combo box
                    var deletedPerson = (from p in DB.Persons
                                         where p.ID == idToDelete
                                         select p).First();

                    DB.Persons.DeleteOnSubmit(deletedPerson);

                    if (MainMenuForm.MenuChoice == "Student")
                    {
                        var deletedStudent = (from s in DB.Students
                                              where s.SID == idToDelete
                                              select s).First();

                        DB.Students.DeleteOnSubmit(deletedStudent);
                        MessageBox.Show("Student deleted");
                    }
                    else if (MainMenuForm.MenuChoice == "Teacher")
                    {
                        
                        var deletedTeacher = (from t in DB.Teachers
                                              where t.TID == idToDelete
                                              select t).First();

                        DB.Teachers.DeleteOnSubmit(deletedTeacher);

                        MessageBox.Show("Teacher deleted");
                    }
                    else if (MainMenuForm.MenuChoice == "Administrator")
                    {
                        // Delete the administrator record
                        var deletedAdministration = (from t in DB.Administrations
                                      where t.AID == idToDelete
                                      select t).First();

                        DB.Administrations.DeleteOnSubmit(deletedAdministration);
                    }
                    else
                    {
                        throw new NotSupportedException();
                    }
                    
                    DB.SubmitChanges();
                    
                    UpdateData(updated);
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
            // Lookup the selected Qualification name and put it in the adjacent label
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
