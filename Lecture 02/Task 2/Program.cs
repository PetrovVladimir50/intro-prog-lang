int[] array = {11,28,23,4,85,6,30,8,79};

int n = array.Length;

int find = 99;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.Write("Элемент в массиве под номером: ");
        Console.WriteLine(index);
        break;
    }
    index++; 
}

if (index == n)
{
    Console.WriteLine("Нужнего элемента не найдено");
}
