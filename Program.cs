using System;

namespace helloworld
{
    class MainClass
    {

        static int highScore = 57;
        static string highScoreUser = "JaredRoss";

        static void Main(string[] args)
        {
            // Prompt for username
            Console.WriteLine("What is your username?");
            string localUsername = Console.ReadLine();

            // Prompt for score
            Console.WriteLine("What is your score?");
            int localScore = int.Parse(Console.ReadLine());

            CheckScore(localScore, localUsername);
        }

        public static void CheckScore(int localScore, string playerName)
        {
            if (localScore > highScore)
            {
                Console.WriteLine("Old high score: " + highScore + highScoreUser);
                Console.WriteLine("Congratulations {0}! Your score of {1} replaced the old high score of {2} set by {3}!", playerName, localScore, highScore, highScoreUser);
                highScore = localScore;
                highScoreUser = playerName;
                Console.WriteLine("New High Score: " + highScore + highScoreUser);
            } 
            else if (localScore == highScore)
            {
                Console.WriteLine("No rewards for a tie, but you tied the high score!");
            }
            else
            {
                Console.WriteLine("You stink! Try again!");
            }
        }
    }
}














