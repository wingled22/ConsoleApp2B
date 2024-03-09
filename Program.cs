using System;

namespace ConsoleApp2B
{

 



    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Width = 10;
            r.Height = 4;
            r.CalculatePerimeter();
            Console.WriteLine("perimeter is : " + r.Perimeter);

            Square s = new Square();
            s.Side = 5;
            s.CalculatePerimeter();
            Console.WriteLine("perimeter is : " + s.Perimeter);

        }
    }
}