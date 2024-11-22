using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ilk_winform
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
      //  public Employee personelDetail = new Employee();
        public Employee personelDetail = new Employee();


        private void Form2_Load(object sender, EventArgs e)
        {
            txtAge2.Text = personelDetail.Age.ToString();
            txtId2.Text = personelDetail.EmployeeID.ToString();
            txtName2.Text = personelDetail.Name;
        }
    }
}
