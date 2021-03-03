int CountNumbersDivisibleBy2or3or5(int min, int max)
{
    int count = 0;
    for (int i = min; i <= max; i++)
    {
        if (i % 2 == 0 ||
            i % 3 == 0 ||
            i % 5 == 0)
        {
            count++;
        }
    }
    return count;
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