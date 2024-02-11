// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все 
// натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.Clear();
Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine()!);
void EvenNumber(int m, int n)
{
    int a = n-m +1;
    if (m > n)
        return;
    int i = 0;
    if (i < a)
    {
        Console.Write($"{m}, ");
        i = +1;
    }
    EvenNumber(m+1,n);
}
EvenNumber(m,n);
