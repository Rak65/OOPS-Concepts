using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    public class EncapsulationConcepts
    {
        private string name;
        private string description;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Name : {Name}, Description : {Description} ");
        }
    }
}
