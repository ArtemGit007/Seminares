// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.

Console.WriteLine(" Введите число");
int a = Convert.ToInt32(Console.ReadLine());
double del = 0.0;
if(a>=100 &&a < 1000)
{
    del = a%10.0;
    Console.WriteLine(" Последняя цифра: " + del);
}
else
{
Console.WriteLine(" Введено не трёхзначное число");
}
