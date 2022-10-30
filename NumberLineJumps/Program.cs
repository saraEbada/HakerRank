// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

int x1 = 0;
int v1 = 3;

int x2 = 4;
int v2 = 2;

int dis1 = x1 + v1;
int dis2 = x2 + v2;
int i = 0;

while (i < 10000)
{
    if (dis1 == dis2)
    {
        Console.WriteLine("YES");
    }
    dis2 += v2;
    dis1 += v1;

    i++;
}
Console.WriteLine("NO");