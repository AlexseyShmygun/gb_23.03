/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int[] numbers = new int[5];
Random rand = new();
int count = 0;

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rand.Next(100, 1000);

    if (numbers[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine(string.Join(", ", numbers));
Console.WriteLine($"Колличество четных чисел в массиве = {count}");