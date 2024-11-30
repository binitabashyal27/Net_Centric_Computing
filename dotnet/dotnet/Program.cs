using System;

namespace netcentric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program to print the calendar (one month) using jagged array
            Console.WriteLine("Printing the calendar (one month) using jagged array.\n");

            // Initialize the calendar using a jagged array
            // This will be for a 31-day month, but we'll adjust depending on the actual month
            int[][] calendar =
            {
                new int[] {0, 0, 0, 0, 0, 0, 0}, // Week 1 (starting at Friday)
                new int[] {0, 0, 0, 0, 0, 0, 0}, // Week 2
                new int[] {0, 0, 0, 0, 0, 0, 0}, // Week 3
                new int[] {0, 0, 0, 0, 0, 0, 0}, // Week 4
                new int[] {0, 0, 0, 0, 0, 0, 0}, // Week 5
                new int[] {0, 0, 0, 0, 0, 0, 0}  // Week 6 (if needed)
            };

            // Set the start day to Friday (5th index position)
            int startDay = 5; // Friday

            // Days in the month (this example assumes 31 days)
            int daysInMonth = 31;

            // Fill the calendar with the days of the month
            int day = 1;
            for (int i = 0; i < 6; i++)  // 6 weeks maximum
            {
                for (int j = 0; j < 7; j++) // 7 days per week
                {
                    // Start filling the calendar once we reach the starting day
                    if (i == 0 && j < startDay)
                    {
                        calendar[i][j] = 0; // Empty slots before the start day
                    }
                    else if (day <= daysInMonth)
                    {
                        calendar[i][j] = day;
                        day++;
                    }
                    else
                    {
                        calendar[i][j] = 0; // Empty slots after the last day
                    }
                }
            }

            // Print the calendar header with day names
            Console.WriteLine("Sun    Mon    Tue    Wed    Thu    Fri    Sat");

            // Print the calendar weeks
            for (int i = 0; i < calendar.Length; i++)
            {
                for (int j = 0; j < calendar[i].Length; j++)
                {
                    if (calendar[i][j] == 0)
                    {
                        // If the day is 0 (empty), print a space for alignment
                        Console.Write("       ");
                    }
                    else
                    {
                        // Print the day number, aligning them properly
                        Console.Write(String.Format("{0,-7}", calendar[i][j]));
                    }
                }
                Console.WriteLine(); // New line after each week
            }
        }
    }
}
