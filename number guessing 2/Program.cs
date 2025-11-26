namespace number_guessing_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            int choice = 1;
            do
            {
                game();
                Console.WriteLine("Would you like to play again?");
                Console.WriteLine("1-Yes");
                Console.WriteLine("2-No");
                choice= int.Parse(Console.ReadLine());
                if (choice<1 || choice > 2)
                {
                    Console.WriteLine("Invalid choice, please try again");
                    return;

                }
               
            }
            while (choice == 1);
        }

        static void game()
        {
            int score = 0;
            Console.WriteLine("Please choose your difficulty.");
            Console.WriteLine("1- Easy \n 2- Medium \n 3- Hard \n 4- Extreme");
            int diff = int.Parse(Console.ReadLine());

            if (diff > 4 || diff < 1)
            {
                Console.WriteLine("Invalid choice, please try again");
                return;
            }
            

            switch (diff)
            {
                case 1:
                    Random r = new Random();
                    int number_1 = r.Next(1, 10);
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("please enter the {0} guess", i + 1);
                        int guess_1 = int.Parse(Console.ReadLine());
                        if (guess_1 == number_1)
                        {
                            Console.WriteLine("Congratulations, you guessed the number correctly :D!");
                            break;
                        }
                        else
                        {  if (i < 2)
                            {
                                if (guess_1 < number_1)
                                {
                                    Console.WriteLine("Sorry, you guessed the wrong number!");
                                    Console.WriteLine("Hint <3 The number is greater than your guess");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, you guessed the wrong number!");
                                    Console.WriteLine("Hint <3 The number is less than your guess");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Sorry, you have no more guesses left :(");
                                Console.WriteLine("The number was {0}", number_1);
                            }
                            
                        }
                  
                    }
                    break;

                case 2:
                    Random n = new Random();
                    int number_2 = n.Next(1, 10);
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("please enter the {0} guess", i + 1);
                        int guess_2 = int.Parse(Console.ReadLine());
                        if (guess_2 == number_2)
                        {
                            Console.WriteLine("Congratulations, you guessed the number correctly :D!");
                            break;
                        }
                        else
                        { if (i < 4)
                            {
                                if (guess_2 < number_2)
                                {
                                    Console.WriteLine("Sorry, you guessed the wrong number!");
                                    Console.WriteLine("Hint <3 The number is greater than your guess");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, you guessed the wrong number!");
                                    Console.WriteLine("Hint <3 The number is less than your guess");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Sorry, you have no more guesses left :(");
                                Console.WriteLine("The number was {0}", number_2);
                            }
                        }
                    }
                        break;
                case 3:
                    Random m = new Random();
                    int number_3 = m.Next(1, 100);
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("please enter the {0} guess", i + 1);
                        int guess_3 = int.Parse(Console.ReadLine());
                        if (guess_3 == number_3)
                        {
                            Console.WriteLine("Congratulations, you guessed the number correctly :D!");
                            break;
                        }
                        else
                        { if (i < 2)
                            {
                                if (guess_3 < number_3)
                                {
                                    Console.WriteLine("Sorry, you guessed the wrong number!");
                                    Console.WriteLine("Hint <3 The number is greater than your guess");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, you guessed the wrong number!");
                                    Console.WriteLine("Hint <3 The number is less than your guess");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Sorry, you have no more guesses left :(");
                                Console.WriteLine("The number was {0}", number_3);
                            }
                        }

                    }
                    break;
                case 4:
                    Random j = new Random();
                    int number_4 = j.Next(1, 100);
                        Console.WriteLine("please enter the only guess");
                        int guess_4 = int.Parse(Console.ReadLine());
                        if (guess_4 == number_4)
                        {
                            Console.WriteLine("Congratulations, you guessed the number correctly :D!");                       
                            break;
                        }
                        else
                        
                            {
                                Console.WriteLine("Sorry, you guessed incorrectly :(");
                                Console.WriteLine("The number was {0}", number_4);
                            }
                    break;
            }
        }



    }
    }
            

           