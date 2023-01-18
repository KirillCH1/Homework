
//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.



Console.Clear();

int[] array = СreateNewArray(5);
PrintArray(array, SumOddElements(array));


void PrintArray(int[] array, int sum)
{
    Console.WriteLine($"[{String.Join(", ", array)}] сумма нечетных позиций --> {sum}");
}

int SumOddElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum += array[i];
    }
    return sum;
}

int[] СreateNewArray(int size)
{
    var rnd = new Random();
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(-99, 99);
    }

    return array;
}
