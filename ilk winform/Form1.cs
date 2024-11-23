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
        // Math Sınıfı
        // Math metotları -> https://prnt.sc/QBFF_LNcu6sF
        public mainform()
        {
            InitializeComponent();
        }
        //text box'ın boş olup olmadığını konrol etmek için
        bool control = false;
        //text boxtan gelen verileri tutmak için
        double firstNumber = 0, secondNumber = 0;
        private void mainform_Load(object sender, EventArgs e)
        {

        }
        void set1Parameter(string text)
        {
            if (text.Trim() != "")
            {
                control = true;
                firstNumber = Convert.ToDouble(text);
            }
            else
            {
                control = false;
            }
        }
        void set2Parameter(string text1, string text2)
        {
            if (text1.Trim() != "" && text2.Trim() != "")
            {
                control = true;
                firstNumber = Convert.ToDouble(text1);
                secondNumber = Convert.ToDouble(text2);
            }
            else
            {
                control = false;
            }
        }
        private void txtFirstNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Sadece rakam yazma kodu
            TextBox textBox = sender as TextBox;

            // Sayı kontrolü, kontrol tuşları, nokta ve eksi işareti
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != '.' &&
                e.KeyChar != '-')
            {
                //e.Handled özelliği, olayın işlenip işlenmediğini belirler:
                //true: Olay işlenmiş olarak kabul edilir ve varsayılan davranış engellenir.
                //false: Olay işlenmemiştir ve varsayılan davranış devam eder.
                e.Handled = true; // Geçersiz karakter engellendi
            }

            // Nokta birden fazla olamaz
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }

            // Eksi işareti sadece başta olabilir
            if (e.KeyChar == '-' && textBox.SelectionStart != 0)
            {
                e.Handled = true;
            }
            #endregion
        }

        private void txtSecondNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Sadece rakam yazma kodu
            TextBox textBox = sender as TextBox;

            // Sayı kontrolü, kontrol tuşları, nokta ve eksi işareti
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != '.' &&
                e.KeyChar != '-')
            {
                //e.Handled özelliği, olayın işlenip işlenmediğini belirler:
                //true: Olay işlenmiş olarak kabul edilir ve varsayılan davranış engellenir.
                //false: Olay işlenmemiştir ve varsayılan davranış devam eder.
                e.Handled = true; // Geçersiz karakter engellendi
            }

            // Nokta birden fazla olamaz
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
            }

            // Eksi işareti sadece başta olabilir
            if (e.KeyChar == '-' && textBox.SelectionStart != 0)
            {
                e.Handled = true;
            }
            #endregion
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            set2Parameter(txtFirstNumber.Text, txtSecondNumber.Text);
            if (!control)
            {
                MessageBox.Show("Please fill the Necessary Fields");
            }
            else
            {
                txtResult.Text = Math.Min(Convert.ToDecimal(firstNumber), Convert.ToDecimal(secondNumber)).ToString();
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            set2Parameter(txtFirstNumber.Text, txtSecondNumber.Text);
            if (!control)
            {
                MessageBox.Show("Please fill the Necessary Fields");
            }
            else
            {
                // Sayının Mutlak Değerini Alır
                txtResult.Text = Math.Max(Convert.ToDecimal(firstNumber), Convert.ToDecimal(secondNumber)).ToString();
            }
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            set1Parameter(txtFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show("Please fill the Necessary Fields");
            }
            else
            {
                txtResult.Text = Math.Abs(Convert.ToDecimal(firstNumber)).ToString();
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            set1Parameter(txtFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show("Please fill the Necessary Fields");
            }
            else
            {
                // Girilen sayısı pozitif ise 1, negatif ise -1 değerini döndürür
                txtResult.Text = Math.Sign(Convert.ToDecimal(firstNumber)).ToString();
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            set1Parameter(txtFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show("Please fill the Necessary Fields");
            }
            else
            {
                // Derece cinsinden girilen sayıyı radyant'a çeviricez
                double temp = (firstNumber * (Math.PI)) / 180;
                txtResult.Text = Math.Sin(temp).ToString();
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            set1Parameter(txtFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show("Please fill the Necessary Fields");
            }
            else
            {
                // Derece cinsinden girilen sayıyı radyant'a çeviricez
                double temp = (firstNumber * (Math.PI)) / 180;
                txtResult.Text = Math.Cos(temp).ToString();
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            set1Parameter(txtFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show("Please fill the Necessary Fields");
            }
            else
            {
                // Derece cinsinden girilen sayıyı radyant'a çeviricez
                double temp = (firstNumber * (Math.PI)) / 180;
                txtResult.Text = Math.Tan(temp).ToString();
            }
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            set2Parameter(txtFirstNumber.Text, txtSecondNumber.Text);
            if (!control)
            {
                MessageBox.Show("Please fill the Necessary Fields");
            }
            else
            {
                // firstNumber^secondNumber işlemi
                txtResult.Text = Math.Pow(firstNumber, secondNumber).ToString();
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            set1Parameter(txtFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show("Please fill the Necessary Fields");
            }
            else
            {
                // Girilen sayının karekökünü gösterir örneğin:
                // firstNumber 36 girilmişse sonuç 6 gösterilir.
                txtResult.Text = Math.Sqrt(firstNumber).ToString();
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            set2Parameter(txtFirstNumber.Text, txtSecondNumber.Text);
            if (!control)
            {
                MessageBox.Show("Please fill the Necessary Fields");
            }
            else
            {
                // secondNumber tabanında firstNumber
                // secondNumber = 10, firstNumber = 1000 cevap = 3
                txtResult.Text = Math.Log(firstNumber, secondNumber).ToString();
            }
        }

        private void btnLog1_Click(object sender, EventArgs e)
        {
            set1Parameter(txtFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show("Please fill the Necessary Fields");
            }
            else
            {
                // 10 tabanında firstNumber
                // firstNumber = 1000, sonuç 3 
                txtResult.Text = Math.Log10(firstNumber).ToString();
            }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            set1Parameter(txtFirstNumber.Text);
            if (!control)
            {
                MessageBox.Show("Please fill the Necessary Fields");
            }
            else
            {
                // e tabanında firstNumber
                txtResult.Text = Math.Exp(firstNumber).ToString();
            }
        }

        private void btnCopyFirst_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Trim() != "")
            {
                txtFirstNumber.Text = txtResult.Text;
                txtSecondNumber.Clear();
                txtResult.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            txtFirstNumber.Clear();
            txtSecondNumber.Clear();
            txtResult.Clear();
        }


    }
}
