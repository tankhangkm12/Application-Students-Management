using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace Management_application
{
    public partial class Addstudent : Form
    {
        public Addstudent()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void labelgender_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureavt_Click(object sender, EventArgs e)
        {

        }

        private void buttonupload_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            { 
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = openFileDialog.FileName;
                    pictureavt.Image=Image.FromFile(imageLocation); 

                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSAVE_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(textfullname, "");
            errorProvider1.SetError(groupBoxgender, "");
            errorProvider1.SetError(birthday, "");
            errorProvider1.SetError(textBoxnumberphone, "");
            errorProvider1.SetError(textBoxidcard, "");
            errorProvider1.SetError(comboBoxmajor, "");
            if (textfullname.Text=="")
            {
                errorProvider1.SetError(textfullname, "Please Entered your name ! ");
            }  
            
            if (radioButton1.Checked==false && radioButton2.Checked==false && radioButton3.Checked==false)
            {
                errorProvider1.SetError(groupBoxgender, "please choose a gender");
            }    

            if (birthday.Value.Year>2005)
            {
                errorProvider1.SetError(birthday, "You are less than 18 age");
            }

            if (textBoxnumberphone.Text == "")
            {
                errorProvider1.SetError(textBoxnumberphone, "Please Entered your phone number ! ");
            }

            if (textBoxidcard.Text == "")
            {
                errorProvider1.SetError(textBoxidcard, "Please Entered your card");
            }
            if (comboBoxmajor.SelectedIndex == -1)
            {
                errorProvider1.SetError(comboBoxmajor, "Please choose your major ! ");
            }

            Students student = new Students
            {
                Fullname = textfullname.Text,
                Gender = radioButton1.Checked ? "Male" : radioButton2.Checked ? "Female" : "Other",
                Birthday = birthday.Value.ToString("dd-MM-yyyy"),
                Phone = textBoxnumberphone.Text,
                IDcard = textBoxidcard.Text,
                Major = comboBoxmajor.SelectedItem.ToString(),
                codestudent = Students.setcodeStudent()
            };
            Managementstudent managamentstudent = new Managementstudent();
            managamentstudent.AddStudent(student);


        }

        private void comboBoxmajor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
