Console.WriteLine("Введите номер А");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер B");
int numB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер C");
int numC = Convert.ToInt32(Console.ReadLine());

int max = numA;

if (numA < numB)
{
    max = numB;
}
if (max < numC)
{
    max = numC;
}

Console.WriteLine($"max = {max}");
