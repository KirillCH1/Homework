
//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.



Console.Clear();

CountValue();

void CountValue()
{

    double b1 = GetNumberFromUser("Введите значение b1: ", "Ошибка ввода!");
    double k1 = GetNumberFromUser("Введите значение k1: ", "Ошибка ввода!");
    double b2 = GetNumberFromUser("Введите значение b2: ", "Ошибка ввода!");
    double k2 = GetNumberFromUser("Введите значение k2: ", "Ошибка ввода!");

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine($"b1={b1}, k1={k1}, b2={b2}, k2={k2} -> ({x};{y})");

    double GetNumberFromUser(string message, string errorMessage)
    {
        while (true)
        {
            Console.Write(message);
            bool isCorrect = double.TryParse(Console.ReadLine(), out double userNumber);
            if (isCorrect)
                return userNumber;
            Console.WriteLine(errorMessage);
        }
    }
}