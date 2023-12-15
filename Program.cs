/*
Задача 30
Напишите программу, которая выводит массив из 8-ми элементов, заполненный нулями 
и единицами в случайном порядке [1,0,1,1,0,1,0,0]
*/
int size = 8;
int[] array = new int [size]; // Массив из 8 элементов, изначально 8 нулей
for (int i = 0; i < size; i++)
{
   array[i] = new Random ().Next(0, 2); 
   // array[i] = new Random ().Next(2)
   //Console.Write(array[i] + " ");
}
Console.WriteLine($"Массив: [ {String.Join("; ",array)} ]");