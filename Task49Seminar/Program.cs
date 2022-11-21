// Задание 49 задайте двухмерный массив. Найдите элименты, у которых оба индекса четные, и замените эти элименты на их квадраты

Console.Write("Введите колличество сторок массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите колличество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
Console.WriteLine("исходный массив: ");
PrintArray(array);
Console.WriteLine("искомый массив: ");
PrintArray2(array);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArray2(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                inArray[i, j] = inArray[i, j] * inArray[i, j];
            }
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}