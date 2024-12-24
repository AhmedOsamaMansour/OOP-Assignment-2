using OOP_Assignment_2.Inheritance;
using Common02;
using OOP_Assignment_2.Polymerphism;
using OOP_Assignment_2.Assignments;
namespace OOP_Assignment_2
{

    internal class Program
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static int Sum(int x , int y, int z)
        {
            return x + y + z;
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static double Sum(int x, double y)
        {
            return x + y;
        }
        public static double Sum(double x, int y)
        {
            return x + y;
        } 

        static void Main(string[] args)
        {
            #region Demo Session 6
            #region Indexer
            //PhoneBook obj = new PhoneBook(3);
            //obj.AddPerson(0, "Rana", 01060120817);
            //obj.AddPerson(1, "Ahmed", 01202262155);
            //obj.AddPerson(2, "Osama", 01546259488);
            //Console.WriteLine(obj.GetNumber("Rana"));
            //obj.SetNumber("Rana", 123);
            //Console.WriteLine(obj.GetNumber("Rana"));
            //obj["Rana"] = 234;
            //Console.WriteLine(obj["Rana"]);
            #endregion
            #region Class
            //car c1;
            //c1 = new car(0,"BMW",450);
            //Console.WriteLine(c1);
            #endregion
            #region Inheritance
            //child c = new child(5,4,7);
            //Console.WriteLine(c);
            #endregion
            #region Relationships Between Classes
            #region Inheritance / Association(Composition -Aggregation)
            /*
             * Inheritance is a relationship ex bmw is a car
             * Association has a relationship 
               (Composition = mandatory |||||||| Aggregation = optional) 
               ex room has a chair
             * 
             */
            #endregion
            #endregion
            #region continue Access Modifiers (private protected - protected - internal protected)
            /*
             * private protected -> private
             * protected -> private
             * internal protected -> internal
            */
            #endregion
            #region Class VS Struct

            #endregion
            #region Polymerphism (override - overload)
            #region override
            //TypeA obj = new TypeA(3);
            //obj.a = 1;
            //obj.MyFum01();
            //obj.MyFum02();

            //TypeB newObj = new TypeB(3,5);
            //newObj.a = 1;
            //newObj.B = 2;
            //newObj.MyFum01();
            //newObj.MyFum02();
            #endregion
            #region Overload
            //Console.WriteLine("Rana");
            //Console.WriteLine('R');
            //Console.WriteLine(5.5f);
            //Console.WriteLine(55);
            //Console.WriteLine(Sum(5, 5));
            //Console.WriteLine(Sum(5, 5.5));
            //Console.WriteLine(Sum(5.5, 5));
            //Console.WriteLine(Sum(5.5, 5.5));
            #endregion
            #endregion
            #endregion
            #region Assignment 6
            #region Question 1
            Employee [] EmpArr = new Employee[3];
            EmpArr[0] = new Employee(0,"Ahmed Osama",security_privileges.DBA,5000,new HiringDate(5,12,2024),Genders.Male);
            EmpArr[1] = new Employee(1,"Rana Hatem",security_privileges.guest,12000,new HiringDate(4,11,2023),Genders.Female);
            EmpArr[2] = new Employee(2,"Aya Osama",security_privileges.Full_Access,15000,new HiringDate(9,10,2022),Genders.female);
            foreach (Employee emp in EmpArr) {
                Console.WriteLine(emp);
            }


#endregion

#endregion
}
}
}
