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

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < 10; i++)
            {
                int sayininKaresi = i * i;
                int sayininKupu = i * i * i;

                dataGridView1.Rows.Add(i.ToString(),sayininKaresi.ToString(),sayininKupu.ToString());
            }

        }
    }
}
