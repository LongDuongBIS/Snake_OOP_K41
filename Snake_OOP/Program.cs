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
            var tail = new Point(2, 2, '*');
            var snake = new Snake(tail, 5, Direction.RIGHT);
            snake.Draw();

            var errorMes = string.Empty;
            while (true)
            {
                if (snake.isHitTail())
                {
                    errorMes = "Đụng thân dòi mấy má ôi";
                    break;
                }
                snake.Move();

                Thread.Sleep(150);

                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }

            Console.SetCursorPosition(1, 20);
            Console.WriteLine(errorMes);

            Console.ReadLine();
        }
    }
}