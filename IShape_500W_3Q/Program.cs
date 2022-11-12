using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IShape_500W_3Q
{
    internal class Program : MyExceptions
    {
        static void Main(string[] args)
        {

            /*Შექმენით ინტერფეისი IShape რომელსაც ექნება ფართობის და პერიმეტრის გამოთვლის მეთოდები. 
              Შექმენით პრიზმის, სამკუთხედის, მართკუთხედის, და ტრაპეციის კლასები. Ველები დაამატეთ საჭიროებისამებრ. 
              Გააკეთეთ თითოეულ კლასში IShape-ის იმპლემენტაცია.*/

            try
            {
                Rectangle r = new Rectangle(5, 3);
                Console.WriteLine("area Rectangle ");
                Console.WriteLine(r.GetArea());
                Console.WriteLine("perimeter Rectangle");
                Console.WriteLine(r.GetPerimeter());
            }
            catch { Console.WriteLine("enter the correct parameters"); }

            try
            {
                Triangle t = new Triangle(3, 4, 5);
                Console.WriteLine("area Triangle");
                Console.WriteLine(t.GetArea());
                Console.WriteLine("perimeter Triangle");
                Console.WriteLine(t.GetPerimeter());
            }
            catch { Console.WriteLine("enter the correct parameters"); }

            try
            {
                Trapezium tr = new Trapezium(6, 4, 3, 2);
                Console.WriteLine("area Trapezium");
                Console.WriteLine(tr.GetArea());
                Console.WriteLine("perimeter Trapezium");
                Console.WriteLine(tr.GetPerimeter());
            }
            catch { Console.WriteLine("enter the correct parameters"); }

            try
            {
                TriangularPrism pr = new TriangularPrism(5, 4, 3, 2);
                Console.WriteLine("area TriangularPrism");
                Console.WriteLine(pr.GetArea());
            }
            catch { Console.Write("change parameters"); }

            try
            {
                TriangularPrism pr = new TriangularPrism(5, 4, 3, 2);

                Console.WriteLine("perimeter TriangularPrism");
                Console.WriteLine(pr.GetPerimeter());
            }
            catch { Console.WriteLine("Prism does not have Perimeter"); }


        }


    }
}
