using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp2B
{
    public class Geometry
    {
        public int Area { get; set; }
        public int Perimeter { get; set; }

        public void CalculatePerimeter()
        {
            if (this is Square s)
            {
                s.Perimeter = 4 * s.Side;
            }
            else if (this is Rectangle r)
            {
                r.Perimeter = 2 * (r.Width + r.Height);
            }
        }


        // public void InheritedMethod(){
        //     Console.WriteLine("I am a inherited method");
        // }
    }
}