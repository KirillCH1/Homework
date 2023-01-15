
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
int number = GetNumberFromUser("Введите целое число: ", "Ошибка Ввода");
int sum = CalculateSumNumber(number);
Console.WriteLine($"Cумма чисел равна: {sum}");

int CalculateSumNumber(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
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