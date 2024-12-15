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
        abstract class Vehicle
        {
            public abstract double GetFuel();
        }
        class Bus : Vehicle
        {
            public override double GetFuel()
            {
                return 3000;
            }
        }

        class Truck : Vehicle
        {
            public override double GetFuel()
            {
                return 5000;
            }
        }


        private void mainform_Load(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string textValue;
            Vehicle vh = new Bus();
            double temp = vh.GetFuel();
            textValue = temp.ToString() + Environment.NewLine;
            vh = new Truck();
            double temp2 = vh.GetFuel();
            textValue += temp2.ToString();
            textBox1.Text = textValue;
        }
    }
}