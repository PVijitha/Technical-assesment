Console.WriteLine("Enter your flight time");
int time = int.Parse (Console.ReadLine());
Console.WriteLine("Enter your flight fare");
int fare = int.Parse(Console.ReadLine());
double temp;
if(time >= 6 & time < 9)
{
    temp = (fare * 0.1);
    Console.WriteLine(fare + temp);
}
else if(time >= 9 & time < 17)
{
    temp = (fare * 0.2);
    Console.WriteLine(fare + temp);
}
else if(time >= 17 & time < 23)
{
    temp = (fare * 0.07);
    Console.WriteLine(fare + temp);
}
else
{
    temp = (fare * 0.05);
    Console.WriteLine(fare + temp);
}