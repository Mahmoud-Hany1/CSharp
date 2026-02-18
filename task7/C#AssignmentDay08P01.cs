using System.IO;
using System.Security.AccessControl;

namespace C_AssignmentDay08P01
{
    #region Part 01
    #region Problem 1
    //public interface IVehicle
    //{
    //    void StartEngine();
    //    void StopEngine();
    //}
    #endregion

    #region Problem 5
    //public interface IWalkable
    //{
    //    void Walk();
    //}

    #endregion

    #region Problem 6
    //public struct Account
    //{
    //    private int accountId;
    //    private string accountHolder;
    //    private double balance;

    //    public Account(int id, string holder, double initialBalance)
    //    {
    //        accountId = id;
    //        accountHolder = holder;
    //        balance = initialBalance;
    //    }

    //    public int AccountId
    //    {
    //        get { return accountId; }
    //        set { accountId = value; }
    //    }
    //    public string AccountHolder
    //    {
    //        get { return accountHolder; }
    //        set { accountHolder = value; }
    //    }
    //    public double Balance
    //    {
    //        get { return balance; }
    //        private set { balance = value; }
    //    }
    //    public void Deposit(double amount)
    //    {
    //        if (amount > 0)
    //            balance += amount;
    //    }
    //    public void Display()
    //    {
    //        Console.WriteLine($"ID: {accountId}, Holder: {accountHolder}, Balance: {balance}");
    //    }
    //}
    #endregion

    #region Problem 7
    //public interface ILogger
    //{
    //    void Log(string message)
    //    {
    //        Console.WriteLine($"Default Log: {message}");
    //    }
    //}
    #endregion 
    #endregion

    public interface IShapeSeries
    {
        int CurrentShapeArea { get; set; }
        void GetNextArea();
        void ResetSeries();
    }
//================================================
    public static void PrintTenShapes(IShapeSeries series)
    {
        series.ResetSeries();
        for (int i = 0; i < 10; i++)
        {
              series.GetNextArea();
              Console.WriteLine(series.CurrentShapeArea);
        }
    }


    public static void SelectionSort(int[] numbers)
    {
    int n = numbers.Length;
    for (int i = 0; i < n - 1; i++)
    {
        int minIndex = i;
        for (int j = i + 1; j < n; j++)
        {
            if (numbers[j] < numbers[minIndex])
                minIndex = j;
        }
        // Swap
        int temp = numbers[i];
        numbers[i] = numbers[minIndex];
        numbers[minIndex] = temp;
    }
    }
 




