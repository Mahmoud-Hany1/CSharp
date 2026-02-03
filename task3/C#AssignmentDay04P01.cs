using System;
using System.Drawing;
using System.IO;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace task3
{
    class Program
    {
        static void Main()
        {
            #region program 1
            //// 1️⃣ Initializing array using new int[size]
            //int[] arr1 = new int[3];
            //arr1[0] = 10;
            //arr1[1] = 20;
            //arr1[2] = 30;

            //Console.WriteLine("Array 1:");
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine(arr1[i]);
            //}

            //// 2️⃣ Initializing array using initializer list
            //int[] arr2 = { 40, 50, 60 };

            //Console.WriteLine("\nArray 2:");
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.WriteLine(arr2[i]);
            //}

            //// 3️⃣ Initializing array using Array syntax sugar
            //int[] arr3 = new[] { 70, 80, 90 };

            //Console.WriteLine("\nArray 3:");
            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    Console.WriteLine(arr3[i]);
            //}

            //// 4️⃣ Demonstrating IndexOutOfRangeException
            //try
            //{
            //    Console.WriteLine("\nTrying to access invalid index:");
            //    Console.WriteLine(arr1[5]); // Invalid index
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Exception caught: " + ex.Message);
            //} 
            #endregion
            #region question 1
            //In C#, array elements are automatically initialized with the default value of their data type. 
            #endregion
            #region problem 2
            //// =========================
            //// Original array
            //int[] arr1 = { 1, 2, 3 };

            //// =========================
            //// 1) Shallow Copy
            //int[] arr2 = arr1;   

            //arr2[0] = 100;  

            //Console.WriteLine("After Shallow Copy modification:");
            //Console.WriteLine("arr1[0] = " + arr1[0]); 
            //Console.WriteLine("arr2[0] = " + arr2[0]); 

            //// =========================
            //// 2) Deep Copy using Clone
            //int[] arr3 = (int[])arr1.Clone(); 

            //arr3[1] = 200;      

            //Console.WriteLine("\nAfter Deep Copy (Clone) modification:");
            //Console.WriteLine("arr1[1] = " + arr1[1]); 
            //Console.WriteLine("arr3[1] = " + arr3[1]);  
            #endregion
            #region question 2
            //Array.Clone creates a new array instance, while Array.
            //    Copy copies elements into an existing array; both perform shallow copies 
            #endregion

            #region problem 3
            //int[,] grades = new int[3, 3];


            //for (int i = 0; i < 3; i++) 
            //{
            //    Console.WriteLine($"Enter grades for Student {i + 1}:");
            //    for (int j = 0; j < 3; j++) 
            //    {
            //        Console.Write($"  Subject {j + 1}: ");
            //        grades[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("\nStudent Grades:");


            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write($"Student {i + 1}: ");
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write(grades[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion
            #region question 3
            //Length returns the total number of elements in a multi-dimensional array,
            //    while GetLength returns the size of a specific dimension. 
            #endregion
            #region problem 4
            //    int[] arr = { 5, 2, 8, 1, 3 };

            //    // Original array
            //    Console.WriteLine("Original Array:");
            //    PrintArray(arr);

            //    // 1) Sort
            //    Array.Sort(arr);
            //    Console.WriteLine("\nAfter Sort:");
            //    PrintArray(arr);


            //    // 2) Reverse
            //    Array.Reverse(arr);
            //    Console.WriteLine("\nAfter Reverse:");
            //    PrintArray(arr);


            //    // 3) IndexOf
            //    int index = Array.IndexOf(arr, 3);
            //    Console.WriteLine("\nIndexOf 3:");
            //    Console.WriteLine("Index = " + index);


            //    // 4) Copy
            //    int[] arrCopy = new int[arr.Length];
            //    Array.Copy(arr, arrCopy, arr.Length);
            //    Console.WriteLine("\nAfter Copy (New Array):");
            //    PrintArray(arrCopy);


            //    // 5) Clear
            //    Array.Clear(arr, 0, arr.Length);
            //    Console.WriteLine("\nAfter Clear:");
            //    PrintArray(arr);



            //}
            //static void PrintArray(int[] array)
            //{
            //    foreach (int item in array)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion
            #region question 4
            //Use Array.Copy() for normal copying and Array.ConstrainedCopy() when you need an all - or - nothing safe copy. 
            #endregion

            #region problem 5
            //int[] numbers = { 10, 20, 30, 40, 50 };

            //// 1) Using for loop (forward)
            //Console.WriteLine("Using for loop:");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}
            //Console.WriteLine();

            //// 2) Using foreach loop (forward)
            //Console.WriteLine("\nUsing foreach loop:");
            //foreach (int num in numbers)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();

            //// 3) Using while loop (reverse order)
            //Console.WriteLine("\nUsing while loop (reverse):");
            //int index = numbers.Length - 1;
            //while (index >= 0)
            //{
            //    Console.Write(numbers[index] + " ");
            //    index--;
            //}
            //Console.WriteLine(); 
            #endregion
            #region question 5
            //Because foreach automatically iterates over all elements without using an 
            //    index and prevents accidental modification of array elements. 
            #endregion
            #region problem 6
            //int number;

            //do
            //{
            //    Console.Write("Enter a positive odd number: ");
            //    string input = Console.ReadLine();


            //    bool isValid = int.TryParse(input, out number);


            //    if (!isValid || number <= 0 || number % 2 == 0)
            //    {
            //        Console.WriteLine("Invalid input! Please enter a positive odd number.\n");
            //    }

            //} while (number <= 0 || number % 2 == 0); // تكرار حتى الإدخال صحيح

            //Console.WriteLine($"\nYou entered a valid positive odd number: {number}"); 
            #endregion
            #region question 6
            //Input validation ensures that the program receives data in the expected format, preventing errors,
            //    crashes, and potential security issues. 
            #endregion

            #region problem 7
            //    int[,] matrix = {
            //    { 1, 2, 3 },
            //    { 4, 5, 6 },
            //    { 7, 8, 9 }
            //};

            //    Console.WriteLine("Matrix elements:");


            //    for (int i = 0; i < matrix.GetLength(0); i++) 
            //    {
            //        for (int j = 0; j < matrix.GetLength(1); j++) 
            //        {
            //            Console.Write(matrix[i, j] + " ");
            //        }
            //        Console.WriteLine();
            //    } 
            #endregion
            #region question 7
            //You can format a 2D array by using nested loops and aligning elements in rows and columns,
            //    optionally adding tabs or fixed-width spacing. 
            #endregion
            #region problem 8
            //Console.Write("Enter a month number (1-12): ");
            //int monthNumber;
            //bool isValid = int.TryParse(Console.ReadLine(), out monthNumber);

            //if (!isValid || monthNumber < 1 || monthNumber > 12)
            //{
            //    Console.WriteLine("Invalid month number!");
            //    return;
            //}

            //// ========================
            //// Using if-else
            //Console.WriteLine("\nUsing if-else:");
            //if (monthNumber == 1) Console.WriteLine("January");
            //else if (monthNumber == 2) Console.WriteLine("February");
            //else if (monthNumber == 3) Console.WriteLine("March");
            //else if (monthNumber == 4) Console.WriteLine("April");
            //else if (monthNumber == 5) Console.WriteLine("May");
            //else if (monthNumber == 6) Console.WriteLine("June");
            //else if (monthNumber == 7) Console.WriteLine("July");
            //else if (monthNumber == 8) Console.WriteLine("August");
            //else if (monthNumber == 9) Console.WriteLine("September");
            //else if (monthNumber == 10) Console.WriteLine("October");
            //else if (monthNumber == 11) Console.WriteLine("November");
            //else Console.WriteLine("December");

            //// ========================
            //// Using switch
            //Console.WriteLine("\nUsing switch:");
            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("January"); break;
            //    case 2: Console.WriteLine("February"); break;
            //    case 3: Console.WriteLine("March"); break;
            //    case 4: Console.WriteLine("April"); break;
            //    case 5: Console.WriteLine("May"); break;
            //    case 6: Console.WriteLine("June"); break;
            //    case 7: Console.WriteLine("July"); break;
            //    case 8: Console.WriteLine("August"); break;
            //    case 9: Console.WriteLine("September"); break;
            //    case 10: Console.WriteLine("October"); break;
            //    case 11: Console.WriteLine("November"); break;
            //    case 12: Console.WriteLine("December"); break;
            //} 
            #endregion
            #region question 8
            //Use a switch statement when you have multiple discrete values to compare against a single variable,
            //    as it improves readability and maintainability compared to long if-else chains. 
            #endregion

            #region problem 9
            //int[] numbers = { 5, 2, 8, 1, 3, 2 };

            //// ========================
            //// 1) Sort the array
            //Array.Sort(numbers);
            //Console.WriteLine("Sorted Array:");
            //foreach (int num in numbers)
            //{
            //    Console.Write(num + " ");
            //}
            //Console.WriteLine();

            //// ========================
            //// 2) Search for a specific value
            //int valueToSearch = 2;

            //int firstIndex = Array.IndexOf(numbers, valueToSearch);
            //int lastIndex = Array.LastIndexOf(numbers, valueToSearch);

            //Console.WriteLine($"\nSearching for value {valueToSearch}:");
            //Console.WriteLine("First occurrence index: " + firstIndex);

            #endregion
            #region question 9
            //Array.Sort() in C# uses the QuickSort, HeapSort, or IntroSort algorithms internally,
            //    depending on the data type, and its average time complexity is O(n log n) 
            #endregion

            #region problem 10
            //int[] numbers = { 5, 10, 15, 20 };

            //// ========================
            //// 1) Using for loop
            //int sumFor = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sumFor += numbers[i];
            //}
            //Console.WriteLine("Sum using for loop: " + sumFor);

            //// ========================
            //// 2) Using foreach loop
            //int sumForeach = 0;
            //foreach (int num in numbers)
            //{
            //    sumForeach += num;
            //}
            //Console.WriteLine("Sum using foreach loop: " + sumForeach); 
            #endregion
            #region question 10
            // A for loop is slightly more efficient than foreach for arrays because
            //it accesses elements directly using the index without the overhead of the enumerator that foreach uses. 
            #endregion


        }

    }
}
