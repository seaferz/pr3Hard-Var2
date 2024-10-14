/*Даны три числа a, b, c, которые представляют собой значения сторон 
треугольника. Определить вид треугольника: прямоугольный, остроугольный, 
тупоугольный */

//Просим пользователя ввести стороны треугольника
Console.Write("a = "); //сторона а
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("b = "); //сторона b
double b = Convert.ToDouble(Console.ReadLine());

Console.Write("c = "); //сторона c
double c = Convert.ToDouble(Console.ReadLine());


//По теореме Пифагора
if (a * a + b * b > c * c) //для остроугольного треугольника
{
    Console.WriteLine("Острый");
}
else if (a * a + b * b < c * c) // для тупоугольного треугольника
{
    Console.WriteLine("Тупой");
}
else //для остальных случаев (прямой)
{
    Console.WriteLine("Прямой");
}
