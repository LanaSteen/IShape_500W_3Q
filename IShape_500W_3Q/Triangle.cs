using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IShape_500W_3Q
{
    public class Triangle : IShape
    {
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;



        public Triangle(double side1, double side2, double side3)
        {
            if ((side1 + side2 <= side3) || (side1 + side3 <= side2) || (side2 + side3 <= side2))
            {
                throw new MyExceptions("It is not possible to create triangle with these sides");

            }

            else if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                throw new MyExceptions("Sides can't be zero or under zero");
            }
          
            else
            {
                _side1 = side1;
                _side2 = side2;
                _side3 = side3;

            }
        }
     
        public double GetArea()
        {
            double _semiPer = (_side1 + _side2 + _side3) / 2;
            double area = Math.Sqrt(_semiPer * (_semiPer - _side1) * (_semiPer - _side2) * (_semiPer - _side3));
            return area;

        }

        public double GetPerimeter()
        {
            return _side1 + _side2 + _side3;
        }
    }
   
}
