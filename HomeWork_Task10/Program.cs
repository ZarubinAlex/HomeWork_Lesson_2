// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


 int ShowNumber(string txt, int number)
{
    int digit = Convert.ToInt32(txt[number - 1].ToString());
    return digit;
}


Console.Clear();
Console.Write("Введите число: ");
string digit = Console.ReadLine();

int numberOfShowDigit = 2;

Console.WriteLine(numberOfShowDigit + "-я цифра числа " + digit + ": " + ShowNumber(digit, numberOfShowDigit));
Console.WriteLine();