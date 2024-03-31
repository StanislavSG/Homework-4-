//Задача 3: Напишите программу, которая перевернёт одномерный массив
// (первый элемент станет последним, второй – предпоследним и т.д.)
using System;

class Program
{
    static void Main()
    {
        int[] array = {1, 2, 3, 4, 5}; // Исходный массив
        Array.Reverse(array); // Переворачиваем массив
        
        Console.WriteLine("Перевернутый массив: ");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }
}
