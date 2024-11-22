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
        //değer döndürmeyen metod
        public void rdGizle()
        {
            if (groupBox1.Visible == true)
            {
                btnGizle.Text = "Butonları Gör";
                groupBox1.Visible = false;
            }
            else
            {
                btnGizle.Text = "Butonları Gizle";
                groupBox1.Visible = true;
            }
        }
        //değer döndüren metod
        public string yaziTasi()
        {
            string yazi = textBox1.Text;
            textBox1.Clear();
            return yazi;
        }
        //değer döndürmeyen metod
        public void yaziTemizle()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        //public kullanılmadığında varsayılan private'tir
        string labelaYaz()
        {
            string metin = textBox1.Text;
            return metin;
        }
        public void metniKopyala(string metin)
        {
            textBox1.Text = metin;
        }
        public int topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }
        private void btnGizle_Click(object sender, EventArgs e)
        {
            rdGizle();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            yaziTemizle();
        }

        private void btnYaziTasi_Click(object sender, EventArgs e)
        {
            textBox2.Text = yaziTasi();
        }

        private void btnLabelYaz_Click(object sender, EventArgs e)
        {
            label1.Text = labelaYaz();
        }

        private void btnMetniDegistir_Click(object sender, EventArgs e)
        {
            metniKopyala(textBox2.Text);
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            MessageBox.Show(topla(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString());
        }
    }
}
