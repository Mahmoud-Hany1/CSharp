using System;

class Program
{
    
    enum DayOfWeek
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    static void Main()
    {
        Console.Write("Enter a number (1-7) for a day: ");
        string input = Console.ReadLine();
        int dayNumber;

      
        if (int.TryParse(input, out dayNumber))
        {
            try
            {
                
                DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), dayNumber.ToString());
                Console.WriteLine("The day is: " + day);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Error: Number must be between 1 and 7.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input! Please enter a numeric value.");
        }
    }
}
//3 - What happens if the user enters a value outside the range of 1 to 7? 
//Always validate user input when converting to Enum.

//Enum.Parse لا يتحقق من القيم خارج النطاق، لذلك لازم exception handling.

