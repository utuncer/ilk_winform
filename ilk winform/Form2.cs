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
        public Personel personel = new Personel();
        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = personel.personelID.ToString();
            label2.Text = personel.ad.ToString();
            label3.Text = personel.yas.ToString();
            label4.Text = personel.pozisyon.ToString();
        }
    }
}
