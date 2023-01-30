
//Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();

int[,] array = new int[4, 4];

PrintArray(SpiraFilling(array));

int[,] SpiraFilling(int[,] array)
{
    int line = array.GetLength(0);
    int column = array.GetLength(1);
    int maximumNumbers = array.GetLength(0) * array.GetLength(1);
    int currentValue = 1;
    int start = 0;
    while (currentValue <= maximumNumbers)
    {


        for (int i = start; i < line; i++)  // вправо
        {
            array[start, i] = currentValue;
            currentValue++;
        }
        for (int i = start + 1; i < column; i++) // вниз
        {
            array[i, column - 1] = currentValue;
            currentValue++;
        }
        line--;
        column--;
        for (int i = line - 1; i > start; i--) // влево
        {
            array[line, i] = currentValue;
            currentValue++;
        }
        for (int i = column; i > start; i--) // вверх
        {
            array[i, start] = currentValue;
            currentValue++;
        }
        start++;
    }
    return array;
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