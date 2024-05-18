using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_application
{
    public partial class applicationstudent : Form
    {
        public applicationstudent()
        {
            InitializeComponent();
        }

        private void paneltitle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelstudent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void StudentsManagement_Click(object sender, EventArgs e)
        {
            panelstudent.Visible = true;
            labeltitle.Text = "Students Management System";
            
        }

        private void labeltitle_Click(object sender, EventArgs e)
        {
            
        }

        private void addstudent_Click(object sender, EventArgs e)
        {
            Addstudent student = new Addstudent();
            student.ShowDialog();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RemoveStudent removeStudent = new RemoveStudent();
            removeStudent.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            InformationForm informationform = new InformationForm();
            informationform.ShowDialog();

        }
    }
}
