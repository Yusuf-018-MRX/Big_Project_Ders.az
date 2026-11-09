using Helper;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Xml;

public class Info
{
    public static void Main(string[] args)
    {
        Console.WriteLine();
    }
    Register register = new Register();
    public void Information()
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Info");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(@$"
                Ders.az Programina xos gelmisiniz 
                Program 2 vezifeden istifade edilir 
                1. Teacher
                2. Student
                Hansi haqqinda melumat almaq isteyirsiniz ?
                Secim:  
                ");
            Console.ResetColor();
            string? choice = Console.ReadLine();
            register.Secim(choice);
            if (choice == "Teacher" || choice == "1")
            {
                Console.WriteLine("Teacher Information Loading.....");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@$"
                Teacher ilk once qeydiyat qismi ile tanis olur
                Eger evvelceden qeydiyatdan kecibdirse login sehifesinden 
                username ve password ile kecid edir .
                Eger qeydiyatdan kecmemisdirse qeydiyat sehifesine daxil olub
                Teleb olunan infolari daxil edir . Misal olaraq : Name , Email , Phone Number , Password ve s.
                Daxil olduqdan sonra ise Ana menuda secimler olur , Ferdi ders ler , Qrup dersleri ve Kurs ad altinda ders kecmek 
                Cedvel daxil edilir , heftenin gunleri secilir ve saatlar secilir .
                Hansi Fennlerden dersler kecildiyi de secilir
                Sonra ise artiq CV Admin e gonderilir ve tesdiq gozlenilir            
                Teacher CV ni tam doldurmaq mecburiyyetindedir , eks halda ders kecmek imkani olmayacaqdir . 
                Sonuna qeder oxuduqunuz ucun tesekkur edirik .
                Admin: Yusuf Baghirov Dos Santos . 
                ");
                Console.ResetColor();
                break;
            }
            else if (choice == "Student" || choice == "2")
            {
                Console.WriteLine("Student Information Loading.....");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@$"
                Student ilk once qeydiyat qismi ile tanis olur
                Eger evvelceden qeydiyatdan kecibdirse login sehifesinden 
                username ve password ile kecid edir .
                Eger qeydiyatdan kecmemisdirse qeydiyat sehifesine daxil olub
                Teleb olunan infolari daxil edir . Misal olaraq : Name , Email , Phone Number , Password ve s.
                Daxil olduqdan sonra ise Ana menuda Teacher ler olur eger ders cedveli , saati , region , fenn kimi 
                seyler uygun olsa onda Teacher ile elaqe qurula biler .
                Istediyi fennden ferdi ,qrup seklinde ve ya kurs sekilinde ders istirak etme imkani olur .
                ve s kimi bir cox secim ve ferqli funksiyanalliqlar var .
                Admin: Yusuf Baghirov Dos Santos . 
                ");
                Console.ResetColor();
                break;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Seciminizi duzgun daxil edin !!!");
                Console.ResetColor();
                continue;
            }

        }




    }

}