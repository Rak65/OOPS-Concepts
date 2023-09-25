using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Which Program You want to run : ");
                Console.WriteLine("1. Object-Class-Concepts.");
                Console.WriteLine("2. Inheritance Example.");
                Console.WriteLine("3. Exit");
                string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        ObjectClassConcepts objectClassConcepts = new ObjectClassConcepts("HelloWorld Class", "HelloWorld Object");
                        objectClassConcepts.DisplayDetails();
                        break;
                    case "2":
                        Dog dog = new Dog();
                        Console.WriteLine("Enter Dog name : ");
                        dog.Name = Console.ReadLine();
                        dog.Eat();
                        dog.Bark();
                        break;
                    case "3":
                        isRunning = false;
                        break;
                }
            }
        }
    }
}
