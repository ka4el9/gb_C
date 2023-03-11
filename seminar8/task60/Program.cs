/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)
*/
Console.WriteLine("Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");

int ReadNumber (string messageToUser) {
Console.Write(messageToUser);
return int.Parse(Console.ReadLine());
}

int [,,] GetRandomMatrix (int z, int y, int x, int leftBorder = 0, int rightBorder = 25) {
    
    int [,,] matrix = new int [z, y, x];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = Random.Shared.Next(leftBorder, rightBorder);
            }            
        }
    }
    return matrix;
}

void PrintMatrix (int [,,] matrix) {

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.WriteLine("z = " + (i));

        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i}, {j}, {k})\t ");
            }
            Console.WriteLine(); 
        }
        Console.WriteLine();      
    }
}

Console.WriteLine("Введите размеры трехмерного массива:");
int x = ReadNumber("x = ");
int y = ReadNumber("y = ");
int z = ReadNumber("z = ");
Console.WriteLine();

int [,,] myMatrix1 = GetRandomMatrix(z, y, x);

PrintMatrix(myMatrix1);