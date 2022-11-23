// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

Console.WriteLine($"Введите позицию элимента в массиве для поиска, в формате АБ (А - строка, Б - столбец, без пробелов): ");
string position = Console.ReadLine();

int numPosition = int.Parse(position);
bool elements = false;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (numPosition == ((i + 1) * 10 + (j + 1)))
        {
            elements = true;
        }
    }
}
if (elements)
{
    Console.WriteLine($"Элемент на указанной позиции равен {array[(numPosition / 10 - 1), (numPosition % 10 - 1)]}");
}
else
{
    Console.WriteLine($"Такого элимента в массиве нет!");
}


// Найти число в массиве, есть или нет такое
// Console.Write("Введите число которое найти в массиве: ");
// int number = int.Parse(Console.ReadLine());
// int btrue = 0;
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     int sum = 0;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {

//         if (number == array[i, j])
//         {
//             btrue = 1;
//         }

//     }
// }
// if (btrue == 1)
// {
//     Console.WriteLine($"Число {number} есть в массиве");
// }
// else
// {
//     Console.WriteLine($"Числa {number} нет в массиве");
// }