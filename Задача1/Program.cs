/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/


int[] array = new int[5];
FillArray(array);
int count = 0;

for (int a = 0; a < array.Length; a++)
if (array[a] % 2 == 0)
count++;

string str = string.Join(" ", array);
Console.Write($"{str} -> {count} чётных");

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}