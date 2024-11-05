
    
        int n = 10;
        int m = 100 ;

        for (int i = n; i < m; i++)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            bool isFibo = false;

           
            while (c < m)
            {
                c = a + b;
                if (n < c && c < m)
                {
                    if (i == c)
                    {
                        isFibo = true;
                        break; 
                    }
                }
                a = b;
                b = c;
            }

            if (isFibo)
                Console.WriteLine( i + " is a Fibonacci number");
        }
  
