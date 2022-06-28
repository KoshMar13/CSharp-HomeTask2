// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Insert week day number: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 7)
{
    Console.Write($"There is no day {day}. Insert week day number: ");
    day = Convert.ToInt32(Console.ReadLine());
}
int Day(int num)
{
    if (num < 6)
        return 0;
    else
        return 1;
}
string result = Day(day) == 1 ? "да" : "нет";
Console.WriteLine(result);
