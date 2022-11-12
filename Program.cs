//Задача * Сортировка методом пузырька (сокращенная - максимальное значение, найденное на текущей итерации, не рассматривается в последующих итерациях) 
//
//

void Bubble_Sorting(int[] input, bool Ascending)
        {
            int buffer;//, buffer_low;
            
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input.Length - 1; j++)
                {
                    if (((input[j] > input[j + 1]) && Ascending == true) || ((input[j] < input[j + 1]) && Ascending == false))
                    {
                        buffer = input[j];
                        input[j] = input[j + 1];
                        input[j + 1] = buffer;
                    }
                }            
            }
        }

void Short_Sorting(int[] input, bool Ascending)
        {
            int buffer;//, buffer_low;
            
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i+1; j < input.Length; j++)
                {
                    if (((input[i] > input[j]) && Ascending == true) || ((input[i] < input[j]) && Ascending == false))
                    {
                        buffer = input[i];
                        input[i] = input[j];
                        input[j] = buffer;
                    }
                }            
            }
        }

int [] RandomArray ( int num, int minValue, int maxValue)
{
    int [] result = new int [num];
    for ( int i=0; i < num; i++)
    {
        Random R = new Random();
        result [i] = R.Next(minValue, maxValue + 1);// * maxValue + minValue / 2;
    } 
    return result;
}

Random R = new Random();
int Numbers = R.Next(10, 21);

int [] Arr = new int [Numbers];
Arr = RandomArray(Numbers, -100, 100);

Console.Clear();
Console.WriteLine($"\n Non sorted array");
Console.Write(String.Join(", ", Arr));

Short_Sorting(Arr, false);
Console.WriteLine($"\n\n Array Sorted in NonAscending order by Shortened Algorithm");
Console.Write(String.Join(", ", Arr));

Short_Sorting(Arr, true);
Console.WriteLine($"\n\n Array Sorted in NonDescending order by Shortened Algorithm");
Console.Write(String.Join(", ", Arr));

Bubble_Sorting(Arr, false);
Console.WriteLine($"\n\n Array Sorted in NonAscending order by Bubble Algorithm");
Console.Write(String.Join(", ", Arr));

Bubble_Sorting(Arr, true);
Console.WriteLine($"\n\n Array Sorted in NonDescending order by Bubble Algorithm");
Console.Write(String.Join(", ", Arr));

