
int CountNumbersDivisibleBy2or3or5Classic(int min, int max)
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

int CountNumbersDivisibleBy2or3or5Range(int min, int max) =>
    Enumerable.Range(min, max - min + 1).Where(i => i % 2 == 0 || i % 3 == 0 || i % 5 == 0).Count();

int CountNumbersDivisibleBy2or3or5Analytical(int min, int max)
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

var sw = new Stopwatch();

Console.WriteLine("Count how many numbers divisible by 2, 3 and 5 without a remainder. Input digits or something else or CTRL+C for exit");
var min = ParseDigit("Input minimum number of range (inclusive): ");
var max = ParseDigit("Input maximum number of range (inclusive): ");

Console.WriteLine("Analitical version:");

// Analytical
sw.Start();
var result = CountNumbersDivisibleBy2or3or5Analytical(min, max);
sw.Stop();

Console.WriteLine($"Range from {min} to {max} has {result} numbers that divisible by 2, 3 and 5 without a remainder");
Console.WriteLine($"Time elapsed: {sw.Elapsed}");
sw.Reset();

// Classic
sw.Start();
result = CountNumbersDivisibleBy2or3or5Classic(min, max);
sw.Stop();

Console.WriteLine("Classic version:");
Console.WriteLine($"Range from {min} to {max} has {result} numbers that divisible by 2, 3 and 5 without a remainder");
Console.WriteLine($"Time elapsed: {sw.Elapsed}");
sw.Reset();

// Range
sw.Start();
result = CountNumbersDivisibleBy2or3or5Range(min, max);
sw.Stop();

Console.WriteLine("Range version:");
Console.WriteLine($"Range from {min} to {max} has {result} numbers that divisible by 2, 3 and 5 without a remainder");
Console.WriteLine($"Time elapsed: {sw.Elapsed}");
