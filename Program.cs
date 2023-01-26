//T2

























//T4
























































//T6


// Задача 6: Напишите программу, которая на вход принимает
// число и выдает, является ли число четным (делится ли оно на
// два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.WriteLine("Задача 6");

System.Console.WriteLine("Введите число");

int numberT6 = Convert.ToInt32(Console.ReadLine());

if (numberT6%2==0)
{
    System.Console.WriteLine(numberT6+" -> да");
}
else
{
    System.Console.WriteLine(numberT6+" -> нет");
}

