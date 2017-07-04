using System;

namespace Snake_OOP
{
    public class FoodCreator : IFoodCreator
    {
        private readonly int mapHeight;
        private readonly int mapWidth;
        private readonly Random random = new Random();
        private readonly char sym;

        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        public Point CreateFood() => new Point(random.Next(1, mapWidth - 1), random.Next(1, mapHeight - 1), sym);
    }
}