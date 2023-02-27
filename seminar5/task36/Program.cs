/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


Console.WriteLine("Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");

Console.Write("Введите число (длину) массива: ");
int num = int.Parse(Console.ReadLine());

int [] array = new int [num];

void printArray(int [] arr) {
    Console.Write("[");
    for (int i = 0; i < num; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.WriteLine("]");
}

void fillingArray(int [] arr) {
    for (int i = 0; i < num; i++)
    {
        arr[i] = new Random().Next(-10, 11);
    }
}

void sumNumbers(int [] arr) {
    int sum = 0;
    for (int i = 1; i < num; i++)
    {
        if (i % 2 != 0) {
            sum += arr[i];
        }        
    }
    Console.WriteLine($"Сумма нечетных элементов в массиве = {sum}");
}

printArray(array);
fillingArray(array);
printArray(array);
sumNumbers(array);