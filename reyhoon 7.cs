
List<int> numbers = new List<int>();
char y;
string input;

do
{
    Console.WriteLine("Please enter ten numbers that must start with zero and have at least two different numbers:");
    input = Console.ReadLine();
    string[] parts = input.Split(' ');

    if (parts.Length == 10 && parts[0] == "0")
    {
        numbers.Clear();
        bool allDifferent = true;

        for (int i = 0; i < 10; i++)
        {
            if (int.TryParse(parts[i], out int number))
            {
                numbers.Add(number);
            }
            else
            {
                allDifferent = false;
                break;
            }
        }

        if (allDifferent && numbers.Distinct().Count() > 1)
        {
            Console.WriteLine("It's OK!");
            break; 
        }
        else
        {
            Console.WriteLine("You must enter at least two different numbers.");
        }
    }
    else
    {
        Console.WriteLine("Input must start with zero and contain exactly ten numbers.");
    }

    Console.WriteLine("Press any key to try again...");
    y = Console.ReadKey().KeyChar;
    Console.WriteLine(); 

       } while (true); 
  