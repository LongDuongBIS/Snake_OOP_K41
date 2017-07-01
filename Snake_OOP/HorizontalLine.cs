using System.Collections.Generic;

namespace Snake_OOP
{
    public class HorizontalLine : Figure
    {
        public HorizontalLine()
        {
        }

        public HorizontalLine(int XLeft, int XRight, int Y, char Sym)
        {
            list = new List<Point>();
            for (int X = XLeft; X <= XRight; X++)
            {
                var p = new Point(X, Y, Sym);
                list.Add(p);
            }
        }
    }
}