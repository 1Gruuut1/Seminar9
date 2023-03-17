// Рекурсия.
// Задачи:
// 1. Необходимо написать программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int num)
{
    if(num > 1) ShowNums(num - 1);
    Console.Write(num + " ");
}

ShowNums(5);
*/
// 2. Необходимо написать программу, которая будет принимать на вход некоторое число и возвращать сумму его цифр.
/*
int SumOfDigits(int num)
{
    if(num != 0) return SumOfDigits(num / 10) + num % 10;
    else return 0;
}

int result = SumOfDigits(123);
Console.WriteLine(result);
*/
// 3. Задайте значения M и N, напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNumbers(int m, int n)
{
    if(m < n)
    {
        ShowNumbers(m, n - 1);
        Console.Write(n + " ");
    }
    else if(m > n)
    {
        ShowNumbers(m, n + 1);
        Console.Write(n + " ");
    }
    else if(m == n)
        Console.Write(n + " ");
}

ShowNumbers(1,9);
*/
/*
void ShowNums(int n, int m)
{
    if(n > m) ShowNums(n, m + 1);
    if(n < m) ShowNums(n, m - 1);
    Console.Write(m + " ");
}

ShowNums(1,9);
*/
// 4. Напишите программу которая на вход принимает два числа A и B, и возводит число A в целую степень B.
/*
double CustomPow(double a, int b)
{
    if(b > 0) return a * CustomPow(a, b - 1);
    if(b < 0) return (1/a) * CustomPow(a, b + 1);
    return 1;
}

Console.WriteLine(CustomPow(2,3));
Console.WriteLine(CustomPow(2,-3));
*/

// Домашнее задание:

// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
/*
void NaturalNum(int num)
{
    Console.Write(num + " ");
    if(num > 1) NaturalNum(num - 1);
    
}

NaturalNum(5);
*/


// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
void SumNaturNum (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine(sum); 
        return;
    }
    sum = sum + (m++);
    SumNaturNum(m, n, sum);
}

SumNaturNum(1, 3, 0);
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
/*
int FunctionAckerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return FunctionAckerman(m - 1, 1);
    if (m > 0 && n > 0) return FunctionAckerman(m - 1, FunctionAckerman(m, n - 1));
return FunctionAckerman(m, n);
}

int result = FunctionAckerman(1,5);
Console.WriteLine(result);
*/
