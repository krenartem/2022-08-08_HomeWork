﻿Console.Clear();
Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0)
{
    Console.Write("Число ");
    Console.Write(number);
    Console.WriteLine(" четное");
}
else
{
    Console.Write("Число ");
    Console.Write(number);
    Console.WriteLine(" нечетное");
}
