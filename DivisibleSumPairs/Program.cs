// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int k = 3; //sum of pair can be divided by that number
List<int> ar = new List<int> { 1, 3, 2, 6, 1, 2 };

int count = 0;
for (int i = 0; i < ar.Count; i++)
{
	for (int j = i + 1; j < ar.Count; j++)
	{
		int pairSum = ar[i] + ar[j];
		if (pairSum % k == 0)
		{
			count++;
		}
	}
}

Console.WriteLine($"Count = {count}");