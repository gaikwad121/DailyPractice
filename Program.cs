using System;
namespace project;
public class Programs
{
    static void Main(String[] args)
    {
        SwapNoWitThird();
        SwapNoWithoutThird();
        SwapNoWithoutThird1();
    }
    static void SwapNoWitThird()
    {
        int a = 10;
        int b = 45;
        Console.WriteLine("Before Swaping" + " " + a + " " + b);

        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine("After Swaping" + " " + a + " " + b);
    }
    static void SwapNoWithoutThird()
    {
        int a = 41;
        int b = 67;
        Console.WriteLine("Before Swaping" + " " + a + " " + b);

        a = a * b;
        b = a / b;
        a = a / b;
        Console.WriteLine("After Swaping" + " " + a + " " + b);

    }
    static void SwapNoWithoutThird1()
    {
        int a = 41;
        int b = 67;
        Console.WriteLine("Before Swaping" + " " + a + " " + b);

        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("After Swaping" + " " + a + " " + b);

    }

}
using System;
namespace project;
class Practice_Program
{
    static void Main()
    {
        // Program1();
        Program2();
        Program3();
        Program4();

    }
    static void Program1()
    {
        int[] arr = new int[5];
        Console.WriteLine("Enter the values of the array");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(arr[i] + " ");
        }
    }
    static void Program2()
    {
        string[] arr = { "apple", "banana", "cherry", "date", "elephant" };
        Console.WriteLine(string.Join(", ", arr)); // Fixed the issue by using string.Join to format the array as a string  
        Console.WriteLine(string.Format(", ", arr));
    }
    static void Program3()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.WriteLine(arr.Length);
    }
    static void Program4()
    // reverse array
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int i = 0; int j = arr.Length - 1;
        while (i < j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            i++;
            j--;
        }
        foreach (int a in arr)
        {
            Console.WriteLine(a);
        }
    }
}
