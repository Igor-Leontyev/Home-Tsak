
using System.Collections.Generic;
using System;

int max = 0;
int numbers = 0;
int count = 1;

do{
    Console.WriteLine($"enter any number №:_{count}_");
    Console.WriteLine("enter _00_ to exit");
    Console.Write(" your number : ");
    numbers = Convert.ToInt32(Console.ReadLine());

    if(max < numbers) {
        max = numbers;
    } 
    count++;
}

while(numbers != 00);

Console.WriteLine($"Maximal number = {max}");












