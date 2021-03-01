Console.Write("Please enter digit: ");

if (!int.TryParse(Console.ReadLine(), out var input))
{
    Console.WriteLine("Please enter digit");
    System.Environment.Exit(0);
}

for(int i = 0; i < input; i++)
{
    if (i % 3 == 0)
        Console.Write("Fizz");
    if (i % 5 == 0)
        Console.Write("Buzz");
    if (i % 3 != 0 && i % 5 != 0)
        Console.Write(i.ToString());
    Console.WriteLine();
}