int n = 10;
int m = 1000;

for (int i = n; i < m; i++)
{
   
    if (IsPalindrome(i))

    {
        Console.WriteLine(i);

    }

    static bool IsPalindrome(int number)
    {
        string str = number.ToString();
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        return str == new string(arr);
    }
}



        
       

