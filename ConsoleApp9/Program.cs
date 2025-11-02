

int[] x = { 1, 3, 8, 15, 22, 29, 35, 40, 45, 50 };
Console.WriteLine("the average is ");
double y = x.Average();
Console.WriteLine(y);
for (int n = 0; n < x.Length; n++)
{
    if (x[n] > y)
    {
        Console.WriteLine(x[n]);
    }
}


Console.WriteLine("enter your input");
string input = Console.ReadLine();
Dictionary<char, int> freq = new Dictionary<char, int>();
foreach (var c in input)
{
    if (freq.ContainsKey(c))
    {
        freq[c]++;
    }
    else
    {
        freq[c] = 1;
    }
}
foreach (var kvp in freq)
{
    if (kvp.Value <= 1)
    {
        Console.WriteLine($"{kvp.Key} : {kvp.Value}");
    }
}

