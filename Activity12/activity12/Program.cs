using System.Collections.Generic;
string[] arr = new string[5];
string[] temp = new string[10];
int i;
for( i = 0;i < arr.Length; i++)
{
    Console.WriteLine("Enter passenger name");
    arr[i] = Console.ReadLine();
}
string[] arr2 = new string[5];
for (i = 0; i < arr2.Length; i++)
{
    Console.WriteLine("Enter the destination");
    arr2[i] = Console.ReadLine();
}
int k;
int l;
i = 0;
int m = 0;
for (k = 0; k < 10; k += 2)
{
    if(i < 5) { 
    temp[k] = arr[i];
    i++;
    }
}
for(l = 1; l < 10; l+= 2)
{   if(m < 5) { 
    temp[l] = arr2[m];
    m++;
    }
}
Console.WriteLine(string.Join(",", temp));
