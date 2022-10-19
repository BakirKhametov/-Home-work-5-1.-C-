// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] array = new int[10];
FillArray(array);
WriteArray(array);
Console.WriteLine();
WriteEvenNumber(array);
Console.WriteLine();


void FillArray(int[] NewArray)
{
    for (int i = 0; i < NewArray.Length; i++)
    {
        NewArray[i] = new Random().Next(100, 999);
    }

}
void WriteArray(int[] NewArray)
{
    for (int i = 0; i < NewArray.Length; i++)
    {
        Console.Write($"{NewArray[i]} | ");
    }
}
int WriteEvenNumber(int[] NewArray)
{
    int count = 0;
    for (int i = 0; i < NewArray.Length; i++)
    {
        if(NewArray[i]%2==0)
        {
            count++;
        }

    }
    Console.Write($"Количество четных элементов массива {count} ");
    return count;
}

