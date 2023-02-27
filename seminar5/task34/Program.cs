/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.WriteLine("Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве");

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
        arr[i] = new Random().Next(100, 1000);
    }
}

void evenNumbers(int [] arr) {
    int quantity = 0;
    for (int i = 0; i < num; i++)
    {
        if (arr[i] % 2 == 0) {
            quantity++;
        }        
    }
    Console.WriteLine($"Количество четных чисел в массиве - {quantity}");
}

printArray(array);
fillingArray(array);
printArray(array);
evenNumbers(array);

