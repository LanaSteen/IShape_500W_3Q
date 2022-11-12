using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IShape_500W_3Q
{
    public  class MyExceptions : Exception
    {
    
        public MyExceptions() { }

        public MyExceptions(string message)
            : base(message) { }


     
    }
}
