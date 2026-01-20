namespace SnakeGame
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            SpawnFood(); 
            var speed = 200;
            while (true)
            {
                ReadInput();
                MoveSnake();
                Draw();
              int currentSpeed = Math.Max(50, speed - (snake.Count - 3) * 5);
              Thread.Sleep(currentSpeed); 
            }
                
        }
         static int width = 30;
         static int height = 15;

        static List<(int x, int y)> snake = new List<(int, int)>
        {
            (10,7),
            (9,7),
            (8,7)
        };

        static (int x, int y) food;
        static Random random = new Random();
        enum Direction                   // Yonaliwi
        {
            Right,
            Left,
            Up,
            Down
        }
        static Direction direction = Direction.Right;

        static void Draw()
        {
            Console.Clear();

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // Ramka
                    if(x == 0 || x == width - 1 || y == 0 || y == height - 1)
                    {
                        Console.Write("~");
                    }
                    // Oqati
                    else if(x == food.x && y == food.y)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("X");
                        Console.ResetColor();
                    }
                    // ILON
                    else if(IsSnake(x, y)) 
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("o");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                    Console.WriteLine();
            }
            Console.SetCursorPosition(0, height);
            Console.Write($"Счёт: {snake.Count - 3}");
        }

                
        static bool IsSnake(int x, int y)
        {
            foreach (var part in snake)
            {
                if (part.x == x && part.y == y)
                {
                    return true;
                }
            }
            return false;
        }

        static void MoveSnake()
        {
            var head = snake[0];
            int newX = head.x;
            int newY = head.y;

            if (direction == Direction.Right) newX++;
            if (direction == Direction.Left) newX--;
            if (direction == Direction.Up) newY--;
            if (direction == Direction.Down) newY++;

            // Devor ga uriliw
            if(newX <= 0 || newX >= width - 1 || newY <= 0 || newY >= height - 1)
            {
                GameOver();
            }
            // Tanaga uriliw
            for(int i = 1; i < snake.Count;i++)
            {
                if (snake[i].x == newX && snake[i].y == newY)
                {
                    GameOver();
                }
            }
            // Ilonni xarakati
            snake.Insert(0, (newX, newY));
            // Oqat 
            if(newX == food.x && newY == food.y)
            {
                SpawnFood();
            }
            else
            {
                snake.RemoveAt(snake.Count - 1);
            }
           
        }
        static void ReadInput()
        {
            if (!Console.KeyAvailable) return;
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.W && direction != Direction.Down)
            {
                direction = Direction.Up;
            }
            if (key == ConsoleKey.S && direction != Direction.Up)
            {
                direction = Direction.Down;
            }
            if(key == ConsoleKey.A && direction != Direction.Right)
            {
                direction = Direction.Left;
            }
            if(key == ConsoleKey.D && direction != Direction.Left)
            {
                direction = Direction.Right;
            }
        }

        static void SpawnFood()
        {
            while (true)
            {
                var x = random.Next(1, width - 1);
                var y = random.Next(1, height - 1);
                if(!IsSnake(x, y))
                {
                    food = (x, y);
                    break;
                }
            }
        }

        static void GameOver()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("GAME OVER! Chicvordin!");
            Console.WriteLine($"Счёт: {snake.Count - 3}");
            Console.ReadKey();
            Environment.Exit(0);
        }

    }
}
