Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int index = 2;

if (number > 1)
{
    while (index <= number)
    {
        Console.Write(index + " ");
        index = index + 2;
    }
}