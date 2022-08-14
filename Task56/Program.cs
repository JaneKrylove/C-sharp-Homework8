// Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int FindMinSumRow(int[,] array)
{
    int[] sumElem = new int[array.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        sumElem[i] = sum;
        sum = 0;
    }
    int minSumElem = sumElem[0];
    int minSumElemIndex = 0;
    for (int i = 0; i < sumElem.Length; i++)
    {
        if (minSumElem > sumElem[i])
        {
            minSumElem = sumElem[i];
            minSumElemIndex = i;
        }
    }
    return minSumElemIndex; 
}

/*
Console.WriteLine("Enter the number of rows in the array");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the number of elements in the array row");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the minimum value in the array");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the maximum value in the array");
int maxValue = Convert.ToInt32(Console.ReadLine());
*/

int[,] myArray = CreateRandom2dArray(6, 5, 1, 25);

Show2dArray(myArray);

Console.WriteLine("Number of row with min summ is: " + FindMinSumRow(myArray));