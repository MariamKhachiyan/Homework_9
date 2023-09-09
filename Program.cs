// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/* Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

int endNum = 1;

string PrintNumber(int start, int end)
{
  if (start == end)
  {
    return start.ToString();
  }
  return (start + " " + PrintNumber(start - 1, end));
}

Console.WriteLine(PrintNumber(num, endNum)); */




// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/* 
System.Console.Write("Enter number M: ");
int num1 = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Enter number N: ");
int num2 = Convert.ToInt32(System.Console.ReadLine());

if (num1 < num2)
{
    Console.WriteLine($"Amount of natural numbers in the interval from {num1} to {num2}: {PrintGetSum(num1, num2)}");
}
else
{
    System.Console.WriteLine("Number N must be greater then number N.");
}

int PrintGetSum(int start, int end)
{
    if (start == end)
    {
        return start;
    }
    return start + PrintGetSum(start + 1, end);
} 
 */

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

/* 
Console.WriteLine("Enter first number:");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

int AckermannFunction(int m, int n)
{
    if (m == 0) 
    {
        return n + 1;
    }
    else if ((m > 0)&& (n == 0))
    {
        return AckermannFunction(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
    else
    {
        return n + 1 ;
    }
}

Console.WriteLine(AckermannFunction(numberOne, numberTwo));

 */