
//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии

Console.Clear();

Console.Write("Введите число: ");
int numbers = int.Parse(Console.ReadLine() ?? "");
Console.Write($" N = {numbers} -> \"");
OutputNaturalNumbers(numbers);


void OutputNaturalNumbers(int numbers)
{
    Console.Write($" {numbers},");
    numbers--;
    if (numbers == 1)
    {
        Console.Write($" {numbers}\"");
        return;
    }
    OutputNaturalNumbers(numbers);
}