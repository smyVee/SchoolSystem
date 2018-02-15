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
    //Written by : Paul Smyth
    //Date of last issue : 9/9/2015
    //
    // This form sets up the Main Menu which allows the user to 
    // navigate the key functions of the software.
    // 
    // It takes the static variable personType from the logonForm
    // to indicate if the user is a teacher or administrator. It
    // uses this variable to switch on the menu items the user has
    // access to.
    //
    
    public partial class MainMenuForm : Form
    {
        // Holds the user selection which will be used 
        // in the chosen Form selected from this menu.
        // It will either be Student, Teacher or Administrator
        // depending on the user choice.

        public static string MenuChoice = ""; 

        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

            // Update the form header
            this.Text = LogonForm.personType + " Menu";

            lblMainMenuMessage.Text = "Click on an option";
     
            // Set up which button options will be available for Teacher
            if (LogonForm.personType == "Teacher")
            {
                btnCourses.Enabled = true;
                btnQualifications.Enabled = true;
                btnMarks.Enabled = true;
                btnTeachers.Enabled = false;
                btnStudents.Enabled = false;
                btnAdministrators.Enabled = false;
                btnChangePassword.Enabled = true;
            }
            // Set up which button options will be available for Administrator
            else if (LogonForm.personType == "Administrator")
            {
                btnCourses.Enabled = true;
                btnQualifications.Enabled = true;
                btnMarks.Enabled = false;
                btnTeachers.Enabled = true;
                btnStudents.Enabled = true;
                btnAdministrators.Enabled = true;
                btnChangePassword.Enabled = true;
            }
        }

        private void btnLogoff_Click(object sender, EventArgs e)
        {
            // Return to the logon screen
            this.Close();
        }

        private void btnMarks_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hide the main menu
            MarksForm marks = new MarksForm();
            marks.ShowDialog();
            this.Show(); // show main menu when user exits marks
        }

        private void btnQualifications_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hide the main menu
            QualificationsForm qualifications = new QualificationsForm();
            qualifications.ShowDialog();
            this.Show(); // show main menu when user exits qualifications
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hide the main menu
            CoursesForm courses = new CoursesForm();
            courses.ShowDialog();
            this.Show(); // show main menu when user exits courses
        }

        private void btnAdministrators_Click(object sender, EventArgs e)
        {
            // The StudentsForm is used for maintaining 
            // Student, Teacher and Administrator data
            this.Hide(); //Hide the main menu

            MenuChoice = "Administrator";
            StudentsForm students = new StudentsForm();
            students.ShowDialog();
            this.Show(); // show main menu when user exits administrators
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            // The StudentsForm is used for maintaining 
            // Student, Teacher and Administrator data
            this.Hide(); //Hide the main menu

            MenuChoice = "Teacher";
            StudentsForm students = new StudentsForm();
            students.ShowDialog();
            this.Show(); // show main menu when user exits teachers
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            // The StudentsForm is used for maintaining 
            // Student, Teacher and Administrator data
            this.Hide(); //Hide the main menu

            MenuChoice = "Student";
            StudentsForm students = new StudentsForm();
            students.ShowDialog();
            this.Show(); // show main menu when user exits students
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide(); //Hide the main menu
            ChangePasswordForm password = new ChangePasswordForm();
            password.ShowDialog();
            this.Show(); // show main menu when user exits passwords
        }
    }

    public static class inputChecker
    {

    }
}
