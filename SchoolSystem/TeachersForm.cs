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
    public partial class TeachersForm : Form
    {
        SchoolDataClassesDataContext DB = new SchoolDataClassesDataContext();
        public TeachersForm()
        {
            InitializeComponent();
        }





        private void TeachersForm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }





        //This method performs the required updates for all tables and combo
        //boxes used by this form.
        private void UpdateData()
        {
            // Select the teacher record from the Person & Student database
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
            cmbTeacherIDU.DisplayMember = "ID";
            cmbTeacherIDU.ValueMember = "ID";
            cmbTeacherIDU.DataSource = teacherList;
        }





        // Exit the Add Teacher Screen
        private void btnExitA_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }





        // Exit the Update Teacher screen
        private void btnExitU_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }





        // This method fills in the Update screen data properties based on 
        // the criteria set by the Teacher ID Combo box selection
        private void cmbTeacherIDU_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState; // store for the selected state branch statement

            // Select the Teacher record from the person and teacher databases
            var teacher = (from p in DB.Persons
                           join t in DB.Teachers
                           on p.ID equals t.TID
                           where p.ID == Convert.ToInt32(cmbTeacherIDU.Text)
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
                               t.RegNo
                           }
                           ).First();
            txtFirstNameU.Text = teacher.FName;
            txtLastNameU.Text = teacher.LName;
            dtpDateOfBirthU.Value = teacher.DOB;
            txtPhoneU.Text = teacher.Phone;
            txtAddress1U.Text = teacher.Add1;
            txtAddress2U.Text = teacher.Add2;
            txtSuburbU.Text = teacher.Suburb;

            // Put the right State in the State Combo Box
            selectedState = teacher.State;
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
                case "CST":
                    cmbStateU.SelectedIndex = 5;
                    break;
                case "NT":
                    cmbStateU.SelectedIndex = 6;
                    break;
                case "TAS":
                    cmbStateU.SelectedIndex = 7;
                    break;
            }

            txtPostcodeU.Text = teacher.Postcode;
            txtTeacherRegU.Text = teacher.RegNo;
        }




        // This method updates the Teacher table
        private void btnUpdateU_Click(object sender, EventArgs e)
        {
            try
            {
                // Update the student record in the person database
                var personList = (from p in DB.Persons
                                  where p.ID == Convert.ToInt32(cmbTeacherIDU.Text)
                                  select p).First();

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

                var teacherList = (from t in DB.Teachers
                                   where t.TID == Convert.ToInt32(cmbTeacherIDU.Text)
                                   select t).First();

                teacherList.RegNo = txtTeacherRegU.Text;

                // Save the changes that were made
                DB.SubmitChanges();

                // Refresh the bound controls
                DB.Refresh(RefreshMode.OverwriteCurrentValues, DB.Teachers);

                MessageBox.Show("Teacher ID " + cmbTeacherIDU.Text + " was updated");
                UpdateData();
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }





        private void btnAddA_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new person object for the teacher and add its properties
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
                newPerson.Type = "Teacher";

                // Add the new person to the database
                DB.Persons.InsertOnSubmit(newPerson);
                DB.SubmitChanges();

                // Get the newly created person ID number for the student ID number
                var newPersonID = newPerson.ID;

                // Create new teacher object and add its properties
                var newTeacher = new Teacher();
                newTeacher.TID = newPersonID;
                newTeacher.RegNo = txtTeacherRegA.Text;
                newTeacher.Password = "teacher";

                // Add the new teacher specific data to the database
                DB.Teachers.InsertOnSubmit(newTeacher);
                DB.SubmitChanges();

                MessageBox.Show("Teacher ID " + newPersonID + " was added with a temporary password 'teacher'. Please get " + txtFirstNameA.Text + " to change this password as soon as possible");

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
                int idToDelete = (int)cmbTeacherIDU.SelectedValue;

                // Get the person that matches the criteria in the Teacher ID
                // combo box
                var deletedPerson = (from p in DB.Persons
                                     where p.ID == idToDelete
                                     select p).First();

                var deletedTeacher = (from t in DB.Teachers
                                      where t.TID == idToDelete
                                      select t).First();

                DialogResult d = MessageBox.Show("Are you sure you want to delete this Teacher?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (d == DialogResult.Yes)
                {
                    DB.Persons.DeleteOnSubmit(deletedPerson);
                    DB.SubmitChanges();
                    DB.Teachers.DeleteOnSubmit(deletedTeacher);
                    DB.SubmitChanges();

                    UpdateData();
                    MessageBox.Show("Teacher deleted");
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
    }
}
