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
        // Timer Class
        // Interval -> milisaniye'yi ifade eder 5 saniye = 5000 milisaniye
        public mainform()
        {
            InitializeComponent();
        }
        int counter = 60;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("Timer Aktive");
            progressBar1.Value = counter;
            if(counter == 0)
            {
                timer1.Stop();
                MessageBox.Show("Timer was stopped");
            }
            else
            {
                counter--;
            }
            label1.Text = counter.ToString();
            if(counter % 2 == 0)
            {
                button1.BackColor = Color.White;
            }
            else
            {
                button1.BackColor = Color.Red;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            label1.Text = 60.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
