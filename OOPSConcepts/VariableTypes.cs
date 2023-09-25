using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    public class VariableTypes
    {
        int instaceVar = 5;
        static int staticVar = 20;
        const double PI = 3.14;
        public static void Variable()
        {
            int localVar = 10;
            VariableTypes variableTypes = new VariableTypes();
            Console.WriteLine("Instance Variable : "+ variableTypes.instaceVar);
            Console.WriteLine("Static Variable : "+ staticVar);
            Console.WriteLine("Constant : "+ PI);
            Console.WriteLine("Local Variable : " + localVar);
            Console.WriteLine();
        }
    }
}
