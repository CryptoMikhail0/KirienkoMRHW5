/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

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
        arr[i] = rnd.Next(0, 100);
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int CountSumOdNum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
            sum += arr[i];
    }
    return sum;
}

int arrSize = InputNum("Введите размер массива: ");
int[] newArr = CreateArray(arrSize);
FillArray(newArr);
PrintArray(newArr);
int res = CountSumOdNum(newArr);
Console.WriteLine($"Сумма нечётных эллементов в массиве равна: {res}");