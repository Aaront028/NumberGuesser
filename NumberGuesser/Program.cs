// See https://aka.ms/new-console-template for more information

//Set app vars
string appName = "Number Guesser";
string appVersion = "1.0.0";
string appAuthor = "Brad Traversy";

// Change text color
Console.ForegroundColor = ConsoleColor.DarkGreen;


// Write out app info
Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

// Reset console color
Console.ResetColor();

// Ask users name
Console.WriteLine("What is your name?");

// Get user input
string name = Console.ReadLine();

Console.WriteLine("Hello {0}. Lets play a game!", name);

// Init correct number
//int correctNumber = 7;

// Create a new Random object
Random random = new Random();

int correctNumber = random.Next(1, 10);

// Init guess var
int guess = 0;

Console.WriteLine("Guess a number between 1 and 10");

// Whilte guess is not correct
while(guess != correctNumber) 
{
    // Get users input
    string input = Console.ReadLine();

    // Make sure its a number
    if(!int.TryParse(input, out guess))
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;


        // Write out app info
        Console.WriteLine("Please enter an actual number");

        // Reset console color
        Console.ResetColor();

        // Keep going
        continue;

    }

    // Cast to int and put in guess
    guess = Int32.Parse(input);

    // Match guess to correct number
    if(guess != correctNumber)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;


        // Write out app info
        Console.WriteLine("Wrong number please try again");

        // Reset console color
        Console.ResetColor();

    }
}

// Output success message

Console.ForegroundColor = ConsoleColor.Yellow;


// Write out app info
Console.WriteLine("You have guessed correctly!");

// Reset console color
Console.ResetColor();

