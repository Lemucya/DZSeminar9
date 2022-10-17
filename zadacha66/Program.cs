/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.WriteLine("Введите число M:" );
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:" );
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма чисел от {M} до {N} равна {sumNumber(M, N)}" );

int sumNumber(int a, int b)
{
    int sumNumber = 0;
    for (int i = a; a <= b; a++)
    {
        sumNumber = sumNumber + a;
    }
    return sumNumber;
}
