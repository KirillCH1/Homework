
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int numb;
while (true)
{
    Console.Write("Введите номер дня недели : ");
    if (int.TryParse(Console.ReadLine(), out numb))
        if (numb < 8)
            if (numb > 5)
            {
                Console.WriteLine($"{numb}-> Да");
                break;
            }
            else
            {
                Console.WriteLine($"{numb}-> Нет");
                break;
            }
    Console.WriteLine("Ошибка ввода!");
}