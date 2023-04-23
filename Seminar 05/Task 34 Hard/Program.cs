// Отсортировать массив методом пузырька и подсчета. Сравнить быстродействие методов.
// Проверку сортировки производить отдельно. Сначало запустить программу с одним методом 
// сортировки, а затем с другим. Проверять на длине массива не мение 10000 элементов.

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

int[] BubbleSort(int[] array)
{
  for (int i = 0; i < array.Length - 1; i++)
  {
    for (int j = 0; j < array.Length - 1; j++)
    {
      if (array[j] > array[j + 1])
      {
        int buffer = array[j];
        array[j] = array[j + 1];
        array[j + 1] = buffer;
      }
    }
  }
  return array;
}

int[] CountingSort(int[] array, int numOfValues)
{
  int[] count = new int[numOfValues + 1];
  for (int i = 0; i < array.Length; i++)
  {
    count[array[i]]++;
  }

  int index = 0;
  for (int i = 0; i < count.Length; i++)
  {
    for (int j = 0; j < count[i]; j++)
    {
      array[index] = i;
      index++;
    }
  }
  return array;
}

int[] array1 = GenArray(1000, 0, 10000);

DateTime d1 = DateTime.Now;
int[] array2 = CountingSort(array1,10000);
DateTime d2 = DateTime.Now;

DateTime d3 = DateTime.Now;
int[] array3 = BubbleSort(array1);
DateTime d4 = DateTime.Now;

Console.Write("Подсчет: ");
Console.WriteLine(d2-d1);

Console.Write("Пузырек: ");
Console.WriteLine(d4-d3);

// Сравнил по разному. Насколько понял, эффективность пузырьковой сортировка очень 
// чуствительная к длине массива (n^2), а эффективность подсчета к разбросу массива.



