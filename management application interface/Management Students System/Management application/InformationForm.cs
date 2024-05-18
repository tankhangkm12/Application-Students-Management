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
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InformationForm_Load(object sender, EventArgs e)
        {
            Managementstudent managementstudents = new Managementstudent();
            List<Students>students=managementstudents.GetStudentlist();
            foreach (Students student in students )
            {
                listBox1.Items.Add(student);
            }    
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            Managementstudent managementstudents = new Managementstudent();
            List<Students> students = managementstudents.GetStudentlist();
            listBox1.Items.Clear();
            foreach (Students student in students)
            {
                if (student.Fullname.Contains(textBox1.Text) || Convert.ToString(student.codestudent).Contains(textBox1.Text))
                {
                    listBox1.Items.Insert(0, student); 
                }
                else
                {
                    listBox1.Items.Add(student); 
                }
            }
        }


        private void buttonwatchinfo_Click(object sender, EventArgs e)
        {
            Infostudentcs info = new Infostudentcs();
            info.ShowDialog();

        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
