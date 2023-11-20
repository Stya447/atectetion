// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

//void ShowNums (int n, int i)
//{
//    
//    if (n > i)
//    {
//        ShowNums (n, i+1);
//        System.Console.Write(i + " ");
//    }
//}
//int i = 1;
//int n = 5;
//System.Console.Write(n + " ");
//ShowNums(n, i);

//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

//int SumNumbers (int m, int n)
//{
//    if (n == 0 || m == 0) return 0;
//    if (n > m)
//    {       
//        return SumNumbers(n - 1, m) + n; 
//    }
//    if (n < m)
//    {
//        return SumNumbers(n + 1, m) + n;
//    }
//    if (n==m)
//    {
//        return m;
//    }
//    else return n;
//}
//System.Console.Write(SumNumbers(4,8)+ " ");

//Напишите программу вычисления   с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
System.Console.Write(Akkerman(3,2)+ " ");