// int Numbers(int a)
// {
//     if (a == 1) return 1;
//     else 
//     {
//         return a + Numbers(a - 1);
        
//     }
// }
// int a =Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(Numbers(a));
void Numbers(int a)
{
    if (a == 1) System.Console.WriteLine(1);
    else 
    {
        System.Console.WriteLine(a + a % 10);
        
    }
}
int a =Convert.ToInt32(Console.ReadLine());
Numbers(a);