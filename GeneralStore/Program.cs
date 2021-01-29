using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralStore
{
    class Program
    {
        static void Main(string[] args)
        {
            object Store;
            {
                //This is menu.
                Console.WriteLine("List of Items");
                Console.WriteLine("1 Add Item");
                Console.WriteLine("2 Check Price");
                Console.WriteLine("3 Print Info");
                Console.WriteLine("4 Purchase");
                Console.WriteLine("5 Exit");
                Console.Write("Select your option: ");

                //Performing operation based on selected option.
                switch (Console.ReadLine())
                {
                    case "1":
                        addItem();
                        break;

                    case "2":
                        checkPrice();
                        break;

                    case "3":
                        printInfo();
                        break;

                    case "4":
                        Purchase();
                        break;

                    case "5":
                        Console.WriteLine("Thank you. You exit the program successfully");
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Please select a valid option");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }

    abstract class Item
    {
        private
            string Type, Name;
            int Quantity;
            double Price;

        public
            void checkPrice(string name, int quantity);
            void printInfo(string name);
            void purchase(string name, int quantity);
            void addItem(string type, string name, int quantity, double price);
    }

    concrete class Vegetables
    {

    }

    concrete class Textbooks
    {

    }

    concrete class Fruits
    {

    }
}
