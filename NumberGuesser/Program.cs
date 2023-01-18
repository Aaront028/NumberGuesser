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
