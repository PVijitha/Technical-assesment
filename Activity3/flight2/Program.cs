using System.Runtime.InteropServices;

decimal[] passenger = new decimal[10];
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Enter your flight fare");
    passenger[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("Array");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(passenger[i]);

}
Console.WriteLine("Array in Acending order\r\n");
Array.Sort(passenger);
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(passenger[i]);

}
Console.WriteLine("Array in Decending order\r\n");
for (int i = 9; i >= 0; i--)
{
    Console.WriteLine(passenger[i]);

}
Console.WriteLine("Enter the element to be search\r\n");
int temp = int.Parse(Console.ReadLine());
bool flag = false; 
for (int i = 0;i < passenger.Length; i++)
{
    if (passenger[i] == temp)
    {
        flag = true;
    } 
}
if (flag)
{
    Console.WriteLine("The element is present");
}
else
{
    Console.WriteLine("The element is not found");
}
Console.WriteLine($"Array Max {passenger.Max()}");
Console.WriteLine($"Array Min {passenger.Min()}");