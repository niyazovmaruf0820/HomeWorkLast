int Numbers(int a)
{
    int s = 0;
    if (a <= 0) return s;
    else 
    {
        Numbers(a / 10);
        s += a % 10;
    }
    return s;
}
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Numbers(a));