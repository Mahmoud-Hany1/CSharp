using System;
using System.Diagnostics;
using System.Drawing;

namespace CsharpDay02Assignment
{
    class Program
    {
        static void Main()
        {
            //Part01
            #region Problem1
            //int x = 10; //Declare integer variable called x and assign it value 10
            //int y = 20; //Declare integer variable called y and assign it value 20
            //int sum = x + y;
            /*
            this expression calculates the sum of x and y 
            and stores the result in the variable called sum
             */
            //Console.WriteLine(sum); // Display the value of the sum variable on the console 

            #endregion

            #region Question 1
            //ctrl + k + c
            //ctrl + k + u 
            #endregion

            #region Problem2
            //Errors in the code:
            //1) the variable x is declared as int but assigned a string value "10"
            //2) console should be Console (C# is case sensitive)
            //3) using undeclared variable y 
            //Fixed Code:
            //int x = 10;
            //int y = 5;
            //Console.WriteLine(x + y);
            #endregion

            #region Question 2
            //Runtime and logical error
            //1)Runtime Error
            //occurs while the program is running and causes it to crash
            //or stop unexpectedly causes an exception 
            // ex: divsion by zero
            //2)Logical error
            // caused because your logic , so the program runs without crashing
            //but produces incorrect results
            //ex: you declared a variable clled result and assigned it the value of the sum of another 2 variable
            // but the result when the program run is the sum , so you absloutely wrote something wrong like the operator + and - 
            #endregion

            #region Problem3
            //string fullName = "Mahmoud Hany";
            //int age = 21;
            //decimal monthlySalary = 20000;
            //bool isStudent = true;
            #endregion

            #region Question 3
            //Question 3
            //Question: Why is it important to follow naming conventions such as PascalCase in C#? 
            //Answer: to improve redability and make it easier to read and understand by other developers
            //        to be alligned with .NET standards because the .NET itself uses PascalCase   
            #endregion

            #region Problem 4
            Point P1;
            P1 = new Point();
            Point P2;
            P2 = new Point();
            P2 = P1;

            P1.X = 15;
            Console.WriteLine(P2.X);
            #endregion

            #region Question 4
            //Question 4
            //Question: Explain the difference between value types and reference types in terms of memory 
            //allocation.
            //Value Types:Value types store the actual data value directly in memory.
            //            allocated on the stack 
            //Refrence Types: Reference types store a reference (address) to the data, not the data itself.
            //                allocated on the heap 
            #endregion

            #region Problem5
            int X = 15;
            int Y = 4;
            int sum = X + Y;
            int difference = X - Y;
            int product = X * Y;
            double DivisionResult = (double)X / Y;
            int remainder = X % Y;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Division Result: " + DivisionResult);
            Console.WriteLine("Remainder: " + remainder);
            #endregion

            #region Question 5 
            // Question: What will be the output of the following code? Explain why: 
            //int a = 2, b = 7;
            //Console.WriteLine(a % b);
            // the output will be 2 because there is no remainder when you divide 2 over 7 
            #endregion

            #region Problem 6
            int c = 14;
            if (c > 10 && c % 2 == 0)
            {
                Console.WriteLine("The number is greater than 10 and even");
            }
            else
            {
                Console.WriteLine("The answer doesn't meet the both constraints");
            }
            #endregion

            #region Question 6
            //Question: How does the && (logical AND) operator differ from the & (bitwise AND) operator? 
            // && -> used with boolean expressions but it does short circuit -> if the first operand is false , the second is not evaluated
            // &  -> used integers , performs bit by bit AND , but it is long circuit 
            #endregion


            #region Question 7
            //Question: Why is explicit casting required when converting a double to an int? 
            //        1- because there is a potential of data loss : Because the fractional part is discarded, the compiler wants you to explicitly acknowledge that you understand some data will be lost.
            //        2- Converting a large double to int could also overflow 
            #endregion

            #region Problem 8
            Console.WriteLine("Enter ur age");
            int age = int.Parse(Console.ReadLine());
            if (age > 0)
            {
                Console.WriteLine("Your age is: " + age);
            }
            else
            {
                Console.WriteLine("Invalid age! Age must be greater than 0.");
            }
            #endregion



            #region Problem9
            Console.WriteLine("PostFix");
            int h = 5; //h =5
            Console.WriteLine(h++); // prints h then increment it by 1 //5 
            Console.WriteLine(h); // h after the increment //6
            Console.WriteLine("PreFix");
            Console.WriteLine(h); //6
            Console.WriteLine(++h); // increments h then print it // 7
            Console.WriteLine(h);  //7
            #endregion



            #region Question 9
            int x = 5;
            int y = ++x + x++;
            Console.WriteLine(x); //7 -> first x was 5 then inctremented by one at the first operand , and incremented another time at the second operand
            Console.WriteLine(y); // 12 
            #endregion












        }
    }
}