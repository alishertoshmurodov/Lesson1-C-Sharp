
int Num1 = new Random().Next(1,10);
Console.WriteLine(Num1);
int Num2 = new Random().Next(1,10);
Console.WriteLine(Num2);
int Num3 = new Random().Next(1,10);
Console.WriteLine(Num3);
int Num4 = new Random().Next(1,10);
Console.WriteLine(Num4);
int max = Num1;

if (max < Num2)
{
    max = Num2;
}
if (max < Num3)
{
    max = Num3;
}
if (max < Num4)
{
    max = Num4;
}
Console.WriteLine("---Max Value---");
Console.WriteLine(max);