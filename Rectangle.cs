using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp2B
{
    public class Rectangle : Geometry
    {
        public int Width { get; set; }
        public int Height { get; set; }

        // 2 * (l + w)
        //override
        // public new void CalculatePerimeter(){
        //     Perimeter = 2 * ( Width + Height);
        // }

    }
}


//   github.com/wingled22/ConsoleApp2B