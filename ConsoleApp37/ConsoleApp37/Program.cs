using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp37
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*'); // инкапсуляция 
           // p1.Draw();

            Point p2 = new Point(4, 5, '#');
           // p2.Draw();

            Point p3 = new Point(10,15,'$');
            //p3.Draw();

            List<int> nList = new List<int>();
            nList.Add(0);
            nList.Add(1);
            nList.Add(2);

            List<char> cList = new List<char>();
            cList.Add('@');
            cList.Add('$');
            cList.Add('%');

            Point point1 = new Point(nList[0], nList[0], cList[0]);
            Point point2 = new Point(nList[1], nList[1], cList[1]);
            Point point3 = new Point(nList[2], nList[2], cList[2]);

            List<Point> pList = new List<Point>();
            pList.Add(point1);
            pList.Add(point2);
            pList.Add(point3);

            foreach (Point i in pList)
            {
                i.Draw();
            }


            Console.ReadLine();

        }

    }
}
