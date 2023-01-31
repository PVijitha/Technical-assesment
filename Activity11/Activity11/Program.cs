Console.WriteLine("Enter flight number alphabet (F, W, Q, N, A) ");
char letter = char.Parse(Console.ReadLine());
if (letter == 'F')
{
    for (int i = 100; i < 110; i++)
    {
        if (i % 2 != 0)
        {
            Console.Write("F");
            Console.WriteLine(string.Join("F", i));
        }
    }
}
else if (letter == 'W')
{
    for (int i = 100; i <= 110; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write("W");
            Console.WriteLine(string.Join("W", i));
        }
    }
}
else if (letter == 'Q')
{
    int ct;
    ct = 0;
    int n = 0;
    int i = 1;
    while (n < 10)
    {
        int j = 1;
        ct = 0;
        while (j <= i)
        {
            if (i % j == 0)
            ct++;
            j++;
        }
        if (ct == 2)
        {
            Console.Write("Q");
            Console.WriteLine(string.Join("Q", i));
            n++;
        }
        i++;
    }
} 
else if(letter == 'N')
{
    int val1 = 0, val2 = 1, val3, i, n;
    n = 10;
    Console.Write(val1 + " " + val2 + " ");
    for (i = 2; i < n; ++i)
    {
        val3 = val1 + val2;
        Console.Write(val3 + " ");
        val1 = val2;
        val2 = val3;
    }
}
else
{

}

