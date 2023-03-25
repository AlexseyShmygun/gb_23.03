Console.WriteLine("Введите номер А");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер B");
int numB = Convert.ToInt32(Console.ReadLine());


int max = numA;
int min = numA;

if (numA < numB)
{
    min = numA;
    max = numB;
    Console.WriteLine($"max = {max} \nmin = {min}");
}
else if (numB < numA)
{
    max = numA;
    min = numB;
    Console.WriteLine($"max = {max} \nmin = {min}");
}

else
{
    Console.WriteLine("Числа равны");
}