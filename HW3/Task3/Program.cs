// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N: ");

int NumN = Convert.ToInt32(Console.ReadLine());

Console.Write("Таблица кубов чисел от 1 до N: ");

for(int i = 1; i <= NumN; i++)
{
    if (i != NumN)
    Console.Write($"{Math.Pow(i, 3)}, ");

    if (i == NumN)
    Console.Write($"{Math.Pow(i, 3)}");
}