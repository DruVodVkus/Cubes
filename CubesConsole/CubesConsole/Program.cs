﻿double balance = 1000; // базовый баланс
do //начало цикла
{
    Console.WriteLine("Ваш баланс равен " + balance + " рублей");
    Console.WriteLine("Введите ставку");
    double bet = Convert.ToDouble(Console.ReadLine()); // ввод переменной кона
    Console.WriteLine("Выберите число число от 1 до 6 ");
    double a = Convert.ToDouble(Console.ReadLine());// Ввыод значения для джекпота
    Random rnd = new Random();
    int value = rnd.Next(1, 6); //вычисление числа на первом кубике
    Console.WriteLine("Выпавшее число: " + value);
    Random r2d = new Random();
    int value2 = r2d.Next(1, 6); //вычисление числа на первом кубике
    Console.WriteLine("Выпавшее число: " + value2);

    Console.WriteLine();
    double rand = value;
    double ra2d = value2;
    if ((a == rand) | (a == ra2d))  // проверка на джекпот
    {
        Console.WriteLine("Вам выпал джекпот");
        balance = balance + (bet * a);
    }
    else
    {
        {
            if ((rand + ra2d) % 2 == 0)
            {
                balance = balance + bet;
            }
            else
            {
                balance = balance - bet;
            }
        }
    }
} while (balance > 0);
Console.WriteLine("Ну, сорри, не прокнуло :(");