
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int x;
int y;
int z;
int x1;
int y1;
int z1;
double result;
x = DataEntry("(A) X");
y = DataEntry("(A) Y");
z = DataEntry("(A) Z");
x1 = DataEntry("(B) X");
y1 = DataEntry("(B) Y");
z1 = DataEntry("(B) Z");
result = Math.Pow((x - x1), 2) + Math.Pow((y - y1), 2) + Math.Pow((z - z1), 2);
result = Math.Sqrt(result);
Console.WriteLine($" A ({x},{y},{z}) B({x1},{y1},{z1}) -> {result}");


static int DataEntry(string coor)
{
    int num;
    while (true)
    {
        Console.Write($"Введите значение координаты {coor}: ");

        try
        {
            num = Convert.ToInt32(Console.ReadLine());
            break;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода! {exc.Message}");
        }
    }
    return num;
}