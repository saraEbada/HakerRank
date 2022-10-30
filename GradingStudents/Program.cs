// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<int> grades = new List<int> { 73, 67, 38, 33 };

List<int> finaleGrade = new List<int>();
for (int i = 0; i < grades.Count; i++)
{
    var next5Num = (Math.Floor((decimal)grades[i] / 5) + 1) * 5;

    if (next5Num >= 40 && next5Num - grades[i] < 3)
    {
        finaleGrade.Add((int)next5Num);
    }
    else
    {
        finaleGrade.Add(grades[i]);
    }
}