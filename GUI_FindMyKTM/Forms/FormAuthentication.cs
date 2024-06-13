using System;
using GUI_FindMyKTM.Reuseable.Controllers;
using System.Windows.Forms;
using GUI_FindMyKTM.Entities;

namespace GUI_FindMyKTM.Forms
{
    public partial class FormAuthentication : Form
    {
        private AuthController authController = new AuthController();
        public FormAuthentication()
        {
            InitializeComponent();
            fieldPassword.Text = "";
            fieldConfirmPassword.Text = "";
            fieldPassword.PasswordChar = '*';
            fieldConfirmPassword.PasswordChar = '*';
            loginPassword.Text = "";
            loginPassword.PasswordChar = '*';
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Name = fieldName.Text,
                userName = fieldUsername.Text,
                EmailSSO = fieldEmail.Text,
                Faculty = fieldFaculty.Text,
                Phone = fieldPhone.Text,
                Nim = fieldNim.Text,
                Password = fieldPassword.Text,
            };

            if (fieldPassword.Text != fieldConfirmPassword.Text)
            {
                validationLabel.Text = "Password tidak sesuai dengan confirmasi password";
            } else
            {

                authController.RegisterAsync(student);
                validationLabel.Text = "Sesuai!";
            }

            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            authController.LoginAsync(loginEmail.Text, loginPassword.Text);
        }
    }
}
