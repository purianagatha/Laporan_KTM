using System;
using GUI_FindMyKTM.Reuseable.Controllers;
using System.Windows.Forms;
using GUI_FindMyKTM.Entities;

namespace GUI_FindMyKTM.Forms
{
    public partial class FormAuthentication : Form
    {
        public FormAuthentication()
        {
            InitializeComponent();
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

            AuthController authController = new AuthController();
            authController.RegisterAsync(student);
            Console.WriteLine("Tetenonet");
        }
    }
}
