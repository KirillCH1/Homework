
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


int num;        //ввод пользователя
int right;      //храниит правое число для сравнения
int left;       //хранит левое число для сравнения
while (true)
{
    Console.Write("Введите пятизначное число: ");

    try
    {
        num = Convert.ToInt32(Console.ReadLine());
        if (num > 9999 & num < 100000)
            break;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message}");
    }
}

right = num % 10;
left = num / 10000;
if (right == left)
{
    right = (num / 10) % 10;
    left = (num / 1000) % 10;
    if (right == left)
        Console.WriteLine($"{num} -> да");
}
else
    Console.WriteLine($"{num} -> нет");