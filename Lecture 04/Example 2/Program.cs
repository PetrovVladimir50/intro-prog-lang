double Factorial (int num)
{
    if (num == 1 || num == 0) return 1;
    else return num * Factorial(num-1);
}
for (int i = 1; i < 30; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}