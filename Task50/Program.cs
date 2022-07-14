// 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

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

string MatrixSearch(int[,] matrix, int num1, int num2)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    if (num1 < rows && num2 < columns)
        return Convert.ToString(matrix[num1, num2]);
    else
        return "такого числа в массиве нет";
}

int[,] initMatrix = NewMatrixRnd(3, 4, -100, 100);
PrintMatrix(initMatrix);
Console.Write("Insert row: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert column: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(MatrixSearch(initMatrix, r, c));
