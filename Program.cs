// Задача 10: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// System.Console.WriteLine("Введите трехзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 99 && number < 1000)
// {
//     int secondNumber = (number / 10) % 10;
//     System.Console.WriteLine($"Вторая цифра введенного числа {number} - > {secondNumber}");
// }
// else
//     System.Console.WriteLine($"Введенное число {number} не трехзначное");



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// System.Console.WriteLine("Введите любое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int tmp = number;

// while (tmp > 1000)
// {
//     tmp /= 10;
// }

// int result = tmp % 10;

// if (number > 99)
// {
//     System.Console.WriteLine($"Третья цифра введенного числа - > {result}");
// }
//     else
//     System.Console.WriteLine($"Введенное число {number} не трехзначное");



// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и
// проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите цифру, обозначающую день недели: ");
int number = int.Parse(Console.ReadLine());
if (number <= 5)
{
    System.Console.WriteLine("Нет, не выходной");
}
else if (number >= 6)
{
    System.Console.WriteLine("Да, выходной");
}