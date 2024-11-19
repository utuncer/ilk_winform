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
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            // MessageBox.Show("Form Yüklendi");
        }

        private void mainform_Click(object sender, EventArgs e)
        {
            #region Basit Etkileşimli Mesaj Kutusu
            //string message = "Bilinmeyen bir hata oluştu.";
            //DialogResult result = MessageBox.Show(message, "Hata !!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            //if (result == DialogResult.Yes)
            //{
            //    MessageBox.Show("evete basıldı");
            //}
            //if (result == DialogResult.No)
            //{
            //    MessageBox.Show("hayıra basıldı");

            //} 
            #endregion

        }

        private void firstbutton_Click(object sender, EventArgs e)
        {
            #region Butona Tıkladığında Yazıyı (Label'ı) Düzenleyen Komut
            //firstlabel.Text = "deneme";
            //firstlabel.BackColor = Color.IndianRed;
            //firstlabel.ForeColor = Color.White;
            #endregion

            #region Textbox'a Yazılan Metni Label'a Yansıtan Kod
            //firstlabel.Text = textBox1.Text; 
            #endregion


        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Butonun Seçilip Seçilmediğini Kontrol Etme
            //if (radioButton1.Checked == true)
            //{
            //    MessageBox.Show("Radio butonu seçilmiş");
            //}
            //else
            //{
            //    MessageBox.Show("Radio butonu seçilmemiş");
            //} 
            #endregion


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            #region Butonun Değeri Değiştirildiğinde çıkacak Mesaj
            //MessageBox.Show("Radio butonu değiştirildi"); 
            #endregion
        }
    }
}
