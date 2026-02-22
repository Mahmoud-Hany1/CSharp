using System;

namespace AdvancedCSharpProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1 - Weekdays Enum
            Console.WriteLine("=== Problem 1 ===");

            foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
            {
                Console.WriteLine($"{day} = {(int)day}");
            }

            // Question: Why assign values explicitly?
            // Answer: To ensure specific numeric values, maintain compatibility, or integrate with external systems.
            #endregion

            #region Problem 2 - Grades Enum with short
            Console.WriteLine("\n=== Problem 2 ===");

            foreach (Grades grade in Enum.GetValues(typeof(Grades)))
            {
                Console.WriteLine($"{grade} = {(short)grade}");
            }

            // Question: What if value exceeds underlying type?
            // Answer: Compiler error or unexpected overflow occurs.
            #endregion

            #region Problem 3 - Person Class with Department
            Console.WriteLine("\n= Problem 3 =");

            Person p1 = new Person("mahmoud", "IT");
            Person p2 = new Person("mohamed", "HR");

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            // Question: Purpose of virtual keyword for properties
            // Answer: Allows derived classes to override the property behavior.
            #endregion

            #region Problem 4 - Child Class with DisplaySalary
            Console.WriteLine("\n=== Problem 4 ===");

            Child child = new Child(5000);
            child.DisplaySalary();

            // Question: Why can't override a sealed property?
            // Answer: Sealed members prevent further overriding to maintain fixed behavior.
            #endregion

            #region Problem 5 - Static Utility Method for Rectangle Perimeter
            Console.WriteLine("\n=== Problem 5 ===");

            double perimeter = Utility.RectanglePerimeter(5, 10);
            Console.WriteLine($"Rectangle perimeter: {perimeter}");

            // Question: Key difference static vs object members
            // Answer: Static belongs to class itself; object members belong to instances.
            #endregion

            #region Problem 6 - ComplexNumber Operator Overloading
            Console.WriteLine("\n=== Problem 6 ===");

            ComplexNumber c1 = new ComplexNumber(2, 3);
            ComplexNumber c2 = new ComplexNumber(4, 5);
            ComplexNumber result = c1 * c2;
            Console.WriteLine($"Multiplication result: {result}");

            // Question: Can you overload all operators?
            // Answer: No, some operators like conditional logical operators cannot be overloaded.
            #endregion

            #region Problem 7 - Gender Enum with byte
            Console.WriteLine("\n=== Problem 7 ===");

            foreach (Gender g in Enum.GetValues(typeof(Gender)))
            {
                Console.WriteLine($"{g} = {(byte)g}");
            }

            // Question: When to change underlying type?
            // Answer: To reduce memory footprint or match data source type.
            #endregion

            #region Problem 8 - Temperature Conversion
            Console.WriteLine("\n=== Problem 8 ===");

            double f = Utility.CelsiusToFahrenheit(25);
            double c = Utility.FahrenheitToCelsius(77);
            Console.WriteLine($"25°C = {f}°F");
            Console.WriteLine($"77°F = {c}°C");

            // Question: Why can't static class have instance constructors?
            // Answer: Static class cannot be instantiated, so no instance constructor.
            #endregion

            #region Problem 9 - Enum.TryParse
            Console.WriteLine("\n=== Problem 9 ===");

            string input = "A";
            if (Enum.TryParse<Grades>(input, out Grades gradeResult))
                Console.WriteLine($"Parsed grade: {gradeResult}");
            else
                Console.WriteLine("Invalid input");

            // Question: Advantages over int.Parse
            // Answer: Avoids exceptions, safer input handling.
            #endregion

            #region Problem 10 - Employee Equals with Search
            Console.WriteLine("\n=== Problem 10 ===");

            Employee[] emps = new Employee[]
            {
                new Employee("mahmoud"),
                new Employee("mohamed")
            };

            Employee target = new Employee("mahmoud");
            int index = Helper2<Employee>.SearchArray(emps, target);
            Console.WriteLine($"mahmoud found at index: {index}");

            // Question: Equals vs == 
            // Answer: Equals checks logical equality; == compares reference for classes (struct compares values).
            #endregion

            #region Problem 11 - Generic Max Method
            Console.WriteLine("\n=== Problem 11 ===");

            Console.WriteLine(Helper.Max(5, 10));
            Console.WriteLine(Helper.Max(3.5, 2.8));
            Console.WriteLine(Helper.Max("apple", "banana"));

            // Question: Can generics be constrained?
            // Answer: Yes, e.g., class Helper<T> where T: IComparable<T>
            #endregion

            #region Problem 12 - ReplaceArray Generic Method
            Console.WriteLine("\n=== Problem 12 ===");

            int[] numbers = { 1, 2, 2, 3 };
            string[] fruits = { "apple", "banana", "apple" };

            Helper2<int>.ReplaceArray(numbers, 2, 9);
            Helper2<string>.ReplaceArray(fruits, "apple", "orange");

            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine(string.Join(", ", fruits));

            // Question: Generic methods vs generic classes
            // Answer: Methods are for specific operations; classes define reusable types.
            #endregion

            #region Problem 13 - Swap Non-Generic
            Console.WriteLine("\n=== Problem 13 ===");

            Rectangle r1 = new Rectangle { Length = 5, Width = 10 };
            Rectangle r2 = new Rectangle { Length = 2, Width = 3 };

            Swap(r1, r2);
            Console.WriteLine($"r1: {r1.Length},{r1.Width} | r2: {r2.Length},{r2.Width}");

            // Question: Why generic swap preferable?
            // Answer: One method works for any type, no duplicate code.
            #endregion

            #region Problem 14 - Employee with Department Search
            Console.WriteLine("\n=== Problem 14 ===");

            Department it = new Department("IT");
            Department hr = new Department("HR");

            Employee[] staff = {
                new Employee("mahmoud", it),
                new Employee("mohamed", hr)
            };

            int searchIndex = Helper2<Employee>.SearchArray(staff, new Employee("mahmoud", it));
            Console.WriteLine($"mahmoud in IT at index: {searchIndex}");

            // Question: Overriding Equals for Department improves search accuracy.
            #endregion

            #region Problem 15 - Circle Struct vs Class Comparison
            Console.WriteLine("\n=== Problem 15 ===");

            Circle cStruct1 = new Circle(5, "Red");
            Circle cStruct2 = new Circle(5, "Red");

            CircleClass cClass1 = new CircleClass(5, "Red");
            CircleClass cClass2 = new CircleClass(5, "Red");

            Console.WriteLine($"Struct Equals: {cStruct1.Equals(cStruct2)}, Struct == : {cStruct1 == cStruct2}");
            Console.WriteLine($"Class Equals: {cClass1.Equals(cClass2)}, Class == : {cClass1 == cClass2}");

            // Question: == not implemented by default for structs because it's not safe for custom equality logic.
            #endregion
        }

        #region Enums

        enum Weekdays { Monday = 1, Tuesday, Wednesday, Thursday, Friday }
        enum Grades : short { A = 4, B = 3, C = 2, D = 1, F = -1 }
        enum Gender : byte { Male, Female }

        #endregion

        #region Classes

        class Person
        {
            public string Name { get; set; }
            public string Department { get; set; }

            public Person(string name, string dept)
            {
                Name = name;
                Department = dept;
            }

            public override string ToString()
            {
                return $"Name: {Name}, Department: {Department}";
            }
        }

        class Child
        {
            public sealed int Salary { get; set; }

            public Child(int salary)
            {
                Salary = salary;
            }

            public void DisplaySalary()
            {
                Console.WriteLine($"Salary = {Salary}");
            }
        }

        static class Utility
        {
            public static double RectanglePerimeter(double l, double w) => 2 * (l + w);

            public static double CelsiusToFahrenheit(double c) => c * 9 / 5 + 32;
            public static double FahrenheitToCelsius(double f) => (f - 32) * 5 / 9;
        }

        class ComplexNumber
        {
            public double Real { get; set; }
            public double Imag { get; set; }

            public ComplexNumber(double r, double i)
            {
                Real = r;
                Imag = i;
            }

            public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
            {
                return new ComplexNumber(
                    c1.Real * c2.Real - c1.Imag * c2.Imag,
                    c1.Real * c2.Imag + c1.Imag * c2.Real
                );
            }

            public override string ToString() => $"{Real} + {Imag}i";
        }

        class Employee
        {
            public string Name { get; set; }
            public Department Dept { get; set; }

            public Employee(string name) => Name = name;
            public Employee(string name, Department dept) { Name = name; Dept = dept; }

            public override bool Equals(object obj)
            {
                if (obj is Employee e)
                {
                    if (Dept == null || e.Dept == null)
                        return Name == e.Name;
                    return Name == e.Name && Dept.Equals(e.Dept);
                }
                return false;
            }

            public override int GetHashCode() => (Name + Dept?.Name).GetHashCode();

            public override string ToString() => $"Name: {Name}, Department: {Dept?.Name}";
        }

        class Department
        {
            public string Name { get; set; }
            public Department(string name) => Name = name;

            public override bool Equals(object obj)
            {
                return obj is Department d && Name == d.Name;
            }
            public override int GetHashCode() => Name.GetHashCode();
        }

        class Circle
        {
            public int Radius { get; set; }
            public string Color { get; set; }

            public Circle(int r, string c) { Radius = r; Color = c; }

            public override bool Equals(object obj)
            {
                return obj is Circle c && Radius == c.Radius && Color == c.Color;
            }
        }

        class CircleClass
        {
            public int Radius { get; set; }
            public string Color { get; set; }

            public CircleClass(int r, string c) { Radius = r; Color = c; }

            public override bool Equals(object obj)
            {
                return obj is CircleClass c && Radius == c.Radius && Color == c.Color;
            }
        }

        class Rectangle
        {
            public int Length { get; set; }
            public int Width { get; set; }
        }

        #endregion

        #region Generic Helper Classes

        static class Helper
        {
            public static T Max<T>(T a, T b) where T : IComparable<T>
            {
                return a.CompareTo(b) >= 0 ? a : b;
            }
        }

        static class Helper2<T>
        {
            public static void ReplaceArray(T[] arr, T oldVal, T newVal)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (Equals(arr[i], oldVal))
                        arr[i] = newVal;
                }
            }

            public static int SearchArray(T[] arr, T value)
            {
                for (int i = 0; i < arr.Length; i++)
                    if (Equals(arr[i], value))
                        return i;
                return -1;
            }
        }

        #endregion

        #region Non-Generic Swap
        static void Swap(Rectangle r1, Rectangle r2)
        {
            int tempL = r1.Length;
            int tempW = r1.Width;
            r1.Length = r2.Length;
            r1.Width = r2.Width;
            r2.Length = tempL;
            r2.Width = tempW;
        }
        #endregion
        #region Theoretical Questions - Generics and Hierarchy

        // 2) Generalization using Generics
        // Generalization with generics means writing flexible reusable code
        // that works with different data types without duplicating logic.
        // Instead of creating separate methods or classes for int, string, etc.,
        // you define one generic type (e.g., T) that can be replaced at runtime.
        // Example:
        // class Helper<T>
        // {
        //     public T Max(T a, T b) where T : IComparable<T>
        //     {
        //         return a.CompareTo(b) >= 0 ? a : b;
        //     }
        // }
        // Benefit: Reduces code duplication, improves maintainability, allows type safety.

        // 3) Hierarchy Design in Real Business
        // Hierarchy design refers to structuring classes, interfaces, and components
        // in a parent-child relationship that reflects real-world business entities.
        // Example: 
        // - Base class: Employee
        // - Derived classes: Manager, Developer, Intern
        // - Each derived class inherits common attributes/methods from Employee
        // This approach models real-world roles, allows code reuse, and simplifies system maintenance.
        // In businesses, it helps in representing organizational structures, product categories, or service tiers.

        #endregion


    }
}
