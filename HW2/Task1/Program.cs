// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Write("Введите трехзначное число: ");

int thirdNumber = Convert.ToInt32(Console.ReadLine());

if (thirdNumber >= 100 && thirdNumber <= 999)
{
    int secondNumber = (thirdNumber / 10) % 10;
    Console.WriteLine ($"Вторая цифра трехзначного числа: {secondNumber}");
}
else
{
    Console.WriteLine ("Неверный ввод числа.");
}