/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
​
m = 3, n = 4.
​
0,5 7 -2 -0,2
​
1 -3,3 8 -9,9
​
8 7,8 -7,1 9
*/


Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");

int ReadNumber (string messageToUser) {
Console.Write(messageToUser);
return int.Parse(Console.ReadLine());
}

double RandomDoubleValue(double dMin, double dMax)
{ 
    Random random = new Random();
    return Math.Round(random.NextDouble() * (dMax- dMin) + dMin, 1);
}

double [,] GetRandomMatrix (int rows, int columns, double leftBorder = -10, double rightBorder = 11) {
    
    double [,] matrix = new double [rows, columns];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = RandomDoubleValue(leftBorder, rightBorder);
        }        
    }
    return matrix;
}

void PrintMatrix (double [,] matrix) {

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();      
    }

}

int m = ReadNumber("Введите количество строк матрицы = ");
int n = ReadNumber("Введите количество столбцов матрицы = ");
double [,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);