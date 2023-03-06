/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
​
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.WriteLine("Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");

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

void SearchAMcolumns (int [,] matrix, int col, int row) {
    double [] array = new double [col];

    double am = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {   
        array[j] = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            array[j] += matrix[i, j];
            
        } 
        array[j] /= row;
    }
    
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{ Math.Round(array[i], 1)}\t");
    }
    Console.WriteLine("]");
}


int m = ReadNumber("Введите количество строк матрицы = ");
int n = ReadNumber("Введите количество столбцов матрицы = ");
int [,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
SearchAMcolumns(myMatrix, n, m);