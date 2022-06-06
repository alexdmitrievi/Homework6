/*Показать двумерный массив размером m×n заполненный вещественными числами
Задать двумерный массив следующим правилом: Aₘₙ = m+n
В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты*/

double[,] array = new double[5,5];
Random rnd = new Random();
for (int i = 0; i < 5; i++){
    for (int j = 0; j < 5; j++){
        array[i,j] = Convert.ToDouble(rnd.Next(0,100)/10.0);
        Console.Write($"array[{i},{j}] : {array[i,j]} ");
    }
    Console.WriteLine();
}


