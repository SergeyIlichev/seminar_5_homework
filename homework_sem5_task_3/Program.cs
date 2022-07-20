/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

// я взял обычные рандомные числа, не стал вникать, что такое вещественные, прошу прощения за такой беспредел

int[] GetArray(int dimension)
{
    int[] arr = new int[dimension];
    Random randomizer = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomizer.Next(1, 100);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void MaxMinDifference(int[] arr)
{
    int max = 0;
    int min = arr[0];
    int diff = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
        if (arr[i] < min)
            min = arr[i];
        diff = max - min;
    }
    Console.WriteLine($"Разность максимального числа массива {max} и минимального числа массива {min} = {diff}");
}
Console.WriteLine("Введиите количество элементов массива");
int range = int.Parse(Console.ReadLine());
int[] array = GetArray(range);
PrintArray(array);
MaxMinDifference(array);
