using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace input_outbut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Beep(); //Beep ku waa Qoraalka iiga dhig socod macnaha mid Asigoo laqoraya ookale  
            Console.Write("Enter Username :");
            string name = Console.ReadLine();
            Console.Beep();
            Console.Write("Enter Your Pssword:");

            string Passwrd = Console.ReadLine();

            if (name == "Ali" && Passwrd == "1234")
            {

                Console.Write("Your're Admin WElcome Mr/Madam'");
                Console.Write("  " + name);
                Console.WriteLine(" ");
                Console.Beep();
                Console.WriteLine(" ");
            }
            else if (name == "Omar" && Passwrd == "5678")
            {
                Console.Beep();
                Console.WriteLine(" ");
                Console.Write("Hello You'r User Welcome Mr/Madam ':"+ name);
                Console.WriteLine(" ");
                Console.Beep();
                Console.WriteLine(" ");
            }
           else if
             (name == "Adnan" && Passwrd == "9012" )    
            {
                Console.WriteLine(" ");
              Console.WriteLine("You're User WElcome Mr/Madam :" +name);
               Console.Beep();
                
               Console.WriteLine(" ");
  }
            else
            {
  Console.Clear();
                Console.WriteLine("NOT FOUND ! Username : " + name);
                Console.Beep();
                Console.Write("");
                Console.WriteLine("NOT FOUND ! assword: " + Passwrd);
                Console.Beep();
                Console.WriteLine("  ");
             
               
               
            }


            Console.WriteLine("plz Choose 'Enter' To Create New Account Or ESC  To Exit");
            Console.ReadLine();
            Console.WriteLine(" ");
            Console.Beep();
            Console.Write("Enter Username :");
            string UsernameEnter= Console.ReadLine();
           
              Console.Write("Enter Again Username :");
              Console.Write(" ");
            string UserameAgain = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Beep();
            Console.Write("Enter Passwrd : ");
            string PasswrdEnter = Console.ReadLine();
            Console.Beep();
            Console.Write("Enter Password Again :");
            Console.Beep();
            string PasswrdAgain = Console.ReadLine();
            Console.Write(" ");
            if (UsernameEnter ==UserameAgain&&PasswrdEnter==PasswrdAgain)
            {
                Console.WriteLine("");
                Console.Beep();
               Console.Write("***Successefully You Created New Account****  " );
                Console.WriteLine("   ");
                Console.WriteLine("  ");
                Console.Beep();
                Console.WriteLine("Your Username is : "+UsernameEnter);
                Console.Beep();
                Console.WriteLine("Your Pssword is :" + PasswrdEnter);
                Console.Beep();
                Console.WriteLine("");
                
        }
                
            else if (UsernameEnter != UserameAgain && PasswrdEnter != PasswrdAgain)
            {
                Console.WriteLine(" ");
                Console.Beep();
                Console.WriteLine("Invalid ! Username and  Password");
                Console.WriteLine("");
                Console.Beep();
                Console.WriteLine("Good Bye");
                Console.Beep();
                Console.WriteLine("");
                                        
            
            }
                else if(UsernameEnter!=UserameAgain)
            {
                Console.WriteLine("");
                Console.Beep();
                Console.WriteLine("Invalid ! Your Username ");
                Console.Beep();
                    Console.WriteLine("");
                    Console.Beep();
                    Console.WriteLine("Good Bye");
                        Console.WriteLine("");
                   
                }
                
            else if(PasswrdEnter!=PasswrdAgain)
            {
                Console.WriteLine(" ");
                Console.Beep();
                Console.WriteLine("Invalid ! Your Password ");
                
                Console.WriteLine(" ");
                Console.Beep();
                Console.WriteLine("Good Bye");
                Console.WriteLine("");
            }
        
            else 
            {
                 Console.Beep();
                Console.WriteLine("NULL");
                Console.WriteLine(" ");

            }
        }
       
    }


    }

