int[] array = {1, 2, 8, 47, 54, 0, 1, 2, 651, 3};

void PrintArray (int[] arr)
{
    int count = array.Length;
    for(int i = 0; i < count; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

PrintArray(array);

void SelectionSort (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[i]>array[j])
            {
                int remember = array[i];
                array[i] = array[j];
                array[j] = remember;
            }
        }
    }
    PrintArray(array);
}

SelectionSort(array);

