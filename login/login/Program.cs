/*Name =Sagar Devkota */
/* student id=30004439*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("**************Welcome******************");
            Console.WriteLine("The Holiday Park’s new login system ");

            string n, p, r;
            // display to user
            Console.WriteLine("Please enter username atleast 8 character:");
            // save input
            n = Console.ReadLine();
            // show output of our method:
                Console.WriteLine($"{usernameanswer(n)}");
            
           
            


                Console.WriteLine($"{n} Please enter atleast 8 character password:");
                p = Console.ReadLine();
            

                Console.WriteLine($" {password(p)}");
                
                

                Console.WriteLine($"{n} Please comfirm your password should be match");
                r = Console.ReadLine();
           

                Console.WriteLine($" {rpassword(r, p)}");
            
            


            Console.WriteLine("***********Thank you************");
            Console.WriteLine("******* you are Login*********");
            Console.WriteLine("*******press enter to continue*********");
            Console.ReadLine();
        }


        //method for username
        static public  string usernameanswer(string n)
        {
           // while loop to check length:
           while(n.Length <= 7)
            {
               

                Console.WriteLine("Please re-enter username should be  8 character :");
                n = Console.ReadLine();


            }
            return n;
           
        }
       // method for password length:
        static public string password(string p)
        {


            // while loop to check length:
            while (p.Length <= 7)
            {


                Console.WriteLine("sorry, Please try again be sure  it should be  8 character :");
              p   = Console.ReadLine();


            }
            return p;
        }
        //method to comfirm "is re-password same?"
        static public string rpassword(string r, string p)
        {
            
            if( r != p)
            {



                Console.WriteLine(" sorry,' Please try again', be sure that password should be match:");
               r  = Console.ReadLine();

               

            }
           

            return r;
           
        }










        
    }
    
}
