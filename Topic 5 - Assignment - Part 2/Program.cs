// See https://aka.ms/new-console-template for more information
// Carsen
Console.WriteLine("Part 2 - Worst Guessing Game Ever");
Console.WriteLine();

int secretNumber, guessedNumber;
secretNumber = 7;
Console.WriteLine("You are trying to guess a secret number. The possible range is from 1 to 10.");
Int32.TryParse(Console.ReadLine(), out guessedNumber);
if (guessedNumber == 7)
    Console.WriteLine("Congradulations, that's correct.");
else if (guessedNumber <= 6 || guessedNumber >= 8)
    Console.WriteLine("That's incorrect. The number is " + secretNumber + ".");
if (guessedNumber < 1 || guessedNumber > 10)
    Console.WriteLine("You weren't even in the range!");