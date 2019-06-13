/* name=Sagar Devkota */
/* student id =30004439*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll
{
    class Program
    {
        static void Main(string[] args)
        
            // display something and get input from user
            {
                //welcome message
                Console.WriteLine("*******************************************************");
                Console.WriteLine("Welcome");
                Console.WriteLine("*******************************************************");
                Console.Write("Please enter your name: ");//printing name
                string name = Console.ReadLine();

                Console.Write($"{name} Please enter your Gross annual income: ");
                double gross = double.Parse(Console.ReadLine());

                Console.Write($" {name} Please enter tax rate: ");
                double tax = double.Parse(Console.ReadLine());

                Employee p1 = new Employee(name, gross, tax);
                // display our result:

                Console.WriteLine($"Name: {p1.Name}\nGross Salary: {p1.Gross}\nTax: {p1.Tax}%\nNet Salary: {p1.Net()}");
                Console.WriteLine("*******************************************************");
                Console.WriteLine("*************press enter to continue****************");
                Console.WriteLine("*******************************************************");


                Console.ReadLine();
            }

            // class for employee
            class Employee
        { 
            // getter setter
            public string Name { get; set; }
            public double Gross { get; set; }
            public double Tax { get; set; }
            //method for the same name:
            public Employee(string _name, double _gross, double _tax)
            {
                Name = _name;
                Gross = _gross;
                Tax = _tax;
            }

            public double Net()
            {
                // method for calculate to anual gross
                return Gross * (1 - Tax / 100);
            }
        }
    }
}

        
    

