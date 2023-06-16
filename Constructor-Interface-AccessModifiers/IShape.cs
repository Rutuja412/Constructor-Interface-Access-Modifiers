using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor_Interface_AccessModifiers
{
    public interface IShape
    {
        void Draw();
    }
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Circle!!!");
        }
    }
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }
}
