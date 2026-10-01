using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
        int k = 3;

        Console.WriteLine("Before: " + string.Join(" ", numbers));
        Console.WriteLine("k = " + k);

        k = k % numbers.Length;

        int[] rotated = new int[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            rotated[(i + k) % numbers.Length] = numbers[i];
        }

        Console.WriteLine("After: " + string.Join(" ", rotated));
    }
}