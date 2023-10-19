using System;

class Program
{
    static void Main()
    {
        char salesperson;
        double sale, grandTotal = 0;
        double totalD = 0, totalE = 0, totalF = 0;
        char highestSalesperson = ' ';

        do
        {
            Console.Write("Enter salesperson initial (D, E, F) or Z to exit: ");
            salesperson = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (salesperson == 'Z')
                break;

            if (salesperson != 'D' && salesperson != 'E' && salesperson != 'F')
            {
                Console.WriteLine("Error, invalid salesperson selected, please try again");
                continue;
            }

            Console.Write("Enter sale amount: $");
            if (double.TryParse(Console.ReadLine(), out sale) && sale >= 0)
            {
                if (salesperson == 'D')
                {
                    totalD += sale;
                }
                else if (salesperson == 'E')
                {
                    totalE += sale;
                }
                else if (salesperson == 'F')
                {
                    totalF += sale;
                }

                grandTotal += sale;
            }
            else
            {
                Console.WriteLine("Error, invalid sale amount entered, please try again.");
            }

        } while (true);

        Console.WriteLine($"Grand Total: ${grandTotal:N0}");

        if (totalD >= totalE && totalD >= totalF)
        {
            highestSalesperson = 'D';
        }
        else if (totalE >= totalD && totalE >= totalF)
        {
            highestSalesperson = 'E';
        }
        else if (totalF >= totalD && totalF >= totalE)
        {
            highestSalesperson = 'F';
        }

        Console.WriteLine($"Highest Sale: {highestSalesperson}");
    }
}
