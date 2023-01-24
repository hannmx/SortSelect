public static class Infrastructure
{
    public static int[] CreateArray()
    {
        int size, min, max = 0;
        Console.Write($"Введите размер массива: ");
        size = Convert.ToInt32(Console.ReadLine());

        Console.Write($"Введите минимум диапазона рандомных чисел: ");
        min = Convert.ToInt32(Console.ReadLine());

        Console.Write($"Введите максимум диапазона рандомных чисел: ");
        max = Convert.ToInt32(Console.ReadLine());

        return Enumerable.Range(1, size)
        .Select(item => Random.Shared.Next(min, max + 1))
        .ToArray();
    }

    public static void PrintArray(int[] array)
    {
        Console.WriteLine($"[{String.Join(',', array)}]");
    }
}
