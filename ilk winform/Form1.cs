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

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues2();
            teacher.SetValues1();
            textBox1.Clear();
            textBox1.Text += teacher.ID + Environment.NewLine;
            textBox1.Text += teacher.Name + Environment.NewLine;
            textBox1.Text += teacher.Surname + Environment.NewLine;
            textBox1.Text += teacher.Position + Environment.NewLine;
            textBox1.Text += teacher.Salary + Environment.NewLine;
            textBox1.Text += teacher.Branch + Environment.NewLine;
        }
    }
}
