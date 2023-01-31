Console.WriteLine("Enter your date of birth");
DateTime date = DateTime.Parse(Console.ReadLine());
var temp = DateTime.Now.Year - date.Year;
if (temp < 10)
{
    Console.WriteLine("Kid");
}
else if (temp > 10 && temp < 30)
{
    Console.WriteLine("Youth");
}
else if (temp > 30 && temp < 60)
{
    Console.WriteLine("Adult");
}
else
{
    Console.WriteLine("Older");
}