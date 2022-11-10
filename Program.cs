//Задача 37: Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве.

int[] CalcPairs ( int [] input)
{
    int size = input.Length / 2 + input.Length % 2;
    int [] rsl = new int [size];
    for (int i = 0; i < size; i++)
    {
        if (i > input.Length / 2) rsl [i] = input[i]; else  rsl [i] = input [i] * input [input.Length - i - 1];
    }
    return rsl;
}

int [] Arr = {1,2,3,4,5,6}; //new int [5];
int [] Prod = CalcPairs ( Arr );

Console.WriteLine(String.Join(", ", Arr));
Console.WriteLine(String.Join(", ", Prod));
