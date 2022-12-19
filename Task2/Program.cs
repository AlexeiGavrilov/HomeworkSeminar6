// Напишите программу, которая найдёт точку пересечения двух прямых на плоскости, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Ввведите значение k1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите значение b1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите значение k2");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите значение b2");
int b2 = Convert.ToInt32(Console.ReadLine());
if ((k1 == k2) && (b1 == b2))
{
 Console.WriteLine("Прямые совпадают");
} 
else if (k1==k2)
{
Console.WriteLine("Прямые параллельны");
}
else
{
float x=(float)(b2-b1)/(k1-k2);
float y=(float)(k1*(b2-b1))/(k1-k2)+b1;
Console.WriteLine();
Console.WriteLine($"Точка пересечения на плоскости ({x},{y})");
}



