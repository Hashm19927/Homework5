/*Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] array = new int[5];
FillArray(array);
int sum = 0;

for (int a = 0; a < array.Length; a+=2)
    sum = sum + array[a];

string str = string.Join(" ", array);
Console.Write($"{str}->{sum}");

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,10);
    }
}