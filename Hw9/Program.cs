

/* string numberSeries(int M, int n)
{
    if (M <= n) return $"{M} " + numberSeries(M + 1, n);
    else return String.Empty;
}

int SumSeries(int M, int n)
{
    if (M < n) return M + SumSeries(M + 1, n);
    else return n;
}

ulong AkkermanFunction(ulong M = 2, ulong n = 3)
{
    if (M == 0 && (n != 0)) return n + 1;
    if ((n == 0) && (M != 0)) return AkkermanFunction(M - 1, 1);
    else return AkkermanFunction(M - 1, AkkermanFunction(M, n - 1));
}
 */

/*  Задайте значения M и n. Напишите программу, которая выведет все натуральные числа в промежутке от M до n.
M = 1; n = 5. -> ""1, 2, 3, 4, 5""
M = 4; n = 8. -> ""4, 6, 7, 8"" */


System.Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Все натуральные числа в промежутке от M до N: ");
for (int i = M; i <= N; i++)
{
    if (i < N) System.Console.Write($"{i}, ");
    
    else if (i == N) System.Console.Write($"{i}");
}
System.Console.WriteLine();
/* Задайте значения M и n. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до n.
M = 1; n = 15 -> 120
M = 4; n = 8. -> 30 */

int sum = 0;

for (int i = M; i <= N; i++)
{
    sum += i;
}
System.Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");

/* Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29 */

System.Console.WriteLine("Введите первое неотрицательное число n: ");
uint numN = Convert.ToUInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе неотрицательное число m: ");
uint numM = Convert.ToUInt32(Console.ReadLine());



static uint A(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}
System.Console.WriteLine($"Значения функции Аккермана: {A(numN,numM)}");