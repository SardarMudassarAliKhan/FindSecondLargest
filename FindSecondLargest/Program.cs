using System;

public class Program
{
    public static int FindSecondLargest(int[] arr, int key)
    {
        if (arr == null || arr.Length < 2)
        {
            throw new ArgumentException("Array must contain at least two elements.");
        }

        // Initialize first and second largest
        int firstLargest = int.MinValue;
        int secondLargest = int.MinValue;

        // Iterate through the array
        for (int i = 0; i < key; i++)
        {
            // Update firstLargest and secondLargest accordingly
            if (arr[i] > firstLargest)
            {
                secondLargest = firstLargest;
                firstLargest = arr[i];
            }
            else if (arr[i] > secondLargest && arr[i] != firstLargest)
            {
                secondLargest = arr[i];
            }
        }

        if (secondLargest == int.MinValue)
        {
            throw new InvalidOperationException("There is no second largest element in the array.");
        }

        return secondLargest;
    }

    public static void Main()
    {
        // Example array
        int[] arr = { 10, 4, 3, 50, 23, 90 };

        // Input key (size of array or part of it to be considered)
        int key = arr.Length;

        // Find second largest number
        int secondLargest = FindSecondLargest(arr, key);
        Console.WriteLine("The second largest number is: " + secondLargest);
    }
}
