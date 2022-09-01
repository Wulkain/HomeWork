//  напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3d пространстве.
//  a (3,6,8); b (2,1,-7), -> 15.84
//  a (7,-5, 0); b (1,-1,9) -> 11.53;
Console.Write("Введите первое значени координаты Х: ");
double Xa = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите первое значени координаты Y: ");
double Ya = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите первое значени координаты Z: ");
double Za = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе значени координаты Х: ");
double Xb = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе значени координаты Y: ");
double Yb = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе значени координаты Z: ");
double Zb = Convert.ToDouble(Console.ReadLine());

double Distance = Math.Sqrt((Math.Pow((Xb - Xa), 2) + Math.Pow((Yb - Ya), 2) + Math.Pow((Zb - Za), 2)));
Console.Write($"Расстояние между двумя точками в 3d пространстве: {Distance:f2}");