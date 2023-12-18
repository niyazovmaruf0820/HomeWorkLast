void Numbers(int a)
{
    if (a == 0) System.Console.WriteLine(0);
    else 
    {
        Numbers(a + 1);
        System.Console.WriteLine(a);
    }
}
int a = Convert.ToInt32(Console.ReadLine());
Numbers(a);