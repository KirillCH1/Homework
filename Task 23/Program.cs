
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


int num;
int i = 1;
while (true)
{
    Console.Write("Введите число: ");

    try
    {
        num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
        break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message}");
    }
}
while (i <= num)
{
    int temp = i*i*i;
    Console.Write($"{temp},");
    i++;
}