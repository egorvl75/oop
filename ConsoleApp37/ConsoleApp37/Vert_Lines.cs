using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp37
{
    class Vert_Lines
    {
        List<Point> vList;

        public Vert_Lines (int yDown, int yUp, int x, char sym)
        {
            vList = new List<Point>();
            for (int y = yDown; y<= yUp; y++)
            {
                Point p = new Point(x, y, sym);
                vList.Add(p);
            }
          
        }
        public void draaw()
        {
            foreach(Point p in vList)
            {
                p.Draw();
            }
        }
    }
}
