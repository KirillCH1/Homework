
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();

Console.Write("Введите количество строк в массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов в массива: ");
int collums = int.Parse(Console.ReadLine() ?? "");

PrintArray(GetArray(rows, collums, -100, 100));

double[,] GetArray(int rows, int collums, int minV, int maxV)
{
    double[,] array = new double[rows, collums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < collums; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(minV, maxV)) / 10;
        }
    }
    return array;
}
void PrintArray(double[,] array)
{
    string size;
    string box;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            box = Convert.ToString(array[i, j]);
            if (box.Length == 1)
                size = "    ";
            else if (box.Length == 2)
                size = "   ";
            else if (box.Length == 3)
                size = "  ";
            else
                size = " ";
            Console.Write($"{size}" + $"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}