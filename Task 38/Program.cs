
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.



Console.Clear();

double[] array = СreateNewArray(5);
double sum = FindingMiniMaxValue(array);
PrintArray(array, sum);



void PrintArray(double[] array, double sum)
{
    Console.WriteLine($"[{String.Join(", ", array)}] сумма нечетных позиций --> {sum}");
}

double FindingMiniMaxValue(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
            max = array[i];
        if (min > array[i])
            min = array[i];
    }
    return min + max;
}

double[] СreateNewArray(int size)
{
    var rnd = new Random();
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(-99, 99);
    }

    return array;
}
