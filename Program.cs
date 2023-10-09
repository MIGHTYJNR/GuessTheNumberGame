
// Project Name: Guess the Number Game

// Stepwise Procedure:
// 1. Create a new Console Application project.
// 2. Generate a random number between a specified range.
// 3. Prompt the user to guess the number and provide feedback (higher, lower, correct).
// 4. Allow the user a limited number of attempts.
// 5. Display a message indicating whether the user won or lost.
//Build Guess The Number Game

Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.Yellow;
Console.WriteLine("===Welcome to Odus Guess The Number Game===");
Console.ResetColor();

Console.WriteLine("Enter Your Nickname: "); //{0}
string nickname = Console.ReadLine()!;
Console.WriteLine("Enter Your Region: "); //{1}
string region = Console.ReadLine()!;
//Console.WriteLine("Welcome {0}! representing {1}." ,nickname, region);
Console.WriteLine("Welcome {0}! representing {1} \nType 'S' to start your game:",nickname, region);
string startGame = Console.ReadLine()!;


while (!startGame.Equals("S",StringComparison.OrdinalIgnoreCase))
    {
        MessageAndColor("Invalid Key Word Provided!.", ConsoleColor.DarkRed);
        Console.WriteLine("Type 'S' to start the game: ");
        startGame = Console.ReadLine()!;
    }

        Random random = new();
        int targetNum = random.Next(1, 101);
        int attempts = 5; //this isn't fixed, you can always change before running the game
    try
    {
        for (int i = 0; i < attempts; i++)
        {
            Console.Write($"Attempt {i + 1}: Enter your guess: ");
            int userGuess = int.Parse(Console.ReadLine()!);

            if (userGuess > 100)
                {
                    MessageAndColor("You loss!", ConsoleColor.Red);
                    MessageAndColor("Your guess is out of range!\nLucky numbers' range is 1-100.", ConsoleColor.Yellow);
                    continue;
                }
            else if (userGuess < targetNum)
                {
                    MessageAndColor("You loss!\nGuess a bit higher!", ConsoleColor.Red);
                }
            else if (userGuess > targetNum)
                {
                    MessageAndColor("You loss!\nGuess a bit Lowwer!", ConsoleColor.Red);
                }
            else
                {
                    MessageAndColor("Congratulations!\n You won! Your guess is CORRECT!", ConsoleColor.Green);
                    break;
                }
            if (i == 4)
                {
                    MessageAndColor($"Sorry, you're out of attempts. \nThe Lucky Number Was {targetNum}", ConsoleColor.Blue);
                    break;
                }
        } 
    }
    catch (Exception ex)
    {
        MessageAndColor(ex.Message);
    }

static void MessageAndColor(string message, ConsoleColor ConsoleColor=ConsoleColor.Red)
{
    Console.ForegroundColor = ConsoleColor;
    Console.WriteLine(message);
    Console.ResetColor();
}    
