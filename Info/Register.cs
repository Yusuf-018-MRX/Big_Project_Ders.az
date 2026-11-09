using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Teacher_;
using System.Threading.Tasks;
namespace Helper
{
    public class Register
    {
        string? s ;
        public void S(bool isRegister)
        {
            if (isRegister)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Register Succesfuly.....");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Register Failed !!!");
                Console.ResetColor();
            }
        }
        public void Secim(string choise )
        {
            s = choise ;
        }
        public void RegisterUser()
        {

            try
            {
                Console.WriteLine("Pleas Enter Yours Information.");
                Console.Write("Name: ");
                string? name = Console.ReadLine();
                Console.Write("Surname: ");
                string? surname = Console.ReadLine();
                if (s == "Teacher" || s == "1")// Teacher
                {
                    Console.Write("Subject: ");
                    string? subject = Console.ReadLine();
                    Console.Write("Your Experience 1.Annual 2.Monthly 3.None\nSecim: ");
                    string? secim = Console.ReadLine();
                    if (secim == "1")
                    {
                        secim = "Annual";
                    }
                    else if (secim == "2")
                    {
                        secim = "Monthly";
                    }
                    else if (secim == "3")
                    {
                        secim = "";
                        Console.Write("");
                    }
                    else
                    {
                        Console.WriteLine("Error: Yanlis secim !!!");
                    }
                    Console.Write($"Nece {secim} tecrubeniz var:  ");
                    string? experience = Console.ReadLine();
                }
                Console.Write("Gmail: ");
                string? gmail = Console.ReadLine();
                Console.Write("Password: ");
                string? password = Console.ReadLine();
                // bu datalari yoxlamaq ucun harasa gondermek lazimdir .
                Console.WriteLine("Phone Number: ");
                Console.Write("+994 0");
                string? Number = Console.ReadLine();
                Console.Write("Region: ");
                string? region = Console.ReadLine();
                bool isRegister = true;
                S (isRegister);
                Teacher teacher = new Teacher();



                // Butun bu datalar sql Db ye gonderilecek 
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error: {ex.Message}");
                Console.ResetColor();
               
            }
        }
    }
}
