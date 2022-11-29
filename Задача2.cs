// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.Write("Введите b1 число: ");
double b1 = Convert.ToDouble(Console.ReadLine());
 System.Console.Write("Введите b2 число: ");
double b2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите k1 число: ");
double k1 = Convert.ToDouble(Console.ReadLine());
 System.Console.Write("Введите k2 число: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x=0;
double y=0;

if ((k1 == k2) && (b1 == b2))
    {
    Console.WriteLine ("Прямые совпадают");
    }
else 
{
    if (k2==k1)
    {
        Console.WriteLine ("Прямые параллельны");
    }
    else
    {
        x=(b2-b1)/(k1-k2);

        y=(k1*(b2-b1))/(k1-k2)+b1;

        Console.WriteLine ($"x= {x} y= {y}");
    }
}