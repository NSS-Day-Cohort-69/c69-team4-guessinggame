Console.WriteLine(@"Welcome to the guessing game!
Enter your guess:");

Random random = new Random();

int SecretNumber = random.Next(1, 101);

int counter = 4;
while (counter > 0)
{
    Console.WriteLine($"Guesses Left: #{counter}");
    counter --;
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

