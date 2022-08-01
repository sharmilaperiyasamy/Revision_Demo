using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
    public class RegularExp
    {
        const string firstname = @"^[A-Z]{1}[a-z]{2,}$";
        const string lastname = @"^[A-Z]{1}[a-z]{2,}$";
        const string pincode = @"^[0-9]{6}$";
        const string phonenumber = @"^91-[0-9]{10}$";
        const string Email1 = @"^www.[a-zA-Z0-9]{3,20}.(com|in|org|co\.in|net|dev)$";
        const string Email2 = @"^[a-zA-Z0-9\._-]{5,25}.@.[a-z]{2,12}.(com|org|co\.in|net)";
        const string image = @"(\w+)\.(jpg|png|jpeg|gif)$";
        //firstname validation
        public void firstnameValidation(string firstName)
        {
            if (Regex.IsMatch(firstName, firstname))
            {
                Console.WriteLine("First name is valid.");
                return;
            }
            Console.WriteLine("Enter a valid First name.");
        }
        //lastname validation
        public void lastnameValidation(string lastName)
        {
            if (Regex.IsMatch(lastName, lastname))
            {
                Console.WriteLine("Last name is valid.");
                return;
            }
            Console.WriteLine("Enter a valid Last name.");
        }
        //pincode validation
        public void pincodeValidation(string pinCode)
        {
            if (Regex.IsMatch(pinCode, pincode))
            {
                Console.WriteLine("Pincode is valid.");
                return;
            }
            Console.WriteLine("Enter a valid Pincode.");
        }
        //phonenumber validation
        public void phonenumberValidation(string phoneNumber)
        {
            if (Regex.IsMatch(phoneNumber, phonenumber))
            {
                Console.WriteLine("Phonenumber is valid.");
                return;
            }
            Console.WriteLine("Enter a valid Phonenumber.");
        }
        //email validation1
        public void emailValidation1(string email)
        {
            if(Regex.IsMatch(email, Email1))
            {
                Console.WriteLine("Email is Valid.");
                return;
            }
            Console.WriteLine("Enter a valid Email.");
        }
        //email validation2
        public void emailValidation2(string email)
        {
            if (Regex.IsMatch(email, Email2))
            {
                Console.WriteLine("Email is Valid.");
                return;
            }
            Console.WriteLine("Enter a valid Email.");
        }
        //image validation
        public void imageValidation(string Image)

        {
            if (Regex.IsMatch(Image, image))
            {
                Console.WriteLine("Imagename is Valid.");
                return;
            }
            Console.WriteLine("Enter a valid Imagename.");
        }
    }
}
