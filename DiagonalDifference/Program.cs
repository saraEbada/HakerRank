// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

List<List<int>> arr = new List<List<int>> {
    new List<int>{ 11 ,2 ,4},
    new List<int>{ 4, 5 ,6},
    new List<int>{ 10, 8, -12},
};

int sum1 = 0, sum2 = 0;
for (int i = 0; i < arr.Count; i++)
{
    var arr2 = arr[i];

    for (int j = 0; j < arr2.Count; j++)
    {
        if (j == i)
        {
            sum1 += arr2[j];
        }

        if (j == arr2.Count - i - 1)
        {
            sum2 += arr2[j];
        }
    }
}

int diff = sum1 > sum2 ? sum1 - sum2 : sum2 - sum1;
Console.WriteLine(diff);