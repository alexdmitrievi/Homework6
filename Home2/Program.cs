//Задать двумерный массив следующим правилом: Aₘₙ = m+n

int[,] array = new int[5,5];
for (int m = 0; m < 5; m++){
    for (int n = 0; n < 5; n++){
        array[m,n] = m+n;
        Console.Write($"{array[m,n]} ");
    }
    Console.WriteLine();
}


