
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();


Console.Write("Введите строку массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите столбец массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");


int[,] array = GetArray(5, 5, 0, 100);
OutArray(array, rows, columns);

void OutArray(int[,] array, int rows, int columns)
{
    if (array.GetLength(0) > rows && array.GetLength(1) > columns)
    {
        Console.Clear();
        PrintArray(array);
        Console.WriteLine($"  -> {array[rows, columns]}");
    }

    else
    {
        Console.Clear();
        PrintArray(array);
        Console.WriteLine($"  {rows} {columns} -> такого элемента нет");
    }
}

int[,] GetArray(int rows, int columns, int minV, int maxV)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minV, maxV);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    string box = "  ";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > 9)
                box = "  ";
            else
                box = "   ";
            Console.Write($"{box}" + $"{array[i, j]}");
        }
        Console.WriteLine();
    }
}