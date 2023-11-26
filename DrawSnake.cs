using System;
namespace Snake
{
	public class DrawSnake
	{
		public static void Draw(Pixel hoofd)
		{
            Console.SetCursorPosition(hoofd.xPos, hoofd.yPos);

            Console.Write("■");

            Console.SetCursorPosition(hoofd.xPos, hoofd.yPos);

            Console.Write("■");

            Console.SetCursorPosition(hoofd.xPos, hoofd.yPos);

            Console.Write("■");

            Console.SetCursorPosition(hoofd.xPos, hoofd.yPos);

            Console.Write("■");
        }
	}
}

