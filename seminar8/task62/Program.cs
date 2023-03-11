/*
Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/

Console.WriteLine("Задача 62. Заполните спирально массив 4 на 4.");

int ReadNumber (string messageToUser) {
Console.Write(messageToUser);
return int.Parse(Console.ReadLine());
}

int [,] GetRandomMatrix (int rowsColumns) {
    
    int [,] matrix = new int [rowsColumns, rowsColumns];
    int m = 0;    

    for (int i = 0; i < (rowsColumns / 2); i++) {

        for (int j = i; j < (rowsColumns - i); j++) {   
            matrix[i,j] = m;
            m++;
        }
        for (int j = 1; j < (rowsColumns - i - i); j++) {   
            matrix[(j + i), (rowsColumns - i) - 1] = m;    
            m++;
        }
        for (int j = (rowsColumns - 2) - i; j >= i; j--) {  
            matrix[(rowsColumns - i) - 1, (j)] = m;            
            m++;
        }
        for (int j = ((rowsColumns - i) - 2); j > i; j--) {
            matrix[j, i] = m;
            m++;
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

int m = ReadNumber("Введите размер стороны квадратной матрицы = ");
int [,] myMatrix1 = GetRandomMatrix(m);

PrintMatrix(myMatrix1);


