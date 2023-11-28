using System;
namespace Snake
{
	public class GameLogic
	{
		public static void Play(string movement, Pixel hoofd)
		{
            ConsoleKeyInfo info = Console.ReadKey();

            switch (info.Key)

            {

                case ConsoleKey.UpArrow:

                    movement = "UP";

                    break;

                case ConsoleKey.DownArrow:

                    movement = "DOWN";

                    break;

                case ConsoleKey.LeftArrow:

                    movement = "LEFT";

                    break;

                case ConsoleKey.RightArrow:

                    movement = "RIGHT";

                    break;

            }

            if (movement == "UP")

                hoofd.yPos--;

            if (movement == "DOWN")

                hoofd.yPos++;

            if (movement == "LEFT")

                hoofd.xPos--;

            if (movement == "RIGHT")

                hoofd.xPos++;
        }

        public static void gameOver(Pixel hoofd, int screenwidth, int screenheight, int score, List<int> telje)
        {
            if (hoofd.xPos == 0 || hoofd.xPos == screenwidth - 1 || hoofd.yPos == 0 || hoofd.yPos == screenheight - 1)

            {

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;

                Console.SetCursorPosition(screenwidth / 5, screenheight / 2);

                Console.WriteLine("Game Over");

                Console.SetCursorPosition(screenwidth / 5, screenheight / 2 + 1);

                Console.WriteLine("Score is: " + score);

                Console.SetCursorPosition(screenwidth / 5, screenheight / 2 + 2);

                Environment.Exit(0);

            }

            for (int i = 2; i < telje.Count(); i += 2)

            {

                if (hoofd.xPos == telje[i] && hoofd.yPos == telje[i + 1])

                {

                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.SetCursorPosition(screenwidth / 5, screenheight / 2);

                    Console.SetCursorPosition(screenwidth / 5, screenheight / 2 + 1);

                    Console.WriteLine("Score is: " + score);

                    Console.SetCursorPosition(screenwidth / 5, screenheight / 2 + 2);

                    Environment.Exit(0);

                }

            }
        }
        public static int HittingAnObstacle(Pixel hoofd, int obstacleXpos, int obstacleYpos, int score, int screenwidth, int screenheight, Random randomnummer, List<int> teljePositie)
        {
            if (hoofd.xPos == obstacleXpos && hoofd.yPos == obstacleYpos)
            {
               score++;

               teljePositie.Insert(0, hoofd.xPos);
               teljePositie.Insert(1, hoofd.yPos);

               DrawSnake.DrawTail(teljePositie);

               return score;
            } 
            
            teljePositie.Insert(0, hoofd.xPos);
            teljePositie.Insert(1, hoofd.yPos);

            teljePositie.RemoveAt(teljePositie.Count - 1);
            teljePositie.RemoveAt(teljePositie.Count - 2);

            DrawSnake.DrawTail(teljePositie);

            return score;
        }
    }
}

