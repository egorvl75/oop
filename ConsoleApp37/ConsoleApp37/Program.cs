using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 3;
            char sym1 = '*';
            Draw(x1, y1, sym1);

            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';
            Draw(x2, y2, sym2);

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
