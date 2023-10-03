namespace CSharpDSA.Sorting.Tests;

public class BubbleSortTests
{
    [Test]
    public void Integer_Array()
    {
        int[] arr = new int[] { 3, 7, 2, 5, 6, 4, 3 };
        BubbleSort<int>.Sort(arr);
        int[] expected = new int[] { 2, 3, 3, 4, 5, 6, 7 };
        
        Assert.That(expected, Is.EqualTo(arr));
    }

    [Test]
    public void String_Array() 
    {
        string[] arr = new string[] { "Cathy", "John", "Caroline", "Isaac", "Monica" };
        BubbleSort<string>.Sort(arr);
        string[] expected = new string[] { "Caroline", "Cathy", "Isaac", "John", "Monica" };

        Assert.That(expected, Is.EqualTo(arr));
    }

    [Test]
    public void Duplicated_String_Item_Keep_Order()
    {
        string str1 = new("Caroline");
        string str2 = new("Caroline");
        string[] arr = new string[] { str1, str2, "Cathy", "Aaron" };
        BubbleSort<string>.Sort(arr);


        Assert.Multiple(() =>
        {
            Assert.That(arr[1], Is.SameAs(str1));
            Assert.That(arr[2], Is.SameAs(str2));
        });
    }
}
