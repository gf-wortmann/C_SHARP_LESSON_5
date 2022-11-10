//Задача 37: Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве.

int[] CalcPairs ( int [] input)
{
    int size = input.Length / 2 + input.Length % 2;
    int [] rsl = new int [size];
    for (int i = 0; i < size; i++)
    {
        if (i == input.Length / 2) rsl [i] = input[i]; else  rsl [i] = input [i] * input [input.Length - i - 1];
    }
    return rsl;
}

int [] RandomArray ( int num, int minValue, int maxValue)
{
    int [] result = new int [num];
    for ( int i=0; i < num; i++)
    {
        Random R = new Random();
        result [i] = R.Next(minValue, maxValue + 1);
    } 
    return result;
}

Random R = new Random();
int Numbers = R.Next(5, 21);

int [] Arr = new int [Numbers];
Arr = RandomArray(Numbers, 0, 100);

int [] Prod = CalcPairs ( Arr );

Console.WriteLine(String.Join(", ", Arr));
Console.WriteLine(String.Join(", ", Prod));
