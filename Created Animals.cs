using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Created_Animals:Animal
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int age { get; set; }
        public string Pet { get; set; }
        public Created_Animals() 
        { 
        this.age = 0;
            this.Name = Name;
            this.Species = string.Empty;
            this.Pet = string.Empty;
        }
    }
}
