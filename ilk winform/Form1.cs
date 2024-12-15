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
        // 
        public mainform()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Virtual
            Employee employee = new Employee();
            textBox1.Text = employee.SetValues(1, "Charles", 2000);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Override
            Teacher employee = new Teacher();
            textBox1.Text = employee.SetValues(1, "Charles", 2000);
        }
    }
}
