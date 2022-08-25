// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
string? end = "end", input = "";
int N;
while (input != end)
{
    do 
    {
        try
        {
            Console.Write("Please enter a positive number: ");
            N = Convert.ToInt32(Console.ReadLine());
            int Number1 = 1;
            if (N > 0 )
            {   
                Console.Write("All even numbers from 1 to N: ");
                while (Number1 <= N)
                {
                    if(Number1 %2 == 0)
                    {
                        Console.Write(Number1+" ");
                    }
                    ++Number1;
                }
            }
            else
            {
                Console.Write("Invalid number entered");
            }
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Wrong symbol format");
        }
    }
    while(true);
Console.WriteLine("");
Console.Write("Чтобы закончить работу в программе введите end. Для продолжения работы, нажмите Enter: ");
input = Console.ReadLine();
}