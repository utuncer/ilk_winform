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

        private void btn1_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.personelID = txtID.Text;
            personel.ad = txtAd.Text;
            personel.pozisyon = txtPozisyon.Text;
            personel.yas = txtYas.Text;
            Form2 form2 = new Form2();
            form2.personel = personel;
            form2.ShowDialog();
        }
    }
}
