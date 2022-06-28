// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number / 100 > 10 || number / 100 == 0)
{
    Console.Write("Вы ввели неправильное число. Введите трёхзначное число: ");
    int numb = Convert.ToInt32(Console.ReadLine());
    number = numb;
}

int Decim(int decim)
{
    return (decim / 10) % 10;
}

Console.WriteLine(Decim(number));
