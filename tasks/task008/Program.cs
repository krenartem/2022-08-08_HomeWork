Console.Clear();
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = 2;
if (number < 2)
{
    Console.WriteLine("четных чисел в диапазоне нет");
}
else
{
    Console.Write("Четные числа в диапазоне от 1 до ");
    Console.Write(number);
    Console.WriteLine(":");
    Console.Write("2");
    number2 += 2;
        while (number2 <= number)
    {
        Console.Write(", ");
        Console.Write(number2);
        number2 += 2;        
    }
    Console.WriteLine("");
}
