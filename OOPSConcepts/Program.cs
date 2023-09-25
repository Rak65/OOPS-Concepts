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
                Console.WriteLine("3a. Polymorphism Overrides.");
                Console.WriteLine("3b. Polymorphism Overloading.");
                Console.WriteLine("4. Encapsulation Concepts.");
                Console.WriteLine("5. Abstraction Concepts.");
                Console.WriteLine("6. Exit");
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
                    case "3a":
                        PolymorphismOverride polymorphismOverride1 = new Circle();
                        PolymorphismOverride polymorphismOverride2 = new Square();
                        polymorphismOverride1.Draw();
                        polymorphismOverride2.Draw();
                        break;
                    case "3b":
                        PolymorphismOverloading pol = new PolymorphismOverloading();
                        pol.Login(7988975494L);
                        pol.Login("Rakesh", "1234");
                        break;
                    case "4":
                        EncapsulationConcepts encapsulationConcepts = new EncapsulationConcepts();
                        encapsulationConcepts.Name = "Rakesh";
                        encapsulationConcepts.Description = "This is Description.";
                        encapsulationConcepts.DisplayDetails();
                        break;
                    case "5":
                        Circle1 circle = new Circle1();
                        Rectangle rectangle = new Rectangle();
                        circle.Draw();
                        rectangle.Draw();
                        break;
                    case "6":
                        isRunning = false;
                        break;
                }
            }
        }
    }
}
