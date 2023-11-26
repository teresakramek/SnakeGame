using System;
namespace Snake
{
	public class DrawObstacle
	{
		public static void Draw(int obstacleXpos, int obstacleYpos, string obstacle, Pixel hoofd, int screenwidth, int screenheight, int score, List<int> telje)
		{
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.SetCursorPosition(obstacleXpos, obstacleYpos);

            Console.Write(obstacle);



            Console.ForegroundColor = ConsoleColor.Green;

            Console.SetCursorPosition(hoofd.xPos, hoofd.yPos);

            Console.Write("■");



            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < screenwidth; i++)

            {

                Console.SetCursorPosition(i, 0);

                Console.Write("■");

            }

            for (int i = 0; i < screenwidth; i++)

            {

                Console.SetCursorPosition(i, screenheight - 1);

                Console.Write("■");

            }

            for (int i = 0; i < screenheight; i++)

            {

                Console.SetCursorPosition(0, i);

                Console.Write("■");

            }

            for (int i = 0; i < screenheight; i++)

            {

                Console.SetCursorPosition(screenwidth - 1, i);

                Console.Write("■");

            }

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Score: " + score);

            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("H");

            for (int i = 0; i < telje.Count(); i++)

            {

                Console.SetCursorPosition(telje[i], telje[i + 1]);

                Console.Write("■");

            }
        }
	}
}

