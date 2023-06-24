// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double [] CreateNewArray ()
{
    int sizeArray = 5;
    double [] array = new double[sizeArray];
    for (int i = 0; i < sizeArray; i++)
    {   
        array[i] = Convert.ToDouble(new Random().Next(0, 9999)) / 100;
    }
    return array;
}

void PrintArray (double [] arrayPrint)
{
    Console.Write("Your array is: ");
    for (int i = 0; i < arrayPrint.Length; i++)
        Console.Write(arrayPrint[i] + " ");
    Console.WriteLine();
}

double IdentifyMaxElem (double [] arrayAnalysed)
{
    double maxElem = arrayAnalysed[0];
    for (int i = 1; i < arrayAnalysed.Length; i++)
    {
        if (arrayAnalysed[i] > maxElem)
        {
            maxElem = arrayAnalysed[i];
        }
    }
    return maxElem;
}

double IdentifyMinElem (double [] arrayAnalysedAgain)
{
    double minElem = arrayAnalysedAgain[0];
    for (int i = 1; i < arrayAnalysedAgain.Length; i++)
    {
        if (arrayAnalysedAgain[i] < minElem)
        {
            minElem = arrayAnalysedAgain[i];
        }
    }
    return minElem;
}


double [] newGivenArray = CreateNewArray();
PrintArray(newGivenArray);
Console.WriteLine($"{IdentifyMaxElem(newGivenArray)} is MAX");
Console.WriteLine($"{IdentifyMinElem(newGivenArray)} is MIN");
Console.WriteLine($"The difference between MAX and MIN is {IdentifyMaxElem(newGivenArray) - IdentifyMinElem(newGivenArray)}");
