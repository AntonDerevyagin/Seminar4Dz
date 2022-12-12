// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int MethodRead(string messege)
{
    Console.WriteLine(messege);
    return Convert.ToInt32(Console.ReadLine());
}

void MethodSum(int number) //567
{
    int res = 0;
    int tot = 0;
    while (number > 0)
    {
        res = number % 10;
        tot = tot + res;
        number = number / 10;
    }
    Console.WriteLine(tot);
}

int number = MethodRead("Введите число: ");
MethodSum(number);