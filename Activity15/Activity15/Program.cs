string[] arr = new string[5];
string[] temp = new string[5];
int ex;
int pay = 0;
int total = 0;
while (true)
{
    Console.WriteLine("1.Want to calculate extra pay");
    Console.WriteLine("2.Sort maximum value");
    Console.WriteLine("3.Calculate total");
    var choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            PayAmound();
            break;
        case "2":
            SortAmount();
            break;
        case "3":TotalAmount();
            break;

    }
}
void PayAmound() {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("\nEnter the weight you to carry");
            int wt = int.Parse(Console.ReadLine());
            if (wt <= 23)
            {
                Console.WriteLine("You don't have extra charge");
            }
            else
            {
                ex = wt - 23;
                pay = ex * 15;
                temp[i] = pay.ToString();
                Console.WriteLine("You have to pay $ " + pay);
            }
        }  
    }
void SortAmount()
    {
        Array.Sort(temp);
        for(int i = 0; i < temp.Length; i++) {
        Console.WriteLine(temp[i]);
    }
}
void TotalAmount()
{
   for (int i = 0; i < temp.Length;i++)
    {
        total += int.Parse(temp[i]);
    }
    Console.WriteLine(total);
}
