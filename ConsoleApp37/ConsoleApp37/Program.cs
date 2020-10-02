using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*'); 
            p1.Draw();

           Point p2 = new Point(4, 5, '#');
            p2.Draw();

            Point p3 = new Point(10,15,'$');
            p3.Draw();
            Hor_Lines line = new Hor_Lines(5, 10, 8, '*');
            line.Drow();
            Vert_Lines linee = new Vert_Lines(5, 10, 8, '*');
            linee.draaw();

            Console.ReadLine();

        }

    }
}
