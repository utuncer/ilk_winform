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
        /*
        Enum
        Projemizdeki sabitlerin isimlendirilmesidir.
        */
        public mainform()
        {
            InitializeComponent();
        }
        #region
        enum colors { red, blue, white, black, yellow, purple, brown, orange };

        private void btnShow_Click(object sender, EventArgs e)
        {
            string tt = "Red:" + (int)colors.red + Environment.NewLine;
            tt += "Blue:" + (int)colors.blue + Environment.NewLine;
            tt += "White:" + (int)colors.white + Environment.NewLine;
            tt += "Black:" + (int)colors.black + Environment.NewLine;
            tt += "Yellow:" + (int)colors.yellow + Environment.NewLine;
            tt += "Purple:" + (int)colors.purple + Environment.NewLine;
            tt += "Brown:" + (int)colors.brown + Environment.NewLine;
            tt += "Orange:" + (int)colors.orange + Environment.NewLine;
            textBox1.Text = tt;
        }
        #endregion
    }
}