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
        File & FileInfo
        File Metotları -> https://hizliresim.com/6cz4qkr
        FileInfo -> https://hizliresim.com/gm4fxlt
        FileInfo Metotları -> https://prnt.sc/FAXtgPtpqhZJ

        Belirli bir kaynağı okumak, yazmak için Stream sınıfını kullanmak gerekli
        File/Memory/Buffered/Netork/Pipe/Crypto Stream
        */
        public mainform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  File.Create("Firstfile.txt");
            if (!File.Exists("Firstfile.txt"))
            {
                FileInfo outfile = new FileInfo("Firstfile.txt");
                outfile.Create();
            }
            else
            {
                FileInfo outfile = new FileInfo("Firstfile.txt");
                outfile.Delete();
                outfile.Create();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Filestreamin 3 parametresi işlem yapmak istediği dosyanın ismi/dosyanın olup olmaması yani kontrol mekanizması(FileMode.OpenOrCreate varsa aç yoksa oluştur)/ne işlem yapacaksın okuma ya da yazma
            FileStream fs = new FileStream("third.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs); // tanımlanan filestreami burada parametrede gösteriyorsun
            sw.WriteLine("Bu ilk satır");
            sw.WriteLine("Bu ikinci satır");
            sw.WriteLine("Bu üçüncü satır");
            sw.Flush(); //metinleri dosayaya iletmek için kullanılır
            sw.Close();
            fs.Close(); //değiştirilen dsoyanın son haline görmek için her ikisinide kapatıyoruz
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("third.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream) // sr.Close() yazılana kadar döngü devam edecek
            {
                textBox1.Text += sr.ReadLine() + Environment.NewLine;
            }
            sr.Close();
            fs.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {//file copy parametreleri -> kaynak, hedef
            File.Copy("secondfile.txt",@"C:\temp\secondfile.txt");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo("third.txt");
            MessageBox.Show(file.Name); //dosya adı
            MessageBox.Show(file.FullName); //dosyanın adı yoluyla birlikte gelir
        }
    }
}
