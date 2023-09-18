internal class Program
{
    private static void Main(string[] args)
    {
        double[] RandArray(int size, int min, int max)
        {
            double[] array = new double[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = new Random().Next(min, max) + new Random().NextDouble();
            }
            return array;
        }

        double GetMax(double[] arr)
        {
            double res = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > res)
                {
                    res = arr[i];
                }
            }
            return res;
        }

        double GetMin(double[] arr)
        {
            double res = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < res)
                {
                    res = arr[i];
                }
            }
            return res;
        }

        double[] newarray = RandArray(5, 0, 20);
        Console.WriteLine(string.Join(" ", newarray));

        double res = GetMax(newarray) - GetMin(newarray);
        Console.WriteLine($"Минимальное число: {GetMin(newarray)}");
        Console.WriteLine($"Максимальное число: {GetMax(newarray)}");
        Console.WriteLine($"Результат: {res}");
    }
}