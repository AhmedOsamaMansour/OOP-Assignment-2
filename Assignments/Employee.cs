using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
enum Genders { 
    Male = 0, M = 0 , m = 0 , male = 0 ,
    Female = 1, F = 1 , f = 1 , female = 1
}
enum security_privileges
{
    guest, Developer, secretary , DBA , Full_Access = guest|Developer|secretary|DBA
}

namespace OOP_Assignment_2.Assignments
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public security_privileges SecurityLevel {  get; set; }
        public decimal Salary { get; set; }
        public HiringDate HireDate;
        public Genders Gender {  get; set; }
        public Employee(int id, string name, security_privileges sp , decimal salary,HiringDate hd,Genders g) {
            this.Id = id;
            this.Name = name;
            this.SecurityLevel = sp;
            this.Salary = salary;
            this.HireDate = hd;
            this.Gender = g;
        }
        public override string ToString()
        {
            return string.Format("Employee :\n Id = {0} \nName = {1} \nSecurity Level = {2} \nSalary = {3} \nHiring Date = {4} \nGender = {5}",Id,Name,SecurityLevel,Salary,HireDate,Gender);
        }

    }
}
