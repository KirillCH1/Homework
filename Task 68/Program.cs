
//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n

Console.Clear();

int numbM = EnteringNumbers("M");
int numbN = EnteringNumbers("N");
int result = 0;
Console.Write($"M = {numbM}; N = {numbN} ->");

Console.WriteLine($" {CalculationAckermanFunction(numbM, numbN)}");


int CalculationAckermanFunction(int numbM, int numbN)
{
    if (numbM == 0)
        return numbN + 1;
    if (numbM != 0 && numbN == 0)
        return CalculationAckermanFunction(numbM - 1, 1);
    if (numbM > 0 && numbN > 0)
        return CalculationAckermanFunction(numbM - 1, CalculationAckermanFunction(numbM, numbN - 1));
        
    return CalculationAckermanFunction(numbM, numbN);
}

int EnteringNumbers(string messege)
{
    Console.Write($"Введите число \"{messege}\": ");
    int numbers = int.Parse(Console.ReadLine() ?? "");
    return numbers;
}