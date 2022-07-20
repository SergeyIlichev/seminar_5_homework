/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

int[] GetArray(int dimension)
{
    int[] arr = new int[dimension];
    Random randomizer = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = randomizer.Next(1, 50);
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

void SumUnevenNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0)
        sum = sum + arr[i];
    }
    Console.WriteLine($"Cумма  нечетных чисел в массиве = {sum}");
}

Console.WriteLine("Введиите количество элементов массива");
int range = int.Parse(Console.ReadLine());
int[] array = GetArray(range);
PrintArray(array);
SumUnevenNumbers(array);
