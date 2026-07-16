int predefined = 98;

int guess = -1;
int attempts = 0;

while (guess != predefined)
{
    Console.Write("Make your guess : ");
    guess = Convert.ToInt32(Console.ReadLine());
    attempts++;

    if(guess > predefined)
    {
        Console.WriteLine("Guess Lower");
    }
    else if(guess < predefined)
    {
        Console.WriteLine("Guess Higher");
    }
}

Console.WriteLine("Congratulations! You guessed the number in " +  attempts + " attempts");

