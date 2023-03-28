// Задача №12: Напишите программу, которая на вход будет принимать два числа 
// и будет выводить, является ли второе число кратным первому.
// Если оно не кратно, программа будет выводить остаток от деления.

// 1 Метод
int num1 = int.Parse(Console.ReadLine()??"0");

// 2 Метод (медленее)
int num2 = Convert.ToInt32(Console.ReadLine());

bool result = (num1%num2==0);

if (result)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine("Второе число не кратно первому");
    Console.Write("Остаток от деления: ");
    Console.WriteLine(num1%num2);
}