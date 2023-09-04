/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    int[] newArr = new int[size];
    return newArr;
}

void FillArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
        arr[i] = rnd.Next(100, 1000);
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int CountEvenNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
            count += 1;
    }
    return count;
}

int arrSize = InputNum("Введите размер массива: ");
int[] newArr = CreateArray(arrSize);
FillArray(newArr);
PrintArray(newArr);
int res = CountEvenNum(newArr);
Console.WriteLine($"Количество чётных чисел в массиве равно: {res}");
