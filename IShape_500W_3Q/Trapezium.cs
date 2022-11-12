using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IShape_500W_3Q
{

    public class Trapezium : IShape
    {
       
        private readonly double _side1;
        private readonly double _side2;
        private readonly double _side3;
        private readonly double _side4;



        public Trapezium(double side1, double side2, double side3, double side4)
        {
            if(side1 <= side2 || side1 <= side3 || side1 <= side4)
            {
                throw new MyExceptions("first write size of the long parallel side of the trapezium" +
                                         "and second parameter should be the short parallel side"
                                         + "non of third and forth should be greater then first parameter");
            }

            else if (( (side1 + side2 + side3 + side4) / 2 - side2 - side3) <= 0
                || ((side1 + side2 + side3 + side4) / 2 - side2 - side4) <= 0)
            {

                throw new MyExceptions("Sides sizes are ageinst of the law of sides of the Trapezoid");
                
            }
            else if (side1 <= 0 || side2 <= 0 || side3 <= 0 || side4 <= 0)
            {
                throw new MyExceptions("Sides can't be zero or under zero");
            }
         
            else
            {

                _side1 = side1; // long parallel side
                _side2 = side2; // short parallel side
                _side3 = side3; // non parallel side
                _side4 = side4;  // non parallel side
               
            }
        }

        public double GetArea()
        {
            
            double _semiPer = (_side1 + _side2 + _side3+ _side4) / 2;
            double area = ((_side1 + _side2) / (_side1 - _side2)) * 
                            Math.Sqrt((_semiPer - _side1) * (_semiPer - _side2) * 
                            (_semiPer - _side2 - _side3) * (_semiPer - _side2 - _side4));
            return area;
            

        }
     

   
        public double GetPerimeter()
        {
            return _side1 + _side2 + _side3 + _side4;
        }
    }
}
