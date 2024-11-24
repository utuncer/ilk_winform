using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilk_winform
{
    public class Employee : Human
    {
        public int Position { get; set; }
        public int Salary { get; set; }
        public void SetValues1()
        {
            ID = 1;
            Name = "TestName";
            Surname = "TestSurname";
        }
    }
}
