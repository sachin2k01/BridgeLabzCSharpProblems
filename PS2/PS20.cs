using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2
{
    public class PS20
    { 
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee{ Department="IT",Name="Sathish",Salary=24000},
                new Employee{ Department="Sales",Name="Anjan",Salary=44000},
                new Employee{ Department="IT",Name="Sachin",Salary=57000},
                new Employee{ Department="HR",Name="Bharath",Salary=22000},
                new Employee{ Department="Marketing",Name="Rakshank",Salary=21000},
                new Employee{ Department="IT",Name="Lakshmi",Salary=44500},
            };

            var salab=list.FindAll(x => x.Salary>=25000).ToList();
            Console.WriteLine("Employee who's salary are Greater than 25000");
            foreach(var x in salab) Console.WriteLine($"Employee Name: {x.Name}");
            Console.WriteLine();

            var sal=(from sa in list where sa.Salary<30000 select sa).ToList();
            Console.WriteLine("using linq select the employye salary lesser than 30000");
            foreach(var y in sal) Console.WriteLine(y.Name );
            Console.WriteLine();


        }
    }

    class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }

        public int Salary { get; set; }

       
    }
}
