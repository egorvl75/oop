using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(); // создание экземпляра класса 
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            p1.Draw();

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';
            Draw(p2.x, p2.y, p2.sym);

            int x3 = 10;
            int y3 = 15;
            char sym3 = '$';
            Draw(x3, y3, sym3);
            Console.ReadLine();

        }
        static void Draw (int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
    }
}
