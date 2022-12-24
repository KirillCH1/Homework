
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 

int numb;
while (true)
{
    Console.Write("Введите 3х значное число : ");
    if (int.TryParse(Console.ReadLine(), out numb))
        break;
    Console.WriteLine("Ошибка ввода!");
}
int a = (numb / 10) % 10;

Console.WriteLine($"{numb} -> {a}");