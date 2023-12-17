// Задача 1: Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.


// int[,]array = new int[3,4]; // создание двумерного массива

// void CreateArray()    // заполнение массива
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }
// }
// void PrintArray()  //вывод массива
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void FindElementsArray() // выполнение задания
// {
//     Console.WriteLine("Введите число");
//     int n = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите число");
//     int m = Convert.ToInt32(Console.ReadLine());


//     if (m <= array.GetLength(0) + 1 && n <= array.GetLength(1) + 1)

//     {

//         //array[i,j] == array[n,m]
//         Console.Write($"Число равно - {array[n - 1, m - 1]}");
//     }

//     else

//     {
//         Console.WriteLine("Такого числа нет");
//     }

// }

// CreateArray();
// PrintArray();
// FindElementsArray();//готова


// // Задача 2: Задайте двумерный массив. Напишите программу, которая 
// поменяет местами первую и последнюю строку массива.


// int[,]array = new int[4,3]; // создание двумерного массива

// void CreateArray()    // заполнение массива
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }
// }
// void PrintArray()  //вывод массива
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void ConversArray()  // выполнение задания 
// {
//     int t;
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         t = array[0, j];
//         array[0, j] = array[3, j];
//         array[3, j] = t;
//     }

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// CreateArray();
// PrintArray();
// ConversArray(); //готова




// // Задача 3: Задайте прямоугольный двумерный массив. Напишите программу,
//  которая будет находить строку с наименьшей суммой элементов.

// int[,]array = new int[3,4]; // создание двумерного массива

// void CreateArray()    // заполнение массива
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }
// }
// void PrintArray()  //вывод массива
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void SumMinString()  // выполнение задания 
// {
//     int index =0, minsum =0;
//     for(int i =0; i<array.GetLength(0); i++)
//     {
//         int sum =0;
//         for(int j =0; j< array.GetLength(1); j++)
//         {
//             sum+=array[i,j]; //sum=sum+array[i,j
//         }
//         Console.WriteLine($"Сумма {i +1} строки = {sum}");
//         if (i==0)
//         {
//             minsum=sum;
//         }
//         else if(sum<minsum)
//         {
//             minsum=sum;
//             index=i;
//         }
//     }
//     string line = string.Empty;
//     for(int j =0; j<array.GetLength(1); j++)
//     {
//         line += array[index,j] + "";
//     }
//     Console.WriteLine($"Строка с минимальной суммой элементов - {index+1}.");
// }
// CreateArray();
// PrintArray();
// SumMinString();  //готова



// // Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении 
// которых расположен наименьший элемент массива. Под удалением понимается 
// создание нового двумерного массива без строки и столбца


// int[,] array = new int[3, 4]; // создание двумерного массива

// void CreateArray()    // заполнение массива
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 100);
//         }
//     }
// }
// void PrintArray()  //вывод массива
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {

//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
// void MinElementsArray() // выполнение задания
// {
//     int min = array[0, 0];
//     int MinRow = 0;
//     int MinCol = 0;
//     //Находим min элемент и его индексы
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < min)
//             {
//                 min = array[i, j];
//                 MinRow = i;
//                 MinCol = j;
//             }
//         }
//     }

//     int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1)];
//     int IndexRow = 0;
//     int IndexCol = 0;
//     Console.WriteLine($"Минимальный элемент массива {min}");

//     // преносим элементы массива в новый массив пропуская MinRow и MinCol.

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         if (i != MinRow)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 if (j != MinCol)
//                 {
//                     result[IndexRow, IndexCol] = array[i, j];
//                     IndexCol++;

//                 }
//             }
//             IndexRow++;
//             IndexCol = 0;
//         }

//     }

//     for (int i = 0; i < result.GetLength(0); i++)    //выводим новый массив уменьшив размерность
//     {
//         for (int j = 0; j < result.GetLength(1) - 1; j++)
//         {
//             Console.Write(result[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// CreateArray();
// PrintArray();
// MinElementsArray();
// //готова