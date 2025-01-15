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
        // kütüphanelerin arasna using System.IO; eklenmeli
        Dosya isimleri/uzantılarına ulaşmak için path class kullanılır
        GetDirectoryName
        GetExtension
        GetFileName
        GetFileNamWitoutExtension
        GetFullPath
        GetCurrentApplicationPath
        */
        public mainform()
        {
            InitializeComponent();
        }

        #region

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += Path.GetDirectoryName(@"C:\new folder\temp\forest.png")+Environment.NewLine; //dosyanın olduğu klasörü yazar C:\new folder\temp\
            textBox1.Text += Path.GetFileName(@"C:\new folder\temp\forest.png")+Environment.NewLine;
            textBox1.Text += Path.GetFileNameWithoutExtension(@"C:\new folder\temp\forest.png")+Environment.NewLine; 
            textBox1.Text += Path.GetExtension(@"C:\new folder\temp\forest.png")+Environment.NewLine; 
            textBox1.Text += Path.GetPathRoot(@"C:\new folder\temp\forest.png")+Environment.NewLine; 
            textBox1.Text += Path.GetFullPath(@"C:\new folder\temp\forest.png")+Environment.NewLine; 
        }
    }
}
