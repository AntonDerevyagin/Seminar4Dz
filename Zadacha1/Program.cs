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

void MethodDegree(int A, int B)
{
    int res = 1;
    for (int i = 1; i <= B; i++)
    {
        res = res * A;
        
    }
    Console.WriteLine(res);

}

int A = MethodRead("Введите число А: ");
int B = MethodRead("Введите число B: ");
MethodDegree(A,B);


