using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_2.Inheritance
{
    internal class child:parent
    {
        public int z { get; set; }
        public child(int x,int y,int z):base(x,y)
        {
            
            this.z = z;
        }
    }
}
