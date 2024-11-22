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
        List<int> numberList = new List<int>();
        List<string> textList = new List<string>();
        List<Employee> list = new List<Employee>();
        List<Days> daylist = new List<Days>();
        private void mainform_Load(object sender, EventArgs e)
        {
            Employee employee1 = new Employee();
            employee1.Name = "Name1";
            employee1.Surname = "Surname";
            employee1.EmployeeId = 1;

            Employee employee2 = new Employee();
            employee2.Name = "Name2";
            employee2.Surname = "Surname2";
            employee2.EmployeeId = 2;

            Employee employee3 = new Employee();
            employee3.Name = "Name3";
            employee3.Surname = "Surname3";
            employee3.EmployeeId = 3;

            list.Add(employee1);
            list.Add(employee2);
            list.Add(employee3);



            Days day1 = new Days();
            day1.Id = 1;
            day1.textValue = "Monday";

            Days day2 = new Days();
            day2.Id = 2;
            day2.textValue = "Tuesday";

            Days day3 = new Days();
            day3.Id = 3;
            day3.textValue = "Wednasday";

            Days day4 = new Days();
            day4.Id = 4;
            day4.textValue = "Thursday";

            Days day5 = new Days();
            day5.Id = 5;
            day5.textValue = "Friday";

            Days day6 = new Days();
            day6.Id = 6;
            day6.textValue = "Saturday";

            Days day7 = new Days();
            day7.Id = 7;
            day7.textValue = "Sunday";

            daylist.Add(day1);
            daylist.Add(day2);
            daylist.Add(day3);
            daylist.Add(day4);
            daylist.Add(day5);
            daylist.Add(day6);
            daylist.Add(day7);

            //comboBox'a kaynak olarak listeyi gösteriyoruz
            cmbDays.DataSource = daylist;
            cmbDays.DisplayMember = "textValue";
            cmbDays.ValueMember = "ID";
            dataGridView1.DataSource = daylist;
        }
        void fillList()
        {
            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(3);
        }
        private void btnFillList_Click(object sender, EventArgs e)
        {
            #region numberList'in verilerini textbox'ta görüntüleyen kod
            //numberList.Clear();
            //fillList();
            //foreach (var item in numberList)
            //{
            //    txtList.Text += item.ToString() + Environment.NewLine;
            //} 
            #endregion
            #region Sınıftan oluşturulan objelerin verilerini textbox'ta görüntüleyen kod
            //foreach (var item in list)
            //{
            //    txtList.Text += item.EmployeeId + " " + item.Name + " " + item.Surname + Environment.NewLine; 
            //} 
            #endregion

        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  MessageBox.Show(cmbDays.SelectedValue.ToString());
        }
    }
}
