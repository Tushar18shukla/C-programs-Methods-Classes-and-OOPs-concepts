using System;

namespace CombinedProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. C# Methods
            // Exercise: Write a C# method named GreetUser that takes a user's name as a parameter and prints a greeting message.
            GreetUser("Tushar");

            // 2. C# Method Parameters
            // Exercise: Create a method named CalculateSum that accepts two integers as parameters and returns their sum.
            int sumResult = CalculateSum(10, 20);
            Console.WriteLine("The sum is: " + sumResult);

            // 3. C# Method Overloading
            // Exercise: Implement method overloading by creating two methods named Multiply.
            int productOfTwo = Multiply(5, 10);
            Console.WriteLine("The product of 5 and 10 is: " + productOfTwo);

            int productOfThree = Multiply(2, 3, 4);
            Console.WriteLine("The product of 2, 3, and 4 is: " + productOfThree);

            // 4. C# Classes
            // Exercise: Create a class named Car with properties Make, Model, and Year. Create an instance and call the Print method.
            Car myCar = new Car("Toyota", "Corolla", 2020);
            myCar.Print();
            Console.WriteLine();

            // 6. C# Classes/Objects
            // Exercise: Create a class named Book with properties Title, Author, and ISBN. Implement the IPrintable interface.
            // Add a private field _pageCount and a public property PageCount. Include a parameterless constructor.
            Book myBookDefault = new Book();
            myBookDefault.Print();
            Console.WriteLine();

            // 6. C# Classes/Objects (continued)
            // Exercise: Create an instance of Book, assign values, and call Print.
            Book myBook = new Book
            {
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                ISBN = "978-0-06-112008-4"
            };
            myBook.PageCount = 281;
            myBook.Print();
            Console.WriteLine();

            // 6. C# Classes/Objects (continued)
            // Exercise: Attempt to set a negative page count.
            myBook.PageCount = -10;  // Invalid page count
            Console.WriteLine();

            // 10. C# OOP (Object-Oriented Programming)
            // Exercise: Create a base class named Animal with a method Speak. Derive a class Dog from Animal and override Speak.
            Dog myDog = new Dog();
            myDog.Speak();
            Console.WriteLine();

            // 11. C# Access Modifiers
            // Exercise: Create a class named Employee with private, protected, and public fields.
            // Create properties or methods to access these fields from outside the class.
            Employee emp = new Employee
            {
                FirstName = "Tushar",
                LastName = "Shukla",
                Salary = 50000
            };
            emp.DisplayEmployeeDetails();
            Console.WriteLine();

            // 11. C# Access Modifiers (continued)
            // Exercise: Attempt to set a negative salary.
            emp.Salary = -10000;  // Invalid salary
            Console.WriteLine();

            // 12. C# Inheritance
            // Exercise: Create a base class Person with properties Name and Age. Derive a class Student and add a property StudentID.
            Person personReference = new Student
            {
                Name = "Tushar Shukla",
                Age = 24,
                StudentID = "S123456"
            };
            Console.WriteLine(personReference.GetDetails());
            Console.WriteLine();

            // 13. C# Polymorphism
            // Exercise: Use polymorphism by creating a method in the Person class named GetDetails.
            // Override it in the Student class to include the StudentID.
            Console.WriteLine(personReference.GetDetails());
            Console.WriteLine();

            // 14. C# Abstraction
            // Exercise: Create an abstract class Shape with an abstract method Area(). Derive Circle and Rectangle and implement Area.
            Shape myCircle = new Circle(5);
            Console.WriteLine($"Area of Circle: {myCircle.Area()}");

            Shape myRectangle = new Rectangle(4, 6);
            Console.WriteLine($"Area of Rectangle: {myRectangle.Area()}");
            Console.WriteLine();

            // 15. C# Interface
            // Exercise: Create an interface IPrintable with a method Print(). Implement this interface in Book and Car classes.
            // (Already implemented above in Book and Car classes)
            myBook.Print();
            myCar.Print();
            Console.WriteLine();

            // 16. C# Enums
            // Exercise: Define an enum DayOfWeek with values for each day of the week.
            // Write a method that takes DayOfWeek as a parameter and prints a message depending on the day.
            PrintDayMessage(DayOfWeek.Wednesday);
        }

        // 1. C# Methods
        static void GreetUser(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }

        // 2. C# Method Parameters
        static int CalculateSum(int num1, int num2)
        {
            return num1 + num2;
        }

        // 3. C# Method Overloading
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        // 3. C# Method Overloading (continued)
        static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        // 4. C# Classes
        class Car : IPrintable
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }

            public Car(string make, string model, int year)
            {
                Make = make;
                Model = model;
                Year = year;
            }

            public void Print()
            {
                Console.WriteLine($"Car Details: {Year} {Make} {Model}");
            }
        }

        // 6. C# Classes/Objects
        class Book : IPrintable
        {
            private int _pageCount;

            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }

            public int PageCount
            {
                get { return _pageCount; }
                set
                {
                    if (value >= 0)
                    {
                        _pageCount = value;
                    }
                    else
                    {
                        Console.WriteLine("Page count cannot be negative.");
                    }
                }
            }

            public Book()
            {
                Title = "Default Title";
                Author = "Default Author";
                ISBN = "000-0-00-000000-0";
            }

            public void Print()
            {
                Console.WriteLine($"Book Title: {Title}");
                Console.WriteLine($"Author: {Author}");
                Console.WriteLine($"ISBN: {ISBN}");
                Console.WriteLine($"Page Count: {PageCount}");
            }
        }

        // 10. C# OOP (Object-Oriented Programming)
        class Animal
        {
            public virtual void Speak()
            {
                Console.WriteLine("Animal sound");
            }
        }

        // 10. C# OOP (Object-Oriented Programming) (continued)
        class Dog : Animal
        {
            public override void Speak()
            {
                Console.WriteLine("Bark");
            }
        }

        // 11. C# Access Modifiers
        class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            private decimal _salary;

            public decimal Salary
            {
                get { return _salary; }
                set
                {
                    if (value >= 0)
                    {
                        _salary = value;
                    }
                    else
                    {
                        Console.WriteLine("Salary cannot be negative.");
                    }
                }
            }

            public string FullName
            {
                get { return $"{FirstName} {LastName}"; }
            }

            public void DisplayEmployeeDetails()
            {
                Console.WriteLine($"Employee Name: {FullName}");
                Console.WriteLine($"Employee Salary: {Salary}");
            }
        }

        // 12. C# Inheritance
        class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            // 13. C# Polymorphism
            public virtual string GetDetails()
            {
                return $"Name: {Name}, Age: {Age}";
            }
        }

        // 12. C# Inheritance (continued)
        class Student : Person
        {
            public string StudentID { get; set; }

            // 13. C# Polymorphism (continued)
            public override string GetDetails()
            {
                return $"Name: {Name}, Age: {Age}, Student ID: {StudentID}";
            }
        }

        // 14. C# Abstraction
        abstract class Shape
        {
            public abstract double Area();
        }

        // 14. C# Abstraction (continued)
        class Circle : Shape
        {
            public double Radius { get; set; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public override double Area()
            {
                return Math.PI * Radius * Radius;
            }
        }

        // 14. C# Abstraction (continued)
        class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public Rectangle(double width, double height)
            {
                Width = width;
                Height = height;
            }

            public override double Area()
            {
                return Width * Height;
            }
        }

        // 15. C# Interface
        interface IPrintable
        {
            void Print();
        }

        // 16. C# Enums
        enum DayOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        // 16. C# Enums (continued)
        static void PrintDayMessage(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Sunday:
                    Console.WriteLine("Relax, it's Sunday!");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Start of the work week!");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("Keep going, it's Tuesday.");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("Midweek already!");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Almost Friday!");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("It's Friday, the weekend is near.");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Enjoy your Saturday!");
                    break;
            }
        }
    }
}
