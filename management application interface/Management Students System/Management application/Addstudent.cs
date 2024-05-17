using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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
                    pictureBoxboy.Visible = false;
                    pictureBoxgirl.Visible = false;
                    imageLocation = openFileDialog.FileName;
                    pictureavt.Image = Image.FromFile(imageLocation);
                    pictureBoxboy.Image=Image.FromFile(imageLocation);
                    pictureBoxgirl.Image = Image.FromFile(imageLocation);

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
            if (textfullname.Text == "")
            {
                errorProvider1.SetError(textfullname, "Please Entered your name ! ");
            }

            if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
            {
                errorProvider1.SetError(groupBoxgender, "please choose a gender");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Addstudent_Load(object sender, EventArgs e)
        {
            pictureBoxboy.Visible = false;
            pictureBoxgirl.Visible = false;
        }

        private void groupBoxgender_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBoxboy_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked==true)
            {
                pictureBoxboy.Visible = true;

            }
            else
            {
                pictureBoxboy.Visible = false;

            }
        }
        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked==true)
            {
                pictureBoxgirl.Visible = true;
            }
            else
            {
                pictureBoxgirl.Visible = false;

            }
        }

        private void birthday_ValueChanged(object sender, EventArgs e)
        {
      

        }

        private void pictureBoxgirl_Click(object sender, EventArgs e)
        {

        }

    }
}
