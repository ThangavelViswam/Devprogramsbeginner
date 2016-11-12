using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RactangleAreacalc
{

    class Rectangle
    {
        //member variable
        private int lenght, width;

        //Defining a function to add value
        public void Acceptdetails()
        {
            lenght = 23;
            width = 21;
        }

        public int area()
        {
            return lenght * width;
        }

        public void display()
        {
            Console.WriteLine("Lenght=" + lenght);
            Console.WriteLine("Width=" + width);
            Console.WriteLine("Area=" + area());
            Console.ReadKey();
        }
    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.Acceptdetails();
            r1.display();
            Rectangle r2 = new Rectangle();
            r2.display();
            Console.ReadKey();
        }
    }
}
