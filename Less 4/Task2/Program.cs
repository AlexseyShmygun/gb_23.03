/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6]-> 0 */


int[] numbers = new int[5];
Random rand = new();
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rand.Next(1, 50);
    if (i % 2 == 1)
    {
        sum += numbers[i];
    }
}
Console.WriteLine($"Сумма нечетных элементов = {sum}");