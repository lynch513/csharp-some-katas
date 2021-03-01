public bool IsNumberHasTwoAdjacentDigits(int number)
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


Console.WriteLine("Check that the number has adjacent digits. Input digit or something else or CTRL+C for exit");

while(true)
{
    Console.Write("Input number: ");
    var input = Console.ReadLine();
    if (!int.TryParse(input, out var digit))
        break;
    
    Console.WriteLine($"Number {digit} has adjacent numbers: {IsNumberHasTwoAdjacentDigits(digit)}");
}
