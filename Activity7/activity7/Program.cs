int miles;
string name;
Console.WriteLine("Enter your name");
name = Console.ReadLine();
Console.WriteLine("Enter total travelled miles");
miles = int.Parse(Console.ReadLine());
//if(miles > 10000)
//{
//    Console.WriteLine("You get 10 frequent flyer points");
//}
//else if(miles < 20000)
//{
//    Console.WriteLine("You get 20 frequent flyer points");
//}
//else if(miles < 50000)
//{
//    Console.WriteLine("You get 30 frequent flyer points");
//}
//else if(miles < 100000)
//{
//    Console.WriteLine("You get 50 frequent flyer points");
//}

switch (miles)
{
    case < 10000:
        Console.WriteLine("You get 10 frequent flyer points");
        break;
    case < 20000:
        Console.WriteLine("You get 20 frequent flyer points");
        break;
    case < 50000:
        Console.WriteLine("You get 30 frequent flyer points");
        break;
    case < 100000:
        Console.WriteLine("You get 50 frequent flyer points");
        break;
}