using System.Buffers.Text;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_AssignmentDay05
{
    class Program
    {
        static void Main()
        {
            #region Part01

            #region Problem1
            //try
            //{
            //    Console.WriteLine("Enter 1st number: ");
            //    int num1 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter 2nd number: ");
            //    int num2 = int.Parse(Console.ReadLine());

            //    int result = num1 / num2;
            //    Console.WriteLine("result = " + result);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("You can't divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Operation Complete");
            //} 
            #endregion

            #region Question1
            //Ques1: What is the purpose of the finally block? 
            //Ans1 : The finally block is always executed whether there is exception or not 
            #endregion

            #region Problem 3
            //int? number = null;
            //int modifyNumber = number ?? 100;
            //Console.WriteLine("value using ?? operator: " + modifyNumber);

            //if (number.HasValue)
            //{
            //    Console.WriteLine("Number has value: " + number.Value);
            //}
            //else
            //{
            //    Console.WriteLine("Number is null, HasValue = false");
            //}

            //number = 50;
            //if (number.HasValue)
            //{
            //    Console.WriteLine("After assignment, Value = " + number.Value);
            //} 
            #endregion

            #region Question 3
            //ques3: What exception occurs when trying to access Value on a null Nullable<T>? 
            //Ans3 : InvalidOperationException 
            #endregion

            #region Problem4
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //try
            //{
            //    Console.WriteLine(numbers[10]);
            //}
            //catch (IndexOutOfRangeException)
            //{
            //    Console.WriteLine("Error, Index is out of the array boundaries");
            //} 
            #endregion

            #region Question4
            //ques4: Why is it necessary to check array bounds before accessing elements? 
            //Ans4 : Because the array have a fixed size so you check the bounds to prevent IndexOutOfRangeException 
            #endregion

            #region Problem 5
            //int[,] matrix = new int[3, 3];
            //for(int i=0; i<matrix.GetLength(0); i++)
            //{
            //    for(int j=0; j<matrix.GetLength(1); j++)
            //    {
            //        Console.Write($"Enter value in [{i},{j}]: ");
            //        matrix[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            ////sum of each row
            //for(int i=0; i<matrix.GetLength(0);i++)
            //{
            //    int sumrow = 0;
            //    for(int j=0; j<matrix.GetLength(1);j++)
            //    {
            //        sumrow += matrix[i, j];
            //    }
            //    Console.WriteLine($"Sum of row number {i} = {sumrow}");
            //}

            ////sum of each column
            //for (int j = 0; j < matrix.GetLength(1); j++)
            //{
            //    int sumcolumn = 0;
            //    for (int i = 0; i < matrix.GetLength(0); i++)
            //    {
            //        sumcolumn += matrix[i, j];
            //    }
            //    Console.WriteLine($"Sum of column number {j} = {sumcolumn}");
            //} 
            #endregion

            #region Question5
            //ques5:  How is the GetLength(dimension) method used in multi-dimensional arrays?
            //Ans5 :  returns the size of a specific dimension -> GetLength(0): num of rows
            //                                                 -> GetLength(1): num of columns 
            #endregion

            #region Problem6
            //int[][] jagged = new int[3][];
            //jagged[0] = new int[2];
            //jagged[1] = new int[4];
            //jagged[2] = new int[3];

            //// Populate with user input
            //for (int i=0; i <jagged.Length; i++)
            //{
            //    for (int j= 0;j <jagged[i].Length; j++)
            //    {
            //        Console.Write($"Enter value for row {i}, column {j}: ");
            //        jagged[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //// Print values row by row
            //Console.WriteLine("\nJagged Array Values:");
            //for (int i = 0; i < jagged.Length; i++)
            //{
            //    for (int j = 0; j < jagged[i].Length; j++)
            //    {
            //        Console.Write(jagged[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region Question 6
            //ques6: How does the memory allocation differ between jagged arrays and rectangular  arrays ?
            //Ans6 : Jagged-> array of arrays , each row is allocated separately , rows can have different sizes , more overhead in memory
            //Rectangular-> single block of memory , all elements allocated together , all rows must have same size , more memory efficient 
            #endregion

            #region Problem 7
            //string? name = null;

            //Console.Write("Do you want to enter your name? (y/n): ");
            //string choice = Console.ReadLine()!;   // using null-forgiveness operator

            //if (choice.ToLower() == "y")
            //{
            //    Console.Write("Enter your name: ");
            //    name = Console.ReadLine();
            //}

            //// Use the nullable string
            //if (name != null)
            //{
            //    Console.WriteLine("Hello " + name);
            //}
            //else
            //{
            //    Console.WriteLine("No name was provided.");
            //} 
            #endregion

            #region Question 7
            //ques7: What is the purpose of nullable reference types in C#? 
            //Ans7 : to help developers avoid NullReferenceException at compile time.
            //       Make the compiler warn you when a reference might be null 
            #endregion

            #region Problem 8
            //// Boxing:
            //int number = 25;
            //object boxedNum = number;
            //Console.WriteLine("Boxed value: " + boxedNum);

            //try
            //{
            //    // Unboxing:
            //    int unboxedNumber = (int)boxedNum;  // Correct unboxing
            //    Console.WriteLine("Unboxed value: " + unboxedNumber);

            //    // Invalid unboxing 
            //    object anotherBox = 3.14; 
            //    int wrongUnbox = (int)anotherBox;
            //}
            //catch (InvalidCastException)
            //{
            //    Console.WriteLine("Error, Invalid cast during unboxing!");
            //} 
            #endregion

            #region Question 8
            //ques8: What is the performance impact of boxing and unboxing in C#? 
            //Ans8 : causes much overhead
            //       Boxing: allocate memory on th heap , copy the value from stack to heap, causes garbage collector overhead 
            //       UnBoxing: requires checking the types and casting , copy the value from heap back to stack , extra CPU work 
            #endregion

            #region Problem9
            //int sum, product;

            //SumAndMultiply(5, 3, out sum, out product);

            //Console.WriteLine("Sum = " + sum);
            //Console.WriteLine("Product = " + product); 
            #endregion

            #region Question 9
            //ques9: Why must out parameters be initialized inside the method?
            //Ans9 : Because out parameters mean to return values from the method.
            //       If you don’t assign a value to an 'out' parameter inside the method -> compile-time error. 
            #endregion

            #region Problem10
            //// Normal call
            //PrintMessage("Hello");

            //// Using named parameter
            //PrintMessage(text: "Welcome", count: 3); 
            #endregion

            #region Question 10
            //ques10: Why must optional parameters always appear at the end of a method's parameter list ?
            //Ans10 : Because C# matches arguments to parameters by position unless you use named parameters. 
            #endregion

            #region Problem11
            //int[]? numbers = null;
            //int? length = numbers?.Length;

            //Console.WriteLine("Array length: " + (length?.ToString() ?? "Array is null"));

            //numbers = new int[] { 1, 2, 3, 4, 5 };

            //// Access again safely
            //length = numbers?.Length;
            //Console.WriteLine("Array length after initialization: " + length);
            #endregion

            #region Question 11
            //ques11:  How does the null propagation operator prevent NullReferenceException?
            //Ans11 : checks if the object is null before accessing its member.
            //        If the object is null: it stops and returns null instead of throwing an exception. 
            #endregion

            #region Problem 12
            //Console.WriteLine("Enter a day of the week: ");
            //string day = Console.ReadLine() ?? "";

            //int dayNumber = day.ToLower() 
            //switch
            //{
            //    "monday" => 1,
            //    "tuesday" => 2,
            //    "wednesday" => 3,
            //    "thursday" => 4,
            //    "friday" => 5,
            //    "saturday" => 6,
            //    "sunday" => 7,
            //    _ => -1
            //};

            //if (dayNumber == -1)
            //    Console.WriteLine("Invalid day entered.");
            //else
            //    Console.WriteLine($"Day number is: {dayNumber}"); 
            #endregion

            #region Question 12
            //ques12: When is a switch expression preferred over a traditional if statement?
            //Ans12 : When :1)You are mapping one value to another
            //              2)You have many conditions based on the same variable
            //              3)You want cleaner, shorter, and more readable code
            //              4)You want to return a value directly
            #endregion

            #region Problem13
            //// Call with individual values
            //int sum1 = SumArray(1, 2, 3, 4, 5);
            //Console.WriteLine("Sum of individual values: " + sum1);

            //// Call with array
            //int[] numbers = { 10, 20, 30 };
            //int sum2 = SumArray(numbers);
            //Console.WriteLine("Sum of array values: " + sum2); 
            #endregion

            #region Question13
            //ques13: What are the limitations of the params keyword in method definitions?
            //Ans13 : 1) it must be the last parameter
            //        2) it allows only one 'params' per method
            //        3) the type must be an array
            //        4) cant be used with 'ref' or 'out' parameters 
            #endregion

            #endregion

            #region Part02

            #region Problem1
            //int n;
            //do
            //{
            //    Console.Write("Enter a positive integer: ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

            //for (int i = 1; i <= n; i++)
            //{
            //    if (i < n)
            //        Console.Write(i + ", ");
            //    else
            //        Console.WriteLine(i);
            //} 
            #endregion

            #region Problem2
            //int n;
            //Console.Write("Enter an integer: ");
            //while (!int.TryParse(Console.ReadLine(), out n))
            //{
            //    Console.Write("Invalid input. Enter an integer: ");
            //}
            //Console.WriteLine($"\nMultiplication table for {n}:");
            //for (int i = 1; i <= 12; i++)
            //{
            //    if (i < 12)
            //        Console.Write((n * i) + ", ");
            //    else
            //        Console.WriteLine(n * i);
            //} 
            #endregion

            #region Problem3
            //int n;
            //do
            //{
            //    Console.Write("Enter a positive integer: ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);
            //Console.WriteLine($"\nEven numbers from 1 to {n}:");

            //for (int i=2; i<=n; i+=2)
            //{
            //    if(i<n && (n%2!=0 || i<n-1))
            //       Console.Write(i + ", " );
            //    else 
            //        Console.WriteLine(i);
            //} 
            #endregion

            #region Problem4
            //int baseNumber, power;

            //Console.Write("Enter the base number:");
            //while (!int.TryParse(Console.ReadLine(), out baseNumber))
            //{
            //    Console.Write("Invalid input.Enter integer for base: ");
            //}

            //Console.Write("Enter the exponent (non-negative integer): ");
            //while (!int.TryParse(Console.ReadLine(), out power) || power < 0)
            //{
            //    Console.Write("Invalid input.Enter a non-negative integer for exponent: ");
            //}

            //int result = 1;
            //for (int i = 1; i <= power; i++)
            //{
            //    result *= baseNumber;
            //}
            //Console.WriteLine($"\n{baseNumber}^{power} = {result}");
            #endregion

            #region Problem 5
            //Console.Write("Enter a string:");
            //string input = Console.ReadLine() ?? "";

            //// Convert string to arr of characters
            //char[] charArray = input.ToCharArray();

            //// Reverse the arr
            //Array.Reverse(charArray);

            //// Convert to string
            //string reversed = new string(charArray);

            //Console.WriteLine("Reversed string: " + reversed); 
            #endregion

            #region Problem 6
            //int number;

            //// Read integer from user
            //Console.Write("Enter an integer: ");
            //while (!int.TryParse(Console.ReadLine(), out number))
            //{
            //    Console.Write("Invalid input. Enter a valid integer: ");
            //}

            //int reversed = 0;
            //int temp = Math.Abs(number); // Handle negative numbers

            //while (temp > 0)
            //{
            //    int digit = temp % 10;       // Get last digit
            //    reversed = reversed * 10 + digit; // Append digit
            //    temp /= 10;                  // Remove last digit
            //}
            //Console.WriteLine($"Reversed integer: {reversed}"); 
            #endregion

            #region Problem 7
            //Console.Write("Enter the size of the array: ");
            //int n;
            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.Write("Invalid input. Enter a positive integer: ");
            //}

            //int[] arr = new int[n];

            //// Read array values from user
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"Enter element {i}: ");
            //    while (!int.TryParse(Console.ReadLine(), out arr[i]))
            //    {
            //        Console.Write($"Invalid input. Enter element {i}: ");
            //    }
            //}

            //int maxDistance = 0;

            //// Nested loops to find longest distance
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            int distance = j - i - 1; // count of cells between them
            //            if (distance > maxDistance)
            //                maxDistance = distance;
            //        }
            //    }
            //}
            //Console.WriteLine($"Longest distance between matching elements: {maxDistance}"); 
            #endregion

            #region Problem 8
            //Console.Write("Enter a sentence: ");
            //string sentence = Console.ReadLine() ?? "";

            //string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //Array.Reverse(words);

            //Console.WriteLine(string.Join(" ", words)); 
            #endregion 


            #endregion

        }

        #region Part01

        #region Problem2
        //public static void TestDefensiveCode()
        //{
        //    int X, Y, Z;

        //    // X must be positive > 0
        //    do
        //    {
        //        Console.WriteLine("Enter 1st number: ");
        //    }
        //    while (!int.TryParse(Console.ReadLine(),out X) || X<=0);

        //    // Y must be > 1
        //    do
        //    {
        //        Console.WriteLine("Enter 2nd number: ");
        //    }
        //    while (!int.TryParse(Console.ReadLine(),out Y) || Y<=1);

        //    Z = X / Y;
        //    Console.WriteLine($"Result = {Z}");

        //    int[] arr = { 1, 2, 3 };
        //    if (arr?.Length > 69)
        //        arr[69] = 90;
        //} 
        #endregion

        #region Question 2
        //ques2: How does int.TryParse() improve program robustness compared to int.Parse()? 
        //Ans2 : int.Parse() -> throws an exception if the input is invalid
        //       int.TryParse() -> don't throw exceptions 
        #endregion

        #region Problem 9
        //static void SumAndMultiply(int x, int y, out int sum, out int product)
        //{
        //    sum = x + y;
        //    product = x * y;
        //}
        #endregion

        #region Problem10
        //static void PrintMessage(string text, int count = 5)
        //{
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine(text);
        //    }
        //} 
        #endregion

        #region Problem13
        //static int SumArray(params int[] values)
        //{
        //    int sum = 0;
        //    foreach (int val in values)
        //    {
        //        sum += val;
        //    }
        //    return sum;
        //} 
        #endregion 

        #endregion



    }
}
