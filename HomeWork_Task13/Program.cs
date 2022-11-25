// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


 int ShowNumber(string txt, int number)
{
    int digit = Convert.ToInt32(txt[number - 1].ToString());
    return digit;
}

Console.Clear();
Console.Write("Введите число: ");
string digit = Console.ReadLine();

int numberOfShowDigit = 3;

if(numberOfShowDigit > digit.Length) 
    Console.WriteLine(numberOfShowDigit + "-й цифры нет");
else
    Console.WriteLine(numberOfShowDigit + "-я цифра числа " + digit + ": " + ShowNumber(digit, numberOfShowDigit));

Console.WriteLine();