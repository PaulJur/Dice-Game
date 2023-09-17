using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variables
            int playerRandom;
            int opppnentRandom;

            int playerScore = 0;
            int opppnentScore = 0;
            
            Random random = new Random();

            #endregion
            #region DiceLoop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll");
                Console.WriteLine(" ");
                Console.ReadKey();  

                playerRandom = random.Next(1,7);
                Console.WriteLine("Rolled: "+ playerRandom);

                opppnentRandom = random.Next(1,7);
                Console.WriteLine("Opponent rolled: " + opppnentRandom);

                Console.WriteLine("------------------");
                System.Threading.Thread.Sleep(1500);

                if (playerRandom > opppnentRandom)
                {
                    playerScore++;
                    Console.WriteLine("PLAYER WON ROUND");
                    Console.WriteLine(" ");
                }
                else if (opppnentRandom > opppnentScore)
                {
                    opppnentScore++;
                    Console.WriteLine("OPPONENT WON ROUND");
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("TIE");
                    Console.WriteLine(" ");
                }
                Console.WriteLine("Player Score: " + playerScore+" Opponent: "+ opppnentScore);
            }
            if(playerScore > opppnentScore)
            {
                Console.WriteLine("YOU WON");
                return;
            }else if(playerScore < opppnentScore)
            {
                Console.WriteLine("YOU LOST");
                return;
            }
            #endregion
            Console.ReadKey();
        }


    }


}