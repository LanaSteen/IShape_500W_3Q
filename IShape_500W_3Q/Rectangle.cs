using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IShape_500W_3Q
{

    public class Rectangle : IShape
    {
        private readonly double _side1;
        private readonly double _side2;

        public Rectangle(double side1, double side2)
        {
            if (side1 <= 0 || side2 <= 0)
            {
                throw new MyExceptions("Sides can't be zero or under zero");
            }
            else
            {
                _side1 = side1;
                _side2 = side2;
            }

        }

        public double GetArea()
        {
            return _side1 * _side2;
        }

        public double GetPerimeter()
        {
            return 2 * (_side1 + _side2);
        }

    }
}
