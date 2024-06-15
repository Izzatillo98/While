using System;
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

                 Console.WriteLine($" 1 x {number} = {number * 1} 2 x {number} = {number * 2} 3 x {number} = {number * 3} 4 x {number} = {number * 4} 5 x {number} = {number * 5} 6 x {number} = {number * 6} 7 x {number} = {number * 8} 8 x {number} = {number * 8} 9 x {number} = {number * 9} ");        
                 number ++;
                }
                        
             Console.WriteLine("Do you want continue? (yes -> no)");
             number1 = Console.ReadLine();
        }
        while (number1 == "yes");



