// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<int> a = new List<int> { 2, 4 };
List<int> b = new List<int> { 16, 32, 96 };

int start = a.Max();
int end = b.Min();

int count = 0;
for (int i = start; i <= end; i++)
{
    if (a.TrueForAll(x => i % x == 0) && b.TrueForAll(y => y % i == 0))
    {
        count++;
    }
}

Console.WriteLine(count);