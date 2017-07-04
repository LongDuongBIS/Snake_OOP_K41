using System;
using System.Text;
using System.Threading;

namespace Snake_OOP
{
    public class Program
    {
        protected Program()
        {
        }

        private static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.SetBufferSize(200, 200);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Press 'Enter' to start the game ahihi");
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();

            var walls = new Walls(80, 25);
            walls.Draw();

            var p = new Point(4, 6, '*');
            var snake = new Snake(p, 5, Direction.RIGHT);
            snake.Draw();

            var foodCreator = new FoodCreator(80, 25, '$');
            var food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.isHitTail())
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }
            WriteGameOver();
            Console.ReadLine();
        }

        private static void WriteGameOver()
        {
            Console.SetCursorPosition(17, 12);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Thua rồi gà quá ahihi! Press any key to quit the game.");
        }
    }
}