﻿int[] array = { 7, 0, -4, 3, 1, -2, 5 };
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}\t");
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
    for (int j= array.Length - (2); j>= i; j--)
    {
        if (array[j] > array[j+1])
        {
            int temp = array[j];
            array[j] = array[j+1];
            array[j+1] = temp;
        }
        
    }
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]}\t");
    }
    Console.WriteLine();
}