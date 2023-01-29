
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

int[,] firstMatrix = GetArray(5, 5, 0, 10);
int[,] secondMatrix = GetArray(5, 5, 0, 10);
PrintArray(firstMatrix);
PrintArray(secondMatrix);
int[,] resultMatrix = MultiplicationTwoMatrices(firstMatrix, secondMatrix);
Console.WriteLine("Результирующая матрица будет:");
PrintArray(resultMatrix);

int[,] MultiplicationTwoMatrices(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] result = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                result[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return result;

}

void PrintArray(int[,] array)
{
    string box = " ";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > 9)
                box = "";
            else
                box = " ";
            Console.Write(box + $" {array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
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