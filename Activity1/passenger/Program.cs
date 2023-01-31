
String[] passenger = new String[10];
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Enter your name");
    passenger[i] = Console.ReadLine();
}
Console.WriteLine("Array");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(passenger[i]); 

}
Console.WriteLine("Array in Acending order\r\n");
Array.Sort(passenger);
for(int i = 0; i < 10; i++)
{
    Console.WriteLine(passenger[i]);

}
Console.WriteLine("Array in Decending order\r\n");
for(int i = 9; i >=0; i--)
{
    Console.WriteLine(passenger[i]);

}
Console.WriteLine("Enter the name to be search\r\n");
string tempName = Console.ReadLine();
string match = Array.Find(passenger, element => element == tempName );
if(match != null)
{
    Console.WriteLine("The search element is found");
}
else
{
    Console.WriteLine("The element is not found");
}
foreach(string s in passenger)
{
    Console.WriteLine(s + " " + s?.Length);
}
Console.WriteLine("Array split\r\n");

foreach (string s in passenger)
{
    var temp = s?.Split(" ");

    for (int i = 0; i < temp?.Length; i++)
    {
        Console.WriteLine(temp[i]);
    }

}
Console.WriteLine("Array Duplicate");
for (int i = 0; i < passenger.Length; i++) 
{
    for(int j = i+1; j < passenger.Length;j++)
{
    if(passenger[i] == passenger[j])
        {
            Console.WriteLine(passenger[i]); 
        }
}
    
}