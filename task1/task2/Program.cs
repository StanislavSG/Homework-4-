//Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу,
 //которая покажет количество чётных чисел в массиве.
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] array = new int[10]; // Создаем массив из 10 элементов

        // Заполняем массив случайными трехзначными числами
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = RandomNumber();
        }

        // Подсчет количества четных чисел в массиве
        int evenCount = 0;
        foreach (var number in array)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        Console.WriteLine($"Количество четных чисел в массиве: {evenCount}");
    }

    // Метод для генерации случайного трехзначного числа
    static int RandomNumber()
    {
        return new Random().Next(100, 1000); // Генерация числа от 100 до 999
    }
}
