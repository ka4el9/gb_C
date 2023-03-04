/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.WriteLine("Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
double y1 = 0;
double y2 = 0;
double x1 = 0;

double readNumber(string messageToUser){
    Console.Write(messageToUser);
    return double.Parse(Console.ReadLine());
}

double yFunction (double k, double x, double b) {
    double y = k * x + b;
    return y;
}
double xFunction (double k1, double k2, double b1, double b2) {
    double x = (b2-b1)/(k1-k2);
    return x;
}


double b1 = readNumber("Введите значение b1= ");
double k1 = readNumber("Введите значение k1= ");
double b2 = readNumber("Введите значение b2= ");
double k2 = readNumber("Введите значение k2= ");

x1 = xFunction(k1, k2, b1, b2);
y1 = yFunction(k1, x1, b1);
y2 = yFunction(k2, x1, b2);

if (y1 == y2) {    
Console.WriteLine($"Точка пересечения прямых ({x1}, {y1})");
}
else if ((b1 == b2)) {
    Console.WriteLine($"Прямые совпадают");
}
else Console.WriteLine($"Прямые параллельны и не имеют пересечений");
