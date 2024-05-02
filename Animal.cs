using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{
    public class Animal 
    {
        public Animal()
        {
            this.Aname = Aname;
            this.Pname = Pname;
            this.Age = Age;

        }

        public Animal(string Aname, string Pname, int Age, string type) 
        { 
        this.Aname = Aname;
            this.Pname = Pname;
            this.Age = Age;
            this.Type= type;
        }

        public string Aname { get; set; }
        public string Pname { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }
    }
}
