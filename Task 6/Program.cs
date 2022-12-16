
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число : ");
int number = int.Parse(Console.ReadLine() ??"");
int result = number %2;
if (result == 1)
{
    Console.Write($"{number} -> нечетное число ");
}
else if(result == -1)
{
    Console.Write($"{number} -> нечетное число ");
}
else
{
    Console.Write($"{number} -> четное число ");
}
