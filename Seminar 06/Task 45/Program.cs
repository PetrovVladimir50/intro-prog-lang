// Задача №45: Напишите программу, которая будет создавать копию заданного одномерного массива
// с помощью поэлементного копирования.

int[] arr = {5,8,9,2,};

int[] CopyArr(int[] arr)
{
    int[] outArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
       outArr[i]=arr[i];
    }
    return outArr;
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
// Страндартное средство
int[] outArr = new int[arr.Length];

arr.CopyTo(outArr,0);

PrintArray1D(arr);
PrintArray1D(CopyArr(arr));
PrintArray1D(outArr);