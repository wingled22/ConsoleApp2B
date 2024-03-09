using System;

namespace ConsoleApp2B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(4, 10);
            Console.Write("enter height: ");
            r.Height = string.IsNullOrEmpty(Console.ReadLine().Trim()) ?  0 : Convert.ToInt32(Console.ReadLine().Trim());

            Console.Write("enter height: ");
            r.Width = string.IsNullOrEmpty(Console.ReadLine().Trim()) ?  0 :  Convert.ToInt32(Console.ReadLine().Trim());


            r.CalculatePerimeter();

        }
    }
}