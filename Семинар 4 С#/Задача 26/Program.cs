// Задача 26: Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine(" Введите число: ");

int numb = Convert.ToInt32(Console.ReadLine());

int b = numb.ToString().Length;

Console.WriteLine(b);
