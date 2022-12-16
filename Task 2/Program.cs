Console.Write("Введите число a : ");
int namber1 = int.Parse(Console.ReadLine() ??"");

Console.Write("Введите число b : ");
int namber2 = int.Parse(Console.ReadLine() ??"");

if (namber1>namber2)
{
    Console.WriteLine($"a = {namber1} b = {namber2} -> max {namber1}");
}
else
{
    Console.WriteLine($"a = {namber1} b = {namber2} -> max {namber2}");
}

