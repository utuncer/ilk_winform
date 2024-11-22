using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
        Employee personelDetail = new Employee();

        private void btnSet_Click(object sender, EventArgs e)
        {
            personelDetail.Name = txtName.Text;
            personelDetail.Age = Convert.ToInt32(txtAge.Text);
            personelDetail.EmployeeID = Convert.ToInt32(txtId.Text);
            MessageBox.Show("All Data Received");
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            txtAge.Clear();
            txtId.Clear();
            txtName.Clear();
            MessageBox.Show(personelDetail.EmployeeID + " " + personelDetail.Name + " " + personelDetail.Age);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            personelDetail.Name = txtName.Text;
            personelDetail.Age = Convert.ToInt32(txtAge.Text);
            personelDetail.EmployeeID = Convert.ToInt32(txtId.Text);
            Form2 form2 = new Form2();
            form2.personelDetail = personelDetail;
            form2.ShowDialog();
        }
    }
}
