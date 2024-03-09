using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace ConsoleApp2B
{
    public class Square : Geometry
    {
        public int Side { get; set; }

        // // side * 4
        // public new void CalculatePerimeter(){
        //     Perimeter = 4 * Side;
        // }
    }
}