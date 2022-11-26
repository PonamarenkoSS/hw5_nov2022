// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] MakeArray(int size, int MinValue, int MaxValue)
// {
//     int[] array = new int[size];
//     for (int i=0; i<size; i++)
//     {
//         array[i] = new Random().Next(MinValue, MaxValue);
//     }
//     return array;
// }

// int[] ARRAY = MakeArray(10, 100, 1000);
// Console.WriteLine($"Массив: [{String.Join(",", ARRAY)}]");

// int GetCount(int[] ARRAY)
// {
//     int count = 0;
//     for (int i=0; i<ARRAY.Length; i++)
//     {
//         if (ARRAY[i]%2==0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int result = GetCount(ARRAY);
// Console.WriteLine($"Количество чётных числе в массиве составляет {result}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] MakeArray(int size, int MinValue, int MaxValue)
// {
//     int[] array = new int[size];
//     for (int i=0; i<size; i++)
//     {
//         array[i] = new Random().Next(MinValue, MaxValue);
//     }
//     return array;
// }

// int[] ARRAY = MakeArray(10, -50, 51);
// Console.WriteLine($"Массив: [{String.Join(",", ARRAY)}]");

// int GetSum(int[] ARRAY)
// {
//     int sum = 0;
//     for (int i=1; i<ARRAY.Length; i+=2)
//     {
//        sum += ARRAY[i];
//         }
//     return sum;
// }

// int result = GetSum(ARRAY);
// Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях, составляет {result}");

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int[] MakeArray(int Size, int MinValue, int MaxValue)
// {
//     int[] array = new int[Size];
//     for (int i=0; i<Size; i++)
//     {
//         array[i] = new Random().Next(MinValue, MaxValue);
//     }
//     return array;
// }

// int[] ARRAY = MakeArray(9, -10, 10);
// Console.WriteLine($"Массив: [{String.Join(",", ARRAY)}]");

// int[] NewArray (int[] array)
// {  
//     int size = 0;
//     int[] newARRAY = new int[size];
//     if (array.Length%2 == 0)
//     {
//         newARRAY = new int[array.Length/2];
//         for (int i = 0; i<array.Length/2; i++)
//         {
//             newARRAY[i] = array[i]*array[array.Length-1-i];
//         }
//     }
//     else 
//     {
//         newARRAY = new int[array.Length/2+1];
//         for (int i = 0; i<array.Length/2; i++)
//         {
//             newARRAY[i] = array[i]*array[array.Length-1-i];
//         } 
//         newARRAY[array.Length/2] = array[array.Length/2];
//     }
//     return newARRAY;
// }

// int[] NewARRAY = NewArray(ARRAY);
// Console.WriteLine($"Преобразованный массив: [{String.Join(",", NewARRAY)}]");

// Задача 38: Задайте массив целых чисел от -10 до 10. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// int[] MakeArray(int size, int MinValue, int MaxValue)
// {
//     int[] array = new int[size];
//     for (int i=0; i<size; i++)
//     {
//         array[i] = new Random().Next(MinValue, MaxValue);
//     }
//     return array;
// }

// int[] ARRAY = MakeArray(10, -10, 11);
// Console.WriteLine($"Массив: [{String.Join(",", ARRAY)}]");

// int GetMax(int[] array)
// {
//     int i = 0;
//     int max = array[i];
//     foreach(int el in array)
//     {
//         if (el>max)
//         {
//             max = el;
//         }
//     }
//     return max;
// }

// int GetMin(int[] array)
// {
//     int i = 0;
//     int min = array[i];
//     foreach(int el in array)
//     {
//         if (el<min)
//         {
//             min = el;
//         }
//     }
//     return min;
// }
// int result = GetMax(ARRAY) - GetMin(ARRAY);
// Console.WriteLine($"Разница между максимальным {GetMax(ARRAY)} и минимальным {GetMin(ARRAY)} значением массива составляет {result}");
