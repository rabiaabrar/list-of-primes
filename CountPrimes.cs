using System;
using System.Collections.Generic;

// Test question from Square Cash App
// Count the number of prime numbers under 50,000

class Solution
{
    static void Main(string[] args)
    {
        var ListOfPrimes = GetListOfPrimes(50000);
        
        //Console.WriteLine(String.Join(", ", ListOfPrimes));
        Console.WriteLine(ListOfPrimes.Count);        
    }
    
    static List<int> GetListOfPrimes(int upperLimit)
    {
        var ListOfPrimes = new List<int>{};
        
        for(int i=2; i<upperLimit; i++)
        {
            if(IsPrime(i))
                ListOfPrimes.Add(i);
        }
        
        return ListOfPrimes;
    }                
    
    static bool IsPrime(int number)
    {
        //Simple algorithm: If a number is divisible by any number smaller than itself, it is not a prime number
        for(int i=2; i<number; i++)
            if(number%i==0)
                return false;
        return true;
    }
}
