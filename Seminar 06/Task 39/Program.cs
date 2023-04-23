// Задача №39: Напишите программу, которая перевернет одномерный массив.
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

int[] SwapArr(int[] arr)
{
  int[] newArray = new int[arr.Length];
  for (int i = 0; i<arr.Length;i++)
  {
    newArray[newArray.Length-1-i] = arr[i];
  }
  return newArray;
}

int[] array1 = GenArray(10,-10,10);
PrintArray1D(array1);
int[] array2 = SwapArr(array1);
PrintArray1D(array2);