    class Program
    {
        static void Main()
        {
            #region Part 01
            #region Problem 1
            //IVehicle car = new Car();
            //IVehicle bike = new Bike();

            //car.StartEngine();
            //car.StopEngine();

            //bike.StartEngine();
            //bike.StopEngine(); 
            #endregion

            #region Question1
            //ques1: Why is it better to code against an interface rather than a concrete class? 
            //Ans1 : more flexible and extensible and maintainable and support SOLID principles like DIP and OCP  
            #endregion

            #region Problem 2
            //Shape rect = new Rectangle(2, 3);
            //Shape circ = new Circle(4);

            //rect.Display();
            //Console.WriteLine("Rectangle Arear is: " + rect.GetArea());

            //circ.Display();
            //Console.WriteLine("Circle Area is: " + circ.GetArea()); 
            #endregion

            #region Question 2
            //ques2: When should you prefer an abstract class over an interface?  
            //Ans2 : when many classes share common behaviour, when you want to add base functionality later 
            #endregion

            #region Problem 3
            //Product[] products =
            //    {
            //new Product(1, "Laptop", 15000),
            //new Product(2, "Mouse", 300),
            //new Product(3, "Keyboard", 700),
            //new Product(4, "PC", 5000)
            //};

            //Array.Sort(products);
            //Console.WriteLine("products sorted by Price");
            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Question 3
            //ques3: How does implementing IComparable improve flexibility in sorting?  
            //Ans3 : it enables default sorting behaviour(Array.Sort())

            #endregion

            #region Problem 4
            //Student original = new Student(1, "Mody", new Address("Cairo"));

            ////shallow Copy
            //Student shallowCopy = original;

            ////deep Copy (Using Copy Ctr)
            //Student deepCopy = new Student(original);

            //// Modify original reference type
            //original.Address.City = "Alexandria";

            //Console.WriteLine("Original:");
            //original.Display();

            //Console.WriteLine("\nShallow Copy:");
            //shallowCopy.Display();

            //Console.WriteLine("\nDeep Copy:");
            //deepCopy.Display(); 
            #endregion

            #region Question 4
            //ques4: What is the primary purpose of a copy constructor in C#?
            //Ans4 : to crate new obj with the same values as an existing obj{deep copy}

            #endregion

            #region Problem 5
            //Robot robot = new Robot();
            ////Calls Robot's method
            //robot.Walk();

            ////Calls Interface implementation
            //IWalkable walkableRobot = robot;
            //walkableRobot.Walk(); 
            #endregion

            #region Question 5
            //ques5: How Does Explicit Interface Implementation Help in Resolving Naming Conflicts?
            //Ans5 : .Explicit methods can't be accessed using class object directly.
            //        it is Only accessible via interface reference. 
            #endregion

            #region Problem 6
            //Account acc = new Account(1, "mody", 1000);
            //acc.Display();

            //acc.Deposit(500);

            //Console.WriteLine("After Deposit:");
            //acc.Display(); 
            #endregion

            #region Question 6
            //ques6: What is the key difference between encapsulation in structs and classes?
            //Ans6 : Encapsulation works the same in both structs and classes in terms of access modifiers and data hiding.
            //The key difference is that classes are reference types(shared object), while structs are value types(copied object),
            //which affects how encapsulated data behaves when assigned or passed to methods.
            #endregion

            #region Question 7
            //ques7:
            //ans7 :ABSTRACTION: Hiding complex implementation details and showing only what is necessary.
            //                   focus on what the object does not how it does it
            //    ENCAPSULATION: Hiding internal data and restricting direct access to it
            // its relationship: Encapsulation helps achieve abstraction. 
            #endregion

            #region Problem 7
            //ILogger logger = new ConsoleLogger();

            //logger.Log("Hello World!"); 
            #endregion

            #region Question 8
            //ques8: Question: How do default interface implementations affect backward compatibility in C#? 
            //ans8 : 1.Prevents Breaking Changes(you can extend interfaces without forcing all existing imps to change) 
            #endregion

            #region Problem 8
            ////default constructor
            //Book book1 = new Book();
            //book1.Display();

            ////constructor with Title only
            //Book book2 = new Book("1984");
            //book2.Display();

            ////constructor with Title and Author
            //Book book3 = new Book("C# The ultimate Guide", "Mahmoud Hany");
            //book3.Display(); 
            #endregion

            #region Question 9
            //ques9: How does constructor overloading improve class usability? 
            //ans9 : 1.Provides Flexible Object Initialization 
            //       2.Improves Readability 
            #endregion


            #endregion

            //part02

            Shape[] shapes = new Shape[]
            {
                 new Shape("Square", 25),
                 new Shape("Circle", 78.5),
                 new Shape("Rectangle", 50),
                 new Shape("Circle", 28.3),
                 new Shape("Square", 16)
            };

            Array.Sort(shapes);

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }

            GeometricShape tri = new Triangle(4, 5);
            GeometricShape rect = new Rectangle(6, 7);

            Console.WriteLine($"Triangle Area: {tri.CalculateArea()}");
            Console.WriteLine($"Rectangle Area: {rect.CalculateArea()}, Perimeter: {rect.Perimeter}");

            int[] areas = { 25, 78, 50, 16, 28 };
            SelectionSort(areas);

            Console.WriteLine("Sorted Areas:");
            foreach (var area in areas)
                Console.WriteLine(area);

            GeometricShape shape1 = ShapeFactory.CreateShape("rectangle", 5, 6);
            GeometricShape shape2 = ShapeFactory.CreateShape("triangle", 4, 5);

            Console.WriteLine($"Rectangle Area: {shape1.CalculateArea()}, Perimeter: {shape1.Perimeter}");
            Console.WriteLine($"Triangle Area: {shape2.CalculateArea()}");


        }
    }
}
