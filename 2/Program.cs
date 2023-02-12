// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите число a: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c: ");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1 >= num2 && num1 >= num3)
{
    System.Console.Write("Максимальное число = а");
}
else if (num2 >= num3)
{
    System.Console.Write("Максимальное число = b");
}
else
{
    System.Console.Write("Максимальное число = c");
}