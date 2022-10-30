// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<int> arr = new List<int> { 2, 3, 1, 3 };

int max = 0;
int maxCount = 0;

for (int i = 0; i < arr.Count; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
        maxCount = 0;
    }
    if (arr[i] == max)
    {
        maxCount++;
    }
}

Console.WriteLine(maxCount);