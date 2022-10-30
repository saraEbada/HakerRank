// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int n = 6;

for (int i = 0; i < n; i++)
{
    string str = "";
    int hashNum = i + 1;
    int spaceNum = n - hashNum;

    for (int j = 0; j < spaceNum; j++)
    {
        str += " ";
    }

    for (int j = 0; j < hashNum; j++)
    {
        str += "#";
    }

    Console.WriteLine(str);
}