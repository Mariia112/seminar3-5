// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Ввести размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] threeDigitNumbers = new int[size];
FillArrayRandomNumbers(threeDigitNumbers);
Console.WriteLine("Массив: ");
PrintArray(threeDigitNumbers);
int count = 0;

for (int z = 0; z < threeDigitNumbers.Length; z++)
if (threeDigitNumbers[z] % 2 == 0)
count++;

Console.WriteLine($"всего {threeDigitNumbers.Length} чисел, {count} из них чётные");

void FillArrayRandomNumbers(int[] threeDigitNumbers)
{
    for(int i = 0; i < threeDigitNumbers.Length; i++)
    {
        threeDigitNumbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] threeDigitNumbers)
{
    Console.Write("[ ");
    for(int i = 0; i < threeDigitNumbers.Length; i++)
    {
        Console.Write(threeDigitNumbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}