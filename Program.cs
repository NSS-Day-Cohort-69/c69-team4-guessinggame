Console.Clear();
Console.WriteLine("Welcome to the guessing game!");

Random random = new Random();

int SecretNumber = random.Next(1, 101);

int counter = 0;
bool nightmare = false;
Console.WriteLine(@"Please select a difficulty level: 
    1. Easy
    2. Medium
    3. Hard
    4. Cheater");
string response = Console.ReadLine();
if (response =="1") 
{
    counter = 8;
} 
else if (response == "2") 
{
    counter = 6;
}
else if (response == "3")
{
    counter = 4;
} 
else if (response == "4") {
    counter = 10;
    nightmare = true;
}
else 
{
    Console.WriteLine("Invalid Entry.");
}
Console.WriteLine("Enter your guess:");







while (counter > 0)
{
    if (!nightmare) 
    {
    Console.WriteLine($"Guesses Left: #{counter}");
    counter--;
    }
    int UserGuess = int.Parse(Console.ReadLine());
    if (UserGuess == SecretNumber)
    {
        Console.WriteLine("WAOW!!!!!");
        return;
    }
    else
    {
        if (UserGuess > SecretNumber)
        {
            Console.WriteLine("Your guess was too high! Try again scrub..");
        }
        else 
        {
            Console.WriteLine("Your guess was too low. Try again scrub..");
        }
    }
}
Console.WriteLine($"The correct number was {SecretNumber}");
