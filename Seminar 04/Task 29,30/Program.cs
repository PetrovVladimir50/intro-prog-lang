// Задача №30: Напишите программу, которая выводит массив из 8 элементов,
// заполненный 0 и 1 в случайном порядке.

// Создает и заполняет масив случайными числами
int[] GenArray01(int size, int max, int min)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Random rnd = new Random();
        array[i] = new Random().Next(min,max+1);
    }
    return array;
}

// Выводит массив в консоль
void PrintArray1D (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.Write("]");
}

// Чтение данных пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    int result = int.Parse(Console.ReadLine() ?? "0");
    return result;
}

int size = ReadData("Введите размер массива: ");
int max = ReadData("Введите макс. значение: ");
int min = ReadData("Введите мин. значение: ");

int[] array = GenArray01(size, max, min);
PrintArray1D(array);

