
Random random = new Random();
int min = 1;
int max = 100;
int guess;
int guesses;
bool playAgain = true;
int number;
String response;

while (playAgain)
{
    guess = 0;
    guesses = 0;
    response = "";
    number = random.Next(min, max + 1);
    

    while (guess != number)
    {
        Console.WriteLine("Enter a number between " + min + " and " + max);
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Guess: " + guess);

        if (guess > number)
        {
            Console.WriteLine(guess + " is too high!");
        }
        else if (guess < number)
        {
            Console.WriteLine(guess + " is too low!");
        }
        else
        {
            Console.WriteLine("Yes you got it");
        }
        guesses++;
    }
    

    Console.WriteLine("Number: " + number);
    Console.WriteLine("YOU WIN");
    Console.WriteLine("Guesses: " + guesses);


    Console.WriteLine("Would you like to play again (Y/N): ");
    response = Console.ReadLine();
    response = response.ToUpper();

    if (response == "Y")
    {
        playAgain = true;
    } else
    {
        playAgain = false;
    }
}