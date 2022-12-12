// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

int MethodRead(string messege)
{
    Console.WriteLine(messege);
    return Convert.ToInt32(Console.ReadLine());
}

void MethodDegree(int a, int b)
{
    int res = 1;
    for (int i = 1; i <= b; i++)
    {
        res = res * a;
        
    }
    Console.WriteLine(res);

}

int numberA = MethodRead("Введите число А: ");
int numberB = MethodRead("Введите число B: ");
MethodDegree(numberA, numberB);


