Console.Write("Введите первое число : ");
int numberOne = int.Parse(Console.ReadLine() ??"");

Console.Write("Введите второе число : ");
int numberTwo = int.Parse(Console.ReadLine() ??"");

Console.Write("Введите третье число : ");
int numberThree = int.Parse(Console.ReadLine() ??"");

if(numberOne > numberTwo)
{
    if(numberOne>numberThree)
    {
        Console.WriteLine($"{numberOne},{numberTwo},{numberThree} -> {numberOne}");
    }
    else
    {
        Console.WriteLine($"{numberOne},{numberTwo},{numberThree} -> {numberThree}");
    }
    
}
else
{
    if(numberTwo>numberThree)
    {
        Console.WriteLine($"{numberOne},{numberTwo},{numberThree} -> {numberTwo}");
    }
    else
    {
        Console.WriteLine($"{numberOne},{numberTwo},{numberThree} -> {numberThree}");
    }
}

