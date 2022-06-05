using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace XIAOMI_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            method item_list = new method();            
            string choice;
            Queue queue = new Queue();

            while (true)
            {
                Console.WriteLine("|--------------------------------------------------------------------|");
                Console.WriteLine();
                Console.WriteLine("|-----------------WELCOME TO XIOAMI SHOPPING CART SYSTEM-------------|");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|-------------------------------MAIN MENU----------------------------|");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|                      A- PRODUCT CATEGORY                           |");
                Console.WriteLine("|                      B- VIEW SHOPPING CART                         |");               
                Console.WriteLine("|                      C- UPDATE QUANTITY OF PRODUCT                 |");
                Console.WriteLine("|                      D- SEARCH PRODUCT                             |");
                Console.WriteLine("|                      E- REMOVE PRODUCT FROM SHOPPING CART          |");
                Console.WriteLine("|                      F- EXIT                                       |");
                Console.WriteLine("|                                                                    |");
                Console.WriteLine("|--------------------------------------------------------------------|");
                Console.Write("                        ENTER YOUR CHOICE: ");


                choice = Console.ReadLine();
                choice = choice.ToUpper();


                switch (choice)
                {

                    case "A":
                        Console.WriteLine();
                        item_list.getdata();
                        break;

                    case "D":
                        Console.WriteLine();
                        item_list.findData();
                        break;                   


                     case "B":
                          Console.WriteLine();
                          item_list.Sort();
                          break;

                      case "C":
                          Console.WriteLine();
                          item_list.update_data();
                          break;

            
                     case "E":
                          Console.WriteLine();
                          item_list.deleteData();
                          break;

                      case "F":
                          Environment.Exit(0);
                          break;

                      default:
                          Console.WriteLine();
                          Console.WriteLine("               INVALID CHOICE. PLEASE ENTER CORRECT CODE!!!");
                          Console.WriteLine("|--------------------------------------------------------------------|");
                          Console.WriteLine();
                          break;


                 }
            }
        }
    }
}
