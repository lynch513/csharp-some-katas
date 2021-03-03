bool IsNumberHasTwoAdjacentDigits(int number)
{
    int digit1, digit2;
    
    while (number > 0)
    {
        digit1 = number % 10;
        digit2 = number / 10;

        if (digit1 == digit2 % 10)
            return true;

        number = digit2;
    }
    return false;
}

int ParseDigit(string message)
{
    Console.Write(message);
    if (!int.TryParse(Console.ReadLine(), out var min))
    {
        Console.WriteLine("Please input digit");
        System.Environment.Exit(0);
    }
    return min;
}

Console.WriteLine("Count adjacent digits in a series of numbers. Input digits or something else or CTRL+C for exit");
var min = ParseDigit("Input minimum number in range (inclusive): ");
var max = ParseDigit("Input maximum number in range (inclusive): ");

var count = 0;

for(var i = min; i <= max; i++)
{
    if (IsNumberHasTwoAdjacentDigits(i))
        count++;
}

Console.WriteLine($"Range from {min} to {max} contain {count} numbers that have adjacent numbers");
Console.WriteLine($"Range from {min} to {max} contain {max - min + 1 - count} numbers that haven't adjacent numbers");
