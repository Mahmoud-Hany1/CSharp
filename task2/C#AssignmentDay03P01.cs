using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Xml;
using static System.Formats.Asn1.AsnWriter;

class Program
{
    class MyClass
    {
        public int Value;
    }
    static void Main()
    {
        #region problem 1

        //Console.Write("Enter a number: ");
        //string input = Console.ReadLine();

        //// باستخدام int.Parse
        //try
        //{
        //    int number1 = int.Parse(input);
        //    Console.WriteLine("int.Parse result: " + number1);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("int.Parse error: " + ex.Message);
        //}

        //// باستخدام Convert.ToInt32
        //try
        //{
        //    int number2 = Convert.ToInt32(input);
        //    Console.WriteLine("Convert.ToInt32 result: " + number2);
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("Convert.ToInt32 error: " + ex.Message);
        //}
        #endregion
        #region Question 1
        //int.Parse throws an exception when the input is null, while Convert.ToInt32 returns 0 when the input is null. 
        #endregion
        #region problem 2
        //Console.Write("Enter a number: ");
        //string input = Console.ReadLine();

        //if (int.TryParse(input, out int number))
        //{
        //    Console.WriteLine("Valid number: " + number);
        //}
        //else
        //{
        //    Console.WriteLine("Error: Invalid integer input.");
        //} 
        #endregion
        #region Question 2
        //Because TryParse does not throw exceptions when the input is invalid, making applications more stable and user-friendly. 
        #endregion
        #region problem 3
        //object obj = new object();

        //// Assign int
        //obj = 10;
        //Console.WriteLine("int value HashCode: " + obj.GetHashCode());

        //// Assign string
        //obj = "Ali";
        //Console.WriteLine("string value HashCode: " + obj.GetHashCode());

        //// Assign double
        //obj = 10.5;
        //Console.WriteLine("double value HashCode: " + obj.GetHashCode()); 
        #endregion
        #region question 3
        //GetHashCode() is used to speed up searching and storing objects in collections like Dictionary and HashSet. 
        #endregion
        #region problem 4
        //// إنشاء كائن جديد
        //MyClass obj1 = new MyClass();
        //obj1.Value = 10;

        //MyClass obj2 = new MyClass();

        //obj2 = obj1;


        //Console.WriteLine("Before change:");
        //Console.WriteLine("obj1.Value = " + obj1.Value);
        //Console.WriteLine("obj2.Value = " + obj2.Value);

        //// تعديل القيمة باستخدام obj1
        //obj1.Value = 50;


        //Console.WriteLine("\nAfter change via obj1:");
        //Console.WriteLine("obj1.Value = " + obj1.Value);
        //Console.WriteLine("obj2.Value = " + obj2.Value); 
        #endregion
        #region question 4
        //Reference equality checks whether two references point to the exact same object in memory,
        //    which is important for correctness and performance in .NET. 
        #endregion

        #region problem 5
        //string Greeting = "Hello";

        //// طباعة الـ HashCode قبل التعديل
        //Console.WriteLine("Before modification:");
        //Console.WriteLine("HashCode: " + Greeting.GetHashCode());


        //Greeting = Greeting + " Hi Willy";

        //// طباعة الـ HashCode بعد التعديل
        //Console.WriteLine("\nAfter modification:");
        //Console.WriteLine("Value: " + Greeting);
        //Console.WriteLine("HashCode: " + Greeting.GetHashCode()); 
        #endregion

        #region question 5
        //String is immutable in C# to ensure safety, performance, and correct behavior in hash-based collections. 
        #endregion
        #region problem 6
        //// إنشاء StringBuilder
        //StringBuilder sb = new StringBuilder("Hi");

        //// طباعة الـ HashCode قبل التعديل
        //Console.WriteLine("Before modification:");
        //Console.WriteLine("Value: " + sb.ToString());
        //Console.WriteLine("HashCode: " + sb.GetHashCode());

        //// إضافة نص
        //sb.Append(" Willy");

        //// طباعة الـ HashCode بعد التعديل
        //Console.WriteLine("\nAfter modification:");
        //Console.WriteLine("Value: " + sb.ToString());
        //Console.WriteLine("HashCode: " + sb.GetHashCode()); 
        #endregion
        #region question 6
        //tringBuilder improves performance by modifying the same object in memory instead of creating multiple string objects during concatenation. 
        #endregion
        #region question 7
        //stringBuilder is faster for large - scale modifications because it avoids repeated object creation and reduces memory and GC overhead. 
        #endregion
        #region problem 7
        //// إدخال الرقم الأول
        //Console.Write("Enter first number: ");
        //int input1 = int.Parse(Console.ReadLine());

        //// إدخال الرقم الثاني
        //Console.Write("Enter second number: ");
        //int input2 = int.Parse(Console.ReadLine());

        //int sum = input1 + input2;

        //// 1) باستخدام Concatenation (+)
        //Console.WriteLine("Sum is " + sum);

        //// 2) باستخدام Composite Formatting
        //Console.WriteLine(string.Format("Sum is {0}", sum));

        //// 3) باستخدام String Interpolation
        //Console.WriteLine($"Sum is {sum}"); 
        #endregion
        #region question 8
        //string interpolation($) is the most commonly used method because it is more readable, concise,
        //    and less error - prone than concatenation and composite formatting. 
        #endregion

        #region problem 8
        // إنشاء StringBuilder
        //StringBuilder sb = new StringBuilder("Hi");

        //// 1) Append text
        //sb.Append(" Willy");
        //Console.WriteLine("After Append: " + sb.ToString());

        //// 2) Replace substring
        //sb.Replace("Willy", "Ahmed");
        //Console.WriteLine("After Replace: " + sb.ToString());

        //// 3) Insert text at specific position
        //sb.Insert(3, "Dear ");
        //Console.WriteLine("After Insert: " + sb.ToString());

        //// 4) Remove portion of text
        //sb.Remove(3, 5); // إزالة كلمة "Dear "
        //Console.WriteLine("After Remove: " + sb.ToString()); 
        #endregion
        #region question 9
        //StringBuilder is designed to efficiently handle frequent modifications by changing the same object in memory,
        //    while strings create a new object for every modification. 
        #endregion


    }

}

