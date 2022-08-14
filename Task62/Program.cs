// Задача 62. Заполните спирально массив 4 на 4.

int[,] FillArraySpiral(int a, int b)
{
    int[,] result = new int[a, b];
    int columns = result.GetLength(1);
    int rows = result.GetLength(0);
    int value = 1;
    for (int i = 0; value <= a * b; i++)
    {
        if (value <= a * b)
        {
            for (int j = i; j < columns - i; j++)
            {
                result[i, j] = value;
                value++;
            }
        }
        if (value <= a * b)
        {
            for (int k = i + 1; k < rows - i; k++)
            {
                result[k, columns - (1 + i)] = value;
                value++;
            }
        }
        if (value <= a * b)
        {
            for (int m = columns - (2 + i); m >= i; m--)
            {
                result[rows - (1 + i), m] = value;
                value++;
            }
        }
        if (value <= a * b)
        {
            for (int s = rows - (2 + i); s >= i + 1; s--)
            {
                result[s, i] = value;
                value++;
            }
        }
    }
    return result;
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

Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Input number of elements: ");
int columns = Convert.ToInt32(Console.ReadLine());


int[,] myArray = FillArraySpiral(rows, columns);

Show2dArray(myArray);
