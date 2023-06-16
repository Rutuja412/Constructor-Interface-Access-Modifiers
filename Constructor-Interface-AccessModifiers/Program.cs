using System;
using System.Drawing;

namespace Constructor_Interface_AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Constructor_Interface_Access Modifiers");
            Console.WriteLine("Constructor");
            Constructor constructor = new Constructor();//Prameterless
            Console.WriteLine("Default value of a : " + constructor.a);//defualt
            Constructor2 constructor2 = new Constructor2(102, "Rutuja");//Parameterized
            constructor2.Display();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Interface !!!");
            Rectangle rectangle1 = new Rectangle();
            rectangle1.Draw();
            Circle circle = new Circle();
            circle.Draw();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("Access Modifiers");
            AccessModifiers access = new AccessModifiers();
            Console.WriteLine("Name= " + access.name);//Public
             // Console.WriteLine(access.LastName);//Private
             
            Derived derive = new Derived();//protected
            derive.Print();
            Console.WriteLine("Company Name =" + access.CompanyName);
            access.PrivateModiDemo();

        }
    }
}
