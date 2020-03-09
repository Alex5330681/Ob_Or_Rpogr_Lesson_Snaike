using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snaike_OOP_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {

             Point p1 = new Point(2, 4, '&'); 
            p1.Draw();

            Point p2 = new Point(12, 10, '%'); 
            p2.Draw();
        

            Console.ReadLine();


            //Point p1 = new Point(1, 3, '*');
            //Point p2 = new Point(4, 5, '#');

            //Console.WriteLine($"p1 = {p1.x}, {p1.y}, {p1.sym}");
            //Console.WriteLine($"p2 = {p2.x}, {p2.y}, {p2.sym}");

            //p1 = p2;
            //Console.WriteLine($"p1 = p2");

            //Console.WriteLine($"p1 = {p1.x}, {p1.y}, {p1.sym}");
            //Console.WriteLine($"p2 = {p2.x}, {p2.y}, {p2.sym}");

            //p2.x++;
            //p2.y++;
            //Console.WriteLine($"p2++");
            //Console.WriteLine($"p1 = {p1.x}, {p1.y}, {p1.sym}");
            //Console.WriteLine($"p2 = {p2.x}, {p2.y}, {p2.sym}");

            Console.ReadLine();
        }
    }
}