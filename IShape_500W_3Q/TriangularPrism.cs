using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IShape_500W_3Q
{
    internal  class TriangularPrism:IShape
    {


        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;
        private readonly double _height;



        public TriangularPrism(double side1, double side2, double side3, double height)
        {
            if ((side1 + side2 <= side3) || (side1 + side3 <= side2) || (side2 + side3 <= side2))
            {
                throw new MyExceptions("It is not possible to create triangle with these sides");

            }

            else if (side1 <= 0 || side2 <= 0 || side3 <= 0 || height<=0)
            {
                throw new MyExceptions("Sides and height can't be zero or under zero");
            }
            else
            {
                _side1 = side1;
                _side2 = side2;
                _side3 = side3;
                _height = height;

            }
        }

        public double GetArea()
        {
            double _semiPer = (_side1 + _side2 + _side3) / 2;
            double areaTriangle = Math.Sqrt(_semiPer * (_semiPer - _side1) * (_semiPer - _side2) * (_semiPer - _side3));
            double areaPrism = 2 * areaTriangle + (_side1 + _side2 + _side3) * _height;
            return areaPrism;

        }

        public double GetPerimeter()
        {

            throw new MyExceptions("Prism does not have Perimeter");
        }

    }



}



/*
 * A=2AB+(a+b+c)h
AB=s(s﹣a)(s﹣b)(s﹣c)
s=a+b+c
2 
*/