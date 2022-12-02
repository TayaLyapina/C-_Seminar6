/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/


Console.Write("Введите числа через запятую: ");
string output = Console.ReadLine();

char symbol = ',';
string[] subs = output.Split(symbol, StringSplitOptions.RemoveEmptyEntries);

int [] numbers = Array.ConvertAll(subs, int.Parse);

int count = 0;

for (int i = 0; i< numbers.Length; i++)
{
    if (numbers[i]>0)
        count++;
        Console.Write($" {numbers[i]} | ");
}

 Console.WriteLine($" - > {count}");


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


