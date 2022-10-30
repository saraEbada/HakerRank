// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int s = 7;//house start
int t = 10; //house end

int a = 4;//apple tree
int b = 12;//orange tree

List<int> apples = new List<int> { 2, 3, -4 };
List<int> oranges = new List<int> { 3, -2, -4 };

int appleCount = 0;
for (int i = 0; i < apples.Count; i++)
{
    var disFromTree = a + apples[i];
    if (disFromTree >= s && disFromTree <= t)
    {
        appleCount++;
    }
}

Console.WriteLine(appleCount);

int orangeCount = 0;
for (int i = 0; i < oranges.Count; i++)
{
    var disFromTree = b + oranges[i];
    if (disFromTree >= s && disFromTree <= t)
    {
        orangeCount++;
    }
}

Console.WriteLine(orangeCount);