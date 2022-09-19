/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

System.Console.WriteLine("Enter number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Enter number of cols: ");
int cols = Convert.ToInt32(Console.ReadLine());


int[,] GetArray (int rows, int cols)
{

    int[,] array = new int [rows,cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i,j] = new Random().Next(1 , 10);
        }
    }
    return array;
}

int[,] SortOfArray (int[,] array)
{
    int tmp = array[0,0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j; k < array.GetLength(1); k++)
            {
                if(array[i,j] < array[i,k]) 
                {
                    tmp = array[i,k];
                    array[i,k] = array[i,j];
                    array[i,j] = tmp;
                }
            }
        }
    }
    return array;
}

void ArrayOut (int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i,j]);
        }
        System.Console.WriteLine();
    }
}
int[,] array1 = GetArray(rows, cols);

ArrayOut(array1);

System.Console.WriteLine();

System.Console.WriteLine();

ArrayOut(SortOfArray(array1));

/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет
находить строку с наименьшей суммой элементов. Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки
с наименьшей суммой элементов: 1 строка */

int minOfArray = EnterIntNumber("Введите минимальное число массива по умолчанию");
int maxOfArray = EnterIntNumber("Введите максимальное число массива по умолчанию");

int EnterIntNumber(string text) 
{
    Console.Write($"{text}...\n");

    while (true)
    {
        try
        {
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        catch (FormatException)
        {
            Console.WriteLine($"Некорректный ввод. Введите целое число!\n");
        }
    }
}
int[,] GetArray2(int rows = 5, int columns = 3, int numMin = 1, int numMax = 9) 
{
    int[,] newArray = new int[rows, columns];
    var rand = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = rand.Next(numMin, numMax + 1);
        }
    }

    return newArray;
}

int[,] array2 = GetArray2(rows, cols, minOfArray, maxOfArray);

System.Console.WriteLine($"\nМассив №2:\n");
ArrayOut(array2);
Console.WriteLine();

FindMinSumOfArray(array2);

void FindMinSumOfArray(int[,] arr) 
{
    int[] arrSumOfRow = new int[arr.GetLength(0)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arrSumOfRow[i] += arr[i, j];
        }

        Console.WriteLine($"Сумма элементов строки {i + 1} = {arrSumOfRow[i]}");
    }

    int minSum = arrSumOfRow[0];
    int indexOfMinRow = 0;

    for (int i = 1; i < arrSumOfRow.Length; i++)
    {
        if (arrSumOfRow[i] < minSum)
        {
            minSum = arrSumOfRow[i];
            indexOfMinRow = i;
        }
    }

    Console.WriteLine($"\nСтрока массива с наименьшей суммой элементов ({minSum}) - № {indexOfMinRow + 1}\n");
}

