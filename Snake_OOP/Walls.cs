using System.Collections.Generic;

namespace Snake_OOP
{
    public class Walls : IWalls
    {
        private readonly List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();

            var upLine = new HorizontalLine(0, mapWidth, 0, '-');
            var downLine = new HorizontalLine(0, mapWidth, mapHeight, '-');
            var leftLine = new VerticalLine(0, mapHeight, 0, '|');
            var rightLine = new VerticalLine(0, mapHeight, mapWidth, '|');

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }

        public bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
    }
}