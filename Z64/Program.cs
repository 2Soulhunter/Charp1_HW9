/*                          Домашнее задание к семинару 9 С#
Задача 64: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Например:
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"               */

Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(ShowNumFromNto1(N));


string ShowNumFromNto1(int N)
{
    if (N==1) return 1.ToString();
    else return ($"{N}, {ShowNumFromNto1(N-1)}");
}