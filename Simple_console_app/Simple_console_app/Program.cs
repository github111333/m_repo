﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is simple Console App.");

<<<<<<< HEAD
            int x, y, w;
            string s;
            Console.WriteLine("Ievadi x: "); s = Console.ReadLine(); x = int.Parse(s);
            Console.WriteLine("Ievadi y: "); s = Console.ReadLine(); y = int.Parse(s);
            w = x + y;
            Console.WriteLine("x un y summa ir: {0}", w);
=======
            int x, y, z;
            string s;
            Console.WriteLine("Ievadi x: "); s = Console.ReadLine(); x = int.Parse(s);
            Console.WriteLine("Ievadi y: "); s = Console.ReadLine(); y = int.Parse(s);
            z = x * y;
            while (z >= 1)
            {
                Console.Write("*");
                z--;
            }
            
>>>>>>> multiply
            Console.ReadLine();
        }
    }
}
