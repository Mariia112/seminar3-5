// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.WriteLine("Ввести размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] Numbers = new int[size];
ArrayRandomNumbers(Numbers);
Console.WriteLine("Массив: ");
PrintArray(Numbers);
int Sum = 0;
 

for (int i = 1; i < Numbers.Length; i+=2)
    Sum = Sum + Numbers[i];

    Console.WriteLine($"Количество чисел, удовлетворяющих условия: {Numbers.Length} , сумма элементов на нечётных позициях = {Sum}");

void ArrayRandomNumbers(int[] Numbers)
{
    for(int i = 0; i < Numbers.Length; i++)
        {
            Numbers[i] = new Random().Next(1,1000);
        }
}
void PrintArray(int[] Numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < Numbers.Length; i++)
        {
            Console.Write(Numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

