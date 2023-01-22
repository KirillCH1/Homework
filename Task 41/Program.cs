
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


Console.Clear();

СountNumbGreaterZero(GetValue());

void СountNumbGreaterZero(int[] array)
{
    int greZero = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            greZero++;
        }
    }
    Console.Clear();

    Console.WriteLine($"[{String.Join(", ", array)}] --> {OutputLine(greZero)} ");

    string OutputLine(int number)
    {
        string text = "";
        switch (number)
        {
            case 0:
                text = "Нет чисел больше нуля";
                break;
            case 1:
                text = "Одно число больше нуля";
                break;
            case 2:
                text = "Два числа больше нуля";
                break;
            case 3:
                text = "Три числа больше нуля";
                break;
            case 4:
                text = "Четыре числа больше нуля";
                break;
            default:
                text = number + " чисел больше нуля";
                break;
        }
        return text;
    }
}

int[] GetValue()
{
    int size = GetNumberFromUser("Введите величену массива: ", "Ошибка ввода");
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"[{String.Join(", ", array)}]");
        array[i] = GetNumberFromUser($"Введите {i + 1} число: ", "Ошибка ввода");
        Console.Clear();

    }
    Console.WriteLine($"[{String.Join(", ", array)}]");
    return array;
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}