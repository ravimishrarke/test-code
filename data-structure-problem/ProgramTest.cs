using System;

class ProgramTests
{
    public static void Test()
    {
        Test1();
        Test2();
        Test3();
        Test4();
        Test5();
    }

    public static void Test1()
    {
        int[] arr1 = { 1, 2, 2, 3, 4 };
        int[] arr2 = { 2, 2, 3, 3, 4, 6 };

        int[] result = Program.GetIntersection(arr1, arr2);

        Console.WriteLine("Test 1:");
        Console.WriteLine(string.Join(", ", result));
        Console.WriteLine();
    }

    public static void Test2()
    {
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = { 4, 5, 6 };

        int[] result = Program.GetIntersection(arr1, arr2);

        Console.WriteLine("Test 2:");
        Console.WriteLine(string.Join(", ", result));
        Console.WriteLine();
    }

    public static void Test3()
    {
        int[] arr1 = { };
        int[] arr2 = { 1, 2, 3 };

        int[] result = Program.GetIntersection(arr1, arr2);

        Console.WriteLine("Test 3:");
        Console.WriteLine(string.Join(", ", result));
        Console.WriteLine();
    }

    public static void Test4()
    {
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = {  };

        int[] result = Program.GetIntersection(arr1, arr2);

        Console.WriteLine("Test 4:");
        Console.WriteLine(string.Join(", ", result));
        Console.WriteLine();
    }

    public static void Test5()
    {
        int[] arr1 = { 1, 2, 3, 4, 5 };
        int[] arr2 = { 1, 6, 7, 8, 9, 10 };

        int[] result = Program.GetIntersection(arr1, arr2);

        Console.WriteLine("Test 5:");
        Console.WriteLine(string.Join(", ", result));
        Console.WriteLine();
    }
}