using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    internal class Game
    {
        private Food[] foods;
        private Snake snake;
        private int delay = 100;
        private int score;

        public Game()
        {
            foods = new Food[4];
            for (int i = 0; i < foods.Length; i++)
            {
                foods[i] = new Food();
                foods[i].foodPositionMaker();
                System.Threading.Thread.Sleep(10);
                foods[i].showFood();
            }
            snake = new Snake();
            snake.showSnake();
        }
        public void run()
        {
            while (true)
            {
                if(Console.KeyAvailable)
                {
                    snake.chaneDirection(Console.ReadKey());
                }


                snake.moveSnake();
                for (int i = 0; i < foods.Length; i++)
                {
                    if (foods[i].checkCollision(snake))
                    {
                        snake.growSnake();
                        foods[i].foodPositionMaker();
                        if (delay > 20)
                            delay -= 10;
                        score++;
                    }
                }
                
                if (snake.sankeSelfCollision())
                {
                    Console.Clear();
                    Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                    Console.Write("GAME OVER");
                    break;
                }
                    
                Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth/2, 0);
                Console.Write($"score: {this.score}");
                snake.showSnake();
                for (int i = 0; i < foods.Length; i++)
                {
                    foods[i].showFood();
                }
                System.Threading.Thread.Sleep(delay);

            }
        }
    }
    class Food
    {
        private string foodChar;
        public Position foodPosition;

        public Food(string foodChar = "@")
        {
            this.foodChar = foodChar;
            foodPosition = new Position();
            foodPositionMaker();
        }
        public void showFood()
        {
            Console.SetCursorPosition(foodPosition.x, foodPosition.y);
            Console.Write(foodChar);
        }
        public void foodPositionMaker()
        {
            int widht = Console.WindowWidth;
            int height = Console.WindowHeight;
            Random random = new Random();
            foodPosition.x = random.Next(0,widht);
            foodPosition.y = random.Next(0,height);
        }
        public bool checkCollision(Snake snake)
        {
            if (foodPosition.x == snake.snakeList[0].x && foodPosition.y == snake.snakeList[0].y)
                return true;
            return false;
        }
    }
    class Snake
    {
        private string snakeHead;
        private string snakeTail;
        public List<Position> snakeList = new List<Position>();
        private int snakeLenght;
        private Direction direction;

        public Snake(string snakeHead = "+", string snakeTail = "o", int snakeLenght = 3)
        {
            this.snakeHead = snakeHead;
            this.snakeTail = snakeTail;
            this.snakeLenght = snakeLenght;
            this.snakeList = new List<Position>();
            this.direction = Direction.right;
            makeSnake();
        }
        public void makeSnake()
        {
            int midWidht = Console.WindowWidth/2;
            int midHeight = Console.WindowHeight/2;
            for (int i = 0; i < snakeLenght; i++)
            {
                Position temp = new Position(midWidht - i,midHeight);
                snakeList.Add(temp);
            }
        }
        public void growSnake()
        {
            this.snakeLenght++;
            Position temp = new Position(snakeList[snakeList.Count-1].x, snakeList[snakeList.Count - 1].y);
            snakeList.Add(temp);
        }
        public void chaneDirection(ConsoleKeyInfo key) 
        {
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if(this.direction != Direction.down)
                        this.direction = Direction.up;
                    break;
                case ConsoleKey.DownArrow:
                    if (this.direction != Direction.up)
                        this.direction = Direction.down;
                    break;
                case ConsoleKey.LeftArrow:
                    if (this.direction != Direction.right)
                        this.direction = Direction.left;
                    break;
                case ConsoleKey.RightArrow:
                    if (this.direction != Direction.left)
                        this.direction = Direction.right;
                    break;
            }
        }
        public void moveSnake()
        {
            for (int i = snakeLenght - 1; i > 0; i--)
            {
                snakeList[i].x = snakeList[i - 1].x;
                snakeList[i].y = snakeList[i - 1].y;
            }
            switch (direction)
            {
                case Direction.up:
                    if (snakeList[0].y == 0)
                    {
                        snakeList[0].y = Console.WindowHeight;
                    }
                    snakeList[0].y--;
                    break;
                case Direction.down:
                    if (snakeList[0].y == Console.WindowHeight)
                    {
                        snakeList[0].y = 0;
                    }
                    snakeList[0].y++;
                    break;
                case Direction.left:
                    if (snakeList[0].x == 0)
                    {
                        snakeList[0].x = Console.WindowWidth - 1;
                    }
                    snakeList[0].x--;
                    break;
                case Direction.right:
                    if (snakeList[0].x == Console.WindowWidth - 1)
                    {
                        snakeList[0].x = 0;
                    }
                    snakeList[0].x++;
                    break;

            }
        }
        public void showSnake()
        {
            for (int i = 0; i < snakeLenght; i++)
            {
                Console.SetCursorPosition(snakeList[i].x, snakeList[i].y);
                if(i == 0)
                    Console.Write(snakeHead);
                else
                    Console.Write(snakeTail);
            }
        }

        public bool sankeSelfCollision()
        {
            for (int i = 1; i < snakeList.Count; i++)
            {
                if (snakeList[0].x == snakeList[i].x && snakeList[0].y == snakeList[i].y)
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Position
    {
        public int x;
        public int y;

        public Position()
        {

        }
        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    enum Direction
    {
        up,
        down,
        left,
        right,
        none
    }
}
