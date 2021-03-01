string GetFizzBuzz(int i) =>
    (i % 3, i % 5) switch {
        (0, 0) => "FizzBuzz",
        (0, _) => "Fizz",
        (_, 0) => "Buzz",
        _ => i.ToString()
    };

Console.Write("Please enter digit: ");

if (!int.TryParse(Console.ReadLine(), out var input))
{
    Console.WriteLine("Please enter digit");
    System.Environment.Exit(0);
}

for (int i = 0; i < input; i++)
{
    Console.WriteLine(GetFizzBuzz(i));
}
