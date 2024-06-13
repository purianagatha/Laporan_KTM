using GUI_FindMyKTM.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_FindMyKTM.Forms
{
    public partial class FormCreate : Form
    {
        public FormCreate()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // SUBMIT BUTTON
            var report = new Report
            {
                Title = textBoxNama.Text,
                StudentId = textBoxNIM.Text,
                CreatedAt = DateTime.Now,
                Status = textBoxAlasan.Text,

            };
        }

        private void textBoxNama_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
