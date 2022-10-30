// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<int> s = new List<int> { 1, 2, 1, 3, 2 }; //segments
int m = 2; //month = number of segments
int d = 3; //day = sum of number in each segment

int count = 0;
for (int i = 0; i < s.Count; i++)
{
    //int num = s[i];
    int sum = 0;

    if ((i + m) - 1 < s.Count)
    {
        for (int j = 0; j < m; j++)
        {
            sum += s[i + j];
        }
    }

    if (sum == d)
    {
        count++;
    }
}

Console.WriteLine($"count of possible: {count}");