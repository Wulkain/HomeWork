// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
void ShowThirdDigit (int num)
{
    if (num > 99)
    {
        System.Console.WriteLine($"Третья цифра заданного числа {num.ToString()} это {num.ToString()[2]}");
    }

    else
    {
        System.Console.WriteLine ("Неверный ввод числа.");
    }
}
ShowThirdDigit(78);