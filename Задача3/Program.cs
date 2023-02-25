/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int[] array = new int[5];
FillArray(array);
int max = 0;
int min = 0;

for (int a = 0; a < array.Length; a+=2)
{
    if(array[a]>max)
        max=array[a];
    if (array[a]<min)
        min=array[a];
}

string str = string.Join(" ", array);
Console.Write($"{str}\n{max-min}");

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,10);
    }
}