﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_17_DSA
{
    internal class PrimeNumber
    {
      
            static void Main(string[] args)
            {
                bool isPrime = true;
                Console.WriteLine("Prime Numbers in Range Of 0-1000: ");
                for (int i = 2; i <= 1000; i++)
                {
                    for (int j = 2; j <= 1000; j++)
                    {

                        if (i != j && i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }

                    }
                    if (isPrime)
                    {
                        Console.WriteLine(i);
                    }
                    isPrime = true;
                }

            }
        
    }
}
