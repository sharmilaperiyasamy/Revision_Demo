//creating additional one instance for multicast)
ArithmeticOperation arithOp;

//create delegate instances(single instance)
ArithmeticOperation add = new ArithmeticOperation(Delegates.DelegatesEx.Addition);
ArithmeticOperation mul = new ArithmeticOperation(Delegates.DelegatesEx.Multiplication);

//calling the methods using the delegate objects
add(10);
Console.WriteLine("Output of Addition : {0}", Delegates.DelegatesEx.getNum());
mul(5);
Console.WriteLine("Output of Multiplication : {0}", Delegates.DelegatesEx.getNum());
Console.ReadKey();


// for multicasting delegate comment the single cast methods calling
arithOp = add;
arithOp = arithOp + mul;
//calling multicast
arithOp(5);
Console.WriteLine("Output for Arithmetic Operation : {0}", Delegates.DelegatesEx.getNum());
Console.ReadKey();