public static class Sorting
{
    public static void SortSelection(int[] collection)
    {
        int size = collection.Length;
        for (int i = 0; i < size - 1; i++)
        {
            int posmin = i;
            for (int j = i + 1; j < size; j++) 
            {
                if (collection[j] < collection[posmin]) posmin = j;
            }
            int temp = collection[i];
            collection[i] = collection[posmin];
            collection[posmin] = temp;
        }
    }
}