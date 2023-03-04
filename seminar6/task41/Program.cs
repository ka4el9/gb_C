/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

Console.WriteLine("Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");

Console.Write("Введите число (длину) массива: ");
int num = int.Parse(Console.ReadLine());

int [] array = new int [num];

void printArray(int [] arr) {
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.WriteLine("]");
}

void initArray(int [] arr) {
        for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i} число массива:");
        arr[i] = int.Parse(Console.ReadLine());
    }
}

int moreNull (int [] arr) {
    int sumNul = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sumNul++;
        
    }
    return sumNul;
}

initArray(array);
printArray(array);
Console.WriteLine($"Колличество чисел больше нуля = {moreNull(array)}");