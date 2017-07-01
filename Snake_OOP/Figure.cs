using System.Collections.Generic;

namespace Snake_OOP
{
    public class Figure : IFigure
    {
        internal List<Point> list;

        public void Draw()
        {
            foreach (var p in list)
            {
                p.Draw();
            }
        }

        public bool IsHit(Figure figure)
        {
            foreach (var p in list)
            {
                if (figure.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsHit(Point point)
        {
            foreach (Point p in list)
            {
                if (p.IsHit(point))
                {
                    return true;
                }
            }
            return false;
        }
    }
}