// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int [] CreateNewArray (int size_array)
{
    int [] array = new int[size_array];
    for (int i = 0; i < size_array; i++)
    {   
        array[i] = new Random().Next(-9, 10);
    }
    return array;
}

void PrintArray (int [] arrayPrint)
{
    Console.Write("Your array is: ");
    for (int i = 0; i < arrayPrint.Length; i++)
        Console.Write(arrayPrint[i] + " ");
}

int PrintSumOfElem (int [] arraySumPrint)
{
    int sumArrayOdd = 0;
    if (arraySumPrint.Length % 2 == 0)
    {
        for (int i = 1; i <= arraySumPrint.Length - 1; i = i + 2)
        {
        sumArrayOdd = sumArrayOdd + arraySumPrint[i];
        }
    }
    else
    {
        for (int i = 1; i < arraySumPrint.Length; i = i + 2)
        {
        sumArrayOdd = sumArrayOdd + arraySumPrint[i];
        }
    }
    return sumArrayOdd;
}

Console.Write("Set the length of your array: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] sampleArray = CreateNewArray(size);
PrintArray(sampleArray);
Console.WriteLine();
Console.WriteLine($"The sum of elements with odd indexes is: {PrintSumOfElem(sampleArray)}");
