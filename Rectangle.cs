using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp2B
{
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        //constructor
        public Rectangle(){
            
        }
        public Rectangle(int x){
            
        }
        public Rectangle(int w, int h){
            Width = w;
            Height = h;
        }


        public void CalculatePerimeter(){
            int result = 2 * ( Width + Height);
            Console.WriteLine(
                "The perimeter for "+
                "this Rectangle is : " + result
            ); 
        }
        public void CalculatePerimeter(int x, int y){
            int result = 2 * ( x + y);
            Console.WriteLine(
                "The perimeter for "+
                "this Rectangle is : " + result
            ); 
        }
        public void CalculatePerimeter(double x, double y){
            double result = 2 * ( x + y);
            Console.WriteLine(
                "The perimeter for "+
                "this Rectangle is : " + result
            ); 
        }
    }
}


//   github.com/wingled22/ConsoleApp2B