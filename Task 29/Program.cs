
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

int[] array = new int[8];

PrintArray(ArrayInitialized(array));

void PrintArray(int[] array1)
{
    Console.Write("[");
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write(array1[i]);
        Console.Write(", ");
    }
    Console.Write("]");
}
int[] ArrayInitialized(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = GetNumberFromUser($"Введите {i + 1} число: ", "Ошибка Ввода");
    }
    return array;
}
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}