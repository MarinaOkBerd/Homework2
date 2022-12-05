// на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ((number < 100) || (number >= 1000))
{
    Console.WriteLine("Введено неверное число.");
}
else
{
    Console.WriteLine(((number % 100) / 10));
}  