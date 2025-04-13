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
