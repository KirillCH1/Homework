Console.Write("Введите число : ");
int namber = int.Parse(Console.ReadLine() ??"");
int result = namber %2;
if (result == 1)
{
    Console.Write($"{namber} -> нечетное число ");
}
else if(result == -1)
{
    Console.Write($"{namber} -> нечетное число ");
}
else
{
    Console.Write($"{namber} -> четное число ");
}
