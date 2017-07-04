namespace Snake_OOP
{
    public interface IWalls
    {
        void Draw();

        bool IsHit(Figure figure);
    }
}