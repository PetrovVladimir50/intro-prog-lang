Console.Write("Enter first number: ");
string? number1Line = Console.ReadLine();
Console.Write("Enter second number: ");
string? number2Line = Console.ReadLine();

if (number1Line!=null && number2Line!=null)
{
    int number1 = int.Parse(number1Line);
    int number2 = int.Parse(number2Line);

    if (number1>number2)
    {
        Console.Write("max: ");
        Console.WriteLine(number1);
    }
    else
    {
        Console.Write("max: ");
        Console.WriteLine(number2);
    }
}
