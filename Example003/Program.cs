/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[] CreateArray(int size)
{
    double[] newArr = new double[size];
    return newArr;
}

void FillArray(double[] arr)
{
    Random rnd = new Random();
    int max = 10;
    int min = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round((rnd.NextDouble() + rnd.Next(min, max)), 2);
    }
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

void FindMaxMinDif(double[] arr)
{
    double minEl = arr[0];
    double maxEl = arr[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > maxEl)
            maxEl = arr[i];
        else if (arr[i] < minEl)
            minEl = arr[i];
    }
    double maxMinDif = Math.Round(maxEl - minEl, 2);
    Console.WriteLine($"Разность между максимальным эл-м массива {maxEl} и минимальным эл-м массива {minEl} равна {maxMinDif}");
}

int arrSize = InputNum("Введите размер массива: ");
double[] newArr = CreateArray(arrSize);
FillArray(newArr);
PrintArray(newArr);
FindMaxMinDif(newArr);