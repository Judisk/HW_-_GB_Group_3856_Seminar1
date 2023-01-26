//Start
// Задача 2: Напишите программу, которая на вход принимает
// два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.WriteLine("Задача 2");

System.Console.Write("Введите число 1: ");

int NumberOneT2 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число 2: ");

int NumberTwoT2 = Convert.ToInt32(Console.ReadLine());

if (NumberOneT2>NumberTwoT2)
{
    System.Console.WriteLine("a  = "+ NumberOneT2 + "b = "+ NumberTwoT2+" -> Max = "+ NumberOneT2 );
    }
else
{
    System.Console.WriteLine("a  = "+ NumberOneT2 + " b = "+ NumberTwoT2+" -> Max = "+ NumberTwoT2 );
    }







