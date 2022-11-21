// Задача 51 Задайте двухьерный массив. Найдите сумму элиментов, находящихся на главной диагонали (с индексами (0,0);(1,1) и тд)

Console.Write("Введите колличество сторок массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите колличество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
Console.WriteLine("исходный массив: ");
PrintArray(array);



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


int sum = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (i == j)
        {
            sum = array[i, j] + sum;
        }
    }
}
Console.WriteLine($"сумма диагонали: {sum}");