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
        Delegates
        Fonksiyonun kendisini parametre olarak kullanmak istersek
        function -> Delegate -> Event
        Metotları referansları tutarak çalıştırır
        Bir delegate birden fazla function (metod) işaret edebilir
        */
        public mainform()
        {
            InitializeComponent();
        }
        #region
        string exam;
        public delegate void FillNote(int x);
        public void FillMathNote(int mathNote)
        {
            exam += "Your Math Note is " + mathNote.ToString();
        }
        public void FillChemistryNote(int chemistry)
        {
            exam += "Your Math Note is " + chemistry.ToString();
        }
        public void settextbox (string text)
        {
            textBox1.Text = text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FillNote note = FillMathNote; // Delegate ile metodu (function) bağladık
            note += FillChemistryNote; // Delegate'e bir metod daha bağladık
            note(80);
            settextbox(exam);
            note -= FillMathNote; // Delegate'den metod çıkardık
            note(60);
            settextbox(exam);
        }
        #endregion


    }
}
