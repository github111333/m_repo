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

            int x, y;
            string s;
            Console.WriteLine("Ievadi x: "); s = Console.ReadLine(); x = int.Parse(s);
            Console.WriteLine("Ievadi y: "); s = Console.ReadLine(); y = int.Parse(s);      
            Console.ReadLine();
        }
    }
}
