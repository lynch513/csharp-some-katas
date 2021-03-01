string GetFizzBuzz(int i) =>
    i switch {
        _ when i % 3 == 0 && i % 5 == 0 => "FizzBuzz",
        _ when i % 3 == 0 => "Fizz",
        _ when i % 5 == 0 => "Buzz",
        _ => i.ToString()
    };

Console.Write("Please enter digit: ");

if (!int.TryParse(Console.ReadLine(), out var input))
{
    Console.WriteLine("Please enter digit");
    System.Environment.Exit(0);
}

Enumerable.Range(0, input)
    .ToList()
    .ForEach(i => Console.WriteLine(GetFizzBuzz(i)));
