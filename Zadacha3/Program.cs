// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Данные вводятся с консоли пользователем

int len = ReadInt("Введите длинну массива: ");

int[] array = new int[len];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,9);
    Console.Write(array[i] + " ");
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

