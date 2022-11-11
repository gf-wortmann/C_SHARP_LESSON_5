//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
//

int CountEven ( int [] input)
{
    int acc =0;
    for (int i = 0; i < input.Length; i++)
    {
        acc += (input [i] % 2 == 0) ? 1 : 0;
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
int Numbers = R.Next(5, 21);

int [] Arr = new int [Numbers];
Arr = RandomArray(Numbers, -999, 1000);

int numEven = CountEven ( Arr );

Console.WriteLine(String.Join(", ", Arr));
Console.WriteLine($"Количество четных чисел в массиве = {numEven}");
