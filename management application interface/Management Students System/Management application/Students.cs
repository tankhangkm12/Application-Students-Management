using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_application
{
    internal class Students
    {
        static int count = 0;
        public string StudentID { get; set; }
        public string Fullname { get; set; }
        public string IDcard { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Major { get; set; }
        public string Semester { get; set; }
        public string Status { get; set; }

        public string Birthday { get; set; }
        public Students() 
        {
            count++;
        }
        public override string ToString()
        {
            return this.Fullname;
        }
    }
}
