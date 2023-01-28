
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


Console.Clear();

Console.Write("Введите количество строк в массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов в массива: ");
int collums = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, collums, -100, 100);
PrintArray(array);
ArithmeticMeanArray(array);

void ArithmeticMeanArray(int[,] array)
{
    Console.Write($"Cреднее арифметическое элементов в каждом столбце ->");
    for (int i = 0; i < array.GetLength(1); i++)
    {

        double arithmean = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            arithmean = arithmean + Convert.ToDouble(array[j, i]);
        }
        arithmean = arithmean / array.GetLength(0);
        Console.Write($" {arithmean};");
    }
}

int[,] GetArray(int rows, int collums, int minV, int maxV)
{
    int[,] array = new int[rows, collums];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < collums; j++)
        {
            array[i, j] = new Random().Next(minV, maxV);
        }
    }
    return array;
}
void PrintArray(int[,] array)
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