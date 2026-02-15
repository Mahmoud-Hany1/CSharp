namespace C_AssignmentDay07
{
    #region Problem 6&7
    interface IShape
    {
        double Area { get; }   
        void Draw();

        void PrintDetails()
        {
            Console.WriteLine($"Shape Area: {Area}");
        }
    }
    #endregion

    #region Problem 8
    interface IMovable
    {
        void Move();
    }
    #endregion

    #region Problem 9
    interface IReadable
    {
        void Read();
    }

    interface IWritable
    {
        void Write();
    } 
    #endregion






    class Program
    {
        static void Main()
        {
            #region Problem 1
            //Car c1 = new Car();
            //c1.Display();

            //Car c2 = new Car(1);
            //c2.Display();

            //Car c3 = new Car(2, "Mercedes");
            //c3.Display();

            //Car c4 = new Car(3, "Golf", 1000000);
            //c4.Display(); 
            #endregion

            #region Question 1
            //Ques1: Why does defining a custom constructor suppress the default constructor in C#? 
            //Ans1 : Once you define any custom constructor, the compiler assumes you are have the full control of object initialization.
            //       No constructor defined: Compiler creates default constructor.
            //       At least one constructor defined: Compiler doesn't create default constructor.
            //       If you still need it: You must define it manually. 
            #endregion

            #region Problem 2
            //Calculator calc = new Calculator();

            //int result1 = calc.Sum(3, 3);
            //Console.WriteLine("Sum of 2 int: " + result1);

            //int result2 = calc.Sum(10, 20, 30);
            //Console.WriteLine("Sum of 2 int: " + result2);

            //double result3 = calc.Sum(20.3, 30.3);
            //Console.WriteLine("Sum of 2 int: " + result3); 
            #endregion

            #region Question 2
            //Ques2: How does method overloading improve code readability and reusability? 
            //Ans2 : Readability: instead of using different method names , we use the same method name, and the method name represents the action and parameters represent the variation
            //       Reusability: we reuse the same method name for similar ops 
            #endregion

            #region Problem3
            Child obj = new Child(10, 20, 30);
            obj.Display();
            #endregion

            #region Question 3
            //Ques3:What is the purpose of constructor chaining in inheritance?
            //Ans3 : to ensure that the base class ctr executes first and to avoid code duplication 
            #endregion

            #region Problem 4
            Console.WriteLine("=== Using new ===");

            Parent obj1 = new Child(2, 3, 4);
            Console.WriteLine("Parent reference: " + obj1.Product());

            Child obj2 = new Child(2, 3, 4);
            Console.WriteLine("Child reference: " + obj2.Product());


            Console.WriteLine("\n=== Using override ===");

            Parent obj3 = new ChildOverride(2, 3, 4);
            Console.WriteLine("Parent reference: " + obj3.Product());


            ChildOverride obj4 = new ChildOverride(2, 3, 4);
            Console.WriteLine("Child reference: " + obj4.Product());
            #endregion

            #region Question 4
            //Ques4: How does new differ from override in method overriding?
            //Ans4 : new -> for method hiding, hide the base class method and decision is made at compile time, depends on ref type not obj type
            //      override -> True overriding, base method shoud be virtual, depends on the actual obj not ref obj 
            #endregion

            #region Problem 5
            Parent p = new Parent(10, 20);
            Parent c = new Child(10, 20, 30);
            Child realChild = new Child(1, 2, 3);

            Console.WriteLine(p);
            Console.WriteLine(c);
            Console.WriteLine(realChild);
            #endregion

            #region Question 5
            //Ques5: Why is ToString() often overridden in custom classes? 
            //Ans5 : cause the ToString() returns the full class name whic is not useful 
            //       so, we override it to provide meaningful output and this improves debugging process 
            #endregion

            #region Problem 6
            IShape shape = new Rectangle(5, 10);
            shape.Draw();
            Console.WriteLine("Area: " + shape.Area);
            #endregion

            #region Question 6
            //Ques6:Why can't you create an instance of an interface directly?
            //Ans6 : because the interface has no implementation it just has what must exist(NO logic) 
            #endregion

            #region Problem 7
            IShape circle = new Circle(7);

            circle.Draw();
            circle.PrintDetails();
            #endregion

            #region Question 7
            //ques7: What are the benefits of default implementations in interfaces introduced in C# 8.0?
            //Ans7 : before we can't add a new method to an interface cause it will broke all classes implement it
            //       now, we can add method with default body and the existing implementations don't break

            #endregion

            #region Problem 8
            IMovable movable = new CarMoveable();
            movable.Move();
            #endregion

            #region Question 8
            //Ques8:Why is it useful to use an interface reference to access implementing class methods?
            //Ans8 : to support Abstraction and polymorphism properties 
            #endregion

            #region Problem 9
            File file = new File();

            file.Read();
            file.Write();

            //ussing interface references
            IReadable readable = file;
            readable.Read();

            IWritable writable = file;
            writable.Write();
            #endregion

            #region Question 9
            //Ques9:How does C# overcome the limitation of single inheritance with interfaces?
            //Ans9 : C# allows multiple interface implementation and the interfaces provide multiple behaviour contracts

            #endregion

            #region Problem 10
            Shape rect = new RectangleShape(5, 4);
            rect.Draw();
            Console.WriteLine("Area = " + rect.CalculateArea());
            #endregion

            #region Question 10
            //Ques10:What is the difference between a virtual method and an abstract method in C#?
            //Ans10 :Virtual -> has default implementation in base class
            //                  can be overriden optionally in derived class
            //                   the base class not should be abstract
            //       Abstract -> has no implementation in base class
            //                   must be implemented in derived class
            //                   only exist in abstract class 
            #endregion



        }
    }
}
