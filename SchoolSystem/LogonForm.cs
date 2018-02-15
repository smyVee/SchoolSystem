using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    // This is the logon screen. It takes a user ID and a password from the user
    // and checks it against the data stored in the Teachers / Administration tables.
    // 

    public partial class LogonForm : Form
    {
        SchoolDataClassesDataContext DB = new SchoolDataClassesDataContext();

        //This variable defines the menu access option based on the Person Type
        public static string personType = "";

        // This variable stores the user ID so that it can be used 
        // elsewhere in the program
        public static string personID = "";

        public LogonForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogon_Click(object sender, EventArgs e)
        {
                try
                {
                    // look up ID in Persons database and test to see if the
                    // one entered is valid. If valid, return the Type value 
                    // so that the password can be checked.
                    var loginTest = (from i in DB.Persons
                                     where i.ID == Int32.Parse(txtUserID.Text)
                                     select i.Type).First();

                    if (loginTest == "Administrator")
                    {
                        // lookup password from Administrator file
                        var passwordTest = (from p in DB.Administrations
                                            where p.AID == Int32.Parse(txtUserID.Text)
                                            select p.Password).First();
                        if (passwordTest == txtPassword.Text)
                        {
                            //lblMessage.Text = "Password is correct";
                            // Open the Main Menu Form for Administrators
                            personType = "Administrator"; // sets up the main menu for administrators
                            personID = txtUserID.Text; // used in the changePasssword form
                            this.Hide(); //Hide the logon form
                            MainMenuForm administratorMainMenuForm = new MainMenuForm();
                            administratorMainMenuForm.ShowDialog();
                            clearFields();
                            this.Show(); // show the logon form when user logs off
                        }
                        else
                        {
                            lblMessage.Text = "Password is incorrect";
                            clearFields();
                        }
                    }
                    else if (loginTest == "Teacher")
                    {
                        // lookup password from Teacher file
                        var passwordTest = (from p in DB.Teachers
                                            where p.TID == Int32.Parse(txtUserID.Text)
                                            select p.Password).First();
                        if (passwordTest == txtPassword.Text)
                        {
                            // Open the Main Menu Form for Teachers
                            personType = "Teacher"; // sets up the main menu for teachers
                            personID = txtUserID.Text; // used in the changePasssword form
                            this.Hide(); //Hide the logon form
                            MainMenuForm teacherMainMenuForm = new MainMenuForm();
                            teacherMainMenuForm.ShowDialog();
                            clearFields();
                            this.Show(); // show the logon form when user logs off
                        }
                        else
                        {
                            lblMessage.Text = "Password is incorrect";
                            clearFields();
                        }
                    }
                    else
                    {
                        lblMessage.Text = "Customer ID is invalid. Please contact your Data Administrator.";
                    }
                }

                catch (Exception)
                {
                    lblMessage.Text = "Customer ID is invalid. Please contact your Data Administrator.";
                }
            
        }

        private void LogonForm_Load(object sender, EventArgs e)
        {
            lblMessage.Text = "Please enter a valid User ID and Password.\r\nClick Logon or press Enter to continue.\r\nClick Exit to Quit.";
            clearFields();
        }
        public void clearFields()
        {
            //Clear the text entry areas and prepare the login form a fresh entry
            txtUserID.Clear();
            txtPassword.Clear();
            txtUserID.Select();
        }
    }
}
