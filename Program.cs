﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
string number1;

do
        {        
           Console.WriteLine("Karra jadvali");
            int number;
            int lastnumber;
            Console.Write("Nechchi karradan : ");
            string Inputnumber = Console.ReadLine();
            number = Convert.ToInt32(Inputnumber);
            Console.Write("Nechchi karragacha? : ");
            string Inputlast = Console.ReadLine();
            lastnumber = Convert.ToInt32(Inputlast);
            while (number <= lastnumber)
                {   
                    int multiPlayer = 1;
                    while (multiPlayer <= 9)
                    {
                        Console.Write($" {multiPlayer}x{number}={number * multiPlayer}    ");
                    
                        multiPlayer++;
                    }
                 Console.WriteLine();

                 number ++;
                }
                  
                        
             Console.WriteLine("Do you want continue? (yes -> no)");
             number1 = Console.ReadLine();
        }
        while (number1 == "yes");


