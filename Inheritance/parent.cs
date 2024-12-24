using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_2.Inheritance
{
    internal class parent
    {
        public int x;
        public int y;
        public parent(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override string ToString()
        {
            return $"x = {x}\ny = {y}\n";
        }
    }
}
