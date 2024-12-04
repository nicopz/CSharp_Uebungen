using System;
using System.Collections.Concurrent;

public class Quicksort
{

    public static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;

        Console.WriteLine($"\n--- Partition (low={low}, high={high}, pivot={pivot}) ---");
        Console.WriteLine("Initial Array: ");
        print(array);

        for (int j = low;  j <= high - 1; j++)
        {
            if(array[j] < pivot)
            {
                i++;
                Swap(array, i, j);
                Console.WriteLine($"SWAP: array[{i}]={array[i]} ↔ array[{j}]={array[j]}");
                print(array);
            }
        }
        Swap(array, i + 1, high);
        Console.WriteLine($"SWAP (pivot): array[{i + 1}]={array[i + 1]} ↔ array[{high}]={array[high]}");
        print(array);

        Console.WriteLine($"--- Partition Done (pivot index={i + 1}) ---\n");
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
            int pivotIndex = Partition(array, low, high);
            Console.WriteLine($"\n>>> Recursively sorting left part (low={low}, high={pivotIndex - 1})");
            quicksort(array, low, pivotIndex - 1);

            Console.WriteLine($"\n>>> Recursively sorting right part (low={pivotIndex + 1}, high={high})");
            quicksort(array, pivotIndex + 1, high);
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
        int[] array = { 5, 3, 1, 9 };
        Console.WriteLine("Original Array:");
        print(array);

        Console.WriteLine("\nStarting Quicksort");
        quicksort(array, 0, array.Length - 1);

        Console.WriteLine("\nSorted Array:");
        print(array);
    }
}

