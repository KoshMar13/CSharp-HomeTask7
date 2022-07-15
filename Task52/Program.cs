// 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
int[,] NewMatrixRnd(int row, int column, int min, int max)
{
    int[,] matrix = new int[row, column];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0)
                Console.Write("|");
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j], 3}| ");
            else
                Console.Write($"{matrix[i, j], 3}|");
        }
        Console.WriteLine();
    }
}

void PrintArray(double[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        if (i == 0)
            Console.Write("[");
        if (i < len - 1)
            Console.Write(array[i] + "; ");
        else
            Console.Write(array[i] + "]");
    }
}

double[] MidSumColumnsMatrix(int[,] matrix)
{
    int columns = matrix.GetLength(1);
    double[] midSumColumns = new double[columns];
    int rows = matrix.GetLength(0);
    for (int j = 0; j < columns; j++)
    {
        double midSum = 0;
        for (int i = 0; i < rows; i++)
        {
            midSum += matrix[i, j];
        }
        midSumColumns[j] = midSum / rows;
    }
    return midSumColumns;
}

int[,] initMatrix = NewMatrixRnd(4, 4, -100, 100);
PrintMatrix(initMatrix);
Console.WriteLine("Среднее арифметическое элементов в каждом столбце равняется:");
double[] answer = MidSumColumnsMatrix(initMatrix);
PrintArray(answer);
