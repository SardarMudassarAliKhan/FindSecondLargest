```csharp
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
```

### Explanation:
1. **Input Parameters**:
   - `int[] arr`: The array in which the second largest number is to be found.
   - `int key`: Specifies the number of elements to consider from the array (in this case, it’s the full length of the array).

2. **Algorithm**:
   - Traverse the array, keeping track of the largest and second-largest numbers.
   - If the current element is greater than the current largest, update both `firstLargest` and `secondLargest`.
   - If the current element is between the current largest and second-largest, only update `secondLargest`.

3. **Edge Case Handling**:
   - If the array has fewer than two elements, an `ArgumentException` is thrown.
   - If no distinct second-largest element exists (e.g., all elements are the same), an `InvalidOperationException` is thrown. 
