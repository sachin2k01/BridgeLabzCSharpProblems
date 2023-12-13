using System;


namespace PS2
{
    public class PS7
    {
        static void Main(string[] args)
        {
            string[] game = { "rock", "paper", "scissor" };
            Random random = new Random();
            string device = game[random.Next(game.Length)];
            
            Console.WriteLine("Welcome to Rock Paper Scissor Game...");
            Console.WriteLine();
            Console.WriteLine("Choose your choice");
            Console.WriteLine("Choose 1 for Rock");
            Console.WriteLine("Choose 2 for Paper");
            Console.WriteLine("Choose 3 for Scissor");
            int op=int.Parse(Console.ReadLine());
            string user = userChoice(op);

            Console.WriteLine("Device choice: " + device);
            Console.WriteLine("Your choice: " + user);

            if(user.Equals(device))
            {
                Console.WriteLine("Both are Same Draw..");
            }
            else if(user=="rock" &&  device=="scissor" || user=="paper" && device=="rock"|| user == "scissor" && device == "paper")
            {
                Console.WriteLine("Yow Won");
            }
            else if(user=="paper" && device=="scissor" || user=="scissor" && device=="rock" || user=="rock" && device=="paper")
            {
                Console.WriteLine("You lose");
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }


        }

        public static string userChoice(int ch)
        {
            if(ch==1)
            {
                return "rock";
            }
            else if(ch==2)
            {
                return "paper";
            }
            else if(ch==3)
            {
                return "scissor";
            }
            else { return "invalid"; }
        }
    }
}
