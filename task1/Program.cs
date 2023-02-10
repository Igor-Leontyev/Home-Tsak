// See https://aka.ms/new-console-template for more information
Console.WriteLine("input first number: ");
int first_num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input second number: ");
int second_num = Convert.ToInt32(Console.ReadLine());

if(first_num > second_num)
{
    Console.WriteLine($"Maximal number = {first_num}");
}
else
{
    Console.WriteLine($"Maximal number = {second_num}"); 
}