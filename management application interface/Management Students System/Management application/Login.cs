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
    public partial class Login : Form
    {
        public Login()
        {
            Random random=new Random();
            InitializeComponent();
            labelshowverification.Text=random.Next(100000, 1000000).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labeltitlelogin_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonregister_Click(object sender, EventArgs e)
        {
            Registerform registerform = new Registerform();
            registerform.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private async void buttonlogin_Click(object sender, EventArgs e)
        {
            List<Account> accountList = new List<Account>(); 
            ManagementAccount managementAccount = new ManagementAccount();
            accountList=managementAccount.getAccountsList();
            errorProvider1.SetError(textBoxusername, "");
            errorProvider1.SetError(textBoxpassword, "");
            errorProvider1.SetError(labelshowverification, "");

            List<Task> tasks = new List<Task>();
            foreach (Account user in accountList)
            {
                Task tast = Task.Run(() =>
                {
                    if (textBoxusername.Text == user.Username && textBoxpassword.Text == user.Password && textBoxverification.Text == labelshowverification.Text)
                    {
                        DialogResult = DialogResult.OK;
                        MessageBox.Show("Login successfull!", "Notifications", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (textBoxusername.Text != user.Username)
                        {
                            errorProvider1.SetError(textBoxusername, "Username not true ! ");
                        }
                        if (textBoxpassword.Text != user.Password)
                        {
                            errorProvider1.SetError(textBoxpassword, "Password not true ! ");
                        }
                        if (!string.IsNullOrEmpty(textBoxverification.Text))
                        {
                            errorProvider1.SetError(labelshowverification, "Please entered verification ! ");
                        }
                        if (textBoxverification.Text != labelshowverification.Text)
                        {
                            errorProvider1.SetError(labelshowverification, "Verification not true ! ");
                        }
                    }

                });
                tasks.Add(tast);                   
            }
            await Task.WhenAll(tasks);
            Random random = new Random();
            labelshowverification.Text=random.Next(100000,1000000).ToString();

        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            DialogResult result=MessageBox.Show("Do you exit ? ", "EXIT", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Close();
            }
        }

        private void labelshowverification_Click(object sender, EventArgs e)
        {

        }

        private void textBoxverification_KeyDown(object sender, KeyEventArgs e)
        {

            
        }

        private void textBoxverification_DragEnter(object sender, DragEventArgs e)
        {
        }
    }
}
