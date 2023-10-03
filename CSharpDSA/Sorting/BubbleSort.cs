namespace CSharpDSA.Sorting;

public class BubbleSort<T> where T : IComparable<T>
{
    public static void Sort(T[] array)
    {
        for (int i = 0; i < array.Length - 1; i++) 
        {
            for (int j = 0; j < array.Length - 1; j++) 
            {
                if (Greater(array, j, j + 1))
                {
                    Swap(array, j, j + 1);
                }
            }
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
