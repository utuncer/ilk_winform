using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilk_winform
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }
        #region
        public partial class Employee
        {
            public int EmployeeID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
        }
        partial class Employee

        {
            public void SetValues()
            {
                Name = "Charles";
                EmployeeID = 1;
                Salary = 5000;
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.SetValues();
            textBox1.Text = emp.EmployeeID.ToString() + " " + emp.Name + " " + emp.Salary;
        }
        #endregion
    }
}