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

        }
    }
}
