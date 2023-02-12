// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите числa a: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите числa b: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2)
{
    System.Console.Write("a равно b");
    return;
}

if (num1 >= num2)
{
System.Console.Write("a больше чем b");
}
else
{
    System.Console.Write("b больше чем a");
}