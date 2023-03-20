// Задача 40:программа,которая  принимает на вход три числа и проверяет, может ли существовать 
//треугольник со сторонами такой длинны.(т. каждая сторона треугольника меньше суммы двух других 
//сторон.AB<BC+AC;BC<AB+AC;AC<AB+BC)
//Задача 42: программа, которая будет преобразовывать десятичное число в двоичное.
//Задача 44: не используя рекурсию, выведите первые N чисел Фибоначи. Первые два числа 
//Фибоначи: 0 и 1.
//Задача 45: программа, которая будет создавать копию данного массива с помощью поэлементарного 
//копирования


//Задача 40.


/*
bool TriangleExist(int[] sides)

{
    return (sides[0]< sides[1]+ sides[2]) && (sides[1]< sides[0]+ sides[2]) && (sides[2]< sides[0]+ sides[1]);
}

Console.WriteLine("Введите 3 числа через пробел: ");
    int[] numb = Console.ReadLine().Split().Select(int.Parse).ToArray();
    Console.Write($"Треугольник со сторонами {numb[0]},{numb[1]},{numb[2]}");
    if(TriangleExist(numb))
{
    Console.WriteLine("может существовать");
}
    
    else
{
    Console.WriteLine("не может существовать");
}
    
*/


//Задача 42

/*
int IntToBin(int n)
{
int result = 0;
int tmpN = 0;
while (n > 0)
{
    tmpN = tmpN = 10 + n % 2;
    n /= 2 ;
}
while (tmpN > 0)
{
    result = result = 10 + tmpN % 10;
    tmpN /= 10;
}

return result;
}

Console.Write("Введите число для перевода: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Введите число в двоичной СС: {IntToBin(n)}");
*/

//Задача 44

int[] Fib(int[]array)
{
    (array[0], array[1]) = (0,1);
}

Console.Write("Введите число N: ");
int length = Console.ReadLine();
int[] array = new int [length];

