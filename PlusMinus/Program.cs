// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//List<int> arr = new List<int> { 55, 48, 48, 45, 91, 97, 45, 1, 39, 54, 36, 6, 19, 35, 66, 36, 72, 93, 38, 21, 65, 70, 36, 63, 39, 76, 82, 26, 67, 29, 24, 82, 62, 53, 1, 50, 47, 65, 67, 19, 66, 90, 77 };

List<int> arr = new List<int> { -4, 3, -9, 0, 4, 1 };

int arrCount = arr.Count;
decimal count0 = arr.Where(c => c == 0).Count();
decimal countPos = arr.Where(c => c > 0).Count();
decimal countMin = arr.Where(c => c < 0).Count();

Console.WriteLine((countPos / arrCount).ToString("0.000000"));

Console.WriteLine((countMin / arrCount).ToString("0.000000"));

Console.WriteLine((count0 / arrCount).ToString("0.000000"));