// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32.SafeHandles;

/*
class Program
{
 
   List<Contact> contacts = new List<Contact>();

    static void Main (string[]arg)
   {
    while (true)
    {
        Console.WriteLine("Contact List Menu:");
        Console.WriteLine("1.Add Contact:");
        Console.WriteLine("2.View Contact:");
        Console.WriteLine("3.serch contact by name:");
        Console.WriteLine("4.Exit:");
       Console.WriteLine("Enter your choice:"); 

      if (int.TryParse(Console.ReadLine(),out int choice))
      {
        
         switch (choice)
        {
          case 1:
              AddContact();
              break;
         case 2:
             ViewContact();
             break;
         case 3:
              SearchContactByName();
             break;          
         case 4:
              return;
              default:
        Console.WriteLine("Enter invalid choice");
                break;
        }
      }
      else
      {
        Console.WriteLine("Invalid input. please enter a valid number");

      }
    }  
     static void AddContact()
    {
      Console.WriteLine("Enter the name:");
      string name = Console.ReadLine()!;
      Console.WriteLine("Enter the phoneNumber");
      string phoneNumber = Console.ReadLine()!;
      Console.WriteLine("Enter the email  :"); 
      string email = Console.ReadLine()!;

      Contact newcontacts = new Contact
      {
         Name = name,
         PhoneNumber = phoneNumber,
         Email = email,
      };
     
      contacts.Add(new Contact());
       Console.WriteLine("Contact Added.");

    }
    
    static void ViewContact()
    {
      Console.WriteLine("List of Contact:");
      foreach (var contact in contacts)
      {
        Console.WriteLine($"Name {contact.Name}");
        Console.WriteLine($"PhoneNumber {contact.PhoneNumber}");
        Console.WriteLine($"Age {contact.Email}");
        Console.WriteLine();
      }
    }
    static void SearchContactByName()
    {
      Console.WriteLine("Enter the name to serch for :");
      string name = Console.ReadLine()!;

      var foundContacts = contacts.Where(contacts -> contact.Name == name ).TOLI;
      if (foundContacts.count > 0)
      {
        Console.WriteLine("found Contacts:");
        foreach (var contact in foundContacts)
        {
          Console.WriteLine($"Name: {contact.Name}");
          Console.WriteLine($"PhoneNumber: {contact.PhoneNumber}");
          Console.WriteLine($"Age {contact.Age}");
          Console.WriteLine();
        }         
      }
      else
      {
        Console.WriteLine("No contact found with that name");
      }
    }
     
}}      
*/


namespace symbolsOfCalculator
 {
   class Program
   {
    static void Main (string[] arg)
    {
      string a = string.Empty;
      do
      {
        Console.WriteLine("please input any four Number:");
        Console.WriteLine();
        Console.WriteLine("please input First Number:");
        int Num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("please input Second Number:");
        int Num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("please input Third Number:");
        int Num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("please input Fourth Number:");
        int Num4 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("please choose any symbols you want to use: ");
        Console.WriteLine("1. Add");
        Console.WriteLine("2.Minus");
        Console.WriteLine("3.Div");
        Console.WriteLine("4.Mut");
        Console.WriteLine("5.Mod");
        int Number = Convert.ToInt32(Console.ReadLine());
        switch (Number)
        {
          case 1:
               Console.WriteLine("Your Result Is: " + Add(Num1 , Num2 , Num3, Num4));
               break;
          case 2:
               Console.WriteLine("Your Result is: " + Minus(Num1 , Num2 , Num3 , Num4));
               break;
          case 3:
               Console.WriteLine("Your Result Is: " + Div(Num1 , Num2 , Num3 , Num4));
               break;
          case 4:
               Console.WriteLine("Your Result is: " + Mut(Num1 , Num2 , Num3, Num4));
               break;
          case 5:
               Console.WriteLine("Your Result is: " + Mod(Num1 , Num2 , Num3 , Num4));
               break;
               default:
               Console.WriteLine("Please Input Again");
                       break;       
        }
          Console.WriteLine("press yes if you to want input again:");
          a = Console.ReadLine()!;
      }
       while (a == "yes");
    }
      public static int Add(int Num1, int Num2 , int Num3 , int Num4)
      {
        return Num1 + Num2 + Num3 + Num4;
      }
      public static int Minus(int Num1, int Num2 , int Num3 , int Num4)
      {
        return Num1 - Num2 - Num3 - Num4;
      }
      public static int Div(int Num1, int Num2 , int Num3 , int Num4)
      {
        return Num1 / Num2 / Num3 / Num4;
      }
      public static int Mut(int Num1, int Num2 , int Num3 , int Num4)
      {
        return Num1 * Num2 * Num3 * Num4;
      }
      public static int Mod(int Num1, int Num2 , int Num3 , int Num4)
      {
        return Num1 % Num2 % Num3 % Num4;
      }
   }

 }

