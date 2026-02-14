using System.Xml.Linq;

namespace C_AssignmentDay06
{
    #region Problem 1
    //public struct Point
    //{
    //    public int X;
    //    public int Y;

    //    public Point() //default ctr
    //    {
    //        X = 0;
    //        Y = 0;
    //    }

    //    public Point(int x, int y) //parameterized ctr
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //    public override string ToString()
    //    {
    //        return $"({X}, {Y})";
    //    }
    //}
    #endregion

    #region Problem 3
    //public struct Employee
    //{
    //    private int EmpId;
    //    private string Name;
    //    private decimal Salary;

    //    public Employee(int empId, string name, decimal salary)
    //    {
    //        EmpId = empId;
    //        Name = name;
    //        Salary = salary;
    //    }

    //    public string GetName()
    //    {
    //        return Name;
    //    }

    //    public void SetName(string name)
    //    {
    //        if (!string.IsNullOrWhiteSpace(name))
    //            Name = name;
    //    }

    //    public int _EmpId
    //    {
    //        get { return EmpId; }
    //        set
    //        {
    //            if (value > 0)
    //                EmpId = value;
    //        }
    //    }

    //    public decimal _Salary
    //    {
    //        get { return Salary; }
    //        set
    //        {
    //            if (value >= 0)
    //                Salary = value;
    //        }
    //    }
    //    public override string ToString()
    //    {
    //        return $"ID: {EmpId}, Name: {Name}, Salary: {Salary}";
    //    }
    //}
    #endregion

    #region Problem 4
    //public struct Point
    //{
    //    public int X;
    //    public int Y;

    //    public Point(int x)
    //    {
    //        X = x;
    //        Y = 0;
    //    }

    //    public Point(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //    }
    //    public override string ToString()
    //    {
    //        return $"({X}, {Y})";
    //    }
    //} 
    #endregion

    #region Problem 5
    //public struct Point
    //{
    //    public int X;
    //    public int Y;

    //    public Point(int x, int y)
    //    {
    //        X = x;
    //        Y = y;
    //    }

    //    // after modification
    //    public override string ToString()
    //    {
    //        return $"Point -> X: {X,-3} | Y: {Y,-3}";
    //    }
    //} 
    #endregion

    #region Problem 6
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Employee
    {
        public string Name;
        public int Age;

        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }
    } 
    #endregion


    class Program
    {
        #region Problem 6
        static void ModifyPoint(Point p)
        {
            p.X = 100;
            p.Y = 100;
        }

        static void ModifyEmployee(Employee e)
        {
            e.Name = "Changed";
            e.Age = 99;
        } 
        #endregion
        static void Main()
        {
            #region Problem 1
            //Point p1 = new Point();          // default
            //Point p2 = new Point(5, 10);    // parameterized

            //Console.WriteLine(p1);  // (0, 0)
            //Console.WriteLine(p2);  // (5, 10) 
            #endregion

            #region Question 1
            //Ques1: Why can't a struct inherit from another struct or class in C#? 
            //Ans1 : 1. Struct is a value-Type (stored in Stack) and Inheritance requires ref-type behaviour
            //       2. Structs designed to be lightweight and fast, and inheritance raises the complexity 
            #endregion

            #region Problem 2
            //TypeA obj = new TypeA(); // acces from another class in the same project
            //// Console.WriteLine(obj.F);  //Error (private)
            //Console.WriteLine(obj.G);    // internal(accesible)
            //Console.WriteLine(obj.H);    // public(accessible) 
            #endregion

            #region Question 2
            //ques2: How do access modifiers impact the scope and visibility of a class member?
            //Ans2 : private: accessible only in the same class
            //       internal: accessible in the same class and the same project
            //       public: accessible in the same class and same project and other projects 
            #endregion

            #region Problem 3
            //Employee emp = new Employee(1, "Mahmoud", 5000);
            //Console.WriteLine(emp);

            //// Using methods
            //emp.SetName("Ahmed");
            //Console.WriteLine("Updated Name: " + emp.GetName());

            //// Using properties
            //emp._EmpId = 10;
            //emp._Salary = 8000;
            //Console.WriteLine(emp);
            #endregion

            #region Question 3
            //ques3: Why is encapsulation critical in software design?  
            //Ans3 : 1. for Data protection and prevents invalid or harmful values from assign
            //       2.makes the code easier to maintain 
            #endregion

            #region Problem 4
            //Point p1 = new Point(5);
            //Point p2 = new Point(10, 20);
            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            #endregion

            #region Question 4
            //ques4: what is constructors in structs? 
            //Ans4 : parameterized constructors, default parameterless constructor 
            #endregion

            #region Problem 5
            //Point p1 = new Point(2, 5);
            //Point p2 = new Point(10, 20);
            //Point p3 = new Point(-3, 7);

            //Console.WriteLine(p1);
            //Console.WriteLine(p2);
            //Console.WriteLine(p3); 
            #endregion

            #region Question 5
            //ques5: How does overriding methods like ToString() improve code readability? 
            //Ans5 : the output become human-friendly. 
            #endregion

            #region Problem 6
            Point point = new Point(5, 5);
            Employee emp = new Employee("Mahmoud", 25);

            ModifyPoint(point);
            ModifyEmployee(emp);

            Console.WriteLine($"Point: {point.X}, {point.Y}");
            Console.WriteLine($"Employee: {emp.Name}, {emp.Age}");
            #endregion

            #region Question 6
            //ques6: How does memory allocation differ for structs and classes in C#? 
            //Ans6 : Struct: value type , stored in the stack, copy of the data when we pass it to a method, faster in allocation speed, no support of inheritance 
            //       Class:  ref type , stored in the heap, refrence to same object is passed when we pass it to method, slower in allocation speed , support of inheritance  
            #endregion

        }
    }
}
