﻿// Напишите программу, которая будет принимать 
// на вход число и  возвращать сумму его цифр
// Пример 
// 123 => 6 
// 63 => 9 

// ==============================================

// int Recurs(int a)
// {
//     if (a == 0) { return 0; }
//         return Recurs(a / 10) + a % 10;
// }
// int rec = Recurs(123);
// Console.Write(rec);

// ===========================================
// Задайте значение N. Напишите программу, которая выведет  
// все натуральные числа в промежутке от 1 до N.
// Пример 

// N=5 => 1 2 3 4 5 
// ===========================================

// void Recurs(int a)
// {
// 	if (a!=0) 
// 		{
// 			Recurs(a-1);		
// 			Console.Write($"{a} "); 
// 		}
// }
// Recurs(10);
// ==============================================

// Считать строку с консоли, содержащую латинские буквы. 
//  Вывести на экран согласные буквы этой строки
// Использовать рекурсию. Не использовать цикл
// Пример 

// “hello” => h l l 
// “World” => W r l d 
// “Hello world!” => H l l w r l d 
// =====================================================

// string str1 = "aeyiou";
// void Conson_Word(string word, int i = 0)
// {
//     if (i == word.Length)
//         return;

//     if (str1.Contains(char.ToLower(word[i])) == false)
//         Console.Write(word[i] + " ");
//         Conson_Word(word, i + 1);
// }
// Console.WriteLine("Введите слово: ");
// string str2 = Console.ReadLine()!;
// Conson_Word(str2);
// =====================================================

