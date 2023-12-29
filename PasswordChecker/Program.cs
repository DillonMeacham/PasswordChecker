using System;

namespace PasswordChecker
{

        // Define the Tools class first
    public static class Tools
    {
        public static bool Contains(string input, string characters)
        {
            foreach (char c in characters)
            {
                if (input.Contains(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
  class Program
  {
    public static void Main(string[] args)
    {
    // Defining standards
    int minLength = 8;
    string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    string lowercase = "abcdefghijklmnopqrstuvwxyz";
    string digits = "1234567890";
    string specialChars = "!@#$%^&*()-+";

    // Capturing input from user

    Console.Write("Enter a password: ");
    string password = Console.ReadLine();

    // Testing the password

    int score = 0;
    
    //If password meets min length, add 1 point to score
    
    if (password.Length >= minLength)
    {
    score++;
    }

    //If password contains uppercase, add 1 point to score
    
    if (Tools.Contains(password, uppercase)) {
      score++;
    }

    if (Tools.Contains(password, lowercase)) {
      score++;
    }

    if (Tools.Contains(password, digits)) {
      score++;
    }

    if (Tools.Contains(password, specialChars)) {
      score++;
    }

    // Prints out score
    Console.WriteLine($"Your password score is a {score} out of 5.");

    switch(score)
    {
      case 4:
      case 5:
      
      Console.WriteLine("Your password is extremely strong!");
      break;

      case 3:

      Console.WriteLine("Your password is strong!");
      break;

      case 2:

      Console.WriteLine("Your password is medium!");
      break;

      case 1:

      Console.WriteLine("Your password is weak.");
      break;

      default:
      Console.WriteLine("This password doesn't meet any of the standards..");
      break;  
    }


    
    }
  }
}
