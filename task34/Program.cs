int[] RandArray (int size, int min, int max)
{
    int[] array = new int[size];
    for (int i=0; i<size; i++)
    {
        array[i]=new Random().Next(min, max+1);
    }
    return array;
}

int EvenCount (int[] array)
{
    int count=0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]%2==0)
        {
            count++;
        }
    }
    return count;
}

int[] newarray = RandArray (5, 100, 999);
Console.WriteLine(string.Join(" ", newarray));

Console.WriteLine($"{(EvenCount(newarray))}");