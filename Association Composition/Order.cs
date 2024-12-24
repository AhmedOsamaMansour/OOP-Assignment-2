using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_2.Association_Composition
{
    internal class order
    {
        public int Id { get; set; }
        public string BuyerEmail { get; set; }
        public decimal SubTotal { get; set; }
        public OrderItem[] Items { get; set; }
        public order(string _BuyerEmail,OrderItem [] _Items)
        {
            this.BuyerEmail = _BuyerEmail;
            this.Items = _Items;
        }
    }
}
