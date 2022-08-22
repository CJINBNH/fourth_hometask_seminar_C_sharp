// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int digit = 0;
int sum = 0;
int count = 0;
// while (number > 0)
for (int j = 10; j < number * 10; j = j * 10)
{
    digit = number / j;
    count++;
    // Console.WriteLine(count);
}
for (int i = 0; i < count; i++)
{
    sum = (number % 10) + sum;
    number = number / 10;
    // Console.WriteLine(number);
}
if (number == 1) sum = 1;

Console.WriteLine(sum);