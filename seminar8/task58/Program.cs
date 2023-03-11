/*
//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/

Console.WriteLine("Задача 58. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");

int ReadNumber (string messageToUser) {
Console.Write(messageToUser);
return int.Parse(Console.ReadLine());
}

int [,] GetRandomMatrix (int rows, int columns, int leftBorder = 0, int rightBorder = 10) {
    
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

void SearchMultMatrix (int [,] matrix1, int [,] matrix2) {
    int [,] array = new int [matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {   
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            array[i, j] = matrix1[i, j] * matrix2[i, j];             
        }     
    }
    PrintMatrix(array);    
}

int m = ReadNumber("Введите количество строк матрицы = ");
int n = ReadNumber("Введите количество столбцов матрицы = ");
int [,] myMatrix1 = GetRandomMatrix(m, n);
Console.WriteLine("Первая матрица:");
PrintMatrix(myMatrix1);

int [,] myMatrix2 = GetRandomMatrix(m, n);
Console.WriteLine("Вторая матрица:");
PrintMatrix(myMatrix2);

Console.WriteLine("Произведение матриц:");
SearchMultMatrix(myMatrix1, myMatrix2);