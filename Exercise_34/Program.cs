// Задача 34: Задайте массив заполненный случайными положительными
//  трёхзначными числами. Напишите программу, которая покажет 
//  количество чётных чисел в массиве.

int [] CreateNewArray ()
{
    int size_array = 3;
    int [] array = new int[size_array];
    for (int i = 0; i < size_array; i++)
    {   
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray (int [] array_to_print)
{
    Console.Write("Your array is: ");
    for (int i = 0; i < array_to_print.Length; i++)
        Console.Write(array_to_print[i] + " ");
    Console.WriteLine();
}

int EvenElemsInArray (int [] array_to_analyse)
{
    int evenNumbers = 0;
    for (int i = 0; i < array_to_analyse.Length; i++)
    {
        if (array_to_analyse[i] % 2 == 0)
            evenNumbers = evenNumbers + 1;
    }
    return evenNumbers;
}

int [] myArray = CreateNewArray();
PrintArray(myArray);
Console.WriteLine($"Resulting amount of EVEN numbers in your array: {EvenElemsInArray(myArray)}");