//T2

























//T4
























































//T6
























//T8


// Задача 8: Напишите программу, которая на вход принимает
// число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Задание 8");

System.Console.Write("Введите число: ");

int numberNT8 = Convert.ToInt32(Console.ReadLine());

int number2T8=2;

if (numberNT8==1 || numberNT8<=0)
{
    System.Console.WriteLine("Некорректное число");
    }
else 
{
    System.Console.Write(numberNT8+" -> ");
    while (number2T8<=numberNT8)
    {
        System.Console.Write(number2T8+" ");
        number2T8+=2;
    
    }  
}