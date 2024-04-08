Console.WriteLine(@"Welcome to the guessing game!
                Enter your guess:");

int UserGuess = int.Parse(Console.ReadLine());

int SecretNumber = 42;

if (UserGuess == SecretNumber)
{
    Console.WriteLine("WAOW!!!!!");
}
else
{
    Console.WriteLine("scrub");
}