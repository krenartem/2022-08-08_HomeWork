Console.Clear();
Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA < numberB)
{
   Console.WriteLine($"Число {numberA} меньше числа {numberB}");
}

else
{
    if (numberA > numberB)
    {
        Console.WriteLine($"Число {numberA} больше числа {numberB}");
    }
    else
    {
        Console.WriteLine($"Число {numberA} равно числу {numberB}");
    }
}