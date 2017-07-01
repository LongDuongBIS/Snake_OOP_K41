namespace Snake_OOP
{
    public interface IPoint
    {
        char Sym { get; set; }
        int X { get; set; }
        int Y { get; set; }

        void Clear();

        void Draw();

        bool IsHit(Point point);

        void Move(int offset, Direction direction);

        string ToString();
    }
}