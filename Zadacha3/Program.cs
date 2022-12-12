// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Данные вводятся с консоли пользователем

// int MethodRead(string messege)
// {
//     Console.WriteLine(messege);
//     return Convert.ToInt32(Console.ReadLine());
// }

// //ЗАДАЧА НА МАССИВ
// int[] array = new int [15];
// //int number = new Random().Next(0,2);
// for (int i = 0; i < array.Length; i++)// length  длина массива
// {
//     array[i] = new Random().Next(0,2); // это мы рандомим каждый последующий элемент в массиве
// }
// Console.WriteLine(string.Join(",", array)); // Джоин это вывод массива в строку 


// int [] array = new int[8];
// {
    
//     for (int i = 0; i <= array.Length; i++)
//     {
//         array[i] = new Random().Next(1,10);
        
//     }
//     Console.WriteLine(string.Join(",", array[]));
    
   
// }

// int lenArray = MethodRead("Введите длину массива: ");

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

