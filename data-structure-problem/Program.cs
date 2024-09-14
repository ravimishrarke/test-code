using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        ProgramTests.Test();
    }

    public static int[] GetIntersection(int[] arr1, int[] arr2)
    {
        Array.Sort(arr1);
        Array.Sort(arr2);

        List<int> result = new List<int>();

        for (int i = 0, j = 0; i < arr1.Length && j < arr2.Length;)
        {
            if (arr1[i] < arr2[j])
            {
                i++;
            }
            else if (arr1[i] > arr2[j])
            {
                j++;
            }
            else
            {
                if (result.Count == 0 || arr1[i] != result[result.Count - 1])
                {
                    result.Add(arr1[i]);
                }
                i++;
                j++;
            }
        }

        return result.ToArray();
    }
}



