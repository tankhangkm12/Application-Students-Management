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

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
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
    }
}
