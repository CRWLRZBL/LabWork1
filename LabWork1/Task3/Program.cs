﻿int[] array = { 7, 0, -4, 3, 1, -2, 5 };
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}\t");
}
Console.WriteLine();
for (int i = 1; i < array.Length; i++)
{
    int k = array[i];
    int j = i - 1;

    while (j >= 0 && array[j] > k)
    {
        array[j + 1] = array[j];
        array[j] = k;
        j--;
    }
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]}\t");
}
Console.WriteLine();
