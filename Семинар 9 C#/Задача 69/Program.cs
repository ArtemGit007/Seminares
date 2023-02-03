// Задача 69 Напишите программу, которая на вход принимает два числа А и В, 
// и возводит число А в целую степень В с помощью рекурсии.

// А = 3, В = 5  -> 243 (3 в 5);
// А = 2, В = 3 ->  8

int exponent(int n, int m)
{
    if (m == 0)
        return 1;
    else
        return n * exponent(n, m - 1);
}



Console.WriteLine("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число:");
int m = Convert.ToInt32(Console.ReadLine());

int exp = exponent(n, m);
Console.WriteLine(exp);
