namespace CSharpDSA.Sorting;

public class BubbleSortOptimized<T> where T : IComparable<T>
{
    public static void Sort(T[] array)
    {
        int i = 0;
        bool swapped = true;
        
        while (swapped)
        {
            swapped = false;

            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (Greater(array, j, j + 1))
                {
                    Swap(array, j, j + 1);
                    swapped = true;
                }
            }
            i++;
        }
    }

    private static bool Greater(T[] array, int index1, int index2)
    {
        return array[index1].CompareTo(array[index2]) > 0;
    }

    private static void Swap(T[] array, int index1, int index2)
    {
        (array[index1], array[index2]) = (array[index2], array[index1]);
    }
}
