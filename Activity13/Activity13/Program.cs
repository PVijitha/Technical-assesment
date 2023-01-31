string[] arr = new string[5];
    for (int i = 0; ; i++)
    {
        Console.WriteLine("Enter your flight number");
        arr[i] = Console.ReadLine();

        Console.WriteLine("Do you want to quit ? Y/N");
        char ans = char.Parse(Console.ReadLine());
        if (ans == 'Y')
        {
            Console.WriteLine("Quit");
            break;
        }
    }
    

