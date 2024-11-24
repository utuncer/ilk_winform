using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilk_winform
{
    class Ogrenci
    {
        // prop
        // Ogrenci.Numara diyerek Form1.cs üzerinden ulaşılabilir
        public static int Numara { get; set; }
        // Ogrenci ogrenci = new Ogrenci();
        // nesnesi tanımlandıktan sonra
        // ogrenci.Not1(); diyerek Form1.cs üzerinden ulaşılabilir
        public void Not1()
        {

        }
        // Ogrenci.Not(); diyerek Form1.cs üzerinden ulaşılabilir
        public static void Not2()
        {

        }
    }
}
