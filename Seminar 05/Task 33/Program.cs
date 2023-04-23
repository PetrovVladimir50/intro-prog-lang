// Задача №33: Задайте массив. Напишите программу, определяющую,
// присутствует ли заданное число в массиве.

string ReadDataStr(string msg)
{
    Console.Write(msg);
    string line = Console.ReadLine() ?? "0";
    return line;
}

int ReadDataInt(string msg)
{
    Console.Write(msg);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

int[] StrToIntArray(string data, string simbol)
{
    string[] arrayStr = data.Split($"{simbol}");

    int[] arrayInt = new int[arrayStr.Length];

    for (int i = 0; i < arrayStr.Length; i++)
    {
        arrayInt[i] = int.Parse(arrayStr[i]);
    }
    return arrayInt;
}

void FindNumInArray(int[] arr, int num)
{
    bool findMarker = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            Console.WriteLine("Заданное число "+ (i+1) + "-е в массиве");
            findMarker = true;
        }

    }
    if (findMarker == false) Console.WriteLine("Такого элемента не найдено.");
}

string arrayLine = ReadDataStr("Введите массив через пробел: ");

int num = ReadDataInt("Введите число для поиска: ");

int[] array = StrToIntArray(arrayLine, " ");

FindNumInArray(array, num);




