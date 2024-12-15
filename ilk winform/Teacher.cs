using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilk_winform
{
    public class Teacher : Employee
    {
        public override string SetValues(int EmployeeID, string name, int salary)
        {
            ID = EmployeeID;
            Name = name;
            Salary = salary;
            control = true;
            string text = ID.ToString() + " " + Name + " " + Salary.ToString() + " " + control.ToString();
            return text;
        }
    }
}
