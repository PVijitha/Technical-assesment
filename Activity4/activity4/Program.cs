Console.WriteLine("Enter your date of birth");
DateTime dob = DateTime.Parse(Console.ReadLine());
TimeSpan temp = DateTime.Now.Subtract(dob);
var temp2 = DateTime.Now.Year - dob.Year;
Console.WriteLine("Days");
Console.WriteLine(temp.Days);
Console.WriteLine("Hours");
Console.WriteLine($"Total Hours: {temp.TotalHours}");
Console.WriteLine("Month");
Console.WriteLine(temp2 * 12);
Console.WriteLine("Week");
Console.WriteLine(temp.Days/7);
Console.WriteLine("year");
Console.WriteLine(temp2);
    if (DateTime.IsLeapYear(dob.Year))
    {
        Console.WriteLine("is a Leap Year.");
    }

    else
    {
        Console.WriteLine("is not a Leap Year.");
    }
