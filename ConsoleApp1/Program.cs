using System;

static class my
{
    static void even()
    {
        int[] arr = { 2, 5, 7, 3, 8 };
        for(int i = 0; i <= arr.Length-1; i++)
        {
            if (arr[i] % 2 == 0)
            {
                Console.WriteLine("{0} even",arr[i]);
            }
            else
            {
                Console.WriteLine("{0} odd", arr[i]);
            }
        }
    }
    static void fact()
    {
        int fact = 1,n=7;
        for(int i = 1; i <= n; i++)
        {
            fact = fact * i;
        }
        Console.WriteLine(fact);

    }
    static void reversestring()
    {
        string reverse = "", name = "ashkeen";
        for(int i = name.Length - 1; i >= 0; i--)
        {
            reverse = reverse + name[i];
        }
        Console.WriteLine(reverse);
    }
    static void naturalsum()
    {
        int sum = 0;
        for(int i = 0; i <= 10; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine(sum);
    }
    static void numsuum()
    {
        int sum=0,re, num = 123;
        while (num > 0)
        {
            re = num % 10;
            sum = sum + re;
            num = num / 10;
        }
        Console.WriteLine(sum);
    }
    static void reversnum()
    {
        int revers = 0, num = 123, re;
        while (num > 0)
        {
            re = num % 10;
            revers = revers * 10 + re;
            num = num / 10;
        }
        Console.WriteLine(revers);
    }


    static void Main(string[] args)
    {

        reversnum();
    }
    
}
    

