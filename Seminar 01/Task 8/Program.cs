// На вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число N: ");
//Считываем данные с консоли
string? numLine = Console.ReadLine();

// Проверка на null
if(numLine!=null)
{
    int endNum = int.Parse(numLine);

    int lstNum = 1;

    string res = string.Empty;

    // Цикл
    while (lstNum<=endNum)
    {
        int remainder = lstNum % 2;
        if (remainder == 0)
        {
            res = res + lstNum + " ";
        }
        lstNum++;
    }
    Console.Write("Четные числа от 1 до N: ");
    Console.Write(res);
}
