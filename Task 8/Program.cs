
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число : ");
int number = int.Parse(Console.ReadLine() ??"");
int i = 1;
while( i < number+1 )
{
    int result = i %2;
    if(result ==0)
    {
        Console.Write($"{i}, ");
    }
    i++;
}