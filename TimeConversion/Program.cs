// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string s = "07:05:45PM";

string m = s.Substring(s.Length - 2);
string[] time = s.Split(':');

string hour = time[0];
string minute = time[1];
string second = time[2].Substring(0, 2);

string outPut;
if (string.Equals(m, "pm", StringComparison.OrdinalIgnoreCase))
{
    outPut = hour switch
    {

        "12" => "12" + ":" + minute + ":" + second,
        _ => (Convert.ToInt32(hour) + 12) + ":" + minute + ":" + second
    };
}
else
{
    outPut = hour switch
    {

        "12" => "00" + ":" + minute + ":" + second,
        _ => hour + ":" + minute + ":" + second
    };
}

Console.WriteLine(outPut);