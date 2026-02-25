using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_AssignmentDay10
{
    #region problem 1
    //public class SortingAlgorithm<T>
    //{
    //    public void Sort(T[] array, IComparer<T> comparer)
    //    {
    //        for (int i = 0; i < array.Length - 1; i++)
    //        {
    //            for (int j = 0; j < array.Length - i - 1; j++)
    //            {
    //                if (comparer.Compare(array[j], array[j + 1]) > 0)
    //                {
    //                    T temp = array[j];
    //                    array[j] = array[j + 1];
    //                    array[j + 1] = temp;
    //                }
    //            }
    //        }
    //    }
    //} 
    #endregion

    #region problem 1
    //public class SalaryComparer : IComparer<Employee>
    //{
    //    public int Compare(Employee x, Employee y)
    //    {
    //        return x.Salary.CompareTo(y.Salary);
    //    }
    //} 
    #endregion

    #region problem 2&3&4
    //public class SortingTwo<T> where T : IComparable<T>
    //{
    //    public void Sort(T[] array, Comparison<T> comparison)
    //    {
    //        for (int i = 0; i < array.Length - 1; i++)
    //        {
    //            for (int j = 0; j < array.Length - i - 1; j++)
    //            {
    //                if (comparison(array[j], array[j + 1]) > 0)
    //                {
    //                    T temp = array[j];
    //                    array[j] = array[j + 1];
    //                    array[j + 1] = temp;
    //                }
    //            }
    //        }
    //    }
    //}
    #endregion

    #region problem 5
    //public class SortingTwo<T>
    //{
    //    public void Sort(T[] array, Func<T, T, bool> shouldSwap)
    //    {
    //        for (int i = 0; i < array.Length - 1; i++)
    //        {
    //            for (int j = 0; j < array.Length - i - 1; j++)
    //            {
    //                if (shouldSwap(array[j], array[j + 1]))
    //                {
    //                    T temp = array[j];
    //                    array[j] = array[j + 1];
    //                    array[j + 1] = temp;
    //                }
    //            }
    //        }
    //    }
    //}
    #endregion

    #region problem 7
    //public class SortingAlgorithm<T>
    //{
    //    // Standalone generic method
    //    public static void Swap<U>(U[] array, int index1, int index2)
    //    {
    //        U temp = array[index1];
    //        array[index1] = array[index2];
    //        array[index2] = temp;
    //    }

    //    // Example sort using Swap
    //    public void Sort(T[] array, Comparison<T> comparison)
    //    {
    //        for (int i = 0; i < array.Length - 1; i++)
    //        {
    //            for (int j = 0; j < array.Length - i - 1; j++)
    //            {
    //                if (comparison(array[j], array[j + 1]) > 0)
    //                {
    //                    Swap(array, j, j + 1);
    //                }
    //            }
    //        }
    //    }

    #endregion

    #region problem 8
    //public class SortingTwo<T>
    //{
    //    public void Sort(T[] array, Comparison<T> comparison)
    //    {
    //        for (int i = 0; i < array.Length - 1; i++)
    //        {
    //            for (int j = 0; j < array.Length - i - 1; j++)
    //            {
    //                if (comparison(array[j], array[j + 1]) > 0)
    //                {
    //                    T temp = array[j];
    //                    array[j] = array[j + 1];
    //                    array[j + 1] = temp;
    //                }
    //            }
    //        }
    //    }
    //} 
    #endregion

    #region problem 10
    public class SortingAlgorithm<T> where T : ICloneable, IComparable<T>
    {
        public void Sort(T[] array)
        {
            // Simple Bubble Sort (for demonstration)
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        // Clone the array before sorting
        public T[] CloneArray(T[] original)
        {
            T[] cloned = new T[original.Length];

            for (int i = 0; i < original.Length; i++)
            {
                cloned[i] = (T)original[i].Clone();
            }

            return cloned;
        }
    }
    #endregion

    #region problem 11
    public delegate string StringTransformer(string input);
    #endregion

    #region problem 12
    public delegate int MathOperation(int a, int b);
    #endregion

    #region problem 13
    public delegate R Transformer<T, R>(T input); 
    #endregion

    class Program
    {
        #region problem 9
        //// Generic method that returns the default value of T
        //public static T GetDefault<T>()
        //{
        //    return default(T);
        //} 
        #endregion

        #region problem 11
        public delegate string StringTransformer(string input);

        public static List<string> TransformList(List<string> list, StringTransformer transformer)
        {
            List<string> result = new List<string>();

            foreach (var item in list)
            {
                result.Add(transformer(item));
            }

            return result;
        }
        #endregion

        #region problem 12
        public delegate int MathOperation(int a, int b);
        // Method that accepts two integers and a delegate
        public static int PerformOperation(int x, int y, MathOperation operation)
        {
            return operation(x, y);
        }
        #endregion

        #region problem 13
        public delegate R Transformer<T, R>(T input);

        public static List<R> TransformList<T, R>(List<T> list, Transformer<T, R> transformer)
        {
            List<R> result = new List<R>();

            foreach (var item in list)
            {
                result.Add(transformer(item));
            }

            return result;
        }
        #endregion

        #region problem 14
        public static List<int> ApplyFunction(List<int> numbers, Func<int, int> operation)
        {
            List<int> result = new List<int>();

            foreach (var number in numbers)
            {
                result.Add(operation(number));
            }

            return result;
        }
        #endregion

        #region problem 15
        public static void ApplyAction(List<string> list, Action<string> action)
        {
            foreach (var item in list)
            {
                action(item);
            }
        }
        #endregion

        #region problem 16
        public static List<int> FilterList(List<int> numbers, Predicate<int> condition)
        {
            List<int> result = new List<int>();

            foreach (var number in numbers)
            {
                if (condition(number))
                {
                    result.Add(number);
                }
            }

            return result;
        } 
        #endregion


        static void Main(string[] args)
        {
            #region problem 1
            //Employee[] employees =
            //{
            //new Employee("Ahmed", 8000),
            //new Employee("", 5000),
            //new Employee("Mahmoud", 12000)
            //};

            //SortingAlgorithm<Employee> sorter = new SortingAlgorithm<Employee>();
            //sorter.Sort(employees, new SalaryComparer());

            //foreach (var emp in employees)
            //{
            //    Console.WriteLine(emp);
            //} 
            #endregion

            #region question 1
            //ques1: What are the benefits of using a generic sorting algorithm over a non-generic one?
            //ans1 : type safety(compile-time type checking)
            //       code reusability(the sorting class works for any custom class)
            //       follow SOLID principles(OCP) 
            #endregion

            #region problem 2
            //int[] numbers = { 3, 8, 1, 6, 2 };
            //SortingTwo<int> sorter = new SortingTwo<int>();

            ////Lambda expression
            //sorter.Sort(numbers, (x, y) => y.CompareTo(x));
            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //} 
            #endregion

            #region question 2
            //ques2:How do lambda expressions improve the readability and flexibility of sorting methods?
            //ans2 :more flexibility, and supports functional programming  
            #endregion

            #region problem 3
            //string[] words = { "Mahmoud", "Noor", "C#", "IT", "Developer" };

            //SortingTwo<string> sorter = new SortingTwo<string>();

            //// Sort by string length ascending
            //sorter.Sort(words, (x, y) => x.Length.CompareTo(y.Length));

            //foreach (var word in words)
            //{
            //    Console.WriteLine(word);
            //} 
            #endregion

            #region question 3
            //ques3: Why is it important to use a dynamic comparer function when sorting objects of various data types?
            //ans3 : because different types have different sorting logic
            //       for improving flexibility and reusability 
            #endregion

            #region problem 4
            //Manager[] managers =
            //{
            //new Manager("Ahmed", 15000),
            //new Manager("menna", 10000),
            //new Manager("Mahmoud", 20000)
            //};

            //SortingTwo<Manager> sorter = new SortingTwo<Manager>();
            //sorter.Sort(managers, (x, y) => x.Salary.CompareTo(y.Salary));

            //foreach (var manager in managers)
            //{
            //    Console.WriteLine(manager);
            //} 
            #endregion

            #region question 4
            //ques4:How does implementing IComparable<T> in derived classes enable custom sorting?
            //ans4 :objects define their own comparison logic, enables default sorting  
            #endregion

            #region problem 5
            //Employee[] employees =
            //{
            //new Employee("Noor", 5000),
            //new Employee("Mahmoud", 8000),
            //new Employee("menna", 7000),
            //new Employee("Omar", 6000)
            //};
            //SortingTwo<Employee> sorter = new SortingTwo<Employee>();

            ////sort by name length 
            //sorter.Sort(employees, (x, y) => x.Name.Length > y.Name.Length);
            //foreach (var emp in employees)
            //{
            //    Console.WriteLine(emp);
            //} 
            #endregion

            #region question 5
            //ques5:What is the advantage of using built-in delegates like Func<T, T, TResult> in generic programming?
            //ans5 : you will no need to declare custom delegates, improves code readability, more flexible and reusable 
            #endregion

            #region problem 6
            //int[] numbers = { 5, 2, 8, 1, 3 };

            //// Anonymous function
            //Array.Sort(numbers, delegate (int x, int y)
            //{
            //    return x.CompareTo(y);   // Ascending
            //});
            //Console.WriteLine("using anonymous function:");
            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //}

            //// Lambda expression
            //Array.Sort(numbers, (x, y) => x.CompareTo(y));
            //Console.WriteLine("using lambda:");
            //foreach (var num in numbers)
            //{
            //    Console.WriteLine(num);
            //} 
            #endregion

            #region question 6
            //ques6: How does the usage of anonymous functions differ from lambda expressions in terms of readability and efficiency?
            //ans6 : lambda expression mis shorter, cleaner and more redable 
            //       in terms of efficiency there is no significant difference  
            #endregion

            #region problem 7
            //int[] numbers = { 10, 20, 30, 40 };

            //Console.WriteLine("Before Swap:");
            //foreach (var n in numbers)
            //    Console.WriteLine(n);

            //// Swap index 0 and 2
            //SortingAlgorithm<int>.Swap(numbers, 0, 2);

            //Console.WriteLine("\nAfter Swap:");
            //foreach (var n in numbers)
            //    Console.WriteLine(n); 
            #endregion

            #region question 7
            //ques7:Why is the use of generic methods beneficial when creating utility functions like Swap?
            //ans7 : for reusability instead of creating swap for each data type, you create only swap<T>()
            //       for type safety 
            #endregion

            #region problem 8
            //Employee[] employees =
            //{
            //new Employee("Mahmoud", 8000),
            //new Employee("Noor", 5000),
            //new Employee("menna", 8000),
            //new Employee("Omar", 5000)
            //};

            //SortingTwo<Employee> sorter = new SortingTwo<Employee>();

            //sorter.Sort(employees, (x, y) =>
            //{
            //    int salaryComparison = x.Salary.CompareTo(y.Salary);

            //    if (salaryComparison != 0)
            //        return salaryComparison;

            //    // If salaries are equal, compare by Name
            //    return x.Name.CompareTo(y.Name);
            //});

            //foreach (var emp in employees)
            //{
            //    Console.WriteLine(emp);
            //} 
            #endregion

            #region question 8
            //ques8:What are the challenges and benefits of implementing multi-criteria sorting logic in generic methods?
            //ans8 :Benefits: more flexible and realistic sorting , clean separation of concerns
            //      challenges: increased complexity, and readability issues 
            #endregion

            #region problem 9
            //// Example with value type
            //int defaultInt = GetDefault<int>();
            //Console.WriteLine($"Default int: {defaultInt}"); // Output: 0

            //// Example with reference type
            //string defaultString = GetDefault<string>();
            //Console.WriteLine($"Default string: {defaultString ?? "null"}"); // Output: null

            //// Example with a custom class
            //MyClass defaultObj = GetDefault<MyClass>();
            //Console.WriteLine($"Default MyClass object: {defaultObj ?? null}"); // Output: null

            //// Example with nullable type
            //int? defaultNullableInt = GetDefault<int?>();
            //Console.WriteLine($"Default nullable int: {defaultNullableInt}"); // Output: null 
            #endregion

            #region question 9
            //ques9: Why is the default(T) keyword crucial in generic programming, and how does it handle value and reference types differently?
            //ans 9: In generic programming, you don’t know whether T is a value type or reference type.
            //default(T) ensures type-safe initialization without hardcoding the value.
            //It prevents errors that could occur if you tried to assign null to a value type or 0 to a reference type. 
            #endregion

            #region problem 10
            //Employee02[] employees =
            //{
            //new Employee02 { Name = "Noor", Salary = 5000 },
            //new Employee02 { Name = "menna", Salary = 3000 },
            //new Employee02 { Name = "Omar", Salary = 7000 }
            //};

            //SortingAlgorithm<Employee02> sorter = new SortingAlgorithm<Employee02>();

            //// Clone before sorting
            //Employee02[] clonedEmployees = sorter.CloneArray(employees);

            //// Sort cloned array
            //sorter.Sort(clonedEmployees);

            //Console.WriteLine("Original Array:");
            //foreach (var emp in employees)
            //    Console.WriteLine(emp);

            //Console.WriteLine("\nSorted Cloned Array:");
            //foreach (var emp in clonedEmployees)
            //    Console.WriteLine(emp); 
            #endregion

            #region question10
            //ques10:How do constraints in generic programming ensure type safety and improve the reliability of generic methods?
            //ans10 : compile-time safety, prevents invalid types 
            #endregion

            #region problem 11
            //List<string> names = new List<string>
            //{
            //"Noor",
            //"menna",
            //"Omar"
            //};

            //// 1️⃣ Convert to Uppercase
            //List<string> upper = TransformList(names, ToUpperCase);

            //// 2️⃣ Reverse Strings
            //List<string> reversed = TransformList(names, ReverseString);

            //Console.WriteLine("Uppercase:");
            //upper.ForEach(Console.WriteLine);

            //Console.WriteLine("\nReversed:");
            //reversed.ForEach(Console.WriteLine); 
            #endregion

            #region question 11
            //ques11:What are the benefits of using delegates for string transformations in a functional programming style?
            //ans11 :You can add new transformations without modifying existing code. 
            #endregion

            #region problem 12
            //int a = 10;
            //int b = 5;
            //// Using named methods
            //Console.WriteLine("Addition: " + PerformOperation(a, b, Add));
            //Console.WriteLine("Subtraction: " + PerformOperation(a, b, Subtract));
            //Console.WriteLine("Multiplication: " + PerformOperation(a, b, Multiply));
            //Console.WriteLine("Division: " + PerformOperation(a, b, Divide));
            //// Using lambda expressions
            //Console.WriteLine("Addition (Lambda): " +
            //    PerformOperation(a, b, (x, y) => x + y)); 
            #endregion

            #region question 12
            //ques12: How does using delegates promote code reusability and flexibility?
            //ans12 : You can easily add new operations without modifying "PerformOperation".
            //        does not care what operation is being performed. it executes the delegate. 
            #endregion

            #region problem 13
            //// Convert integers to strings
            //List<int> numbers = new List<int> { 1, 2, 3, 4 };

            //List<string> stringNumbers = TransformList(numbers, n => n.ToString());

            //Console.WriteLine("Integers to Strings:");
            //stringNumbers.ForEach(Console.WriteLine);


            //// Convert integers to squares
            //List<int> squares = TransformList(numbers, n => n * n);

            //Console.WriteLine("\nIntegers to Squares:");
            //squares.ForEach(Console.WriteLine);


            ////  Convert strings to their lengths
            //List<string> names = new List<string> { "Noor", "menna", "Omar" };

            //List<int> lengths = TransformList(names, s => s.Length);

            //Console.WriteLine("\nNames to Lengths:");
            //lengths.ForEach(Console.WriteLine); 
            #endregion

            #region question 13
            //ques13:What are the advantages of using generic delegates in transforming data structures?
            //ans13 : reusability and type safety

            #endregion

            #region problem 14
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            //Func<int, int> square = x => x * x;

            //List<int> squaredNumbers = ApplyFunction(numbers, square);

            //Console.WriteLine("Squared Numbers:");
            //squaredNumbers.ForEach(Console.WriteLine); 
            #endregion

            #region question 14
            //ques14: How does Func simplify the creation and usage of delegates in C#?
            //ans14 : No Need to Define Custom Delegates and supports built-in generic support

            #endregion

            #region problem 15
            //List<string> names = new List<string>
            //{
            //"Noor",
            //"menna",
            //"Omar"
            //};
            //// Action that prints the string
            //Action<string> print = s => Console.WriteLine(s);
            //ApplyAction(names, print);

            //// Or directly with lambda
            //ApplyAction(names, s => Console.WriteLine("Hello " + s)); 
            #endregion

            #region question 15
            //ques16:Why is Action preferred for operations that do not return values?
            //ans16 : designed for void methods, works perfectly with lambda 
            #endregion

            #region problem 16
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            //// Predicate that checks if number is even
            //Predicate<int> isEven = x => x % 2 == 0;

            //List<int> evenNumbers = FilterList(numbers, isEven);

            //Console.WriteLine("Even Numbers:");
            //evenNumbers.ForEach(Console.WriteLine);

            //// Or directly using lambda
            //List<int> evenNumbers2 = FilterList(numbers, x => x % 2 == 0); 
            #endregion

            #region question 16
            //ques16:What role do predicates play in functional programming, and how do they enhance code clarity?
            //ans16 : predicate takes an input and returns true or false, used for filtering data , validating conditions  
            #endregion















        }


        #region problem 11
        //// Transformation 1
        //public static string ToUpperCase(string input)
        //{
        //    return input.ToUpper();
        //}

        //// Transformation 2
        //public static string ReverseString(string input)
        //{
        //    char[] chars = input.ToCharArray();
        //    Array.Reverse(chars);
        //    return new string(chars); 
        #endregion

        #region problem 12
        public static int Add(int x, int y) => x + y;
        public static int Subtract(int x, int y) => x - y;
        public static int Multiply(int x, int y) => x * y;
        public static int Divide(int x, int y) => x / y; 
        #endregion
    }


}


