// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int[] array = new int[10];
FillArray(array);
WriteArray(array);
Console.WriteLine();
WriteMinNumber(array);
Console.WriteLine();
WriteMaxNumber(array);
Console.WriteLine();
DifferenceNumber(array);
Console.WriteLine();

void FillArray(int[] NewArray)
{
    for (int i = 0; i < NewArray.Length; i++)
    {
        NewArray[i] = new Random().Next(0, 100);
    }

}
void WriteArray(int[] NewArray)
{
    for (int i = 0; i < NewArray.Length; i++)
    {
        Console.Write($"{NewArray[i]} | ");
    }
}
int WriteMinNumber(int[] NewArray)
{
    int min = int.MaxValue;
    foreach (int ElementMin in NewArray)
    {
        if (ElementMin < min)
        {
            min = ElementMin;
        }
    }
    //Console.Write($"Минимальное число массива {min} ");
    return min;
}
int WriteMaxNumber(int[] NewArray)
{
    int max = int.MinValue;
    foreach (int ElementMax in NewArray)
    {
        if (ElementMax > max)
        {
            max = ElementMax;
        }
    }
    //Console.WriteLine($"Максимальное число массива {max}  ");
    return max;
}
void DifferenceNumber(int[] NewArray)
{
    int Dif = WriteMaxNumber(array) - WriteMinNumber(array);
    Console.WriteLine($"{WriteMaxNumber(array)} - {WriteMinNumber(array)} = {Dif} ");
}
