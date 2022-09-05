// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
double Circle (int A, int B)
{
    double result =1;
    for(int i = 1;i <= B;i++ ) result *= A;
    return result;
}
Console.WriteLine($"Результат числа А в степени В: {Circle(numA,numB)}");


// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int Summ ()
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int result = 0;
    for (int i = 0; num > 0; i++)
    {
        result += num%10;
        num = num/10;
       
    }
    return result;
}
Console.WriteLine($"Сумма цифр в числе: {Summ()}");


/* Напишите программу, которая задаёт массив из введенного числа и выводит их на экран.
пользователь вводит число элементов в массиве и минимальное, и максимальное значение . 
надо заполнить массив рандоными данными от минимального до максимального значение .
И важное уточнениее , делать все в методе который возвращает массив
5, 1, 20 -> [1, 2, 5, 7, 19]
3, 1, 33 -> [6, 1, 33] */
int[] Massive ()
{
    Console.Write("Введите размер массива: ");
    int numElementM = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите минимальное число массива: ");
    int minM = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите максимальное число массива: ");
    int maxM = Convert.ToInt32(Console.ReadLine());
    
    int[] array = new int[numElementM];

    for (int i = 0; i < numElementM; i++)
    {
        array[i] = new Random().Next(minM, maxM + 1);
    }
    return array;
}
System.Console.Write($"Массив: {String.Join(",", Massive())}");