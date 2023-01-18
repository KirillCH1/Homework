
//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.



Console.Clear();
int[] array = СreateNewArray(5);
int evenNum = DefineEvenNumbers(array);
PrintArray(array,evenNum);



void PrintArray(int[] array, int evenNumbers)
{
    Console.WriteLine($"[{String.Join(", ", array)}] четных чисел --> {evenNum}");
}

int DefineEvenNumbers(int[] array)
{
    int evenNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenNum++;
        }
    }
    return evenNum;
}

int[] СreateNewArray(int size)
{
    var rnd = new Random();
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(100, 999);
    }

    return array;
}
