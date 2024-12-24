using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_2.Association_Aggregation
{
    internal class Departement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee[] ? employees { get; set; }
        public Departement(string name) 
        { 
            this.Name = name;
        }
        public Departement(string name, Employee[] e) 
        {
            this.Name = name;
            this.employees = e;
        }
    }
}
