string GetFizzBuzz(int i) =>
    (i % 3 == 0, i % 5 == 0) switch {
        (true, false) => "Fizz",
        (false, true) => "Buzz",
        (true, true) => "FizzBuzz",
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
