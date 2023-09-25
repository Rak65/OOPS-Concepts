using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    public class PolymorphismOverride
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a generic shape.");
        }
    }
    class Circle : PolymorphismOverride
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }
    class Square : PolymorphismOverride
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a square.");
        }
    }
}
