using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_application
{
    public partial class RemoveStudent : Form
    {
        public RemoveStudent()
        {
            InitializeComponent();
        }
        private void RemoveStudent_Load(object sender, EventArgs e)
        {
            Managementstudent managementstudent = new Managementstudent();
            List<Students> students = managementstudent.GetStudentlist();
            foreach (Students student in students)
            {
                checkedListBoxstudent.Items.Add(student);
            }    
        }

        private void checkedListBoxstudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi có lựa chọn trong checkedListBoxstudent
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you sure to remove student ?", "Remove Student", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                List<Students> removestudents = new List<Students>();
                foreach (Students student in checkedListBoxstudent.CheckedItems)
                {
                    removestudents.Add(student);
                }
                for (int i = 0; i < removestudents.Count; i++)
                {
                    checkedListBoxstudent.Items.Remove(removestudents[i]);
                }

                List<Students> updatejson = new List<Students>();
                foreach (Students student in checkedListBoxstudent.Items)
                {
                    updatejson.Add(student);
                }
                Managementstudent managementstudent = new Managementstudent();
                managementstudent.Removestudent(updatejson);
            }
           
        }

    }
}
