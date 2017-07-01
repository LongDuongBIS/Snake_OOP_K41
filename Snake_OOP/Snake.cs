using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake_OOP
{
    public class Snake : Figure
    {
        private Direction direction;

        public Snake(Point tail, int length, Direction direction)
        {
            this.direction = direction;
            list = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                var p = new Point(tail);
                p.Move(i, this.direction);
                list.Add(p);
            }
        }

        public Snake()
        {
        }

        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    direction = Direction.LEFT;
                    break;

                case ConsoleKey.UpArrow:
                    direction = Direction.UP;
                    break;

                case ConsoleKey.RightArrow:
                    direction = Direction.RIGHT;
                    break;

                case ConsoleKey.DownArrow:
                    direction = Direction.DOWN;
                    break;
            }
        }

        public bool Eat(Point food)
        {
            var head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.Sym = head.Sym;
                list.Add(food);
                return true;
            }
            return false;
        }

        public bool isHitTail()
        {
            var head = list.Last();
            for (int i = 0; i < list.Count - 2; i++)
            {
                if (head.IsHit(list[i]))
                {
                    return true;
                }
            }
            return false;
        }

        public void Move()
        {
            var tail = list.First();
            list.Remove(tail);
            var head = GetNextPoint();
            list.Add(head);

            tail.Clear();
            head.Draw();
        }

        private Point GetNextPoint()
        {
            var head = list.Last();
            var nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }
}