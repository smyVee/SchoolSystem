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
    public partial class AdministratorsForm : Form
    {
        SchoolDataClassesDataContext DB = new SchoolDataClassesDataContext();
        public AdministratorsForm()
        {
            InitializeComponent();
        }





        // This method exits from the Update screen
        private void btnExitU_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }





        // This method exits from the Add screen
        private void btnExitA_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }





        private void AdministratorsForm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }





        //This method performs the required updates for all tables and combo
        //boxes used by this form.
        private void UpdateData()
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
            cmbAdminIDU.DisplayMember = "ID";
            cmbAdminIDU.ValueMember = "ID";
            cmbAdminIDU.DataSource = adminList;
        }





        // This method fills in the Update screen data properties based on 
        // the criteria set by the Admin ID Combo box selection
        private void cmbAdminIDU_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState; // store for the selected state branch statement

            // Select the Teacher record from the person and teacher databases
            var admin = (from p in DB.Persons
                           join a in DB.Administrations
                           on p.ID equals a.AID
                           where p.ID == Convert.ToInt32(cmbAdminIDU.Text)
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
                               a.Role
                           }
                           ).First();
            txtFirstNameU.Text = admin.FName;
            txtLastNameU.Text = admin.LName;
            dtpDateOfBirthU.Value = admin.DOB;
            txtPhoneU.Text = admin.Phone;
            txtAddress1U.Text = admin.Add1;
            txtAddress2U.Text = admin.Add2;
            txtSuburbU.Text = admin.Suburb;

            // Put the right State in the State Combo Box
            selectedState = admin.State;
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

            txtPostcodeU.Text = admin.Postcode;
            txtAdminRoleU.Text = admin.Role;
        }




        // This method updates the Administrator table
        private void btnUpdateU_Click(object sender, EventArgs e)
        {
            try
            {
                // Update the student record in the person database
                var personList = (from p in DB.Persons
                                  where p.ID == Convert.ToInt32(cmbAdminIDU.Text)
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

                var adminList = (from a in DB.Administrations
                                   where a.AID == Convert.ToInt32(cmbAdminIDU.Text)
                                   select a).First();

                adminList.Role = txtAdminRoleU.Text;

                // Save the changes that were made
                DB.SubmitChanges();

                // Refresh the bound controls
                DB.Refresh(RefreshMode.OverwriteCurrentValues, DB.Teachers);

                MessageBox.Show("Administrator ID " + cmbAdminIDU.Text + " was updated");
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
                // Create a new person object for the administrator and add its properties
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
                newPerson.Type = "Administrator";

                // Add the new person to the database
                DB.Persons.InsertOnSubmit(newPerson);
                DB.SubmitChanges();

                // Get the newly created person ID number for the administrator ID number
                var newPersonID = newPerson.ID;

                // Create new administrator object and add its properties
                var newAdministration = new Administration();
                newAdministration.AID = newPersonID;
                newAdministration.Role = txtAdminRoleA.Text;
                newAdministration.Password = "adminis";

                // Add the new student specific data to the database
                DB.Administrations.InsertOnSubmit(newAdministration);
                DB.SubmitChanges();

                MessageBox.Show("Administrator ID " + newPersonID + " was added with a temporary password 'adminis'. Please get " + txtFirstNameA.Text + " to change this password as soon as possible");

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
                int idToDelete = (int)cmbAdminIDU.SelectedValue;

                // Get the person that matches the criteria in the Administrator ID
                // combo box
                var deletedPerson = (from p in DB.Persons
                                     where p.ID == idToDelete
                                     select p).First();

                var deletedAdministration = (from t in DB.Administrations
                                      where t.AID == idToDelete
                                      select t).First();

                DialogResult d = MessageBox.Show("Are you sure you want to delete this Administrator?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (d == DialogResult.Yes)
                {
                    DB.Persons.DeleteOnSubmit(deletedPerson);
                    DB.SubmitChanges();
                    DB.Administrations.DeleteOnSubmit(deletedAdministration);
                    DB.SubmitChanges();

                    UpdateData();
                    MessageBox.Show("Administrator deleted");
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
