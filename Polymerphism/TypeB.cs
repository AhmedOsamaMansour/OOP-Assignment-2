using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_2.Polymerphism
{
    internal class TypeB:TypeA
    {
        public int B {  get; set; }
        public TypeB(int a , int b):base(a)
        {
            this.B = b;
        }
        public new void MyFum01()
        {
            Console.WriteLine("Child");
        }
        public override void MyFum02()
        {
            Console.WriteLine($"A = {a}\nb = {B}");
        }

    }
}
