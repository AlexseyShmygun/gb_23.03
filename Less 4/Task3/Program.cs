/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

System.Console.WriteLine("введите длину массива ");
int lenght = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Минимальное значение ");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Максимальное значение ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[] array = GetNumbers(lenght, minValue, maxValue);
int[] GetNumbers(int lenght, int minValue, int maxValue)
{
    int[] numbers = new int[lenght];
    Random rand = new();
    for (int i = 0; i < lenght; i++)
    {
        numbers[i] = rand.Next(minValue, maxValue);
    }

    return numbers;
}

int max = GetMax(array);
int min = GetMin(array);
int GetMin(int[] NewArray)
{
    int min = NewArray[0];
    for (int i = 1; i < NewArray.Length; i++)
    {
        if (NewArray[i] < min)
        {
            min = NewArray[i];
        }
    }
    return min;
}

int GetMax(int[] NewArray)
{
    int max = NewArray[0];
    for (int i = 1; i < NewArray.Length; i++)
    {
        if (NewArray[i] > max)
        {
            max = NewArray[i];
        }
    }
    return max;
}

Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Минимальное значение = {min},  Максимальное значение = {max}");
Console.WriteLine($"Разница равняется = {max - min}");