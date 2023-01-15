
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

int num = GetNumberFromUser("Введите целое число: ", "Ошибка Ввода");
int power = GetNumberFromUser("Введите сепень числа: ", "Ошибка Ввода");
int result = CalculatePowerNumber(num, power);
Console.WriteLine($" Число {num} в степени {power} =  {result}");


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

int CalculatePowerNumber(int number, int power)
{
    int res = number;
    while (power - 1 > 0)
    {
        res *= number;
        power--;
    }
    return res;
}
