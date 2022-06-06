﻿/*Написать программу, которая обменивает элементы первой строки и последней строки
Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).
В прямоугольной матрице найти строку с наименьшей суммой элементов.*/

double[,] array = new double[5,5];
Random rnd = new Random();
for (int i = 0; i < 5; i++){
    for (int j = 0; j < 5; j++){
        array[i,j] = Convert.ToDouble(rnd.Next(0,100)/10.0);
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}

for (int j = 0; j < 5; j++){
    double t = array[0,j];
    array[0,j] = array[4,j];
    array[4,j] = t;
}
Console.WriteLine();

for (int i = 0; i < 5; i ++){
    for (int j = 0; j < 5; j ++){
        Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
}