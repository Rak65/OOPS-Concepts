using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    public class PolymorphismOverloading
    {
        public void  Login(long mobileNumber)
        {
            Console.WriteLine("Login Successful with Mobile Number.");
        }
        public void Login(string username, string password)
        {
            Console.WriteLine("Login Successful with UserName and Password.");
        }
    }
}
