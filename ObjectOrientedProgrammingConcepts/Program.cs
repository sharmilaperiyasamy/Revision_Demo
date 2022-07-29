
// 3)creating object instance of class is object
ObjectOrientedProgrammingConcepts.School msg = new ObjectOrientedProgrammingConcepts.School();
//accessing the school methods(public)
msg.display();
//msg.show();

//accessing the school methods(private)
//msg.Greeting();
//since it is private it can't be accessed here shows error
//msg.name();


ObjectOrientedProgrammingConcepts.rectangle rec = new ObjectOrientedProgrammingConcepts.rectangle();
string a = "Marks";
Console.Write("\nPolymorphism-overLoading (string datatype) : ");
Console.Write(rec.area(a));
int b = 10;
Console.Write("\nPolymorphism-overLoading (int datatype) : ");
Console.Write(rec.area(b));


ObjectOrientedProgrammingConcepts.Base stuBase = new ObjectOrientedProgrammingConcepts.Child();
Console.Write("\nPolymorphism-overriding : ");
Console.WriteLine(stuBase.StudentName());

ObjectOrientedProgrammingConcepts.addition obj = new ObjectOrientedProgrammingConcepts.addition(); //an object is created , constructor is called
Console.WriteLine("-----------default constructor---------------");
obj.display();
ObjectOrientedProgrammingConcepts.paraconstrctor v = new ObjectOrientedProgrammingConcepts.paraconstrctor(100, 175);   // Creating object of Parameterized Constructor and ing values
Console.WriteLine("-----------parameterized constructor---------------");
Console.WriteLine("\t");
Console.WriteLine("value of a = " + v.a);
Console.WriteLine("value of b = " + v.b);

ObjectOrientedProgrammingConcepts.Tenth stu1 = new ObjectOrientedProgrammingConcepts.Tenth("Anushiya", 23);
ObjectOrientedProgrammingConcepts.Tenth stu2 = new ObjectOrientedProgrammingConcepts.Tenth(stu1);
Console.WriteLine("-----------copy constructor---------------");// here is stu1 details is copied to stu2.
Console.WriteLine(stu2.Details);

Console.WriteLine("-----------static constructor---------------");
ObjectOrientedProgrammingConcepts.TenthB.Fees();

Console.WriteLine("-------Private constructor----------");
Console.WriteLine();
ObjectOrientedProgrammingConcepts.Counter.currentview = 500;
ObjectOrientedProgrammingConcepts.Counter.visitedCount();
Console.WriteLine("Now the view count is: {0}", ObjectOrientedProgrammingConcepts.Counter.currentview);
Console.ReadLine();