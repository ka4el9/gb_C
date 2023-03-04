/*
Пользователь вводит с клавиатуры неопределенное количество чисел (while (true)).
 Посчитайте, сколько чисел больше 0 ввёл пользователь.
 Ввод чисел останавливается при помощи ввода слова "stop"
*/


Console.WriteLine("Пользователь вводит с клавиатуры неопределенное количество чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается при помощи ввода слова stop");

Console.Write("Введите число (длину) массива: ");
int LEN = int.Parse(Console.ReadLine());
int [] array = new int [LEN];

void printArray(int [] arr) {
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.WriteLine("]");
}

void initArray(int [] arr) {

    int i = 0;
    int number = 0;
    string answer = string.Empty;

    while (true)
    {
        Console.Write($"Введите {i} число массива:");
        answer = Console.ReadLine();
    
        if (answer == "stop")
        {
        break;
        }
        else {
            number = Convert.ToInt32(answer);
            arr[i] = number; 
        }
        i++;
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