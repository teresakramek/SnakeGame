using System;
namespace Snake
{
	public class DrawSnake
	{
		public static void Draw(Pixel hoofd)
		{
            Console.SetCursorPosition(hoofd.xPos, hoofd.yPos);

            Console.Write("■");
        }

		public static void DrawTail(List<int> tail)
        {
		    for (int i = 2; i < tail.Count - 1; i += 2)
            {
                Console.SetCursorPosition(tail[i], tail[i-1]);
                Console.Write("■");
            }
		}
	}
}

