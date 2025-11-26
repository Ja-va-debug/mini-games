using System;
Console.WriteLine("Welcome to the number guessing game!");
int choice = 1;
do
{
    game();
    Console.WriteLine("Would you like to play again?");
    Console.WriteLine("1-Yes");
    Console.WriteLine("2-No");
    choice = int.Parse(Console.ReadLine());
}
while (choice == 1);

static void game()
{
    Console.WriteLine("Please enter the minimum value.");
    int min = int.Parse(Console.ReadLine());
    Console.WriteLine("Please enter the maximum value.");
    int max = int.Parse(Console.ReadLine());
    if (min >= max)
    {
        Console.WriteLine("The minimum value cannot be greater than or equal to the maximum value, please try again");
        return;
    }
    Console.WriteLine("Please enter the number of attempts you would like knowing that you have a maximum of " + max / 2 + " attempts");

int attempts = int.Parse(Console.ReadLine());
    if (attempts < 1 || attempts > max / 2)
    {
        Console.WriteLine("The number of attempts must be between 1 and {0}, please try again", max / 2);
        return;
    }

    Console.WriteLine("You have {0} guesses in a range between {1} to {2}, good luck :) ", attempts, min, max);
    Random r = new Random();
    int number = r.Next(min, max + 1);
    for (int i = 0; i < attempts; i++)
    {

        Console.WriteLine("please enter the {0} guess", i + 1);
        int guess = int.Parse(Console.ReadLine());
        if (guess == number)
        {
            Console.WriteLine("Congratulations, you guessed the number correctly :D!");
            break;
        }
        else
        {
            if (guess < number)
            {
                Console.WriteLine("Sorry, you guessed the wrong number!");
                Console.WriteLine("Hint <3 The number is greater than your guess");
            }
            else
            {
                Console.WriteLine("Sorry, you guessed the wrong number!");
                Console.WriteLine("Hint <3 The number is less than your guess");
            }
            if (i == attempts - 1)
            {
                Console.WriteLine("Sorry, you have no more guesses left :(");
                Console.WriteLine("The number was {0}", number);
            }

        }

    }
}