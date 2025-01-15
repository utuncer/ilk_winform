using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        System I/O
        Dosya oluşturma, silme, yazma, kapatma gibi işlemleri yapmamızı sağlayan bir namespace dir
        bu işlemler için kullanılan somut olmayan sınıflar -> https://prnt.sc/j53gN4mBL4GN
        Directory ve Directory Sınıfları -> https://prnt.sc/_g8lCQ327koD / https://hizliresim.com/smxh08e / https://prnt.sc/Z_zGq4MW8Zhi
        */
        public mainform()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //  Directory.CreateDirectory("temp"); //bin\Debug kısmına temp adında klasör oluşturacak
            //DirectoryInfo dir = new DirectoryInfo("temp");
            //dir.Create(); 
            //
            //dir.LastAccessTime.ToString();// -> dosyaya son erişim zamanı, CreationTime -> oluşturma zamanı

            if (Directory.Exists("temp"))//bu dosya bin/debug'da var mı?
            {
                MessageBox.Show("Bu dosya zaten var!");
            }
            else
            {
                Directory.CreateDirectory("temp");
                MessageBox.Show("Dosya oluşturuldu...");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            // Directory.Move("yerini değiştirmek istediğin klasör","değiştirmek istediğin klasörün gideceği yol");
            Directory.Move("temp", @"c:\temp");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Directory.Delete(@"c:\temp");
        }
    }
}
