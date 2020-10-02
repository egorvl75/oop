using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 26); // window's size
            // Рамка
            Hor_Lines upline = new Hor_Lines(0, 78, 0, '+');
            Hor_Lines downline = new Hor_Lines(0, 78, 24, '+');
            Vert_Lines leftline = new Vert_Lines(0, 24, 0, '+');
            Vert_Lines rightline = new Vert_Lines(0, 24, 78, '+');
            upline.Drow();
            downline.Drow();
            leftline.Drow();
            rightline.Drow();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();
            Console.ReadLine();

        }

    }
}
