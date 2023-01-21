// Задача 41. Короткий вариант.
Console.WriteLine("Вводите числа. 0 - завершение ввода");
int temp = 0;
int val = 1;

while (val != 0)
{
    val = Convert.ToInt32(Console.ReadLine());
    if (val > 0) temp++;
}

Console.WriteLine($"Количество чисел > 0 = {temp}");