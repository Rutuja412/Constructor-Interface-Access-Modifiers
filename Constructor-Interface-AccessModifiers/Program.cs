using System;

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
        }
    }
}
