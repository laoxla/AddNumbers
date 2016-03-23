using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AddNumbers
{
    public class Math
    {
        public static int AddNumbers(params  int[] numbers)
        {
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                result += numbers[i];
            }
            return result;
        }

        public static int DoSomething(int a, int b) {
            return a / b;
        }

        public static int DoSomething(int a, int b, int c)
        {
            return a + b + c;
        }

        public static int DoSomething(int a, int b, int c, int d) {
            return a * b * c * d;
        }       
    }

    // buiding a constructor in the Product class.................................
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public double UnitInStock { get; set; }
        public string Despriction { get; set; }
        public Product(string name, decimal price, double unitInStock, string description = null ) {
            this.Name = name;
            this.Price = price;
            this.UnitInStock = unitInStock;
            this.Despriction = description;
        }
    }


    // create static Method to cunt words in a sentence.......................
    public class Counter
    {
        public static int CountWords(string words)
        {
            return words.Split(' ').Length;

            }
       
    }


    // Complex class..................................
    public class Account
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public bool IsOpen { get; set; }
    }
    public class AccountSholder
    {
        public AccountSholder()
        {
            this.CheckingAccount = new Account();
            this.SavingAccount = new Account();
      }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Account CheckingAccount { get; set; }
        public Account SavingAccount { get; set; }

        // method to tranfer money between account..............
        public void Tranfer(decimal amount, Account AccFrom, Account AccTo )
        {
          
            AccFrom.Amount -= amount;
            AccTo.Amount += amount;
        
        }
   }


    // create abstract class .........................
    abstract class Employees
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ShowFullName()
        {
            return string.Format( "{0} {1}",   FirstName, LastName) ;
        }
    }
    class NewEmployees: Employees
    {

    }
    class FullTimeEmployee: Employees
    {
        public double YearsEmployed { get; set; }
    }
    class ContractEmployee: Employees
    {
        public double MonthsEmployed { get; set; }
    }



    public class Program
    {
        public static void Main(string[] args)
        {
//            Debug.Assert(Math.AddNumbers(3, 2) == 5);
//            Debug.Assert(Math.AddNumbers(0, 2) == 2);
//            Debug.Assert(Math.AddNumbers(3, 3, 3) == 9);

//            Debug.Assert(Math.DoSomething(6, 2) == 3);
//            Debug.Assert(Math.DoSomething(3, 3, 3) == 9);
//            Debug.Assert(Math.DoSomething(2, 2, 2, 2) == 16);

//            Console.WriteLine(Counter.CountWords("Hello World!"));
//            Console.ReadLine();



//// for complex class...............................................
//            var AccountSholder = new AccountSholder
//            {
//                //set name....
//                FirstName = "Alice",
//                LastName = "Harris",

//                //set checking account...
//                CheckingAccount = {
//                Id = 23458404,
//                Type = "Checking Account",
//                Amount = 100m,
//                IsOpen = true
//                },

//                //set saving account
//                SavingAccount = {
//                Id = 23458404,
//                Type = "Savings Account",
//                Amount = 0.00m,
//                IsOpen = false
//                }


//            };

            // for absract class...............................

            var employee = new FullTimeEmployee
            {
                FirstName = "Bill",
                LastName = "Gates",
                YearsEmployed = 5
            };
            Debug.Assert(employee.ShowFullName() == "Bill Gates");

            var employee1 = new ContractEmployee
            {
                FirstName = "Steve",
                LastName = "Jobs",
                MonthsEmployed = 2
            };
            Debug.Assert(employee1.ShowFullName() == "Steve Jobs");
            Console.WriteLine(employee1.ShowFullName());

            Console.ReadLine();

        }
    }
}
