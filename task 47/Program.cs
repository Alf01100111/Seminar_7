double[,] GetRndMatrix(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double rnd = new Random().Next(min, max);
            matrix[i,j] = rnd/10;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}\t");            
        }
        Console.WriteLine();
    }
}

double[,] newmatrix = GetRndMatrix(5,4,-100,100);
PrintMatrix(newmatrix);