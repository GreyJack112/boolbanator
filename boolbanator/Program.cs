using System;
using static System.Console;
int c;
double a=0, b=0;
int i = 0;
Title = "Boolbanator";
ConsoleColor Default = Console.ForegroundColor;
//Console.BackgroundColor = ConsoleColor.Blue;
//Console.Clear();
while (true)
{

    i = ++i;
   // WriteLine(i);
   Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("1.Сложение \n2.Вычитание \n3.Умножение \n4.Деление \n5.Возведение в степень \n6.Извлечение корня по основанию \n7.EXIT\n");
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    bool s = int.TryParse(ReadLine(), out c);
        if (s == false)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        WriteLine("\n Error\n ");
        Console.ForegroundColor = Default;
        continue;
    }
   // c = Convert.ToInt32(Console.ReadLine());
    if (c == 7)
    { return; }
    if (c>7)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        WriteLine("\n Error\n ");
        Console.ForegroundColor = Default;
        continue;
    }
    Console.ForegroundColor = ConsoleColor.Green;
    WriteLine("---------------------");
    WriteLine("Введите первую переменную\n");
    s = false;
    while (s != true)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        s = double.TryParse(ReadLine(), out a);
        if (s == false)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            WriteLine("\n Не верная переменная\n ");
            Console.ForegroundColor = Default;
            continue;
        }
        //a = Convert.ToDouble(Console.ReadLine());
    }
    Console.ForegroundColor = ConsoleColor.Green;
    WriteLine("Введите вторую переменную\n");
    s = false;
    while (s != true)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        s = double.TryParse(ReadLine(), out b);
        if (s == false)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            WriteLine("\n Не верная переменная\n ");
            Console.ForegroundColor = Default;
            continue;
        }
        // b = Convert.ToDouble(Console.ReadLine());
    }
    double result;
    Console.WriteLine("---------------------");
    Console.ForegroundColor = ConsoleColor.Yellow;
    if (c == 1)
    {
        result = a + b;
        WriteLine($"Результат сложения {result} \n");
    }
    else if (c == 2)
    {
        result = a - b;
        WriteLine($"Результат вычитания {result} \n");
    }
    else if (c == 3)
    {
        result = a * b;
        WriteLine($"Результат умножения {result}\n");
    }
    else if (c == 4)
    {
        result = a / b;
        if (b == 0)
            WriteLine("На 0 делить нельзя\n");
        else
            WriteLine($"Результат деления {result}\n");
    }
    else if (c == 5)
    {
        result = Math.Pow(a, b);
        WriteLine($"Результат возведения в степень {b} равен {result}\n");
    }
    else if (c == 6)
    {
        result = Math.Pow(a, 1 / b);
        WriteLine($"Число возведенное в степень {b} равно {result}\n");
    }
   
    else
    { WriteLine("\nkek\n"); }

    //if (i > 0)
    //{
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Вы хотите выйти: Y/N.\n");
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string l = Console.ReadLine();
            if (l == "Y")
            {
                Console.ForegroundColor = Default;
                return;
            }
            else if (l == "N")
                break;
            else
                Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nError\n");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            continue;
      //  }
    }
}
