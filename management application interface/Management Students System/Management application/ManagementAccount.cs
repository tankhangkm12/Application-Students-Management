using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Management_application
{
    internal class ManagementAccount
    {
        public ManagementAccount() { }

        private List<Account> accounts=new List<Account>();

        public void ReadJson() 
        {
            try
            {
                string filepath = "accountlogin.json";
                string json = File.ReadAllText(filepath);
                accounts = JsonConvert.DeserializeObject<List<Account>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        public void Registeraccount(Account newaccount)
        {
            ReadJson();

            try
            {
                accounts.Add(newaccount);
                string filepath= "accountlogin.json";
                string json=JsonConvert.SerializeObject(accounts,Formatting.Indented);
                File.WriteAllText(filepath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
