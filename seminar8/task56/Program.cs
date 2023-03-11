/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

Console.WriteLine("Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");

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

void SearchSumColumns (int [,] matrix, int col, int row) {
    int [] array = new int [row];

    for (int j = 0; j < matrix.GetLength(0); j++)
    {   
        array[j] = 0;

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            array[j] += matrix[j, i];            
        }
    }

    int str = 0;
    int min = 0;

    for (int i = 0; i < array.Length; i++)
    {
        min = array[0];
        if (array[i] < min)
        {
            min = array[i];
            str = i;           
        }   
    }
    Console.WriteLine($"Минимальная сумма элементов в {str + 1} строке");
}

int m = ReadNumber("Введите количество строк матрицы = ");
int n = ReadNumber("Введите количество столбцов матрицы = ");
int [,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
SearchSumColumns(myMatrix, n, m);