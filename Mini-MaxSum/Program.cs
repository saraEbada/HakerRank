// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//List<int> arr = new List<int> { 1, 2, 3, 4, 5 };
List<int> arr = new List<int> { 256741038, 623958417, 467905213, 714532089, 938071625 };
//List<int> arr = new List<int> { 5, 5, 5, 5, 5 };

var max = arr[0];
var min = arr[0];

double sum = 0;

for (int i = 0; i < arr.Count; i++)
{
    sum += arr[i];
    if (arr[i] > max)
    {
        max = arr[i];
    }
    if (arr[i] < min)
    {
        min = arr[i];
    }
}

Console.WriteLine($"{sum - min} {sum - max}");