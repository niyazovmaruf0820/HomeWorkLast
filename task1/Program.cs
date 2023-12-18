void Numbers(int a)
{
    if (a == 1) Console.Write(1 + " ");
    else 
    {
        Numbers(a - 1);
        Console.Write(a + " ");
    }
}
int a =Convert.ToInt32(Console.ReadLine());
Numbers(a);