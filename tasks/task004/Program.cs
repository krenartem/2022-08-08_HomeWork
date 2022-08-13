int numberA = 22;
int numberB = 35;
int numberC = 9;
int max;
if (numberA > numberB)
{
    max = numberA;
}
else
{
    max = numberB;
}
    if (max < numberC)
    {
        max = numberC;
    }
Console.Write("MAX = ");
Console.WriteLine(max);