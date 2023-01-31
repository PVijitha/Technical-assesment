Console.WriteLine("Enter the limit");
int limit = int.Parse(Console.ReadLine());
decimal[] arr = new decimal[limit];
decimal[] temp = new decimal[limit * 2];
Console.WriteLine("enter the numbers");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = decimal.Parse(Console.ReadLine());
}
int k = 2;
int l = 1;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        temp[k] = arr[i];
        k += 2;
    }
    else
    {
        temp[l] = arr[i];
        l += 2;
    }
}
Console.WriteLine(string.Join(',',temp));
