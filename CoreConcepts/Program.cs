//method generics without generics concepts
int[] intArray = {1,2,3, 4, 5};
string[] strArray = { "Apple", "Banana", "Peach", "Cherry", "Mango" };
double[] douArray = { 1.1, 2.2, 3.3, 4.4, 5.5 };
Console.WriteLine("Output before using Generic concept: ");
CoreConcepts.Generics_coreconcepts.display(intArray);
CoreConcepts.Generics_coreconcepts.display(strArray);
CoreConcepts.Generics_coreconcepts.display(douArray);

//method generics with generics concepts
Console.WriteLine("Output after using Generic concept: ");
CoreConcepts.Implementgenericmethod.print<int>(intArray);
CoreConcepts.Implementgenericmethod.print<string>(strArray);
CoreConcepts.Implementgenericmethod.print<double>(douArray);


//Generics Concepts in Class
Console.WriteLine("Output while using Generic Concept in Class: ");
new CoreConcepts.GenericClass<int>(intArray).toPrint();
new CoreConcepts.GenericClass<double>(douArray).toPrint();
new CoreConcepts.GenericClass<string>(strArray).toPrint();