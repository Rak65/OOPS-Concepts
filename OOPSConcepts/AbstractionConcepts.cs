using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    abstract class AbstractionConcepts
    {
        public abstract void Draw();
    }
    class Circle1 : AbstractionConcepts
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle");
        }
    }
    class Rectangle : AbstractionConcepts
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }
}
