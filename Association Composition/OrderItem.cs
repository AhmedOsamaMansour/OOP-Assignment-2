using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_2.Association_Composition
{
    internal class OrderItem
    {
        public int Id { get; set; }
        public Product p;
        public decimal price {  get; set; }
        public int quantity { get; set; }
        public OrderItem(Product _P) 
        {
            this.p = _P;
        }
    }
}
