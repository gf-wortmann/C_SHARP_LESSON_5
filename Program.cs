//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
//

int Count_Odd_Sum ( int [] input)
{
    int acc = 0;
    for (int i = 0; i < input.Length; i++)
    {
        acc += (i % 2 == 0) ? 0 : input[i];
    }
    return acc;
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
int Numbers = R.Next(10, 31);

int [] Arr = new int [Numbers];
Arr = RandomArray(Numbers, -99, 99);
//int [] Arr = {4, -6, 89, 6};

int numEven = Count_Odd_Sum ( Arr );

Console.WriteLine(String.Join(", ", Arr));
Console.WriteLine($"Сумма нечетных чисел в массиве = {numEven}");
