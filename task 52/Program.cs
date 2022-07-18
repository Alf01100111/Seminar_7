int[,] GetRndMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
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
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] matrix = GetRndMatrix(5, 4, 0, 10);
PrintMatrix(matrix);

int[] AverInColumns(int[,] matrix)
{
    int[] resultar = new int[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)  //пробежимся по каждому столбцу матрицы
        {                                              //получим массив с суммами каждого столбца
            resultar[j] += matrix[i, j];
        }
    }
    for (int i = 0; i < resultar.Length; i++)
    {
        resultar[i] = resultar[i] / matrix.GetLength(0);  //считаем среднее для каждого элемента массива
    }
    return resultar;
}

