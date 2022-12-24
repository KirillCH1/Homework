
//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int numb;
while (true)
{
    Console.Write("Введите число : ");
    if (int.TryParse(Console.ReadLine(), out numb))
        if (numb > 99)
            break;
        else
            Console.WriteLine($"{numb}-> третьей цифры нет");
    else
        Console.WriteLine("Ошибка ввода!");
}
int number = numb;
int thirdNumb = numb;
int count = 1;
while (true)
{
    number = number / 10;
    count = count * 10;
    if (number == 0)
    {
        count = count / 1000;
        thirdNumb = (thirdNumb / count) % 10;
        break;
    }
}
Console.WriteLine($"{numb} -> {thirdNumb}");