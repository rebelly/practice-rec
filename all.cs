using System;

class Program
{
   static int rec20_ex_19(int n, ref int a)
    {
        Console.WriteLine(n);
        a++;
        if (n < 4) return n - 1;
        if (n >= 4 && n % 3 == 0) return n + 2 * rec20_ex_19( n - 1, ref a);
        else return rec20_ex_19( n - 2, ref a) + rec20_ex_19(n - 3, ref a);
        
    }
    public static void Main()
    {
        int a = 0;
        Console.WriteLine($"Ответ для примера из двадцатой задачи: {rec20_ex_19(19, ref a)} ");
        Console.WriteLine(a);


    }
}
