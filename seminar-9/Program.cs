//Задача 1: Задайте значение N. Напишите программу, которая выведет все четные натуральные 
//числа в промежутке от m до N . Выполнить с помощью рекурсии.
/*
Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
void che(int m, int n)
{
if (m > n)
return;
if (m % 2 == 0)
{
Console.Write($"{m}, ");
}
che(m+1,n);
}
che(m,n);
*/

//Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
//элементов в промежутке от M до N.
/*
Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int summa(int m, int n)
{
if (m==n)
return n;
else return m + summa(m + 1, n);
}
Console.Write($"Сумма натуральных элементов в промежутке от M до N равно {summa(m,n)}");
*/
//Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
int akkerman(int m, int n)
{
if (m == 0) return n + 1;
else if (n == 0) return akkerman(m - 1, 1);
else return akkerman(m - 1, akkerman(m, n - 1));
}
Console.Write($"Функция Аккермана равно {akkerman(m, n)} ");
