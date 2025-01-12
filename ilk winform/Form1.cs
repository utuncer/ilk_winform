using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ilk_winform
{
    public partial class mainform : Form
    {
        /*
        Exception Handling (Hata Yakalama)
        Program Sonlanmadan Hatayı Yakalamak İçin Kullanırız
        Try/Cath/Finally/Throw
        Hataların Tanımlanması -> https://prnt.sc/0t4enAxuzWfM
        */
        public mainform()
        {
            InitializeComponent();
        }

        #region
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int firstNumber = Convert.ToInt32(textBox1.Text);
                int secondNumber = Convert.ToInt32(textBox2.Text);
                int result = firstNumber / secondNumber;
            }
            catch (DivideByZeroException ex)
            {
                throw new Exception("You cannot divide any number to zero"); // Visual studio içerisinde hata tanımlamaya yarar -> https://hizliresim.com/edcjdkm
                //MessageBox.Show(ex.ToString());
            }
            finally //Hata yakalansa da yakalanmasa da çalışır.
            {
                MessageBox.Show("Program Finished");
            }
        }
        #endregion


    }
}
