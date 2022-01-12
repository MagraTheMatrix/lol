using System;

class GFG
{
    
    static bool isPrime(int n)
    {

       
        if (n <= 1)
            return false;

     
        for (int i = 2; i < n; i++)
            if (n % i == 0)
                return false;

        return true;
    }


    static void printPrime(int n)
    {
        for (int i = 2; i <= n; i++)
        {
            if (isPrime(i))
                Console.Write(i + " ");
        }
    }

   
    public static void Main()
    {
        int n = 7;
        printPrime(n);
    }
}
