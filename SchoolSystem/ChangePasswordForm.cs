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
    // Written by : Paul Smyth
    // Date of last issue : 9/9/2015
    //
    // This form allows the user to update his/her password.
    // It prompts the user to input a new password twice, the 
    // second time is to verify that the first password was typed as
    // intended. Once the new password has been validated, the 
    // Teacher/Administration table is updated.
    //
    // It takes the static variable personID from the logonForm
    // to indicate theID of the user that has logged on to the system.
    // This information is used to select the correct record from
    // the teacher / Administration table to receive the password
    // update.
    public partial class ChangePasswordForm : Form
    {
        SchoolDataClassesDataContext DB = new SchoolDataClassesDataContext();
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            clearPasswords(); // clear the text fields

            lblPasswordMessage.Text = "Enter a new 7 character password.\r\nThen re-enter it for verification purposes";

            //Set up ToolTips for the form
            toolTip1.SetToolTip(txtPassword1, "Enter a new 7 character password");
            toolTip1.SetToolTip(txtPassword2, "Re-enter the new password \r\nfor verification purposes");
            toolTip1.SetToolTip(btnExit, "Return to Main Menu");
            toolTip1.SetToolTip(btnUpdate, "Update the changed password");


        }

        // This method tests that the entered password is 7 characters long
        private bool validPasswordLength(string thePassword)
        {
            if (thePassword.Length != 7)
            {
                lblPasswordMessage.Text = "The password must be seven characters long. \r\nPlease try again";
                clearPasswords();
                return false;
            }
            else
            {
                lblPasswordMessage.Text = "";
                return true;
            }
        }

        // This method compares the two entered passwords
        private bool validComparePasswords(string password1, string password2)
        {
            if (txtPassword1.Text != txtPassword2.Text)
            {
                lblPasswordMessage.Text = "The re-entered pasword is not identical. \r\nPlease try again";
                clearPasswords();
                return false;
            }
            else
            {
                lblPasswordMessage.Text = "";
                return true;
            }
        }


        // This method clears the password text fields
        internal void clearPasswords()
        {
            txtPassword1.Clear();
            txtPassword2.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.No;
        }

        // This method checks the data input and if it is ok,
        // write it to the Persons table.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Test to see that the  first password entry is the required length
            if (!validPasswordLength(txtPassword1.Text))
            {
                return;
            }

            // Test to see if the two password entries are identical
            if (!validComparePasswords(txtPassword1.Text, txtPassword2.Text))
            {
                return;
            }

            // Update the password entry in the table
            if (LogonForm.personType == "Administrator")
            {
                var newPassword = (from p in DB.Administrations
                                       where p.AID == Convert.ToInt32(LogonForm.personID)
                                       select p).First();

                newPassword.Password = txtPassword1.Text;

                // Save the changes that were made
                DB.SubmitChanges();

                // Refresh the Bound controls
                DB.Refresh(RefreshMode.OverwriteCurrentValues, DB.Courses);
            }
            else if (LogonForm.personType == "Teacher")
            {
                var newPassword = (from p in DB.Teachers
                                   where p.TID == Convert.ToInt32(LogonForm.personID)
                                   select p).First();

                newPassword.Password = txtPassword1.Text;

                // Save the changes that were made
                DB.SubmitChanges();

                // Refresh the Bound controls
                DB.Refresh(RefreshMode.OverwriteCurrentValues, DB.Courses);
            }

            lblPasswordMessage.Text = "Password has been successfully updated";
        }
    }
}
