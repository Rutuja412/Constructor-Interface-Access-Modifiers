using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor_Interface_AccessModifiers
{
    public class AccessModifiers
    {
        public string name = "Rutuja";//it can be accessed from anywhere.
        private string LastName = "Kadam";//it can only be accessed within the same class or Method
        protected string ID = "AB123";//access the protected member from a derived class.
        internal string CompanyName = "Infosys";//we are able to access it from the Same assemply means Namespace
        public void PrivateModiDemo()
        {
            Console.WriteLine("Last Name : " + LastName);
        }
    }
    public class Derived : AccessModifiers
    {
        public void Print()
        {
            Console.WriteLine("ID = " + ID);
        }
    }
}
