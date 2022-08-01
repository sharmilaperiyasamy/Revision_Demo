RegularExpressions.RegularExp reg = new RegularExpressions.RegularExp();
Console.WriteLine("Enter the firstname : ");
string firstName = Console.ReadLine();
reg.firstnameValidation(firstName);

Console.WriteLine("Enter the lastname : ");
string lastName = Console.ReadLine();
reg.lastnameValidation(lastName);

Console.WriteLine("Enter the pincode : ");
string pinCode = Console.ReadLine();
reg.pincodeValidation(pinCode);

Console.WriteLine("Enter the phoneNumber : ");
string phoneNumber = Console.ReadLine();
reg.phonenumberValidation(phoneNumber);

Console.WriteLine("Enter the Email Address : ");
string email = Console.ReadLine();
reg.emailValidation1(email);

Console.WriteLine("Enter the Email Address : ");
string email2 = Console.ReadLine();
reg.emailValidation2(email2);

Console.WriteLine("Enter the image name : ");
string image = Console.ReadLine();
reg.imageValidation(image);