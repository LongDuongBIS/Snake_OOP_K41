using System;

namespace Snake_OOP
{
    public class Point : IPoint
    {
        public Point()
        {
        }

        public Point(int X, int Y, char Sym)
        {
            this.X = X;
            this.Y = Y;
            this.Sym = Sym;
        }

        public Point(Point point)
        {
            this.X = point.X;
            this.Y = point.Y;
            this.Sym = point.Sym;
        }

        public char Sym { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Clear()
        {
            Sym = ' ';
            Draw();
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Sym);
        }

        public bool IsHit(Point point) => point.X == this.X && point.Y == this.Y;

        public void Move(int offset, Direction direction)
        {
            switch (direction)
            {
                case Direction.LEFT:
                    X -= offset;
                    break;

                case Direction.RIGHT:
                    X += offset;
                    break;

                case Direction.UP:
                    Y -= offset;
                    break;

                case Direction.DOWN:
                    Y += offset;
                    break;
            }
        }

        public override string ToString() => $"({X}, {Y}, {Sym})";
    }
}