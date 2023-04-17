// Задача №35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите кол-во элементов массива, занчения которых лежат в отрезке (9,99).

int[] GenArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Random rnd = new Random();
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
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

int[] array123 = GenArray(123,-100,100);

int result = 0;
foreach (int i in array123)
{
    if (i>8 && i<100) result++;
}

PrintArray1D(array123);
Console.WriteLine("Элементов (9,99): " + result);






