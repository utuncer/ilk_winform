using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ilk_winform
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public bool control { get; set; }

        public virtual string SetValues(int EmployeeID, string name, int salary)
        {
            ID = EmployeeID;
            Name = name;
            Salary = salary;
            string text = ID.ToString() + " " + Name +  " " + Salary.ToString();
            return text;
        }
    }
}
