
using System;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("ENTER NUMBER");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;

Console.Write(1+"\t");
while(count <= number){
    Console.Write(count+"\t");
    count += 2;

}
