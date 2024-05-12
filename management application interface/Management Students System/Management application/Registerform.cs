using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Management_application
{
    public partial class Registerform : Form
    {
        public Registerform()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonregister_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
            errorProvider1.SetError(textBox2, "");
            if (textBox1.Text.Length>7 && textBox2.Text.Length>7 && textBox3.Text.Length>7)
            {
                errorProvider1.SetError(textBox3, "");
                if (textBox2.Text == textBox3.Text)
                {
                    Account account = new Account()
                    {
                        Username = textBox1.Text,
                        Password = textBox2.Text
                    };
                    ManagementAccount managementAccount = new ManagementAccount();
                    managementAccount.Registeraccount(account);
                    MessageBox.Show("Register successfull!");
                    Close();
                }   
                else
                {
                    errorProvider1.SetError(textBox3, "Repeat password not true ! ");
                }    

            }   
            else
            {
                if (textBox1.Text.Length <=7)
                {
                errorProvider1.SetError(textBox1, "Username must to have length more than 7 character ! ");
                }

                if (textBox2.Text.Length <= 7)
                {
                    errorProvider1.SetError(textBox2, "Passworld must to have length more than 7 character ! ");
                }


                //if (textBox3.Text.Length <= 7)
                //{
                //    errorProvider1.SetError(textBox3, "Username must to have length more than 7 character ! ");
                //}
            }
        }

        private void panel2_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            buttonregister_Click(sender, e);
        }
    }
}
