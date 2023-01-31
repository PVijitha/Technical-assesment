string[] arr = new string[5];
Console.WriteLine("Enter the destination");
for(int i = 0;i < arr.Length; i++)
{
     arr[i] = Console.ReadLine();
}
decimal[] arr1= new decimal[5];
Console.WriteLine("Enter the fare");
for(int i = 0;i < arr1.Length; i++)
{
    arr1[i] = decimal.Parse(Console.ReadLine());
}
Console.WriteLine("Enter any number lessthan 5");
int any = int.Parse(Console.ReadLine());
Console.WriteLine($"fare is {arr1[any]}");
Console.WriteLine($"destination  is {arr[any]}");