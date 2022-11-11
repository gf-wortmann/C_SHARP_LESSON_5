//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
//

double Calc_Max_Min_Diff ( double [] input)
{
    double min, max;
    min = max = input [0];

    for (int i = 1; i < input.Length; i++)
    {
        min = (input [i] < min) ? input [i] : min;
        max = (input [i] > max) ? input [i] : max;
    }
    return max - min;
}

double [] RandomArray ( int num, double minValue, double maxValue)
{
    double [] result = new double [num];
    for ( int i=0; i < num; i++)
    {
        Random R = new Random();
        result [i] = R.NextDouble() * maxValue + minValue / 2;
    } 
    return result;
}

void WriteArray (double [] input)
{
    Console.Write ($"{input [0]:0.000}");
    for (int i = 1; i < input.Length; i++)Console.Write($", {input [i]:0.000}");
    Console.WriteLine();
}

Random R = new Random();
int Numbers = R.Next(10, 31);

double [] Arr = new double [Numbers];
Arr = RandomArray(Numbers, -100, 100);
//float [] Arr = {3, 7, 22, 2, 78};
double Max_Min_Diff = Calc_Max_Min_Diff ( Arr );

WriteArray (Arr);
Console.WriteLine($"Разность между максимальным и минимальным числами в массиве = {Max_Min_Diff:0.000}");
