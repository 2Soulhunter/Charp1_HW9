/*                          Домашнее задание к семинару 9 С#
Задача 66: Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N.
Например:
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30                         */

Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N (больше M): ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел от {M} до {N} равна {SumRangeMtoN(M, N)}");


int SumRangeMtoN(int M, int N)
{
    if (N == M) return M;
    else return (SumRangeMtoN(M, N-1) + N);
}