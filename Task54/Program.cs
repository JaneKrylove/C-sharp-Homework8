// Задача 54: 
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


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

int[,] SortingRows(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int s = j + 1; s < array.GetLength(1); s++)
            {
                if (array[i, j] < array[i, s])
                {
                    temp = array[i, s];
                    array[i, s] = array[i, j];
                    array[i, j] = temp;
                }
            }
        }
    }
    return array;
}

/*
Console.WriteLine("Input number of rows: "); // Тут я просто потестила ввод от руки и генерацию массива
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number of elements: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input mini value of Array: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max value Of Array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
*/


int[,] myArray = CreateRandom2dArray(5, 4, 10, 100);

Console.WriteLine("Your first array: ");
Show2dArray(myArray);

Console.WriteLine();

SortingRows(myArray);

Console.WriteLine("Your second array: ");
Show2dArray(myArray);
