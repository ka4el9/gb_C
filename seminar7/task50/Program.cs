/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
​
1 4 7 2
​
5 9 2 3
​
8 4 2 4
​
1 7 -> такого числа в массиве нет
*/

Console.WriteLine("Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");

int ReadNumber (string messageToUser) {
Console.Write(messageToUser);
return int.Parse(Console.ReadLine());
}

int [,] GetRandomMatrix (int rows, int columns, int leftBorder = 0, int rightBorder = 20) {
    
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

void SearchPosition (int [,] matrix, int row, int col) {

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (row > matrix.GetLength(0) - 1) {
            Console.WriteLine("Такого числа нет в массиве!");
            break;
        }
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (col > matrix.GetLength(1) - 1) {
                Console.WriteLine("Такого числа нет в массиве!");
                break;
            } 
            if (i == row && j == col) {
                Console.WriteLine($"{matrix[i, j]}");
            }
             
        }
    }
}

int m = ReadNumber("Введите количество строк матрицы = ");
int n = ReadNumber("Введите количество столбцов матрицы = ");
int [,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
int row = ReadNumber("Введите позицию элемента в строке для поиска в матрице = ");
int col = ReadNumber("Введите позицию элемента в столбце для поиска в матрице = ");
SearchPosition(myMatrix, row, col);