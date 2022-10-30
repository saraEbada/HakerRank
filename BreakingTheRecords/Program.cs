// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<int> scores = new List<int> { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };

var highScore = scores[0];
var lowScore = scores[0];

var highCount = 0;
var lowCount = 0;

for (int i = 1; i < scores.Count; i++)
{
    if (scores[i] > highScore)
    {
        highCount++;
        highScore = scores[i];
    }
    else if (scores[i] < lowScore)
    {
        lowCount++;
        lowScore = scores[i];
    }
}

Console.WriteLine($"High : {highCount} , Low : {lowCount}");