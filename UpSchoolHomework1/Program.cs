// See https://aka.ms/new-console-template for more information

using System;
namespace UpSchoolHomework1
//using UpSchoolHomework1;
{
     class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("************************************************");
            Console.WriteLine("WELCOME TO THE B E S T P A S S W O R D M A N A G E R");
            Console.WriteLine("************************************************\n");


            Console.WriteLine("Do you want to include numbers? (y/n)");
            bool includeNumbers = Console.ReadLine() == "y";


            Console.WriteLine("OK! How about lowercase characters? (y/n)");
            bool includeLowerCase = Console.ReadLine() == "y";
          

            Console.WriteLine("Very nice! How about uppercase characters? (y/n)");
            bool includeUpperCase = Console.ReadLine() == "y";
           

            Console.WriteLine("All right! We are almost done. Would you also want to add special characters?  (y/n)");
            bool includeSpecial = Console.ReadLine() == "y";
         

            Console.WriteLine("Great! Lastly. How long do you want to keep your password length?");
            int passwordLength = Convert.ToInt32(Console.ReadLine());

            var options = new Options();
            Password password = new Password(passwordLength);
            //string CreatePassword = Password.CreatePassword();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Your password: " + Password.CreatePassword(includeNumbers, includeLowerCase, includeUpperCase, includeSpecial, passwordLength, options));


        }


    }



}


 