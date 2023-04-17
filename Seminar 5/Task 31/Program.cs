// Задача №31: Задайте массив из 12 элементов, заполненный случайными числами из (-9,9).
// Найдите сумму отрицательным и положительных элементов массива.

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

void PrintArray1D(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.WriteLine("]");
}

int[] NegPosSum(int[] array)
{
    int sumPos = 0;
    int sumNeg = 0;
    int[] outArray = new int[2];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sumPos += array[i];
        }
        else
        {
            sumNeg += array[i];
        }
    }
    outArray[0] = sumPos;
    outArray[1] = sumNeg;
    return outArray;
}

int[] array = GenArray(12, 9, -9);

int[] outArray = NegPosSum(array);

PrintArray1D(array);

Console.WriteLine("Сумма положительных: " + outArray[0]);
Console.WriteLine("Сумма отрицательных: " + outArray[1]);
