int CountNumbersDivisibleBy2or3or5(int min, int max)
{
    int count = max - min + 1;
    return count - count / 2 + count / 3 + count / 5 - count / (2 * 3) - count / (2 * 5) - count / (3 * 5) + count / (2 * 3 * 5);
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

Console.WriteLine("Count how many numbers divisible by 2, 3 and 5 without a remainder. Input digits or something else or CTRL+C for exit");
var min = ParseDigit("Input minimum number of range (inclusive): ");
var max = ParseDigit("Input maximum number of range (inclusive): ");

Console.WriteLine($"Range from {min} to {max} has {CountNumbersDivisibleBy2or3or5(min, max)} numbers that divisible by 2, 3 and 5 without a remainder");