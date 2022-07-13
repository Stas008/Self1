//Какая то новая задача//
int m = int.Parse(Console.ReadLine());
Console.WriteLine(m);
int n = int.Parse(Console.ReadLine());
Console.WriteLine (n);
string str;
int SumTwoEllements (int x, int y)
{
    int sum=x+y;
    return sum;
}

str=Console.ReadLine();
Console.WriteLine (SumTwoEllements(m,n));
Console.WriteLine (str.Length);
string[] words = str.Split(' ',',','.','!','?', ';');

for (int i = 0; i < words.GetLength(0); i++)
{
    if (words[i].Length<=3)
    {
        Console.WriteLine(words[i]);
    }
}
Console.WriteLine (words.GetLength(0));
