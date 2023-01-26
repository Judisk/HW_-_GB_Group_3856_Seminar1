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

// Задача 2: Напишите программу, которая на вход принимает
// два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Задача 4");

System.Console.WriteLine("Введите число 1");

int numberOneT4 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число 2");

int numberTwoT4 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число 3");

int numberThreeT4 = Convert.ToInt32(Console.ReadLine());

int maxFirstSplitT4,maxSecondSplitT4;

if (numberOneT4<numberTwoT4)
{
    maxFirstSplitT4=numberTwoT4;
}
else
{
    maxFirstSplitT4=numberOneT4;
}
if (numberOneT4<numberThreeT4)
{
    maxSecondSplitT4=numberThreeT4;
}
else
{
    maxSecondSplitT4=numberOneT4;
}

if (maxFirstSplitT4>maxSecondSplitT4)
{
    System.Console.WriteLine(numberOneT4+", "+numberTwoT4+", "+numberThreeT4+" -> "+maxFirstSplitT4);
}
else if (maxFirstSplitT4==maxSecondSplitT4)
{
    System.Console.WriteLine(numberOneT4+", "+numberTwoT4+", "+numberThreeT4+" -> "+maxFirstSplitT4);
}
else
{
    System.Console.WriteLine(numberOneT4+", "+numberTwoT4+", "+numberThreeT4+" -> "+maxSecondSplitT4);
}

