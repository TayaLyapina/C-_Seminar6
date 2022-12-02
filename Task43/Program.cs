/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, 
y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double numberB1 = ReadInt("Введите число b1: ");
double numberK1 = ReadInt("Введите число k1: ");
double numberB2 = ReadInt("Введите число b2: ");
double numberK2 = ReadInt("Введите число k2: ");

if (numberB1 == numberB2)
    Console.WriteLine("Прямые совпадают");

else if(numberK1 != numberK2)
{
    double resultX = (numberB2-numberB1)/(numberK1-numberK2);
    double resultY = numberK1 * resultX + numberB1;
    Console.WriteLine($"Точка пересечения двух прямых ({resultX}; {resultY})");
}
else
    Console.WriteLine("Прямые параллельны");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}