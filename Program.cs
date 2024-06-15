using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
string number1;
int number = 1;
do


{   do
    
    {
     Console.WriteLine($" 1 x {number} = {number * 1} 2 x {number} = {number * 2} 3 x {number} = {number * 3} 4 x {number} = {number * 4} 5 x {number} = {number * 5} 6 x {number} = {number * 6} 7 x {number} = {number * 8} 8 x {number} = {number * 8} 9 x {number} = {number * 9} ");        
    // Console.WriteLine($" 2 x {number} = {number * 2} ");  
     //Console.WriteLine($" 3 x {number} = {number * 3} ");
     //Console.WriteLine($" 4 x {number} = {number * 4} ");
     //Console.WriteLine($" 5 x {number} = {number * 5} ");
     //Console.WriteLine($" 6 x {number} = {number * 6} ");
     //Console.WriteLine($" 7 x {number} = {number * 7} ");
     //Console.WriteLine($" 8 x {number} = {number * 8} ");
     //Console.WriteLine($" 9 x {number} = {number * 9} ");
     
     number ++;
    }
    while (number<=9); 

    number++;
    Console.WriteLine("Do you want continue? (y)");
     number1 = Console.ReadLine();
}while(number<=9);



