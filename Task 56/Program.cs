
//  Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();

int[,] array = GetArray(6, 4, 0, 20);
int linesum = CountAmount(array, 6);
PrintArray(array, linesum);

void PrintArray(int[,] array, int linesum)
{
    string box = "  ";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > 9)
                box = " ";
            else
                box = "  ";
            Console.Write(box + $" {array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {linesum} строка ");
}

int CountAmount(int[,] array, int columnSize)
{

    int[] tempSum = new int[columnSize];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempSum[i] = tempSum[i] + array[i, j];
        }
    }

    int max = tempSum[0];
    int index = 0;
    for (int i = 0; i < tempSum.Length; i++)
    {
        if (max > tempSum[i])
        {
            max = tempSum[i];
            index = i;
        }

    }
    return index +1 ;

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