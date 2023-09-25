using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    public class MethodTypes
    {
        public void Calculator()
        {
            int a=5; int b=6;
            int c=a+b; int d=a+c;
            Console.WriteLine("C : " + c + " D :" + d);
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public static void Method()
        {
            Console.WriteLine("This is static method.");
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
    }
}
