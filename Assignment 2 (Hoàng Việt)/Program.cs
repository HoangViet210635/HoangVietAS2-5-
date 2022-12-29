using System;
using System.Security.Cryptography.X509Certificates;

namespace Assignment_2__Hoàng_Việt_
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int option;
            LibrarySystem CommandExecute = new LibrarySystem();
            BorrowBook ExecuteBorrowBook = new BorrowBook();
            ReturnBook ExecuteReturnBook = new ReturnBook();
            CommandExecute.ListOfBook();
            do
            {
                option = Menu_Operator.EnterUserChoice();
                switch (option)
                {
                    case 1:
                        CommandExecute.DisplaySearchBook();
                        break;
                    case 2:                        
                        CommandExecute.DisplayLibrary();
                        break;
                    case 3:
                        CommandExecute.AddBook();
                        break;
                    case 4:
                        Console.Write("Enter Book's Name: ");
                        string temporaryDelete = Console.ReadLine();
                        if (temporaryDelete != null)
                        {
                            CommandExecute.RemoveBook(temporaryDelete);
                        }
                        else
                        {
                            Console.WriteLine("ERROR !!! Please enter again!");
                        }
                        break;
                    case 5:
                        ExecuteBorrowBook.InputAndOutputBorrow();
                        break;
                    case 6:
                        ExecuteReturnBook.InputAndOutputReturn();
                        break;
                    case 7:
                        Console.WriteLine("EXIT.");
                        break;
                    default:
                        Console.WriteLine("ERROR !!! JUST TYPE FROM 1 --> . TRY AGAIN");
                        break;
                }

            } while (option != 7);
        }   
    }
}
