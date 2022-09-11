/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

int[] CreatArray () 
{ 
 
System.Console.WriteLine($"Enter a size of array : "); 
int sizeArray = Convert.ToInt32(Console.ReadLine()); 
 
int[] array = new int[sizeArray]; 
 
    for (int i = 0; i < sizeArray; i++) 
    { 
        System.Console.Write($"Enter number {i + 1}:\t"); 
        array[i] =  Convert.ToInt32(Console.ReadLine()); 
    } 
 
    System.Console.WriteLine($"Massive: {String.Join(",", array)}"); 
    return array; 
} 
 
int SumPosNumb (int[] array) 
{ 
    int count = 0; 
    for (int i = 0; i < array.Length; i++) 
    { 
        if (array[i] > 0) count ++; 
    } 
    return count; 
} 
int[] ArrWthPosNumb = CreatArray (); 
System.Console.WriteLine($"Sum of positive numbers: {SumPosNumb(ArrWthPosNumb)}");

/* Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

System.Console.WriteLine("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

System.Console.WriteLine("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

if (k1 != k2)
{
    double x = (b2 - b1) / (k1 - k2);

    double y1 = k1 * x + b1;

    Console.WriteLine($"Координаты точки пересечения этих прямых: ({Math.Round(x, 3)}; {Math.Round(y1, 3)})");
}
else if ((k1 == k2) && (b1 == b2)) Console.WriteLine("Прямые совпадают."); 
 
else if ((k1 == k2) && (b1 != b2)) Console.WriteLine("Нет точки пересечения, прямые параллельны.");