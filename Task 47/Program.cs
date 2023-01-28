
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();

Console.Write("Введите количество строк в массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов в массива: ");
int collums = int.Parse(Console.ReadLine() ?? "");

PrintArray(GetArray(rows, collums, 0, 100));

int[,] GetArray(int rows, int collums, int minV, int maxV)
{
    int[,] array = new int[rows, collums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < collums; j++)
        {
            array[i, j] = new Random().Next(minV, maxV + 1);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}