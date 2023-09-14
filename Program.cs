// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] array =  new int [10];
// int countPositiveNum = 0;
// int chet = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100,1000);
//     System.Console.Write(array[i] + " ");
//     chet = array[i]%2;
//     if (chet == 0)
//     {
//         countPositiveNum++;
//     }
// }
// System.Console.WriteLine(countPositiveNum);



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array =  new int [10];
// int sumNechet = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-100,100);
//     System.Console.Write(array[i] + " ");
//     if (i%2 != 0)
//     {
//         sumNechet = sumNechet + array[i];

//     }
// }
// System.Console.Write(sumNechet + " ");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// double[] array =  new double [10];
// Random rand = new Random(); 
// double sum = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = Math.Round(rand.Next(0,100) + rand.NextDouble(),3);
//     System.Console.Write(array[i] + " ");
// }
// double max = array[0];
// double min = array[0];
//     for (int j = 0; j < array.Length; j++)
//     {
//     if (array[j] > max)
//     {
//         max = array[j];
//     }
//     if ( array[j] < min)
//     {
//         min = array[j];
//     }
//     }
// System.Console.WriteLine(max + "");
// System.Console.WriteLine(min + "");
// sum = max - min;
// System.Console.WriteLine(sum);

