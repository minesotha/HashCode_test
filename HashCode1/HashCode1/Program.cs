﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashCode1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3] { 1, 2, 3 };
            var list = (IList)arr;
            list.Add(4);
            
            Console.Beep();
            Console.WriteLine(arr[3]);
            Console.ReadKey();
        }


    }
}