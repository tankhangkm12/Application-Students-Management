using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_application
{
    internal class Managementstudent
    {
        public Managementstudent() { }
        private List<Students> studentslist = new List<Students>();
        public List<Students> GetStudentlist()
        {
            ReadOldStudentlist();
            return studentslist;
        }
        public void ReadOldStudentlist()
        {
            try
            {
                string filepath = "StudentInformation.json";
                string json=File.ReadAllText(filepath);
                studentslist = JsonConvert.DeserializeObject<List<Students>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddStudent(Students newstudent)
        {
            ReadOldStudentlist();
            studentslist.Add(newstudent);
            string json = JsonConvert.SerializeObject(studentslist, Formatting.Indented);
            try
            {
                string filepath = "StudentInformation.json";
                File.WriteAllText(filepath, json);
                MessageBox.Show("Saved","Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Removestudent(List<Students> removestudentslist)
        {
            string json=JsonConvert.SerializeObject(removestudentslist, Formatting.Indented);
            try
            {
            string filepath = "StudentInformation.json";
            File.WriteAllText(filepath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
