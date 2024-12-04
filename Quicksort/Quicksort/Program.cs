using System;
using System.Collections.Concurrent;

public class Quicksort
{

    public static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;

        for(int j = low;  j <= high - 1; j++)
        {
            if(array[j] < pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }
        Swap(array, i + 1, high);
        return i + 1;
    }

    public static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
   

    public static void quicksort(int[] array, int low, int high)
    {
        if(low < high)
        {
            int ret_piv = Partition(array, low, high);
            quicksort(array, low, ret_piv - 1);
            quicksort(array, ret_piv + 1, high);
        }
    }

    public static void print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write(array[i] + " ");
        }
        System.Console.Write("\n");

    }


    public static void Main(string[] args)
    {
        int[] array = { 5, 6, 1, 0, 5, 7, 8 };
        int n = array.Length;
        print(array);
        quicksort(array, 0, n-1);
        print(array);
    }
}

