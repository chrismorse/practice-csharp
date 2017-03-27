using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_csharp
{
    class polymorphism
    {
        
        public static void RunAllTests() {

            // polymorphism.   Notice - Cirle is a circle and a shape.  2 forms.  Poly.  

            List<Shape> newShapes = new List<Shape>();
            newShapes.Add(new Circle());
            newShapes.Add(new Square());

            foreach (Shape s in newShapes)
            {
		        s.Draw();
            }
        }

        public class Shape
        {
            // virtual method - child class can override if they want, but don't have to.
            public virtual void Draw()
            {
                Console.WriteLine("Peforming base call drawing tasks");
            }

        }

        class Circle : Shape
        {
            public Circle()
            {
                Console.WriteLine("I'm a circle");
            }

            public override void Draw()
            {
                Console.WriteLine("Drawing a circle");
            }
        }


        class Square : Shape
        {
            public Square()
            {
                Console.WriteLine("I'm a square");
            }

            public override void Draw()
            {
                Console.WriteLine("Drawing a square");
            }

        }








    }
}
