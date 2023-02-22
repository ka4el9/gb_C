/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.WriteLine("Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");

int ReadNumber (string messageToUser) {
    Console.Write(messageToUser);
    return int.Parse(Console.ReadLine());
}

void ArrayFunction (int NUM) {
    int [] array = new int [NUM];
    Console.Write("Длина массива:");
    Console.WriteLine(array.Length);
    for (int i = 0; i < NUM; i++)
    {
        array[i] = ReadNumber("Введите число, которое добавим в массив: ");
    }

    Console.Write("[");
    for (int i = 0; i < NUM; i++)
    {
        Console.Write(array[i]);
        Console.Write(",");
    }
    Console.WriteLine("]");
}

Console.Write("Введите длину массива: ");
string Length = Console.ReadLine();
int UserLenght = Convert.ToInt32(Length);
ArrayFunction(UserLenght);

