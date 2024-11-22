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
            string[] gunler = new string[]
                {"Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar"};
            dataGridView1.Rows.Clear();
            for (int i = 0; i < gunler.Length; i++)
            {
                string satirGunler = gunler[i];
                dataGridView1.Rows.Add(satirGunler);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[,] gunler = new string[,]
            {
                {"1","Pazartesi" },
                {"2","Salı" },
                {"3","Çarşamba" },
                {"4","Perşembe" },
                {"5","Cuma" },
                {"6","Cumartesi" },
                {"7","Pazar" }
            };
            dataGridView2.Rows.Clear();
            for (int i = 0; i < gunler.GetLength(0); i++)
            {
                string[] gunSayisi = new string[gunler.GetLength(1)];
                for (int j = 0; j < gunler.GetLength(1); j++)
                {
                    gunSayisi[j] = gunler[i,j];
                }
                dataGridView2.Rows.Add(gunSayisi);
            }
        }
    }
}
