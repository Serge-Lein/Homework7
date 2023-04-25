// Task 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] RandomArray()
// {
//     Console.Write("Input number of rows and press <enter>: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input number of colomns and press <enter>: ");
//     int colomns = Convert.ToInt32(Console.ReadLine());

//     double[,] array = new double[rows, colomns];
//     for(int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colomns; j++)
//         {
//             array[i, j] = Math.Round(new Random().Next(-100, 101) + new Random().NextDouble(), 2);
//         }
//     }
//     return array;
// }


// void Print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]} ");
//         }
//             Console.WriteLine();
//     }
// }


// Print2DArray(RandomArray());








////////////////////////////////////////////////////////////////////////////////////////////////
//Task 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.


// int[,] RandomArray()
// {
//     Console.Write("Input number of rows and press <enter>: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input number of colomns and press <enter>: ");
//     int colomns = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, colomns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colomns; j++)
//         {
//             array[i, j] = new Random().Next(1, 100);
//         }
//     }
//     return array;
// }

//  void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[] StringToNum(string input)
// {
//     int count = 1;
//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] == ',')
//         {
//             count++;
//         }
//     }

//     int[] numbers = new int[count];
//     int index = 0;

//     for (int i = 0; i < input.Length; i++)
//     {
//         string temp = "";

//         while (input[i] != ',')
//         {
//             if (i != input.Length - 1)
//             {
//                 temp += input[i].ToString();
//                 i++;
//             }
//             else
//             {
//                 temp += input[i].ToString();
//                 break;
//             }
//         }
//         numbers[index] = Convert.ToInt32(temp);
//         index++;
//     }
//     return numbers;
// }

// void PrintArray(string msg, int[] array)
// {
//     Console.Write(msg);
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");

//     }
//     Console.WriteLine();
// }

//     void FindIn2DArray(int[,] array)
// {
//     Console.Write("Input the index of a number in your 2D array, separeting it with a comma. For example <rows, colomns>: ");
//     string parameters = Console.ReadLine();
//     int[] coord = StringToNum(parameters);

//     if (coord[0] < 0 || coord[1] < 0 || coord[0] > array.GetLength(0) -1 || coord[1] > array.GetLength(1) -1)
//     {
//         Console.WriteLine($"Your array does not include indexes Rows: {coord[0]}; Colomns: {coord[1]}");
//     }
//     else
//     {
//         Console.WriteLine($"The value of the element Rows: {coord[0]}; Colomns: {coord[1]} is equal {array[coord[0], coord[1]]}");
//     }
// }


// int[,] array = RandomArray();
// Print2DArray(array);
// FindIn2DArray(array);














////////////////////////////////////////////////////////////////////////////////////////////////
// // Task 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int[,] RandomArray()
// {
//     Console.Write("Input number of rows and press <enter>: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Input number of colomns and press <enter>: ");
//     int colomns = Convert.ToInt32(Console.ReadLine());

//     int[,] array = new int[rows, colomns];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colomns; j++)
//         {
//             array[i, j] = new Random().Next(1, 100);
//         }
//     }
//     return array;
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void PrintArray(string msg, double[] array)
// {
//     Console.Write(msg);
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");

//     }
//     Console.WriteLine();
// }

// double[] AverageOfColomns(int[,] array)
// {
//     double[] averageArray = new double[array.GetLength(1)];

//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             sum += array[j, i];
//         }
//         averageArray[i] = Math.Round(sum / Convert.ToDouble(array.GetLength(0)), 2);
//     }
//     return averageArray;
// }


// int[,] array = RandomArray();
// Print2DArray(array);
// PrintArray("Average numbers of colomns: ", AverageOfColomns(array));


