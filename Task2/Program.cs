int [] array = { 7, 0, -4, 3, 1, -2, 5 };

for (int i = 1; i < array.Length - 1; i++)
{
    for (int j = 0; j < array.Length - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]}\t");
    }
    Console.WriteLine();
}
