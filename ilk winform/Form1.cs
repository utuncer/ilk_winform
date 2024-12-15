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

        interface Computer
        {
            void GetDesktops();
            void GetLaptops();
        }
        class Dell : Computer, Dellinterface
        {
            public string Name { get; set; }
            public int Price { get; set; }

            public void GetDellLaptops()
            {
                Name = "Dell Laptop";
                Price = 1500;
            }

            public void GetDesktops()
            {
                Name = "Desktops";
                Price = 1000;
            }

            public void GetLaptops()
            {
                Name = "Laptop";
                Price = 800;
            }
        }
        interface Dellinterface
        {
            void GetDellLaptops();
        }
        private void mainform_Load(object sender, EventArgs e)
        {
            Dell dell = new Dell();
            dell.GetDesktops();
            textBox1.Text += dell.Name + " " + dell.Price + Environment.NewLine;
            dell.GetLaptops();
            textBox1.Text += dell.Name + " " + dell.Price + Environment.NewLine; 
            dell.GetDellLaptops();
            textBox1.Text += dell.Name + " " + dell.Price + Environment.NewLine;
        }
    }
}
