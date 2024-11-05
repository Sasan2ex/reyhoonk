
int n = 10;
int m = 100;

for (int i = n; i < m; i++)
{
    bool isprime = true; 
    if (i < 2) isprime = false; 
    else
    {
        for (int j = 2; j <i ; j++)
        {
            if (i % j == 0)
            {
                isprime = false;
                break; 
            }
        }
    }
    if (isprime)
        Console.WriteLine(i + " is prime");
}