
//Напишите программу, которая заполнит спирально массив 4 на 4.

Console.Clear();


int[,] array = new int[4, 4];
PrintArray(SpiraFilling1(array));


int[,] SpiraFilling(int[,] array)
{
    int positionNumber = array[0, 0];
    int counter = 1;
    int line = array.GetLength(0);
    int column = array.GetLength(1);
    for (int j = 1; j < line * column + 1; j++)
    {
        for (int i = j - 1; i < line; i++)
        {
            array[j - 1, i] = counter;
            counter++;
        }
        column = column - 1;
        for (int i = j; i < column + 1; i++)
        {
            array[i, column] = counter;
            counter++;
        }
        line = line - 1;
        for (int i = line - 1; i > -1; i--)
        {
            array[line, i] = counter;
            counter++;
        }
        column = column - 1;
        for (int i = column; i > 0; i--)
        {
            array[i, j - 1] = counter;
            counter++;
        }
        line = line - 1;
    }
    return array;

}

int[,] SpiraFilling1(int[,] array)
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
        for (int i = line-1; i > start; i--) // влево
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