
//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();

Console.Write("Введите количество строк в массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов в массива: ");
int collums = int.Parse(Console.ReadLine() ?? "");
int[,] array = GetArray(rows, collums, 0, 10);
PrintArray(array);
PrintArray(ArraySort(array));


int[,] ArraySort(int[,] array)
{
    for (int n = 0; n < array.GetLength(0); n++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                if (array[n, j] < array[n, j + 1])
                {

                    int temp = array[n, j];

                    array[n, j] = array[n, j + 1];

                    array[n, j + 1] = temp;
                }
            }
        }
        Console.WriteLine();
    }
    return array;
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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]}  ");
        }
        Console.WriteLine();
    }
}