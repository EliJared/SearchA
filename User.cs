using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class User : Form
    {
        string name { get; set; }
        private string password { get; set; }
        public User(string Name,string Password) { 
        this.name = Name;
        this.password = Password;
        }
    }
}
