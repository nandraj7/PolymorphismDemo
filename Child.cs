using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    internal class Child : Parent
    {
        //Methos Overloading
        public void Show(int num1)
        {
            Console.WriteLine("Child Class Show Method");
        }


        //Methos Overloading
        public override void Display()
        {
            Console.WriteLine("Child Class Display Method");
        }
        public override void PutData()
        {
            Console.WriteLine("Child Class PutData Method");
        }
    }
}
