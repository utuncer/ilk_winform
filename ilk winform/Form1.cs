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
        int ilkSayi, ikinciSayi, divisibleNumb, controlNumber = 0;
        string disibleText = "";

        public mainform()
        {
            InitializeComponent();
        }
        private void mainform_Load(object sender, EventArgs e)
        {
            cmBoxDivisibleTerm.Text = "Select";
            cmBoxDivisibleTerm.Items.Add("2");
            cmBoxDivisibleTerm.Items.Add("3");
            cmBoxDivisibleTerm.Items.Add("4");
            cmBoxDivisibleTerm.Items.Add("5");
            cmBoxDivisibleTerm.Items.Add("6");
            cmBoxDivisibleTerm.Items.Add("7");
            cmBoxDivisibleTerm.Items.Add("8");
            cmBoxDivisibleTerm.Items.Add("9");
            cmBoxDivisibleTerm.Items.Add("10");
            txtDivisibleNumber.Enabled = true;
        }

        private void txtFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece sayılara izin verir (ve backspace'e)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Harfi engelle

            }
        }
        private void txtTo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Sadece sayılara izin verir (ve backspace'e)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Harfi engelle

            }
        }

        private void labelDivisibleTerm_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                txtDivisibleNumber.ForeColor = Color.Black; 
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                txtDivisibleNumber.ForeColor = Color.Red;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                txtDivisibleNumber.ForeColor = Color.Green;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                txtDivisibleNumber.ForeColor = Color.Blue;
            }
        }

        private void ChBold_CheckedChanged(object sender, EventArgs e)
        {
            if (ChBold.Checked)
            {
                ChItalic.Checked = false;
                txtDivisibleNumber.Font = new Font(Font, FontStyle.Bold);
            }
            else
            {
                txtDivisibleNumber.Font = new Font(Font, FontStyle.Regular);
            }
        }

        private void ChItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (ChItalic.Checked)
            {
                ChBold.Checked = false;
                txtDivisibleNumber.Font = new Font(Font, FontStyle.Italic);
            }
            else
            {
                txtDivisibleNumber.Font = new Font(Font, FontStyle.Regular);
            }
        }

        private void cmBoxDivisibleTerm_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisibleNumb = Convert.ToInt32(cmBoxDivisibleTerm.SelectedItem.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            if (txtFrom.Text.Trim() == "" || txtTo.Text.Trim() == "")
            {
                errorProvider1.SetError(txtFrom, "Please Fill TextBox");
                MessageBox.Show("Please Fill Neccessary Fields");
            }
            else if (cmBoxDivisibleTerm.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Divisible Term");
            }
            else
            {
                disibleText = "";
                controlNumber = 0;
                ilkSayi = Convert.ToInt32(txtFrom.Text);
                ikinciSayi = Convert.ToInt32(txtTo.Text);
                for (int i = ilkSayi; i <= ikinciSayi; i++)
                {
                    if (i % divisibleNumb == 0)
                    {
                        disibleText += i + " ";
                        controlNumber++;
                        if (controlNumber % 20 == 0)
                        {
                            disibleText += Environment.NewLine;
                        }
                    }
                }
                txtDivisibleNumber.Text = disibleText;
            }

        }
    }
}
