int[] RandArray (int size, int min, int max)
{
    int[] array = new int[size];
    for (int i=0; i<size; i++)
    {
        array[i]=new Random().Next(min, max+1);
    }
    return array;
}

int OddSum (int[] array)
{
    int sum=0;
    for (int i=1; i<array.Length; i+=2)
    {
        sum+=array[i];
    }
    return sum;
}

int[] newarray = RandArray (8, -20, 20);
Console.WriteLine(string.Join(" ", newarray));

Console.WriteLine($"{(OddSum(newarray))}");