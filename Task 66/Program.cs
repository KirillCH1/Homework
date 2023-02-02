
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();

int numbM = EnteringNumbers("M");
int numbN = EnteringNumbers("N");
int result = 0;
Console.Write($"M = {numbM}; N = {numbN} ->");
OutputNaturalNumbers(numbM, numbN, result);



void OutputNaturalNumbers(int start, int end, int temp)
{
    temp = temp + start;
    start++;

    if (start == end)
    {
        temp = temp + start;
        Console.Write($" {temp}");
        return;
    }
    OutputNaturalNumbers(start, end, temp);
}

int EnteringNumbers(string messege)
{
    Console.Write($"Введите число \"{messege}\": ");
    int numbers = int.Parse(Console.ReadLine() ?? "");
    return numbers;
}