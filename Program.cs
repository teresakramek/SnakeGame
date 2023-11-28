using System;

using System.Collections.Generic;

using System.Linq;

using System.Threading;

using Snake;



class Program

{

    static void Main()

    {

        Console.WindowHeight = 16;

        Console.WindowWidth = 32;

        int screenwidth = Console.WindowWidth;

        int screenheight = Console.WindowHeight;

        Random randomnummer = new Random();

        Pixel hoofd = new Pixel();

        hoofd.xPos = screenwidth / 2;

        hoofd.yPos = screenheight / 2;

        hoofd.schermKleur = ConsoleColor.Red;

        string movement = "RIGHT";

        List<int> telje = new List<int>();

        int score = 0;

        List<int> teljePositie = new List<int>();

        teljePositie.Add(hoofd.xPos);

        teljePositie.Add(hoofd.yPos);

        DateTime tijd = DateTime.Now;

        string obstacle = "*";

        int obstacleXpos = randomnummer.Next(1, screenwidth);

        int obstacleYpos = randomnummer.Next(1, screenheight);

        while (true)
        {

            Console.Clear();

            //Draw Obstacle
            DrawObstacle.Draw(obstacleXpos, obstacleYpos, obstacle, hoofd, screenwidth, screenheight, score, telje);

            //Draw Snake
            DrawSnake.Draw(hoofd);

            //Game Logic
            GameLogic.Play(movement, hoofd);

            //Hitting an obstacle
            int newScore = GameLogic.HittingAnObstacle(hoofd, obstacleXpos, obstacleYpos, score, screenwidth, screenheight, randomnummer, teljePositie);
            
            if (newScore > score)
            {
                obstacleXpos = randomnummer.Next(1, screenwidth - 1);
                obstacleYpos = randomnummer.Next(1, screenheight -1);

                DrawObstacle.Draw(obstacleXpos, obstacleYpos, obstacle, hoofd, screenwidth, screenheight, score, telje);

                score = newScore;
            }
 
            //Collision with walls or with yourself
            GameLogic.gameOver(hoofd, screenwidth, screenheight, score, telje);

            Thread.Sleep(50);
        }

    }
 
}