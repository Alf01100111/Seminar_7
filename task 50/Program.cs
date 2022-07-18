double[,] GetRndMatrix(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double rnd = new Random().Next(min, max);
            matrix[i, j] = rnd;
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
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void ShowNumInPos(double[,] matrix, int rows, int columns)
{
    if (rows > matrix.GetLength(0) || columns > matrix.GetLength(1) || rows < 0 || columns < 0)
    {
        System.Console.WriteLine("Такой позиции нет в данной матрице ");   // Спросить на семинаре как сделать через ловлю ошибки System.IndexOutOfRangeException
    }    
    System.Console.WriteLine($"На позиции строка: {rows+1} столбец: {columns+1} - число {matrix[rows, columns]}");
}

double[,] matrix = GetRndMatrix(5, 4, 0, 100);
PrintMatrix(matrix);
System.Console.WriteLine();

System.Console.Write("Ведите строку - ");
int row = Convert.ToInt32(Console.ReadLine()) - 1;

System.Console.Write("Ведите столбец - ");
int column = Convert.ToInt32(Console.ReadLine()) - 1;

ShowNumInPos(matrix, row, column);