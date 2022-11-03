int n = int.Parse(Console.ReadLine()); 

if (n < 100)
{
    Console.WriteLine("Error");
}
else
{
    int coef =  10; 

    if (n > 999)
    {
        while (true) 
        {
            int sep = n / coef;
            if (sep > 100 && sep < 999) 
            {
                break;
            }
            else
            {
                coef *= 10;
            }
        }
        Console.WriteLine($"The third number is { (n  / coef) % 10 }");
    }
else
 {
    Console.WriteLine($"The third number is { n % 10 }");
 }

}

    