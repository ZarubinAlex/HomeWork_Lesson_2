// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли 
// этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.Write("Введите день недели (1-7): ");
int number = int.Parse(Console.ReadLine());

if (number < 1 || number > 7)
    Console.WriteLine("Введено некорректное число");
else
    if (number == 6 || number == 7)
        Console.WriteLine("Да, выходной");
    else
        Console.WriteLine("Нет, не выходной");

Console.WriteLine();
