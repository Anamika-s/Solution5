﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateDiscount(10);
        }
        static void CalculateDiscount(int x)
        {
            int discount = 100;
            if (x == 10)
                discount += 10;
            else if (x == 9)
                discount += 9;
            else if (x == 8)
                discount += 8;
            else
                discount++;

        }
        
    }

}