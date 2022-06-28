// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Insert number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number / 10 < 10)
{
    Console.WriteLine("Третьей  цифры нет");
}
else
{
    
