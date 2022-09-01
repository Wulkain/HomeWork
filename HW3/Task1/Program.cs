// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void StrCheckForPalindrome()
{
    Console.Write("Введите пятизначное число: ");
    string Palindrom = Console.ReadLine()!;

    Palindrom = Palindrom.ToLower().Replace(" ", "");

    int check = 0;
    for (int i = 0; i < Palindrom.Length / 2; i++)
    {
        if (Palindrom[i] == Palindrom[Palindrom.Length - 1 - i]) check++;
    }

    if (check == Palindrom.Length / 2)
    {
        System.Console.WriteLine("Данное число является полиндромом.");
}
else
{
    System.Console.WriteLine("Данное число НЕ является полиндромом.");
}
}
StrCheckForPalindrome();