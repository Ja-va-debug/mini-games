using System.Diagnostics.Metrics;

namespace rock_paper_scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            int counter = 0;
            List<string[]> scores = new List<string[]>();
            while (run)
            {
                Console.WriteLine("Please choose an option!");
                Console.WriteLine("1- Play rock paper scissors");
                Console.WriteLine("2- View previous scores and rounds");
                Console.WriteLine("3- Exit");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Game(scores);
                        counter += 1;
                        break;

                    case 2:
                        for (int i = 0; i< counter; i++)
                        {
                            Console.WriteLine($"Game {i+1} scores:");
                            foreach (string m in scores[i])
                            { Console.WriteLine(m); }
                           
                        }
                        break;

                    case 3:
                        run = false;
                        break;
                }    

            }
        }
        static void Game(List<string[]> scores)
        {
            Console.WriteLine("Please enter the number of rounds you'd like to play!");
            int round = int.Parse(Console.ReadLine());
            Random c = new Random();
            int p_score = 0;
            int c_score = 0;
            string player;
            string computer = "";
            string[] round_scores = new string[round];
            for (int i = 0; i < round; i++)
            {
                int comp = c.Next(1, 4);
                Console.WriteLine("Choose (R)ock, (P)aper or (S)cissors");
                player = Console.ReadLine().ToLower();
                if (player == "s" || player == "r" || player == "p")
                {
                    switch (player)
                    {
                        case "s":
                            player = "scissors";
                            break;
                        case "r":
                            player = "rock";
                            break;
                        case "p":
                            player = "paper";
                            break;
                    }

                    switch (comp)
                    {
                        case 1:
                            computer = "rock";
                            break;
                        case 2:
                            computer = "paper";
                            break;
                        case 3:
                            computer = "scissors";
                            break;

                    }
                    Console.WriteLine($"Player: {player}");
                    Console.WriteLine($"Computer: {computer}");
                    if (computer == player)
                    {
                        p_score += 1;
                        c_score += 1;
                        Console.WriteLine("It's a draw!");
                    }
                    else
                    {
                        switch (player)
                        {
                            case "rock":
                                if (computer == "paper")
                                {
                                    c_score += 1;
                                    Console.WriteLine("You lose this round :(");

                                }
                                else
                                {
                                    p_score += 1;
                                    Console.WriteLine("You win this round :)");
                                }
                                break;
                            case "paper":
                                if (computer == "scissors")
                                {
                                    c_score += 1;
                                    Console.WriteLine("You lose this round :(");
                                }
                                else
                                {
                                    p_score += 1;
                                    Console.WriteLine("You win this round :)");
                                }
                                break;
                            case "scissors":
                                if (computer == "rock")
                                {
                                    c_score += 1;
                                    Console.WriteLine("You lose this round :(");
                                }
                                else
                                {
                                    p_score += 1;
                                    Console.WriteLine("You win this round :)");
                                }
                                break;
                        }

                    }
                   
                  
                  round_scores[i] = $"Round {i + 1} scores: player = {p_score}, computer: {c_score}";
                    
                   

                }
                else
                {
                    Console.WriteLine("invalid choice please try again!");
                    return;
                }

            }
            scores.Add(round_scores);
            Final_Results(p_score, c_score);
        }


            static void Final_Results(int p, int c)
            {
                if (p == c)
                {
                    Console.WriteLine("This game was a draw!");
                }
                else if (p < c)
                { Console.WriteLine("Unfortunately, you have lost this game :("); }
                else Console.WriteLine( "Congrats!! You have won this game :)");
            }
        
    }
}
