// Задача №19: Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// (Решение для чисел любого размера. Так показалось интереснее.)
// (Решение с Dictionary в папке Task 19.2)

// Чтение данных пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

// Проверка на палиндром
bool CheckPal(int num)
{
    bool result = true;

    char[] numList = num.ToString().ToCharArray();

    // Нахожу индекс последнего элемент списка
    int lastElement = numList.Length - 1;

    // Первого элемента
    int firstElement = 0;

    // Кол-во пар для сравнения для цикла
    int pairs = numList.Length / 2;

    // Цикл сравнивает и прерывается, когда элементы пары не равны
    while (firstElement < pairs)
    {
        if (numList[firstElement] != numList[lastElement])
        {
            result = false;
            break;
        }
        firstElement++;
        lastElement--;
    }

    return result;
}

int num = ReadData("Введите число для проверки: ");
Console.WriteLine(CheckPal(num));






