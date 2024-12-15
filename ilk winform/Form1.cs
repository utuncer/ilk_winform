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

        private void btnShow_Click(object sender, EventArgs e)
        {
            Teacher tt = new Teacher();
            tt.SetValues(1);
            textBox1.Text = tt.ID.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 2 Parametre
            Teacher tt = new Teacher();
            tt.SetValues(1, "Charles");
            textBox1.Text = tt.ID.ToString() + " " + tt.Name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 3 Parametre
            Teacher tt = new Teacher();
            tt.SetValues(1, "Charles",1000);
            textBox1.Text = tt.ID.ToString() + " " + tt.Name + " " + tt.Salary.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // 4 Parametre
            Teacher tt = new Teacher();
            tt.SetValues(1, "Charles",1000, true);
            textBox1.Text = tt.ID.ToString() + " " + tt.Name + " " + tt.Salary.ToString() + " " + tt.control.ToString();

        }
    }
}
