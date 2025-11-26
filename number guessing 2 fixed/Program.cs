namespace number_guessing_2_fixed
{
    internal class Program
    {
        static List<int> Previous_scores = new List<int>();
        static void Main(string[] args)
        {
            bool run = true;
            int choice = 0;
            while (run)
            {
                Console.WriteLine("Welcome to the number guessing game!");
                    Game();
                Console.WriteLine("Would you like to play again?");
                Console.WriteLine("1- Yes \n2- No \n3- View previous scores instead");
                choice = int.Parse(Console.ReadLine());
                if (choice < 1 || choice > 3)
                {                                   
                    Console.WriteLine("Invalid choice! please try again");
                    return;

                }
                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        run = false;
                        break;
                    case 3:
                        scores();
                        break;
                }
            }
        }
        static void Game()
        {
            Console.WriteLine("Please choose a difficulty");
            Console.WriteLine("1- Easy (1 => 10, 3 attempts)");
            Console.WriteLine("2- Medium (1 => 100, 5 attempts)");
            Console.WriteLine("3- Hard (1 => 100, 3 attempts)");
            Console.WriteLine("4- Extreme (1 => 100, 1 attempt)");
            int diff = int.Parse(Console.ReadLine());
           if (diff<1 || diff>4)
            {
                Console.WriteLine("Invalid choice! please try again");
                return;
            }
            Random random = new Random();
            int attempts = 0;
            int comp_number = 0;
            int max = 0;

            switch (diff)
            {
                case 1:
                    attempts = 3;
                    max = 10;
                    comp_number = random.Next(1, max);
                    break;
                case 2:
                    attempts = 5;
                    max = 100;
                    comp_number = random.Next(1, max);
                    break;
                case 3:
                    attempts = 3;                    
                    max = 100;
                    comp_number = random.Next(1, max);
                    break;
                case 4:
                    attempts = 1;
                    max = 100;
                    comp_number = random.Next(1, max);
                    break;
            }
            int score = 0;            
            for (int i = 0; i<attempts; i++)
            {
                Console.WriteLine($"Please enter your {i+1} guess!");
                int guess = int.Parse(Console.ReadLine());
                if (guess < 1 || guess > max)
                {
                    Console.WriteLine($"Invalid choice! please make a guess between 1 and {max}");
                    i--;
                    continue;
                }
                if (guess == comp_number && attempts == 1)
                {
                    Console.WriteLine("Congrats! You have guessed correctly!");
                    score = 20;
                }

                if (guess == comp_number)
                {
                    Console.WriteLine("Congrats! You have guessed correctly!");
                    score = (attempts - i) * 2;
                    Console.WriteLine($"Your score is {score} after {i} guess/es");

                    break;
                }
                else
                {
                    if (i < attempts - 1)
                    {
                        Console.WriteLine($"You have guessed incorrectly");
                        Console.WriteLine( guess < comp_number ? "Hint :) The number is more than your guess" : "Hint :) The number is less than your guess");
                    }
                    else
                    {
                        Console.WriteLine($"Unfortunately, you have no more guesses left :( \n=> The number was {comp_number}");
                        Console.WriteLine($"Your score is {score} sadly :(");
                        score = 0;
                    }

                }
                
            }
            Previous_scores.Add(score);
        }

        static void scores()
        { for (int i = 0; i < Previous_scores.Count; i++)
            {
                Console.WriteLine($"You have a score of {Previous_scores[i]} at game {i + 1}");
            }
        }
    }
}
