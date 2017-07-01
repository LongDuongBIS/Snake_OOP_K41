using System.Collections.Generic;

namespace Snake_OOP
{
    public class VerticalLine : Figure
    {
        public VerticalLine()
        {
        }

        public VerticalLine(int YTop, int YDown, int X, char Sym)
        {
            list = new List<Point>();
            for (int Y = YTop; Y <= YDown; Y++)
            {
                var p = new Point(X, Y, Sym);
                list.Add(p);
            }
        }
    }
}