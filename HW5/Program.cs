/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */
int[] Massive ()
{
    Console.Write("Введите размер массива для задачи №34: ");
    int numElemM = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[numElemM];

    for (int i = 0; i < numElemM; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}
int EvenNum (int[] arr)
{
    int countEvenNum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0) countEvenNum++;
    }
    return countEvenNum;
}
int[] mass = Massive ();
System.Console.WriteLine($"В массиве: {String.Join(",", mass)} кол-во четных чисел равно: {EvenNum(mass)}");



/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int[] Massive1 ()
{
    Console.Write("Введите размер массива для задачи 36 или 37: ");
    int numElemM = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[numElemM];

    for (int i = 0; i < numElemM; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    return array;
}
int OddNum (int[] arr)
{
    int sumOdd = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sumOdd += arr[i];
    }
    return sumOdd;
}
int[] mass1 = Massive1 ();
System.Console.WriteLine($"В массиве: {String.Join(",", mass1)} сумма чисел нечетных позиций: {OddNum(mass1)}");


/* Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

int[] ProdOfNum (int[] arr)
{
    int[] prod = new int[(arr.Length + 1) / 2];
    for (int i = 0; i < (arr.Length + 1) / 2; i ++)
    {
        prod[i] = arr[i] * arr[arr.Length - i - 1];
    }
    if (arr.Length % 2 != 0) prod[arr.Length / 2] = arr[arr.Length / 2];
    return prod;
}
int[] massProd = Massive1 ();
System.Console.WriteLine($"В массиве: {String.Join(",", massProd)} находим произведение пар чисел и записываем в новый массив: {String.Join(",", ProdOfNum(massProd))}");


/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

double[] MyArray() 
{
Console.Write("Введите размер массива для задачи №38: ");

int sizeArray = Convert.ToInt32(Console.ReadLine());
 
    double[] array = new double[sizeArray]; 
 
    for (int i = 0; i < sizeArray; i++) array[i] = new Random().Next(0, 101); 
 
    Console.WriteLine($"Массив чисел:\n{String.Join(", ", array)}"); 
 
    return array; 
}

double DiffMinMax(double[] array4) 
{ 
    double minElem = array4[0]; 
    double maxElem = array4[0]; 
             
    for (int i = 1; i < array4.Length; i++) 
    { 
        if (array4[i] < minElem) minElem = array4[i]; 
        if (array4[i] > maxElem) maxElem = array4[i]; 
    } 
 
    Console.WriteLine($"Минимальный элемент массива: {minElem}\n Максимальный элемент массива: {maxElem}"); 
 
    return maxElem - minElem; 
}

double[] diff = MyArray ();
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна: {(DiffMinMax(diff))}\n");