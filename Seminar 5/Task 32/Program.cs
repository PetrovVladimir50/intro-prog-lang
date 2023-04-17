// Задача №32: Напишите программу, которая заменяет элементы массива (числа) противоположными.

int[] GenArray(int size, int max, int min)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Random rnd = new Random();
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void InvertArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;

    }
}

void PrintArray1D(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.WriteLine("]");
}

int[] array = GenArray(10,99,-99);

PrintArray1D(array);
InvertArray(array);
PrintArray1D(array);

