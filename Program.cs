using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
     int minLength = 8;
     string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
     string lowerCase = "abcdefghijklmnopqrstuvwxyz";
     string digits = "0123456789";
     string specialChars = "!@#$%^&*()~-_`=+";

     Console.WriteLine ("Input a practice password");
     string password = Console.ReadLine();

     int score  = 0; // gives a score based on which of the above variables are met using the Tools.Contains method
     if (password.Length >= minLength){
       score++;
       }
       if (Tools.Contains(password, upperCase)){
         score++;
       }
       if (Tools.Contains(password, lowerCase)) {
         score++;
       }
       if (Tools.Contains(password, digits)) {
         score++;
       }
       if (Tools.Contains(password, specialChars)){
         score++;
       }
       switch (score)
       {
         case 5:  // checks the variable score for what it's worth after checking parameters and writes to the console a descritption of the password's strength. 
          Console.WriteLine("Your password is extremely strong");
          break;
         case 4:
           Console.WriteLine("Your password is very strong");
           break;
         case 3:
           Console.WriteLine("Your password is strong");
           break;
         case 2: 
           Console.WriteLine("Your assword is medium");
           break;
         case 1: 
           Console.WriteLine("Your password is weak");
           break;
         default: 
           Console.WriteLine("Password is very bad");
           break;
       }
       
    }
  }
}
