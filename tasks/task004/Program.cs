int numberA = 9;
int numberB = 45;
int numberC = 8;
int max;
if (numberA > numberB)
{
    max = numberA;
}

else
{
    if (numberB > numberC)
    {
        max = numberB;
    }
    else
    {
        max = numberC;
    }
}

Console.Write("MAX = ");
Console.WriteLine(max);