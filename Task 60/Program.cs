
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.



Console.Clear();

PrintArray(GetArray(2, 2, 2));

int[,,] GetArray(int x, int y, int z)
{
    Random rand = new Random();
    int[,,] array = new int[x, y, z];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = rand.Next(0, 99);
                CheckingMatches(array[i, j, k], i, j, k);
            }
        }
    }
    return array;
    void CheckingMatches(int nambArray, int z, int x, int c)
    {
        for (int i = 0; i < z; i++)
        {
            for (int j = 0; j < x; j++)
            {
                for (int k = 0; k < c; k++)
                {
                    if (nambArray == array[i, j, k])
                        array[i, j, k] = rand.Next(0, 99);
                }
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    string box = " ";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {

                if (array[i, j, k] > 9)
                    box = "";
                else
                    box = " ";
                Console.Write(box + $" {array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }

    }
    Console.WriteLine();
}