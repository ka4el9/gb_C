/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
*/

Console.WriteLine("Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.");

int ReadNumber (string messageToUser) {
Console.Write(messageToUser);
return int.Parse(Console.ReadLine());
}

int [,] GetRandomMatrix (int rows, int columns, int leftBorder = 0, int rightBorder = 11) {
    
    int [,] matrix = new int [rows, columns];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder);
        }        
    }
    return matrix;
}

void PrintMatrix (int [,] matrix) {

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t ");
        }
        Console.WriteLine();      
    }
}

void convertArray (int [,] matrix, int col, int row) {

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = col - 1; k > j; k--)
            {
                if (matrix[i, k] < matrix[i,k - 1])
                {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k - 1];
                    matrix[i, k - 1] = temp;
                }                
            }
            Console.Write($"{matrix[i, j]}\t");
        } 
        Console.WriteLine();  
    }
}


int m = ReadNumber("Введите количество строк матрицы = ");
int n = ReadNumber("Введите количество столбцов матрицы = ");
int [,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
Console.WriteLine("Упорядоченный по возрастанию массив:");
convertArray(myMatrix, n, m);