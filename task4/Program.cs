void Numbers(int a)
{
    if (a <= 0) System.Console.WriteLine("");
    else 
    {
        Numbers(a / 10);
        System.Console.Write(a % 10 + " ");
    }
}
int a = Convert.ToInt32(Console.ReadLine());
Numbers(a);
