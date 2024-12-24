using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_2.Polymerphism
{
    class TypeA
    {
        public int a { get; set; }
        public TypeA(int a)
        {
            this.a = a;
        }
        public void MyFum01()
        {
            Console.WriteLine("Iam Fun parent");
        }
        public virtual void MyFum02()
        {
            Console.WriteLine($"Iam Fun 2 \na= {a}");
        }
    }
}
