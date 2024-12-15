using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilk_winform
{
    public class Teacher : Employee
    {
        public void SetValues(int EmployeeID)
        {
            ID = EmployeeID;
        }
        public void SetValues(int EmployeeID, string name)
        {
            ID = EmployeeID;
            Name = name;
        }
        public void SetValues(int EmployeeID, string name, int salary)
        {
            ID = EmployeeID;
            Name = name;
            Salary = salary;
        } 
        public void SetValues(int EmployeeID, string name, int salary, bool controll)
        {
            ID = EmployeeID;
            Name = name;
            Salary = salary;
            control = controll;
        }
    }
}
