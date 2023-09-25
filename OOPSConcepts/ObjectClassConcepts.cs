using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPSConcepts
{
    public class ObjectClassConcepts
    {
        public string ClassName { get; set; }
        public string ObjectName { get; set; }

        public ObjectClassConcepts(string className, string objectName)
        {
            ClassName = className;
            ObjectName = objectName;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"ClassName: {ClassName}, ObjectName: {ObjectName}");
        }
    }
}
