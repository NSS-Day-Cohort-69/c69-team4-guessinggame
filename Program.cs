Console.WriteLine(@"Welcome to the guessing game!
Enter your guess:");


int SecretNumber = 42;

int counter = 0;
while (counter < 4)
{
    Console.WriteLine($"Guesses: #{counter}");
    counter ++;
    int UserGuess = int.Parse(Console.ReadLine());
    if (UserGuess == SecretNumber)
    {
        Console.WriteLine("WAOW!!!!!");
        return;
    }
    else
    {
        Console.WriteLine("scrub");
    }
}

