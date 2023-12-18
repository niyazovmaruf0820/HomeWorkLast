void Numbers(int a)
{
    if (a == 1) Console.Write(1 + " ");
    else 
    {
        Console.Write(a + " ");
        Numbers(a - 1);
    }
}
int a =Convert.ToInt32(Console.ReadLine());
Numbers(a);
