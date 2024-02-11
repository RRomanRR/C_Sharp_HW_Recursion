// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void OutRevers(int[] array, int i)
{
    if (i >= 0)
    {
        Console.Write($"{array[i]} ");
        OutRevers(array, i - 1);
    }
}
int[] array = { 1, 2, 3, 4, 5, 6 };
int i = array.Length -1;
OutRevers(array, i);
