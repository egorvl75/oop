﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp37
{
    class Vert_Lines : Figure
    {
     

        public Vert_Lines (int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yUp; y<= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
          
        }
       
    }
}
