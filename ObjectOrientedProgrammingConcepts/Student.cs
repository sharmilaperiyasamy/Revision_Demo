using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObjectOrientedProgrammingConcepts
{
    //1)Creating a Class
    //4)Encapsulation - Access Specifier Public is used
    public class SchoolName
    {

        //creating constructor - class name and the method name are same having no return type
        public SchoolName()
        {
            Console.WriteLine("Mahendra.");
        }


        //3)Method -object behaviour(Method Declaration)
        public void display()
        {
            Console.Write("Good Morning. ");
        }
    }


    //7)Inheritance - School is child class and SchoolName is base class
    public class School : SchoolName
    {

        private string name = "Anitha";

        //if constructor is used so no need to call the method separately in main
        public School()
        {
            Console.Write("Welcome to All Students!");
        }
        // 4)Encapsulation using private Access Specifier
        //Its private - so not accessible outside class
        private string Name()
        {
            return name;
        }

        //5)Abstraction
        //6)Information hiding
        //Name() is private but accessible and limited to this class only
        public string Greeting()
        {
            return Name();
        }
    }
    public class rectangle
    {
        //8)Polymorphism - many forms same method but different return type
        //1st: same method name, return type (object) but different parameter type (object)
        //Compiletime Polymorphism
        public string area(string a)
        {
            return (a);
        }
        //2nd: same method name, return type (int) but different parameter type (int)
        public int area(int a)
        {
            return (a);
        }
    }
    //Runtime Polymorphism
    public abstract class Base
    {
        public abstract string StudentName();//no body declaration since it is abstract
    }
    public class Child : Base
    {
        //same method name with same signature/parameters
        public override string StudentName()
        {
            //It's mandatory to implement abstract method in derived/child class
            return "Tomorrow is Holiday";
        }
    }
    //Constructor types
    class addition
    {
        int a, b;
        public addition()   //default contructor
        {
            a = 100;
            b = 175;
        }
        public void display()
        {
            Console.WriteLine("value of a = " + a);
            Console.WriteLine("value of b = " + b);
        }
    }
    class paraconstrctor
    {
        public int a, b;
        public paraconstrctor(int x, int y)  // decalaring Paremetrized Constructor with int x,y parameter
        {
            a = x;
            b = y;
        }
    }
    class Tenth
    {
        private string name;
        private int age;
        public Tenth(Tenth stuname)   // declaring Copy constructor.
        {
            name = stuname.name;
            age = stuname.age;
        }
        public Tenth(string name, int age)  // Instance constructor.
        {
            this.name = name;
            this.age = age;
        }
        public string Details     // Get details of employee
        {
            get
            {
                return "The age of " + name + " is " + age.ToString();
            }
        }
    }
    public class TenthB
    {
        static TenthB()
        { // Static constructor
            Console.WriteLine("The static constructor ");
        }

        public static void Fees()
        {
            Console.WriteLine();
            Console.WriteLine("The Fees Pay method");
        }
    }
    public class Counter
    {
        private Counter()   //private constrctor declaration
        {
        }
        public static int currentview;
        public static int visitedCount()
        {
            return ++currentview;
        }
    }
    public class Bike
    {
        public Bike()
        {
            //Constructor
        }
        ~Bike()
        {
            //Destructor
        }
    }
}

