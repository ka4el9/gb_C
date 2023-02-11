/*
Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница
*/

Console.WriteLine("Задание 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.");

Console.WriteLine("Введите число от 1 до 7: ");
string number = Console.ReadLine();
int userNumber = Convert.ToInt32(number);
 
 if ((userNumber < 1) | (userNumber > 7) ) {
    Console.WriteLine("Error! Необходимо ввести число от 1 до 7");
 }
else {
    switch (userNumber)
    {
        case 1: Console.WriteLine("Monday");
        break;

        case 2: Console.WriteLine("Tuesday");
        break;

        case 3: Console.WriteLine("Wednesday");
        break;

        case 4: Console.WriteLine("Thursday");
        break;

        case 5: Console.WriteLine("Friday");
        break;

        case 6: Console.WriteLine("Friday");
        break;

        case 7: Console.WriteLine("Sunday");
        break;
    }
}
