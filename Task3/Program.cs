// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] array = new int[10];
FillArray(array);
WriteArray(array);
Console.WriteLine();
SumOddNumber(array);
Console.WriteLine();


void FillArray(int[] NewArray)
{
    for (int i = 0; i < NewArray.Length; i++)
    {
        NewArray[i] = new Random().Next(0, 10);
    }
}
void WriteArray(int[] NewArray)
{
    for (int i = 0; i < NewArray.Length; i++)
    {
        Console.Write($"{NewArray[i]} | ");
    }
}
int SumOddNumber(int[] NewArray)
{
    int SumOdd = 0;
    for (int i = 0; i < NewArray.Length; i++)
    {
        if (NewArray[i] % 2 == 1)
        {
            SumOdd = SumOdd + NewArray[i];
        }

    }
    Console.Write($"Сумма нечетных элементов массива {SumOdd} ");
    return SumOdd;
}
