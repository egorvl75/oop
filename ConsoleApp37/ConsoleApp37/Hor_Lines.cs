using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp37
{
    class Hor_Lines : Figure
    {


        public Hor_Lines(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x =xLeft; x<= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

 
        }

    }

