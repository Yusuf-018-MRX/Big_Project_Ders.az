using Helper;
using System.Security.AccessControl;
namespace Teacher_
{
    public class Teacher
    {
        public void Main(string[] args)
        {
            Console.WriteLine("Welcome Teacher ");
            Info info = new Info();
            info.Information();
            Login login = new Login();
            Register register = new Register();
            Console.Write(@$"
        Log in or Register 
        Choise: 
        ");
            string Chosie1 = Console.ReadLine() ?? "Register";
            if (Chosie1 == "Log in")
            {
                login.LogIn();
            }
            else if (Chosie1 == "Register" || Chosie1 == "register")
            {
                register.RegisterUser();
                //if ()
        }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Yanlis secim daxil etdiniz !!!");
                Console.ResetColor();
            }





        }
    }
}