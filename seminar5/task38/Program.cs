/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.WriteLine("Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива");

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

void initArray(int [] arr) {
        for (int i = 0; i < num; i++)
    {
        Console.Write($"Введите {i} число массива:");
        arr[i] = int.Parse(Console.ReadLine());
    }
}

int maxElementArray(int [] arr) {
    int max = arr[0];
    for (int i = 0; i < num; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];            
        }
    }

    return max;
}

int minElementArray(int [] arr) {
    int min = arr[0];
    for (int i = 0; i < num; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];            
        }
    }

    return min;
}


initArray(array);
printArray(array);
int maxelem = maxElementArray(array);
Console.WriteLine($"Максимальный элемент массива = {maxelem}");
int minelem = minElementArray(array);
Console.WriteLine($"Минимальный элемент массива = {minelem}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {maxelem - minelem}");
